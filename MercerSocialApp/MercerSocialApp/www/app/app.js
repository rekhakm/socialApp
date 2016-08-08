// Ionic Starter App

// angular.module is a global place for creating, registering and retrieving Angular modules
// 'starter' is the name of this angular module example (also set in a <body> attribute in index.html)
// the 2nd parameter is an array of 'requires'
// 'starter.controllers' is found in controllers.js
angular.module('mercersocialApp', ['ionic','angular-cache'])

.run(function($ionicPlatform,CacheFactory) {
  $ionicPlatform.ready(function() {
    // Hide the accessory bar by default (remove this to show the accessory bar above the keyboard
    // for form inputs)
    if (window.cordova && window.cordova.plugins.Keyboard) {
      cordova.plugins.Keyboard.hideKeyboardAccessoryBar(true);
      cordova.plugins.Keyboard.disableScroll(true);

    }
    if (window.StatusBar) {
      // org.apache.cordova.statusbar required
      StatusBar.styleDefault();
    }
   		CacheFactory("AdvertismentsCache", { storageMode: "localStorage", maxAge: 5000, deleteOnExpire: "aggressive"});
   		CacheFactory("AdvDataCache", { storageMode: "localStorage", maxAge: 5000, deleteOnExpire: "aggressive"});
        CacheFactory("UserDataCache", { storageMode: "localStorage", maxAge: 5000, deleteOnExpire: "aggressive"});
        CacheFactory("myAdsCache", { storageMode: "localStorage"});
        CacheFactory("staticCache", { storageMode: "localStorage"});
  });
})

.config(function($stateProvider, $urlRouterProvider) {

	$stateProvider

	.state('home',{
		abstract: true,
		url : '/home',
		templateUrl: 'app/home/home.html'
	})
	.state('home.advertisements',{
		url : '/advertisements',
		views:
		{
			"tab-advertisements":{
			templateUrl: 'app/home/advertisements.html',
		    }
		}
		
	})
	.state('home.dashboard',{
		url : '/dashboard',
		views:
		{
			"tab-dashboard":{
			templateUrl: 'app/home/dashboard.html',
		    }
		}
	})

	.state('app',{
		abstract: true,
		url : '/app',
		templateUrl: 'app/layout/menu-layout.html'
	})

	.state('landing',{
		abstract: true,
		url : '/landing',
		templateUrl: 'app/home/landing.html'
	})

	.state('landing.login',{
		url : '/login',
		views:
		{
			"tab-login":{
			templateUrl: 'app/login/login.html',
		    }
		}
	})
	.state('app.addNewadv',{
		url : '/addNewadv',
		views:
		{
			"mainContent":{
			templateUrl: 'app/advertisement/addNewadvertisement.html',
		    }
		}
	})	

	.state('app.locations',{
		url : '/locations',
		views:
		{
			"mainContent":{
			templateUrl: 'app/locations/locations.html',
		    }
		}
	})	

	;

	$urlRouterProvider.otherwise('/landing/login');
});


