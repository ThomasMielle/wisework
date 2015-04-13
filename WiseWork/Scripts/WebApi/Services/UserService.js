function UserService($http, LocalDatabase) {
    function Authentifier(name, password) {
        var chemin = "/api/Connexion/verifIdentifiant";
        var identifiant = { Login: name, Password: password };

        return $http.post(chemin, identifiant).success(function (user) {
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
        CurrentUser: function() { return LocalDatabase.CurrentUser; }
    };
}
