
WiseWorkController.controller('ctrl_salon', ['$scope', '$rootScope', '$http', '$routeParams', function ($scope, $rootScope, $http, $routeParams, SalonService) {

    var idSalon = $routeParams.id;

    SalonService.getAllMessage()
        .success(function () {
            //$rootScope.listMessage = SalonService.listMessage();
        })
        .error(function (exception) {

        }
    );
}]);