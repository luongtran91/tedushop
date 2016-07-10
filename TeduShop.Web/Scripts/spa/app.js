/// <reference path="../plugins/angular/angular.js" />

var myApp = angular.module('myModule', []);
myApp.controller("schoolController", schoolController);
myApp.service('ValidatorService', ValidatorService);
myApp.directive("teduShopDirective", teduShopDirective);
schoolController.$inject = ['$scope', 'ValidatorService'];

// Controller
function schoolController($scope, ValidatorService) {
    $scope.num = 1;
    $scope.onCheckNumber = function () {
        $scope.message = ValidatorService.checkNumber($scope.num);
    }
}


// Service
function ValidatorService($window) {
    return {
        checkNumber: checkNumber
    }
    function checkNumber(input) {
        if (input % 2 == 0) {
            return "This is even";
        }
        return 'This is odd';
    }
}

// Dirctive
function teduShopDirective() {
    return {
        restric: "E",
        templateUrl: "/Scripts/spa/teduShopDirective.html"
    }
}