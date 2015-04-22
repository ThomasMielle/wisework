function UserService($http, LocalDatabase) {
    function Authentifier(name, password) {

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
    }

    return {
        Authentifier: Authentifier,
        CurrentUser: function () { return LocalDatabase.CurrentUser; }
    };
}

function UserService($http, LocalDatabase) {
    function getAllUser() {

        var chemin = "/api/Utilisateur/getAllUser";
        LocalDatabase.listUser = null;

        return $http.get(chemin)
            .success(function (listAllUser) {
                LocalDatabase.listUser = listAllUser;
                //Stocker dans la base JS plus tard
            })
            .error(function () {
                LocalDatabase.listUser = null;
                //Supprimer de la base JS 
            });
    }

    return {
        getAllUser: getAllUser,
        listUser: function () { return LocalDatabase.listUser; }
    };
}
