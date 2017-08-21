/// <reference path="D:\projects\angularjs\Assesment_kiran\Test_UI\Scripts/angular.min.js" />

var app = angular.module("myModule", ['ngRoute','ngResource']);
app.constant('apiUrl', 'http://localhost/Test_Api/api/')
app.controller("myController", function ($scope, myFactory) {
    $scope.EmpData = myFactory.EmpDetails.getEmpDetails();
    console.log($scope.EmpData);
})
app.config(function ($routeProvider) {
    $routeProvider
    .when("/About",
    {
        templateUrl: "Home/About"
    })
    .when("/Contact", {
        templateUrl:"Home/Contact"
    })
})
app.directive("myDirective",function () {
    return {
        restrict: 'E',
        scope: {
            inf: '@'
        },
        controller: 'myController',
        template: '<ol> <li ng-repeat= "emp in EmpData ">{{emp.EmpId}}--{{emp.EmpName}}--{{emp.Salary}}</li> </ol>'
    }
});
app.factory("myFactory", function ($resource, apiUrl) {

    return {
        EmpDetails: $resource(apiUrl + 'Data_Api', null, {
            getEmpDetails: { method: 'GET', isArray: true, url: apiUrl + 'Data_Api/Get' }
        })
    }
})