(function() {

	'use strict';

	angular.module('mercersocialApp').controller('LoginCtrl',['$state','$scope','mercersocialApi',LoginCtrl]);
	
	function LoginCtrl($state,$scope,mercersocialApi)
	{
		var vm=this;
		vm.loginData = {};
		
		// Triggered in the login modal to close it
  		vm.closeLogin = function() {
   			// $scope.modal.hide();
  		};

  		  // Perform the login action when the user submits the login form
  		vm.doLogin = function() {
    		console.log('Doing login', vm.loginData);
    		 $state.go('home.dashboard'); 
    		// $state.go('app.modifyuser'); 

    		// Simulate a login delay. Remove this and replace with your login
    		// code if using a login system
    		// $timeout(function() {
      // 				$scope.closeLogin();
    		// 	}, 1000);
  		};

	}
})();
