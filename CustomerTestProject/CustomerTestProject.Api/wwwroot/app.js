var app = angular.module("app", ['ngRoute']);

app.config(['$locationProvider', function ($locationProvider) {
    $locationProvider.hashPrefix("");
}]);

app.config(function ($routeProvider) {
    $routeProvider.
        when('/customer', {
            templateUrl: 'html/customer.html',
            controller: 'CustomerCtrl'
        }).
        when('/customer/:id', {
            templateUrl: 'html/customer.html',
            controller: 'CustomerCtrl'
        }).
        otherwise({
            templateUrl: 'html/customerlist.html',
            controller: 'CustomerListCtrl'
        });
});