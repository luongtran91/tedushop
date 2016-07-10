/// <reference path="../plugins/angular/angular.js" />

var myApp = angular.module('myModule', []);
myApp.controller("schoolController", schoolController);
myApp.service('Validator', Validator);

schoolController.$inject = ['$scope', 'Validator'];

// Controller
function schoolController($scope, Validator) {
    $scope.num = 1;
    $scope.onCheckNumber = function () {
        $scope.message = Validator.checkNumber($scope.num);
    }
}


// Service
function Validator($window) {
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