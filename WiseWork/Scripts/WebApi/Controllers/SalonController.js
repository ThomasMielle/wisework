var WiseWorkController = angular.module('WiseWorkController', []);

WiseWorkController.controller('ctrl_salon', function ($scope, $rootScope, $http, SalonService) {

    //var idSalon = $routeParams.id;

    SalonService.getAllMessage()
        .success(function () {
            $rootScope.listMessage = SalonService.listMessage();
        })
        .error(function (exception) {

        }
    );
});

//WiseWorkController.controller('ctrl_publication_salon', ['$scope', '$http', '$routeParams', function ($scope, $http, $routeParams) {
