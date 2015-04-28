
WiseWorkController.controller('ctrl_salon', ['$scope', '$rootScope', '$http', '$routeParams', 'SalonService', function ($scope, $rootScope, $http, $routeParams, SalonService) {

    var idSalon = $routeParams.id;

    SalonService.getAllMessage().then(function (response) {
        //LocalDatabase.listSalon = response.data;
        $rootScope.listMessage = response.data;
    });

    $scope.newMessage = "/rdv 12/05/2015 14:05:00 15:00:00 'Salon' ";
    var CreateRdvPath = "/api/Salon/createRdv";
    $scope.envoyerMessage = function () {
        var pattern = new RegExp("/rdv");

        if (pattern.test($scope.newMessage)) {
            var str = $scope.newMessage.split("/rdv");
            var eventParams = str[1].split(" ");
            var dateDebut = eventParams[1];
            var heureDebut = eventParams[2];
            var heureFin = eventParams[3];
            var titreRdv = eventParams[4];
            var event = {
                dateDebut: dateDebut,
                heureDebut: heureDebut,
                dateFin: dateFin,
                heureFin: heureFin,
                titreRdv: titreRdv,
                user: { email: "aobmilan@gmail.com", pwd: "pwdddd=" },
                invites: [
                    { email: "bah.founet@gmail.com" },
                    { email: "aobmilan@yahoo.fr" },
                    { email: "aobmilan@facebook.com" },
                ]

            }
            $http.post(CreateRdvPath, event
                )
                .success(function (data) {
                    alert("Rendez vous crée avec succès");
                })
                .error(function (data) {
                    alert("Erreur : Le rdv n'a pas été crée ");
                });

        }

    };
}]);