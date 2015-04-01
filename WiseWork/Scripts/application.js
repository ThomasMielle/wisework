var app = angular.module('wisework', ['mentio','ngRoute']);


app.config(['$routeProvider',
	
  function($routeProvider) {
    $routeProvider.
     when('/', {
        templateUrl: 'partials/index.html',
        controller: 'IndexCtrl'
      }).
      when('/salon/:id', {
        templateUrl: 'partials/salon.html',
        controller: 'SalonCtrl'
      }).
      when('/conversation/:id', {
        templateUrl: 'partials/conversation.html',
        controller: 'MsgCtrl'
      }).
      otherwise({
        redirectTo: '/'
      });
  }]);

app.controller("IndexCtrl",function($scope,$rootScope,SalonFactory){


	$scope.salon = SalonFactory.getSalon(0);
  $rootScope.titrePage = $scope.salon.title;


});

app.controller('LayoutController',function($scope,SalonFactory,MsgFactory,$http, $q, $timeout){

  $scope.salons = SalonFactory.getSalons();
  $scope.users = MsgFactory.getUsers();

        // shows the use of dynamic values in mentio-id and mentio-for to link elements
        $scope.myIndexValue = "5";

        $scope.searchPeople = function(term) {
            var peopleList = [];
            return $http.get('data/peopledata.json').then(function (response) {
                angular.forEach(response.data, function(item) {
                    if (item.name.toUpperCase().indexOf(term.toUpperCase()) >= 0) {
                        peopleList.push(item);
                    }
                });
                $scope.people = peopleList;
                return $q.when(peopleList);
            });
        };


        $scope.getPeopleTextRaw = function(item) {
            return '@' + item.name;
        };
      
});
app.controller('SalonCtrl', function($scope,$rootScope,SalonFactory,$routeParams){

 
 	var id = $routeParams.id;
 	$scope.salon = SalonFactory.getSalon(id);
  $rootScope.titrePage = $scope.salon.title;

 	$scope.addMessage = function(){

 		$scope.salon.messages.push(
	 		{
                "content": $scope.newMsg,
                "date": "",
                "member": [
                    {
                        "id": 1,
                        "name": "FrancesChristian"
                    }
                ]
            }
 		); 
 		$scope.newMsg = "";
 	};


});


app.controller('MsgCtrl',function($scope,MsgFactory,$rootScope,$routeParams){

	var idUser = $routeParams.id;
 
	$scope.user = MsgFactory.getUser(idUser);
  $rootScope.titrePage = $scope.user.name;

	$scope.addMessage = function(){
		$scope.user.messages.push(
			{
	        "content": $scope.newMsg,
	        "date": ""
	      	}
		);
	};
  
});

app.filter('words', function () {
  return function (input, words) {
      if (isNaN(words)) {
          return input;
      }
      if (words <= 0) {
          return '';
      }
      if (input) {
          var inputWords = input.split(/\s+/);
          if (inputWords.length > words) {
              input = inputWords.slice(0, words).join(' ') + '\u2026';
          }
      }
      return input;
  };
});
