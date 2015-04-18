function SalonService($http, LocalDatabase) {
    function getAllSalon() {

        var chemin = "/api/Salon/getSalon";

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