# Code snippets

Register service worker:
```javascript
if ('serviceWorker' in navigator) {
    navigator.serviceWorker.register('serviceWorker.js')
        .then(
            () => console.log("PAGE: Service worker registered"),
            error => console.log(`PAGE: Service worker registration failed ${error}`)
        );
}
```
Add Install and Activate event listeners:
```javascript
self.addEventListener("install", event => {
    console.log("Service worker installed");
});

self.addEventListener("activate", event => {
    console.log("Service worker activated");
});
```
Pre-cache everything using classical fetch event listener 
```javascript
const appCaches = {
    'static': 'static_V1',
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
    '/content/images/ic_refresh_white_24px.svg'
];

self.addEventListener("install", event => {
    caches.delete(appCaches.static);
        event.waitUntil(
            caches.open(appCaches.static)
                .then(cache => cache.addAll(filesToCache))
        );
});

self.addEventListener("activate", event => {
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

self.addEventListener("fetch", event => {
    console.log(`WORKER: Serving ${event.request.url} from CACHE`);
    event.respondWith(caches.match(event.request));
});
```

Cache first strategy 
```javascript
self.addEventListener("fetch", event => {
    event.respondWith(
            caches.match(event.request)
                .then(response => {
                    if (response) {
                        console.log(`WORKER: Serving ${event.request.url} from CACHE`);
                        return response;
                    }
                    if (!navigator.onLine) {
                        console.log("WORKER: Serving Off-line page");
                        return caches.match(new Request('/offline.html'));
                    }
                    console.log(`WORKER: Serving ${event.request.url} from NETWORK`);
                    return fetch(event.request);
                })
        );
});
```

Cache first strategy but update from network when is possible
```javascript
self.addEventListener("fetch", event => {
    event.respondWith(
            caches.match(event.request)
                .then(response => {
                    if (response) {
                        console.log(`WORKER: Serving ${event.request.url} from CACHE`);
                        return response;
                    }
                    if (!navigator.onLine) {
                        console.log("WORKER: Serving Off-line page");
                        return caches.match(new Request('/offline.html'));
                    }
                    console.log(`WORKER: Serving ${event.request.url} from NETWORK`);
                    return fetch(event.request)
                        .then(response => {
                            if (response) {
                                return caches.open(appCaches.dynamic)
                                    .then(cache => {
                                        cache.put(event.request, response.clone())
                                            .then(() => {
                                                return response;
                                            });
                                    })
                            }
                        })
                })
        );    
});
```


