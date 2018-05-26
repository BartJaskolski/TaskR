angular.module("AngularForm.controllers", [])
    .controller("LoginController", function ($scope, UserService) {
        $scope.message = "Zaloguj się";

        $scope.Login = function () {
            UserService.loginMeth($scope.user);
        }
    })
    .factory("UserService", ['$http', function ($http) {
        var fac = {};
        
        fac.loginMeth = function(user)
        {
            $http.post("/api/User/UserLogin", user).then(function (response) {
                alert(response.status);
                console.log(response);
                console.log(response.data.Data);
                if(response.data.Data == null)
                {
                    alert("Błędne hasło lub login");
                }
                else
                {
                    alert("Zalogowano !" + response.data.Data.AccountType);
                }
            })
        }
        return fac;
    }])
