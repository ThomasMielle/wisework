function SalonService($http, LocalDatabase) {
    function getAllSalon() {

        var chemin = "/api/Salon/getAllSalon";
        LocalDatabase.listSalon = null;

        return $http.get(chemin)
            .success(function (listAllSalon) {
                LocalDatabase.listSalon = listAllSalon;
                //Stocker dans la base JS plus tard
            })
            .error(function () {
                LocalDatabase.listSalon = null;
                //Supprimer de la base JS 
            });
    }

    return {
        getAllSalon: getAllSalon,
        listSalon: function () { return LocalDatabase.listSalon; }
    };
}

//function SalonService($http, LocalDatabase) {
//    function getAllMessage() {

//        var chemin = "/api/Salon/getAllMessage";
//        LocalDatabase.listMessage = null;

//        return $http.get(chemin)
//            .success(function (listAllMessage) {
//                LocalDatabase.listMessage = listAllMessage;
//                //Stocker dans la base JS plus tard
//            })
//            .error(function () {
//                LocalDatabase.listMessage = null;
//                //Supprimer de la base JS 
//            });
//    }

//    return {
//        getAllMessage: getAllMessage,
//        listMessage: function () { return LocalDatabase.listMessage; }
//    };
//}