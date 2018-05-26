var app = angular.module("AngularForm", ["AngularForm.controllers", "ngRoute"]);


app.config(["$routeProvider", function ($routeProvider) {
    $routeProvider.
        when("/",
        {
            controller: "LoginController",
            templateUrl: "/Partial/Login.html"
        })
    .otherwise({ redirectTo: "/" });
}]);