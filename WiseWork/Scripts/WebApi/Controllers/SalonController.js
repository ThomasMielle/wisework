//  Controller gérant l'affichage et la mise a jour d'un salon
WiseWorkController.controller('ctrl_salon', function ($scope, $rootScope, $routeParams, $http, SalonService) {
    //initialisation affichage filtre
    $scope.hideFiltres = true;
    $scope.hideFiltreDate = true;

    //initialisation filtre date
    $scope.dateMin = new Date(2014, 00, 01, 0, 0, 0, 0);
    $scope.absoluteDateMin = new Date(2014, 00, 01, 0, 0, 0, 0);
    $scope.absoluteDateMax = new Date();
    $scope.dateMax = new Date();

    // fonction pour changer l'importance d'un message
    $scope.important = function (idMess) {
        SalonService.important(idMess, $routeParams.salonNom)
            .then(function (response) {
                $scope.ListMessage = response.data;
            })
    }

    // fonctions pour le filtre par date
    $scope.openDateMin = function ($event) {
        $event.preventDefault();
        $event.stopPropagation();
        $scope.dateMaxOpened = false;
        $scope.dateMinOpened = true;
    };
    $scope.openDateMax = function ($event) {
        $event.preventDefault();
        $event.stopPropagation();
        $scope.dateMinOpened = false;
        $scope.dateMaxOpened = true;
    };
    // filtre par importance / tag
    $scope.vue = function (vue) {
        SalonService.vue(vue, $routeParams.salonNom)
            .then(function (response) {
                $scope.ListMessage = response.data;
            });
    }

    // affichage / masquage des filtres
    $scope.hideFiltresFunction = function () {
        $scope.hideFiltres = !$scope.hideFiltres;
        if ($scope.hideFiltres) $scope.hideFiltreDate = true;
    }
    $scope.hideFiltreDateFunction = function () {
        $scope.hideFiltreDate = !$scope.hideFiltreDate;
    }

    // filtre par Date
    $scope.filtreDateFunction = function () {
        datas = { nomSalon: $scope.nomSalon, dateMin: $scope.dateMin, dateMax: $scope.dateMax };
        SalonService.filtreDateFunction(datas)
            .then(function (response) {
                $scope.ListMessage = response.data;
            });
    }

    // envoi message
    $scope.envoyerMessage = function () {
        if ($scope.newMessage != "") {
            SalonService.envoiMessage($scope.nomSalon, $scope.newMessage)
                .then(function (response) {
                    $scope.ListMessage = response.data;
                    $scope.newMessage = "";
                });
        }
    };
    SalonService.initialisationSalon($routeParams.salonNom)
        .then(function (response) {
            $scope.ListMessage = response.data.ListMessage;
            $scope.nomSalon = $routeParams.salonNom;
        });
});