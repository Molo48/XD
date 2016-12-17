appModule.controller("profilController", function ($scope) {

	$scope.profil = {
        firstname: "",
        lastname: "",
        age: "",
       inventar: []
        };

    //     inventar:[{
    //       naziv:"",
    //       serBr:"",
    //       knVal:"",
    //       opis:"",
    //       dostup:""
    //       }]
        
    // };
   


      $scope.tempNaz = '';
      $scope.tempSer = '';
      $scope.tempVal = '';
      $scope.tempOpis = '';
      $scope.tempDost = '';

      // $scope.submit = function(){
      // if($scope.tempNaz && $scope.tempSer && $scope.tempVal && $scope.tempOpis && $scope.tempDost){
      //       $scope.profil.ivnentar.naziv=$scope.tempNaz;
      //       $scope.profil.ivnentar.serBr=$scope.tempSer;
      //       $scope.profil.ivnentar.SerBr=$scope.tempVal;
      //       $scope.profil.ivnentar.knVal=$scope.tempOpis;
      //       $scope.profil.ivnentar.opis=$scope.tempDost;
      //       $scope.profil.ivnentar.dostup=$scope.tempDost;
      //       $scope.tempNaz = '';
      //       $scope.tempSer = '';
      //       $scope.tempVal = '';
      //       $scope.tempOpis = '';
      //       $scope.tempDost = '';
      //       }
      // };


      $scope.text = '';
      
      $scope.submit = function() {
        if($scope.tempNaz && $scope.tempSer && $scope.tempVal && $scope.tempOpis){
          $scope.profil.inventar.push({
          naziv : $scope.tempNaz,
          serBr : $scope.tempSer,
          knVal : $scope.tempVal,
          opis : $scope.tempOpis,
          dostup : $scope.tempDost
          });
          }
        
      };
    
});