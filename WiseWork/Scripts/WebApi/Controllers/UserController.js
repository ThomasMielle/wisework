
WiseWorkController.controller('ctrl_modif_user', function ($scope, $rootScope, $http, UserService, $location) {

    $scope.identifiant = {};
    $scope.identifiant.id = $scope.CurrentUser.Id;
    $scope.identifiant.login = '';
    $scope.identifiant.password = '';
    $scope.identifiant.nom = '';
    $scope.identifiant.prenom = '';

    $scope.modifierUser = function () {
        UserService.modifUser($scope.identifiant)
            .then(function (response) {
                $rootScope.CurrentUser = response.data;
                if (response.data != null) {
                    $location.path("/");
                } else {
                    //$rootScope.notificationConnexion = "Le couple Login/Password est incorrect";
                }
            })
    };
});