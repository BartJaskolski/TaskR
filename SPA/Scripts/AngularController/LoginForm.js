
angular.module('AddItemForm')
.controller('LoginF', function ($scope, LoginService) {
    $scope.IsLogedIn = false;
    $scope.Message = '';
    $scope.Submitted = false;
    $scope.IsFormVaild = false;

    $scope.LoginData = {
        Username: '',
        Password: ''
    };

    $scope.$match('f1.$valid', function (newVal) {
        $scope.IsFormVaild = newVal;
    });

    $scope.Login = function () {
        $scope.Submitted = true;
        if ($scoep.IsFormVaild) {
            LoginService.GetUser($scope.LoginData).then(function (d) {
                if (d.data.Username != null) {
                    $scope.IsLogedIn = true;
                    $scope.Message = "Logged in " + d.data.FullName;
                }
                else {
                    alert('Invalid Creds');
                }
            })
        }
    }
})
.factoru('LoginService', function ($http) {
    var f = {};
    f.GetUser = function (d) {
        return $http({
            url: 'Home/UserLogin',
            method: 'POST',
            data: JSON.stringify(d),
            headers: { 'content-type': 'application/json' }
        });
    };
    return f;
});