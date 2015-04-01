var WiseWorkApp = angular.module("WiseWorkApp", ['ngRoute', 'WiseWorkController']);

WiseWorkApp.config(['$routeProvider',
  function ($routeProvider) {
      $routeProvider.
        when('/', {
            templateUrl: 'Vues/accueil.html',
            controller: 'indexCtrl'
        }).
        otherwise({
            redirectTo: '/'
        });
  }]);
