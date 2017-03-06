angular.module("umbraco.resources").factory("zeitRessource", function ($http) {
    return {
        getTime: function (day) {
            return $http.get("/umbraco/api/zeit/getTime", { params: { day: day } });
        },
        setTime: function (day, timeFrom, timeTo) {
            return $http.get("/umbraco/api/zeit/setTime", { params: { day: day, timeFrom: timeFrom, timeTo: timeTo } });
        }
    };

});