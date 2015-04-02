app.factory('MsgFactory',function($http){
	var factory = {
		users : [
			  {
			    "id": 0,
			    "name": "Amadou B.",
			    "messages": [
			      {
			        "content": "non",
			        "date": ""
			      },
			      {
			        "content": "adipisicing",
			        "date": ""
			      },
			      {
			        "content": "aliqua",
			        "date": ""
			      }
			    ]
			  },
			  {
			    "id": 1,
			    "name": "Simont P.",
			    "messages": [
			      {
			        "content": "sint",
			        "date": ""
			      },
			      {
			        "content": "dolore",
			        "date": ""
			      },
			      {
			        "content": "id",
			        "date": ""
			      }
			    ]
			  },
			  {
			    "id": 2,
			    "name": "Jordan O.",
			    "messages": [
			      {
			        "content": "esse",
			        "date": ""
			      },
			      {
			        "content": "proident",
			        "date": ""
			      },
			      {
			        "content": "aliquip",
			        "date": ""
			      }
			    ]
			  },
			  
			  {
			    "id": 3,
			    "name": "Thomas M.",
			    "messages": [
			      {
			        "content": "esse",
			        "date": ""
			      },
			      {
			        "content": "proident",
			        "date": ""
			      },
			      {
			        "content": "aliquip",
			        "date": ""
			      }
			    ]
			  },
			  
			  {
			    "id": 4,
			    "name": "Alain A.",
			    "messages": [
			      {
			        "content": "esse",
			        "date": ""
			      },
			      {
			        "content": "proident",
			        "date": ""
			      },
			      {
			        "content": "aliquip",
			        "date": ""
			      }
			    ]
			  },
			  
			  {
			    "id": 5,
			    "name": "Danny A.",
			    "messages": [
			      {
			        "content": "esse",
			        "date": ""
			      },
			      {
			        "content": "proident",
			        "date": ""
			      },
			      {
			        "content": "aliquip",
			        "date": ""
			      }
			    ]
			  },
			  {
			    "id": 6,
			    "name": "Medhy S.",
			    "messages": [
			      {
			        "content": "esse",
			        "date": ""
			      },
			      {
			        "content": "proident",
			        "date": ""
			      },
			      {
			        "content": "aliquip",
			        "date": ""
			      }
			    ]
			  }
			],
		getUsers :function(){
			/*var deferred = $q.defer();
			$http.get('data/private-msg.json').success(function(data,status){
				factory.users = data;
				deferred.resolve(factory.users);
			}).error(function(data,status){
				//deferred.reject("Impossible de récupérer les données");
			});
			//return deferred.promise;*/
			return factory.users;
			
		},
		getUser : function(id){
			var user ={};
			angular.forEach(factory.users, function(value,key){

				if(value.id == id){
					user = value
				}
			})
			return user;
		}
	};
	return factory ;
})