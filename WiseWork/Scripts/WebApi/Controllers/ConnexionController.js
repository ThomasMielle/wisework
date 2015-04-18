var WiseWorkController = angular.module('WiseWorkController', []);

//  Vérifie la combinaison "login" et "password"
WiseWorkController.controller('ctrl_connexion', function ($scope, $rootScope, $http, UserService) {

    $scope.identifiant = {};
    $scope.identifiant.login = '';
    $scope.identifiant.password = '';
    $scope.CurrentUser = null;

    $scope.verifIdentifiant = function () {
        UserService.Authentifier($scope.identifiant.login, $scope.identifiant.password)
         .success(function () {
             $scope.notificationConnexion = "Bonjour " + UserService.CurrentUser().Login;
             $rootScope.CurrentUser = UserService.CurrentUser();
         })
         .error(function (exception) {
            $scope.notificationConnexion = exception.ExceptionMessage;
         });
    }
});
