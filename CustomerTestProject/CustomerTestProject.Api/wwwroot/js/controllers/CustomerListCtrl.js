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
            $scope.customers = response.data;
        });
    };

    //$scope.AddCustomer = function () {

    //    $http({
    //        method: 'POST',
    //        url: '/api/searchbyphrase/download',
    //        data: $scope.videos
    //    }).then(function successCallback(response) {
    //        $scope.AskForProgress();
    //        $('#loading').hide();

    //    }, function errorCallback(response) {

    //    });
    //}

    //$scope.AskForProgress = function () {

    //    $http({
    //        method: 'GET',
    //        url: '/api/searchbyphrase/askforprogress'
    //    }).then(function successCallback(response) {
    //        $scope.videos = response.data;
    //        $timeout($scope.AskForProgress, 1000);
    //        $('#loading').hide();

    //    }, function errorCallback(response) {
    //    });
    //}

    //$scope.updateSelectedOfVideos = function () {

    //    $http({
    //        method: 'POST',
    //        url: '/api/searchbyphrase/updateselectedofvideos',
    //        data: $scope.videos
    //    }).then(function successCallback(response) {
    //        $timeout($scope.updateSelectedOfVideos, 1000);
    //        $('#loading').hide();

    //    }, function errorCallback(response) {
    //    });
    //}

    //$scope.redirectToUrl = function (url) {
    //    window.open('https://www.youtube.com/watch?v=' + url, '_blank');
    //};

    $scope.InitializeFunction();
});
