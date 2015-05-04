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
            controller: 'ctrl_salon'
        }).
        when('/contact/:idSalon', {
            templateUrl: 'Vues/salonUtilisateur.html',
            controller: 'ctrl_salonUtilisateur'
        }).
        when('/aide', {
            templateUrl: 'Vues/aide.html'
        }).
        when('/deconnexion', {
            templateUrl: 'Vues/connexion.html',
            controller: 'ctrl_deconnexion'
        }).
        when('/modificationProfil', {
            templateUrl: 'Vues/modificationProfil.html',
            controller: 'ctrl_modif_user'
        }).
        when('/probleme', {
            templateUrl: 'Vues/probleme.html',
            controller: 'ctrl_probleme'
        }).
        otherwise({
            redirectTo: '/'
        });
  }]);