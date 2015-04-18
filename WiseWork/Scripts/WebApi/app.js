var WiseWorkApp = angular.module("WiseWorkApp", ['ngRoute', 'WiseWorkController']);

WiseWorkApp.factory("UserService", UserService);
//WiseWorkApp.factory("SalonService", SalonService);
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
            //controller: 'ctrl_accueil'
        }).
        otherwise({
            redirectTo: '/'
        });
  }]);