var WiseWorkApp = angular.module("WiseWorkApp", ['ngRoute', 'WiseWorkController']);
var WiseWorkController = angular.module('WiseWorkController', []);

WiseWorkApp.factory("LocalDatabase", LocalDatabase);

WiseWorkApp.config(['$routeProvider',
  function ($routeProvider) {
      $routeProvider.
        when('/no-route', {
            templateUrl: 'Vues/connexion.html',
            controller: 'ctrl_connexion'
        }).
        when('/', {
            templateUrl: 'Vues/accueil.html',
            controller: 'ctrl_accueil'
        }).
        when('/Salon/:id', {
            templateUrl: 'Vues/message.html'
        }).
        otherwise({
            redirectTo: '/'
        });
  }]);