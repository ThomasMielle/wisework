var WiseWorkApp = angular.module("WiseWorkApp", ['ngRoute', 'WiseWorkController']);
WiseWorkApp.factory("UserService", UserService);
WiseWorkApp.factory("LocalDatabase", LocalDatabase);

WiseWorkApp.config(['$routeProvider',
  function ($routeProvider) {
      $routeProvider.
        when('/', {
            templateUrl: 'Vues/connexion.html',
            controller: 'ctrl_connexion'
        }).
        otherwise({
            redirectTo: '/'
        });
  }]);