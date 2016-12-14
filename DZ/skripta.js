// dokumentacija na https://docs.angularjs.org/api

var appModule = angular.module("app1", ["ngRoute"]);

appModule.config(function ($routeProvider, $locationProvider) {

	$routeProvider.when("/home", {
		templateUrl: "home.html",
		controller: "homeController"
	}).when("/help", {
		templateUrl: "help.html",
		controller: "helpController"
	}).otherwise({
        redirectTo: '/home'
    });
})