//moramo je uključit u index.html
appModule.controller("homeController", function ($scope) {
	// kod koji se bude nalazio unutar tijela ove funkcije je kod 'homeController' kontrolera

	$scope.ime = "diana";

	$scope.varijabla = "neki tekst za prikazati u viewu.";
	
	$scope.isClicked = false;

});
