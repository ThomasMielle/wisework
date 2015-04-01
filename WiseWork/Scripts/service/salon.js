app.factory('SalonFactory',function($http,$q){
	var factory = {
		salons : [
		    {
		        "id": 0,
		        "title": "Developpeurs Web ",
		        "messages": [
		            {
		                "content": "non",
		                "date": "",
		                "member": [
		                    {
		                        "id": 1,
		                        "name": "FrancesChristian"
		                    }
		                ]
		            },
		            {
		                "content": "aute",
		                "date": "",
		                "member": [
		                    {
		                        "id": 2,
		                        "name": "HaysGilmore"
		                    }
		                ]
		            },
		            {
		                "content": "dolor",
		                "date": "",
		                "member": [
		                    {
		                        "id": 3,
		                        "name": "ChristensenWhitfield"
		                    }
		                ]
		            }
		        ]
		    },
		    {
		        "id": 8,
		        "title": "Infographistes",
		        "messages": [
		            {
		                "content": "laborum",
		                "date": "",
		                "member": [
		                    {
		                        "id": 0,
		                        "name": "BoyerValentine"
		                    }
		                ]
		            },
		            {
		                "content": "exercitation",
		                "date": "",
		                "member": [
		                    {
		                        "id": 4,
		                        "name": "CharlesMclaughlin"
		                    }
		                ]
		            },
		            {
		                "content": "amet",
		                "date": "",
		                "member": [
		                    {
		                        "id": 5,
		                        "name": "KimMccray"
		                    }
		                ]
		            }
		        ]
		    },
		    {
		        "id": 9,
		        "title": "Testeurs",
		        "messages": [
		            {
		                "content": "reprehenderit",
		                "date": "",
		                "member": [
		                    {
		                        "id": 10,
		                        "name": "WatersWorkman"
		                    }
		                ]
		            },
		            {
		                "content": "dolor",
		                "date": "",
		                "member": [
		                    {
		                        "id": 7,
		                        "name": "ElisabethPratt"
		                    }
		                ]
		            },
		            {
		                "content": "laboris",
		                "date": "",
		                "member": [
		                    {
		                        "id": 6,
		                        "name": "WelchBrewer"
		                    }
		                ]
		            }
		        ]
		    },
		    ,
		    {
		        "id": 10,
		        "title": "Informatique",
		        "messages": [
		            {
		                "content": "reprehenderit",
		                "date": "",
		                "member": [
		                    {
		                        "id": 10,
		                        "name": "WatersWorkman"
		                    }
		                ]
		            },
		            {
		                "content": "dolor",
		                "date": "",
		                "member": [
		                    {
		                        "id": 7,
		                        "name": "ElisabethPratt"
		                    }
		                ]
		            },
		            {
		                "content": "laboris",
		                "date": "",
		                "member": [
		                    {
		                        "id": 6,
		                        "name": "WelchBrewer"
		                    }
		                ]
		            }
		        ]
		    }
		],
		getSalons :function(){
			/*var deferred = $q.defer();
			$http.get('data/salon.json').success(function(data,status){
				factory.salons = data;
				deferred.resolve(factory.salons);
			}).error(function(data,status){
				deferred.reject("Impossible de récupérer les données");
			});
			return deferred.promise;*/
			return factory.salons;
		
		},
		getSalon : function(id){

			var salon ={};

			angular.forEach(factory.salons, function(value,key){
				
				if(value.id == id){

					salon = value
				}

			})
			
			return salon;
		}

	};
	return factory ;
});
