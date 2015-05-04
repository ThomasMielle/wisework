
WiseWorkApp.factory('SalonUtilisateurService', function ($http, LocalDatabase) {

    var factory = {
        important: function (idMess, nomSalon) {
            var chemin = "/api/salonUtilisateur/updateTag";

            return $http.post(chemin, '"' + nomSalon + ',' + idMess + '"')
                .success(function (listMessage) {
                    LocalDatabase.listMessage = listMessage;
                })
                .error(function () {
                    LocalDatabase.listMessage = null;
                });
            return LocalDatabase.listMessage;
        },
        envoiMessageSalon: function (nomSalon, message) {
            datas = { nomSalon: nomSalon, idUtilisateur: LocalDatabase.CurrentUser.Id, message: message }
            return $http.post("/api/SalonUtilisateur/ajouterMessageSalon", datas)
                .success(function (data) {
                    LocalDatabase.listMessage = data.ListMessage;
                });
            return LocalDatabase.listMessage;
        },
        envoiMessageChat: function (nomSalon, message) {
            datas = { nomSalon: nomSalon, idUtilisateur: LocalDatabase.CurrentUser.Id, message: message, tag: "Chat" }
            return $http.post("/api/SalonUtilisateur/ajouterMessageChat", datas)
                .success(function (data) {
                    LocalDatabase.listMessage = data.ListMessage;
                });
            return LocalDatabase.listMessage;
        },
        getSalon: function (nomSalon) {
            return $http.post("/api/SalonUtilisateur/getSalon", '"' + nomSalon + '"')
                .success(function (data) {
                    LocalDatabase.listMessage = data;
                });
            return LocalDatabase.listMessage;
        },
        getChat: function (nomSalon) {
            datas = { IdCurrentSalon: nomSalon, IdCurrentUtilisateur: LocalDatabase.CurrentUser.Id }
            return $http.post("/api/SalonUtilisateur/getChat", datas)
                .success(function (data) {
                    LocalDatabase.listMessage = data;
                });
            return LocalDatabase.listMessage;
        },
        getInfos: function (nomSalon) {
            return $http.post("/api/SalonUtilisateur/getInfos", '"' + nomSalon + '"')
                .success(function (data) {
                    LocalDatabase.proprio = data;
                });
            return LocalDatabase.proprio;
        }
    };
    return factory;
});