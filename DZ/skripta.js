var appModule = angular.module("app1", ["ngRoute"]);

appModule.config(function ($routeProvider, $locationProvider) {

	$routeProvider.when("/home", {
		templateUrl: "pages/home/home.html",
		controller: "homeController"
	}).when("/profil", {
		templateUrl: "pages/profil/profil.html",
		controller: "profilController"
	}).otherwise({
        redirectTo: '/home'
    });
})