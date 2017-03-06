angular.module("umbraco").controller("ZeitDashboard", function ($scope, zeitRessource) {
    $scope.getTime = function() {
        zeitRessource.getTime($scope.day).then(function(data) {
            debugger;
        });
    }

    $scope.setTime = function () {
        zeitRessource.getTime($scope.day, $scope.timeFrom, $scope.timeTo).then(function(data) {
            debugger;
        });
    }
});