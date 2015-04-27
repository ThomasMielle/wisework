
WiseWorkApp.factory('UserService', function ($http, LocalDatabase) {
    var factory = {
        Authentifier: function(name, password) {

            var chemin = "/api/Connexion/verifIdentifiant";
            var utilisateur = { Login: name, Password: password };

            return $http.post(chemin, utilisateur)
                .success(function (user) {
                    LocalDatabase.CurrentUser = user;
                    //Stocker dans la base JS plus tard
                })
                    .error(function () {
                    LocalDatabase.CurrentUser = null;
                    //Supprimer de la base JS 
                    });
            return LocalDatabase.CurrentUser;
        },
        getAllUser: function() {

            var chemin = "/api/Utilisateur/getAllUser";

            return $http.get(chemin)
                .success(function (listAllUser) {
                    LocalDatabase.listUser = listAllUser;
                    //Stocker dans la base JS plus tard
                })
                .error(function () {
                    LocalDatabase.listUser = null;
                    //Supprimer de la base JS 
                });

            return LocalDatabase.listUser;
        }
    };
    return factory;
});