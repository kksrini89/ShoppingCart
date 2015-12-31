(function () {
    var app = angular.module('ShoppingCartApp');
    app.service('ProductService', ['$http', '$q', function ($http, $q) {
        this.getProduct = function () {
            var deferred = $q.defer();
            $http.get('http://localhost:40537/api/product').success(function (data, status, header, config) {
                deferred.resolve(data);
            }).error(function (data, status, header, config) {
                deferred.reject(status);
            });
            return deferred.promise;
        }
    }]);
})();