appModule.controller("profilController", function ($scope) {

	$scope.profil = {
        firstname: "",
        lastname: "",
        age: "",
        inventar: []
    };
   
      $scope.text = '';
      $scope.submit = function() {
        if ($scope.text) {
          $scope.profil.inventar.push(this.text);
          $scope.text = '';
        }
      };
    
});

