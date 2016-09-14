var LoginApp = angular.module("LoginApp", []);
LoginApp.controller('LoginCtrl', function ($scope, $http) {
    $scope.land = function () {
        $http.post('/Login/ToLogin', {
            StudentNumber: $scope.studentNumber,
            Password: $scope.password,
        }).success(function (d) {
            if (d == true) {
                window.location.href = '/Home/Index'
            }
            else {
                alert('登陆失败')
            }
        }).error(function () {
            alert('服务器错误')
        });
    };
});