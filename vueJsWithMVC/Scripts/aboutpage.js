var aboutPage = new Vue({
    el: '#aboutPage',
    data: {
        message: 'Hello Vue in About Page',
        items: [],
        products: []
    },
    methods: {
        clickme: () => {
            getMessage().then((data) => {
                aboutPage.message = data;
            });
        },
        showList: () => {
            getList().then((data) => {
                aboutPage.items = data;
            });
        },
        clearList: () => {
            aboutPage.items = [];
        },
        getProducts: () => {
            getProductList().then((data) => {
                aboutPage.products = data;
            });
        },
        clearProductList: () => {
            aboutPage.products = [];
        }
    },
    filters: {
        toCurrency: (price) => {
            return new Intl.NumberFormat('en-US', {
                style: 'currency',
                currency: 'USD',
                minimumFractionDigits: 2
            }).format(price);
        }
    }
});

var getMessage = () => {
    return $.get({
        url: "/api/test/getmessage"
    }).catch((error) => {
        console.log("Error executing get " + error);
    });
};

//var formattedPrice = (price) => {
//    return new Intl.NumberFormat('en-US', {
//        style: 'currency',
//        currency: 'USD',
//        minimumFractionDigits: 2
//    }).format(price);
//};

var getList = () => {
    return $.get({
        url: "/api/test/getlist"
    }).catch((error) => {
        console.log("Error executing get " + error);
    });
};

var getProductList = () => {
    return $.get({
        url: "/api/test/getproductlist"
    });
};