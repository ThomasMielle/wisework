
WiseWorkApp.factory('SalonService', function ($http, LocalDatabase) {

    var factory = {
        getAllSalon: function () {
            //var deferred = $q.defer();
            var chemin = "/api/Salon/getSalons";

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
        important: function (idMess, nomSalon) {
            var chemin = "/api/Salon/updateTag";

            return $http.post(chemin, '"' + nomSalon + ',' + idMess + '"')
                .success(function (listMessage) {
                    LocalDatabase.listMessage = listMessage;
                })
                .error(function () {
                    LocalDatabase.listMessage = null;
                });
            return LocalDatabase.listMessage;
        },
        vue: function (vue, nomSalon) {
            var chemin = "/api/Salon/vue"
            return $http.post(chemin, '"' + nomSalon + ',' + vue + '"')
            .success(function (data) {
                LocalDatabase.listMessage = data;
            })
            return LocalDatabase.listMessage;
        },
        filtreDateFunction: function (datas) {
            var chemin = "/api/Salon/filtreDate";
            return $http.post(chemin, datas)
                .success(function (data) {
                    LocalDatabase.listMessage = data;
                })
            return LocalDatabase.listMessage;
        },
        envoiMessage: function (nomSalon, message) {
            datas = { nomSalon: nomSalon, idUtilisateur: LocalDatabase.CurrentUser.Id, message: message }
            return $http.post("/api/Salon/ajouterMessage", datas)
                .success(function (data) {
                    LocalDatabase.listMessage = data.ListMessage;
                });
            return LocalDatabase.listMessage;
        },
        initialisationSalon: function (nomSalon) {
            return $http.post("/api/Salon/getSalon", '"' + nomSalon + '"')
                .success(function (data) {
                    LocalDatabase.listMessage = data.ListMessage;
                });
            return LocalDatabase.listMessage;
        }
    };
    return factory;
});