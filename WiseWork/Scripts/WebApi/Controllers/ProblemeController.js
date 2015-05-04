
WiseWorkController.controller('ctrl_probleme', function ($scope, $rootScope, $http) {
    $scope.description = "";
    $scope.listProbleme = [
    "Les modifications du profil déconnectent l'utilisateur",
    "Les salons entre utilisateurs ne fonctionnent pas",
    "Le partage Google Drive n'est pas implémenté",
    "On ne peut enregistrer qu'un problème ?"
    ];

    //$scope.listProbleme = new Array("Les messages ne s'affiche pas.", "Impossible de voir les salons");

    $scope.ajouterProbleme = function () {
        if ($scope.description != "") {
            $scope.listProbleme[$scope.listProbleme.length] = $scope.description;
            $scope.desrciption = "";
        }
    }
});