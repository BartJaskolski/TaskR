

angular.module('AddItemForm')
.controller('Training', function ($scope, GetCategory) {
    $scope.Contact = null;
    GetCategory.GetLastContact().then(function (d) {
        $scope.Contact = d.data;
    }, function () {
        alert('Failed');
    });

})
.factory('GetCategory', function ($http) {
    var fac = {};
    fac.GetLastContact = function () {
        return $http.get('api/Category/Get');
    }
    return fac;
});