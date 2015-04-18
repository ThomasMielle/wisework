var WiseWorkController = angular.module('WiseWorkController', []);

//  
WiseWorkController.controller('ctrl_accueil', function ($scope, $rootScope, $http, SalonService) {

    SalonService.getAllSalon()
        .success(function () {
            $scope.listSalon = SalonService.listSalon;
            $rootScope.listSalon = SalonService.listSalon;
        })
        .error(function (exception) {

        });
});