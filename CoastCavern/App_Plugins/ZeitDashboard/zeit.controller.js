﻿angular.module("umbraco").controller("ZeitDashboard", function ($scope, zeitRessource, notificationsService) {
    $scope.getTime = function () {
        zeitRessource.getTime($scope.day).then(function (data) {
            $scope.timeFrom = data.data[0];
            $scope.timeTo = data.data[1];
        });
    }

    $scope.setTime = function () {
        if ($scope.day == null) {
            notificationsService.error("DU PIMMELNASE HAST NEN BUG ENTDECKT!!!11!1eins");
        } else {
            debugger;
            zeitRessource.setTime($scope.day, $scope.timeFrom, $scope.timeTo).then(function () {
            });
        }
    }

    $scope.clickDay = function (day) {
        switch (day) {
            case 1:
                {
                    $scope.day = "Monday";
                    break;
                }
            case 2:
                {
                    $scope.day = "Tuesday";
                    break;
                }
            case 3:
                {
                    $scope.day = "Wednesday";
                    break;
                }
            case 4:
                {
                    $scope.day = "Thursday";
                    break;
                }
            case 5:
                {
                    $scope.day = "Friday";
                    break;
                }
            case 6:
                {
                    $scope.day = "Saturday";
                    break;
                }
            case 7:
                {
                    $scope.day = "Sunday";
                    break;
                }

        }
        $scope.getTime();
    }
});