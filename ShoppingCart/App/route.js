(function () {
    var app = angular.module('ShoppingCartApp');
    app.config(['$stateProvider', '$urlRouterProvider', function ($stateProvider, $urlRouterProvider) {
        $urlRouterProvider.otherwise('/Order');
        $stateProvider.state('Order', {
            url: '/Order',
            templateUrl: 'App/Order/Partials/order.html',
            controller: 'OrderController'
        })
        .state('Delivery', {
            url: '/Delivery',
            templateUrl: 'App/Delivery/Partials/delivery.html',
            controller: 'DeliveryController'
        })
        .state('Status', {
            url: '/Status',
            templateUrl: 'App/Status/Partials/status.html',
            controller: 'StatusController'
        });

    }]);
})();