
WiseWorkController.controller('ctrl_salon', ['$scope', '$rootScope', '$http', '$routeParams', 'SalonService', function ($scope, $rootScope, $http, $routeParams, SalonService) {

    var idSalon = $routeParams.id;

    SalonService.getAllMessage().then(function (response) {
        //LocalDatabase.listSalon = response.data;
        $rootScope.listMessage = response.data;
    });
}]);