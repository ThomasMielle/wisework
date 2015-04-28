
//  Vérifie la combinaison "login" et "password"
WiseWorkController.controller('ctrl_connexion', function ($scope, $rootScope, $http, UserService, $location) {

    $scope.identifiant = {};
    $scope.identifiant.login = '';
    $scope.identifiant.password = '';
    $scope.CurrentUser = null;

    $scope.verifIdentifiant = function () {
        UserService.Authentifier($scope.identifiant.login, $scope.identifiant.password)
            .then(function (response) {
                $rootScope.CurrentUser = response.data;
                if (response.data != null) {
                    $location.path("/accueil");
                } else {
                    $rootScope.notificationConnexion = "Le couple Login/Password est incorrect";
                }
            })
    };
});

WiseWorkController.controller('ctrl_deconnexion', function ($scope, $rootScope, $http, $location, LocalDatabase) {
    
    LocalDatabase.CurrentUser = null;
    $rootScope.CurrentUser = null;
    $location.path("/");
});