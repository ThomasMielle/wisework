//  Controller gérant l'affichage et la mise a jour d'un salon
WiseWorkController.controller('ctrl_salon', function ($scope, $rootScope, $routeParams, $http, SalonService, LocalDatabase) {
    //initialisation affichage filtre

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
    //$scope.newMessage = "/rdv 12/05/2015 14:05 15:00 'Salon' ";
    var CreateRdvPath = "/api/Salon/createRdv";
    $scope.envoyerMessage = function () {
        if ($scope.newMessage != "") {

            var patternRdv = new RegExp("/rdv");
            var patterDrive = new RegExp("/drive");
            if (patternRdv.test($scope.newMessage)) {
               
                var str = $scope.newMessage.split("/rdv");
                var invites = LocalDatabase.listUser;
                var eventParams = str[1].split(" ");
                var dateDebut = eventParams[1];
                var heureDebut = eventParams[2];
                var heureFin = eventParams[3];
                var titreRdv = eventParams[4];
                var event = {
                    dateDebut: dateDebut,
                    heureDebut: heureDebut,
                    heureFin: heureFin,
                    invites: invites,
                    titreRdv: titreRdv,
                    userEmail: LocalDatabase.CurrentUser.EmailGoogle
                }
                //var event = JSON.stringify(event);
                $http.post(CreateRdvPath, event)
                    .success(function (data) {
                        var notifRdv = LocalDatabase.CurrentUser.Nom + " vous invite à un rendez vous le " + dateDebut +
                            " de " + heureDebut + " à " + heureFin;
                        var tag = "Rdv";
                        SalonService.envoiMessage($scope.nomSalon, notifRdv,tag)
                          .then(function (response) {
                              $scope.ListMessage = response.data;
                              $scope.newMessage = "";
                          });
                    })
                    .error(function (data) {
                        alert("Erreur : Le rdv n'a pas été crée ");
                    });

            } else if (patterDrive.test($scope.newMessage)) {

                //Mettre ici le code pour le Drive

            } else {
                var tag = "";
                SalonService.envoiMessage($scope.nomSalon, $scope.newMessage)
               .then(function (response) {
                   $scope.ListMessage = response.data;
                   $scope.newMessage = "";
               });
            }

        }
    };
    SalonService.initialisationSalon($routeParams.salonNom)
        .then(function (response) {
            $scope.ListMessage = response.data.ListMessage;
            $scope.nomSalon = $routeParams.salonNom;
            $scope.newMessage = "";

            $scope.hideFiltres = true;
            $scope.hideFiltreDate = true;

            //initialisation filtre date
            $scope.dateMin = new Date(2014, 00, 01, 0, 0, 0, 0);
            $scope.absoluteDateMin = new Date(2014, 00, 01, 0, 0, 0, 0);
            $scope.absoluteDateMax = new Date();
            $scope.dateMax = new Date();

        });
});