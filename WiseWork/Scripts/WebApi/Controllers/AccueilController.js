
WiseWorkController.controller('ctrl_accueil', function ($scope, $rootScope, $http, LocalDatabase, SalonService, UserService) {
   
    SalonService.getAllSalon().then(function (response) {
        //LocalDatabase.listSalon = response.data;
        $rootScope.listSalon = response.data;
    });
    
    UserService.getAllUser().then(function (response) {
        //LocalDatabase.listUser = response.data;
        $rootScope.listUser = response.data;
    });
});