var WiseWorkApp = angular.module("WiseWorkApp", ['ngRoute', 'WiseWorkController', 'ui.bootstrap']);
var WiseWorkController = angular.module('WiseWorkController', []);

WiseWorkApp.factory("LocalDatabase", LocalDatabase);

WiseWorkApp.config(['$routeProvider',
  function ($routeProvider) {
      $routeProvider.
        when('/', {
            templateUrl: 'Vues/connexion.html',
            controller: 'ctrl_connexion'
        }).
        when('/accueil', {
            templateUrl: 'Vues/accueil.html',
            controller: 'ctrl_accueil'
        }).
        when('/salon/:salonNom', {
            templateUrl: 'Vues/salon.html',
            controller: 'salonController'
        }).
        otherwise({
            redirectTo: '/'
        });
  }]);

WiseWorkController.controller('salonController', ['$scope', '$http', '$routeParams',
    function ($scope, $http, $routeParams) {
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
            $http.post("/api/Salon/updateTag", '"' + $routeParams.salonNom + ',' + idMess + '"')
                .success(function (data) {
                    $scope.ListMessage = data;
                })
                .error(function (data, status) {
                    $scope.status = status;
                });
        }
        
        // fonciton pour le filtre par date
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
            $http.post("/api/Salon/vue", '"' + $routeParams.salonNom + ',' + vue + '"')
                .success(function (data) {
                    $scope.ListMessage = data;
                })
                .error(function (data, status) {
                    $scope.status = status;
                });
        }
        // filtre par Date
        $scope.filtreDateFunction = function () {
            datas = { nomSalon: $scope.nomSalon, dateMin: $scope.dateMin, dateMax: $scope.dateMax };
            $http.post("/api/Salon/filtreDate", datas)
                .success(function (data) {
                    $scope.ListMessage = data;
                })
                .error(function (data, status) {
                    $scope.status = status;
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

        // envoyer un message
        $scope.envoyerMessage = function (event) {
            if(event.keyCode==13 && $scope.newMessage != "") {
                datas = { nomSalon: $scope.nomSalon, idUtilisateur: 1, message: $scope.newMessage}
                $http.post("/api/Salon/ajouterMessage", datas)
                    .success(function (data) {
                        $scope.ListMessage = data;
                        $scope.newMessage = "";
                    })
                    .error(function (data, status) {
                        $scope.status = status;
                    });
            }
        }
        // actualisation salon
        $http.post("/api/Salon/getSalon", '"' + $routeParams.salonNom + '"')
            .success(function (data) {
                $scope.ListMessage = data.ListMessage;
                $scope.nomSalon = data.Nom;
            })
            .error(function (data, status) {
                $scope.status = status;
            });
    }
]);

