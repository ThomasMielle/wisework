var WiseWorkController = angular.module('WiseWorkController', []);

WiseWorkController.controller('indexCtrl',
    function ($scope, $http) {

        $http.get("/api/Ressource/getUtilisateur").success(
                    function (data) {
                        $scope.listUtilisateur = data;
                        $scope.NotificationUser = "Loading utilisateur : OK";
                    })
                    .error(function (data) {
                        $scope.NotificationUser = "Loading utilisateur : Fail";
                    })

        $scope.Message = "Hello";
});

