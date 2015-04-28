
WiseWorkApp.factory('SalonService', function ($http, LocalDatabase) {

    var factory = {
        getAllSalon: function() {
            //var deferred = $q.defer();
            var chemin = "/api/Salons/getAllSalon";

            return $http.get(chemin)
                .success(function (listAllSalon) {
                    LocalDatabase.listSalon = listAllSalon;
                    //factory.salons = listAllSalon;
                    //deferred.resolve(factory.salons);
                })
                .error(function () {
                    LocalDatabase.listSalon = null;
                    // deferred.reject("Impossible de récupérer les données");
                });

            return LocalDatabase.listSalon;
        },
        getAllMessage: function() {
            var chemin = "/api/Salon/getAllMessage";

            return $http.get(chemin)
                .success(function (listAllMessage) {
                    LocalDatabase.listMessage = listAllMessage;
                    //factory.messages = listAllMessage;
                })
                .error(function () {
                    LocalDatabase.listMessage = null;
                    //factory.messages = null;
                });
            return LocalDatabase.listMessage;
            // return LocalDatabase.listMessage;
        }
    };
    return factory;
});