importScripts('/content/js/sw-toolbox.js');

const appCaches = {
    'static': 'static_V2',
    'dynamic': 'dynamic_V1'
};
const filesToCache = [
    '/',
    '/offline.html',
    '/content/css/site.css',
    '/content/js/site.js',
    '/content/js/vue.js',
    '/content/js/axios.min.js',
    '/content/images/cake1.png',
    '/content/images/cake2.png',
    '/content/images/cake0.png',
    '/content/images/ic_refresh_white_24px.svg',
    '/content/images/apple-touch-icon.png',
    '/content/images/safari-pinned-tab.svg',
    '/content/images/favicon.ico',
    '/content/images/android-chrome-192x192.png',
    '/content/images/android-chrome-512x512.png',
    '/serviceWorker.js'
];



self.addEventListener("install", event => {
    console.log("Service worker installed");
    caches.delete(appCaches.static);
    event.waitUntil(
        caches.open(appCaches.static)
            .then(cache => cache.addAll(filesToCache))
    )
});

self.addEventListener("activate", event => {
    console.log("Service worker activated");
    event.waitUntil(
        caches.keys().then(function (keyList) {
            return Promise.all(keyList.map(function (key) {
                if (key !== appCaches.static && key !== appCaches.dynamic) {
                    console.log('[ServiceWorker] Removing old cache', key);
                    return caches.delete(key);
                }
            }));
        })
    );
});

toolbox.router.get(new RegExp('^.*\/(|content\/.*|fonts.googleapis.com\/.*|fonts.gstatic.com\/.*|offline.html|manifest.json|serviceWorker.js)$'),
    (request, value, options) => {
        return toolbox.cacheFirst(request, value, options).catch(error => {
            return caches.match(new Request('/offline.html'));
        })
    }, {
        cache: {
            name: appCaches.static,
            //maxAgeSeconds: 86400 //1Day
            maxEntries: 25
        }
    });

toolbox.router.get(new RegExp('^.*\/(api.myjson.com\/.*)$'),
    (request, value, options) => {
        return toolbox.networkFirst(request, value, options).catch(error => {
            return caches.match(new Request('/offline.html'));
        })
    },
    {
        networkTimeoutSeconds: 1,
        cache: {
            name: appCaches.dynamic,
            //maxAgeSeconds: 60
            maxEntries: 5
        }
    });

