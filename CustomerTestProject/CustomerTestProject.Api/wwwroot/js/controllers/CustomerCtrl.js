app.controller('CustomerCtrl', function ($scope, $http, $timeout, $routeParams, $location) {

    $scope.customerDTO = { address: {} };

    $scope.getCustomer = function (id) {
        $http({
            method: 'GET',
            url: '/api/customer/' + id,
        }).then(function successCallback(response) {
            $scope.customerDTO = response.data;
            console.log($scope.customerDTO);
        }, function errorCallback(response) {
            alert("Can not load customer!");
        });
    }

    $scope.back = function () {
        $location.path('');
    }

    $scope.save = function () {

        if ($scope.form.$invalid)
            return;

        if (!!$routeParams.id)
            $scope.updateCustomer();
        else
            $scope.saveNewCustomer();
    }

    $scope.saveNewCustomer = function () {
        $http({
            method: 'POST',
            url: '/api/customer/',
            data: $scope.customerDTO
        }).then(function successCallback(response) {
            $scope.back();
        }, function errorCallback(response) {
            alert("Can not add customer!");
        });
    }

    $scope.updateCustomer = function () {
        $http({
            method: 'PUT',
            url: '/api/customer/',
            data: $scope.customerDTO
        }).then(function successCallback(response) {
            $scope.back();
        }, function errorCallback(response) {
            alert("Can not update customer!");
        });
    }

    if (!!$routeParams.id)
        $scope.getCustomer($routeParams.id);

});