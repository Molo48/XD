//moramo je uključit u index.html
appModule.controller("randomUserController", function ($scope,$http) {
	// kod koji se bude nalazio unutar tijela ove funkcije je kod 'homeController' kontrolera

$scope.gender="0";
$scope.nationality="0";

    $scope.randomUserFetch=function(){
    	


    	$http
    		.get("https://api.randomuser.me/?gender=" + $scope.gender+"&nat="+$scope.nationality)
    		.then(function(response){
    			$scope.user=response.data;
    		});

    };
});


