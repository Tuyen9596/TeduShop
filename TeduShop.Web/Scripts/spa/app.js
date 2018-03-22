/// <reference path="../plugins/angular/angular.js" />
//initialization module
var myApp = angular.module('myModule', []);
myApp.controller('rootController', rootController);
myApp.service('ValidatorService', ValidatorService);
myApp.directive('teduShopDirective', teduShopDirective)
//rootController.$injector = ['$scope', Validator];
//declare cotroller
$scope.num = 2;
function rootController($scope, ValidatorService) {
    $scope.checkNumber = function () {
        ValidatorService.checknumber($scope.num);
    }
    $scope.return = teduShopDirective();
}
function ValidatorService($window) {
    return {
        checknumber: checknumber
    }
    function checknumber(input) {
        if (input % 2 == 0) {
            $window.alert('even');
        }
        else $window.alert('odd');
        }
    
}
function teduShopDirective()
{
    return {
        template:"<h1>return result with name is template</h1>"
    }
}

