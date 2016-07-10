/// <reference path="../plugins/angular/angular.js" />

var myApp = angular.module('myModule', []);
myApp.controller("schoolController", schoolController);
myApp.controller("studentController", studentController);
myApp.controller("teacherController", teacherController);

//declare
function schoolController($scope) {
    $scope.message = "This is my message from school controller";
}
function studentController($scope) {
    $scope.message = "This is my message from student controller";
}
function teacherController($scope) {
    //$scope.message = "This is my message from teacher controller";
}