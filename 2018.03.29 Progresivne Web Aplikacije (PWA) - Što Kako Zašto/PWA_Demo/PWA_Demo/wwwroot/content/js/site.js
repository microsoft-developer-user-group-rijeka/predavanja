//Register service worker
if ('serviceWorker' in navigator) {
    navigator.serviceWorker.register('serviceWorker.js')
        .then(
            () => console.log("PAGE: Service worker registered"),
            error => console.log(`PAGE: Service worker registration failed ${error}`)
        );
}

var malaSpajza = new Vue({
    el: '#malaSpajza',
    data: {
        appName: 'Mala Spajza',
        recipes: []
    },

    mounted() {
        axios
            .get('https://api.myjson.com/bins/axcn3')
            .then(response => {
                this.recipes = response.data.recipes
            })
            .catch(error => console.log(error))
    },
    methods: {
        refreshPage(event) {
            console.log("refreshPage");
            //Request on API to fetch data
            location.reload();
        }
    }
});

