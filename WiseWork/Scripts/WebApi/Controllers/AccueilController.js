var WiseWorkController = angular.module('WiseWorkController', []);

WiseWorkController.controller('ctrl_accueil', function ($scope, $rootScope, $http, SalonService, UserService) {

    SalonService.getAllSalon()
        .success(function () {
            $rootScope.listSalon = SalonService.listSalon();
        })
        .error(function (exception) {

        }
    );

    UserService.getAllUser()
        .success(function () {
            $rootScope.listUser = UserService.listUser();
        })
        .error(function (exception) {

        }
    );
});