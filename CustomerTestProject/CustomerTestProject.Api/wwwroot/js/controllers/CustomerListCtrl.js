app.controller('CustomerListCtrl', function ($scope, $location, $http, $timeout) {

    $scope.gotopage = function (page) {
        $location.path(page);
    };

    $scope.InitializeFunction = function () {

        $http({
            method: 'GET',
            url: '/api/customer',
        }).then(function successCallback(response) {
            $scope.customers = response.data;
        }, function errorCallback(response) {
            alert("Can not load customers!");
        });
    };

    $scope.deleteCustomer = function (id) {

        $http({
            method: 'DELETE',
            url: '/api/customer/' + id
        }).then(function successCallback(response) {
            alert("Customer was removed correctly");
            $scope.InitializeFunction();
        }, function errorCallback(response) {
            alert("Can not delete customer!");
        });
    };

    $scope.InitializeFunction();
});
