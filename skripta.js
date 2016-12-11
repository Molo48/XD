var appModule =angular.module("app1", []);

appModule.controller("imeControllera", function($scope){
    
    $scope.varijabla ="neki tekst za prikazati u viewu";
    $scope.broj1='';
    $scope.broj2='';
    
    $scope.zbroj=function() {
        return $scope.broj1+$scope.broj2;
    };
        
});