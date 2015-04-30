
WiseWorkController.controller('ctrl_probleme', function ($scope, $rootScope, $http) {

    $scope.listProbleme = [
    "Les messages ne s'affiche pas.",
    "Impossible de voir les salons."
    ];

    //$scope.listProbleme = new Array("Les messages ne s'affiche pas.", "Impossible de voir les salons");

    $scope.ajouterProbleme = function () {
        $scope.listProbleme[$scope.listProbleme.length] = $scope.description;
    }
});