<!DOCTYPE html>
<html>
<script src="https://ajax.googleapis.com/ajax/libs/angularjs/1.6.4/angular.min.js"></script>

<body ng-app="myApp">

<div ng-controller="nameCtrl">

Name: <input type="text" ng-model="name" ng-keyup="displayNum();"><br>
Name is: {{name}} <br>
Total Value of name is: {{totalValue}} 
</div>


<script>
var app = angular.module('myApp', [])

.controller("nameCtrl", function($scope) {
   $scope.name = "";
   $scope.totalValue = 0;
   
   $scope.displayNum = function() {
      var totalNameValue = getStringValue($scope.name); //get the total value
      $scope.totalValue = totalNameValue;
   }
   
   function getStringValue(string) {
     var totalStringValue = 0;
     for (var i = 0; i < string.length; i++) {
        totalStringValue += string.charCodeAt(i);
     }
     
     return totalStringValue;
   } 
});



</script>

</body>
</html>
