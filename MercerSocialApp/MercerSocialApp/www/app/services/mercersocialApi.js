(function() {

	'use strict';

	angular.module('mercersocialApp').factory('mercersocialApi',['$http','$q','$ionicLoading','$timeout','$cacheFactory',mercersocialApi]);
	function mercersocialApi($http,$q,$ionicLoading,$timeout,$cacheFactory) {
		var self=this;

		self.advertismentsCache=$cacheFactory("AdvertismentsCache");
		self.advertismentDataCache=$cacheFactory("AdvDataCache");

		self.staticCache=$cacheFactory("staticCache");

		function setAdvId(advId)
		{
			self.staticCache.put("currentAdvId",advId);
		}
		function getAdvId()
		{
			return self.staticCache.get("currentAdvId");
		}
		function getAdvertisements()
		{
			var deferred=$q.defer();
			var	cacheKey="advertisments";
			var	advData=self.advertismentsCache.get(cacheKey);
           
			if(advData)	
			{
				console.log("found data in cache",advData);
				deferred.resolve(advData);
			} else{

				$http.get("http://localhost:49320/api/advertisements").success(function(data){
					console.log("received from http");
					self.advertismentsCache.put(cacheKey,data);
					deferred.resolve(data);

					advData=self.advertismentsCache.get(cacheKey);
					console.log("testing data",advData);
				})
				.error(function(){
					console.log("error  while making http call");
					deferred.reject();
				});
			}

			return deferred.promise;
		}

		function getAdvertisementData()
		{
			console.log("currentAdvId",getAdvId());
			var deferred=$q.defer();
			var cacheKey="advertismentData-"+getAdvId();
			var advdata=self.advertismentDataCache.get(cacheKey);
            //console.log("testdata",advdata);
			if(advdata)	
			{
				console.log("found data in cache",advdata);
				deferred.resolve(advdata);
			} else{

				$ionicLoading.show({template:'Loading...'});

			   $http.get("http://localhost:49320/api/advertisements/"+getAdvId()).success(function(data,status){
				console.log("received via http",data,status);
				$timeout(function(){

					self.advertismentDataCache.put(cacheKey,data);
					deferred.resolve(data);

					advdata=self.advertismentDataCache.get(cacheKey);
					console.log("test1",advdata);
					$ionicLoading.hide();
					deferred.resolve(data);
				},1000);
				
			})
			.error(function(){
				console.log("error  while making http call");
				$ionicLoading.hide();
				deferred.reject();
			});
		 }

			return deferred.promise;

		};


		return {
			getAdvertisements: getAdvertisements,
            getAdvertisementData:getAdvertisementData,
            setAdvId: setAdvId
		};
	};
})();
