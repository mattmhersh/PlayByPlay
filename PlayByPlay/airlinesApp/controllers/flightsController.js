(function (app) {

    var flightsController = function ($scope) {

        $scope.flights =
                [
                    {
                        airline: "United Airlines",
                        flightNumber: 207,
                        startTime: "13:00",
                        endTime: "15:00",
                        totalDuration: 2,
                        price: 500,
                        date: "12/1/2014",
                        cities: ["ORD", "LAS"],
                        approved: false
                    },
                    {
                        airline: "American Airlines",
                        flightNumber: 207,
                        startTime: "13:00",
                        endTime: "15:00",
                        totalDuration: 2,
                        price: 500,
                        date: "12/1/2014",
                        cities: ["SFO", "LAS"],
                        approved: false
                    }
                ];

    };

    //flightsController.$inject = ["$scope"];

    app.controller("flightsController", ["$scope", flightsController]);

}(angular.module("airlineApp")));