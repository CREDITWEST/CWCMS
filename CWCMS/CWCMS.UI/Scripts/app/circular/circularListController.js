
app.controller("circularListController", ["$scope", "$http", function ($scope, $http) {
    $scope.loading = true;
    $scope.addMode = false;

    //get all customer information
    $http.get('api/circular/search').success(function (data) {
        $scope.circulars = data;
        $scope.loading = false;
    })
        .error(function () {
            $scope.error = "An Error has occured while loading posts!";
            $scope.loading = false;
        });


}]);