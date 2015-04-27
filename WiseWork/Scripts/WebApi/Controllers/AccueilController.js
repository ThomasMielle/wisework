
WiseWorkController.controller('ctrl_accueil', function ($scope, $rootScope, $http, LocalDatabase, SalonService, UserService) {
   
    SalonService.getAllSalon().then(function (response) {
        console.log(response.data);
        //LocalDatabase.listSalon = response.data;
        $rootScope.listSalon = response.data;
    });
    
    UserService.getAllUser().then(function (response) {
        console.log(response.data);
        //LocalDatabase.listUser = response.data;
        $rootScope.listUser = response.data;
    });
});