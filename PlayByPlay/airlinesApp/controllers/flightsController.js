(function (app) {

    var flightsController = function ($scope, flightService) {

        var init = function() {
            $scope.flights = flightService.getFlights();
        };

        $scope.selectFlight = function (flight) {
            for (var i = 0; i < $scope.flights.length; i++) {
                $scope.flights[i].approved = false;
            }
            flight.approved = !flight.approved;
        };

        init();

    };

    app.controller("flightsController", ["$scope", "flightService", flightsController]);

}(angular.module("airlineApp")));