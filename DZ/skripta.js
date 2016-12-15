var appModule = angular.module("app1", ["ngRoute"]);

appModule.config(function ($routeProvider, $locationProvider) {

	$routeProvider.when("/home", {
		templateUrl: "home.html",
		controller: "homeController"
	}).when("/profil", {
		templateUrl: "profil.html",
		controller: "profilController"
	}).otherwise({
        redirectTo: '/home'
    });
})