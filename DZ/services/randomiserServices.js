angular.factory('randomiserServices', function(){

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