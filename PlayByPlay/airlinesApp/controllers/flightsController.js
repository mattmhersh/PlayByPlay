(function (app) {

    var flightsController = function ($scope, flightService, $timeout) {

        var onError = function () {
            alert("bam!!!");
        };

        var onFlights = function(response) {
            $scope.flights = response.data;
        };

        var init = function() {
            $scope.flights = flightService.getFlights().then(onFlights, onError);
        };

        $scope.selectFlight = function (flight) {
            for (var i = 0; i < $scope.flights.length; i++) {
                $scope.flights[i].approved = false;
            }            
            flight.approved = !flight.approved;
            if (flightService.selectFlight(flight.id)) {
                $scope.status = "You have successfully selected a flight: " + flight.airline;
                $timeout(function() {
                    $scope.status = "";
                }, 3000);
            }
        };

        init();

    };

    app.controller("flightsController", ["$scope", "flightService", "$timeout", flightsController]);

}(angular.module("airlineApp")));