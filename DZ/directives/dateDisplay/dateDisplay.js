appModule.directive("dateDisplay",function(){

	function dateDisplayController($scope){
		$scope.dateNow=new Date();

	}


	return {
		controller: dateDisplayController,
		templateUrl: "directives/dateDisplay/dateDisplay.html",
		scope: {
			additionalText:"="

		}
	};
});
