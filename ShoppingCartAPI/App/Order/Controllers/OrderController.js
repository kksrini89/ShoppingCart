(function () {
    var app = angular.module('ShoppingCartApp');
    app.controller('OrderController', ['$scope', 'ProductService', function ($scope, ProductService) {
        var viewmodel = {
            products: [],
            product: {
                image: '',
                price: 0.0,
                modelNo: ''
            },
            count: 0,
            i: 0,
            productClick: function (id) {

                viewmodel.product.image = id.productImage;
                viewmodel.product.price = id.price;
                viewmodel.product.modelNo = id.modelNo;
                i++;
                viewmodel.count = i;
            }
        };
        $scope.model = viewmodel;
        ProductService.getProduct().then(function (data) {
            //Copying products from product service, else undefined
            angular.isDefined($scope.model.products) ? angular.copy(data, $scope.model.products) : void (0);
            /* $scope.model.product.image = data.productImage;
             $scope.model.product.modelNo = data.modelNo;
             $scope.model.product.price = data.price;*/
        });
    }]);
})();