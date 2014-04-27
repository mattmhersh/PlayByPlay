(function(app) {
    var flightService = function() {
        var testData = [
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

        var flightFactory = {};
        flightFactory.getFlights = function() {
            return testData;
        };
        flightFactory.selectFlight = function(id) {
            //
            // $http.put("/flights/select/3", id);
            //
            return true;
        };
        return flightFactory;
    };

    app.factory("flightService", flightService);

}(angular.module("airlineApp")));