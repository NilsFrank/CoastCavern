angular.module("umbraco").controller("ZeitDashboard", function ($scope, zeitRessource, notificationsService) {
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
                    $scope.day = "Montag";
                    break;
                }
            case 2:
                {
                    $scope.day = "Dienstag";
                    break;
                }
            case 3:
                {
                    $scope.day = "Mittwoch";
                    break;
                }
            case 4:
                {
                    $scope.day = "Donnerstag";
                    break;
                }
            case 5:
                {
                    $scope.day = "Freitag";
                    break;
                }
            case 6:
                {
                    $scope.day = "Samstag";
                    break;
                }
            case 7:
                {
                    $scope.day = "Sonntag";
                    break;
                }

        }
        $scope.getTime();
    }
});