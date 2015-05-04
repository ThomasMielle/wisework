//  Controller gérant l'affichage et la mise a jour d'un salon
WiseWorkController.controller('ctrl_salonUtilisateur', function ($scope, $rootScope, $routeParams, $http, SalonUtilisateurService) {
    //initialisation affichage filtre
    $scope.nomSalon = "";
    $scope.newMessage = "";

    $scope.hideInfos = true;
    $scope.Chat = false;
    // fonction pour changer l'importance d'un message
    $scope.important = function (idMess) {
        SalonService.important(idMess, $routeParams.salonNom)
            .then(function (response) {
                $scope.ListMessage = response.data;
            })
    }

    // affichage / masquage des infos
    $scope.hideInfosFunction = function () {
        $scope.hideInfos = !$scope.hideInfos;
    }

    // envoi message
    $scope.envoyerMessage = function () {
        if ($scope.newMessage != "") {
            if ($scope.Chat) {
                SalonUtilisateurService.envoiMessageChat($scope.nomSalon, $scope.newMessage)
                    .then(function (response) {
                        $scope.ListMessage = response.data;
                        $scope.newMessage = "";
                    });
            } else {
                SalonUtilisateurService.envoiMessageSalon($scope.nomSalon, $scope.newMessage)
                    .then(function (response) {
                        $scope.ListMessage = response.data;
                        $scope.newMessage = "";
                    });
            }

        }
    };

    // récuperer les messages du mur
    $scope.getSalon = function () {
        if ($scope.Chat) {
            SalonUtilisateurService.getSalon($routeParams.idSalon)
                .then(function (response) {
                    $scope.ListMessage = response.data;
                    $scope.Chat = false;
                });
        }
    };

    // récupérer le chat avec le CurrentUser
    $scope.getChat = function () {
        if (!$scope.Chat) {
            SalonUtilisateurService.getChat($routeParams.idSalon, $rootScope.CurrentUser.Id)
                .then(function (response) {
                    $scope.ListMessage = response.data;
                    $scope.Chat = true;
                });
        }
    }

    SalonUtilisateurService.getSalon($routeParams.idSalon)
        .then(function (response) {
            $scope.ListMessage = response.data;
        });
    SalonUtilisateurService.getInfos($routeParams.idSalon)
        .then(function (response) {
            $scope.proprio = response.data;
            $scope.nomSalon = response.data.Prenom + " " + response.data.Nom;
            var a = 1;
        });
});