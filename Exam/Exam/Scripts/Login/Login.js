var RegisterApp = angular.module("RegisterApp", []);
RegisterApp.controller('RegisterCtrl', function ($scope, $http) {
    $scope.add = function () {
        if (($scope.password).length < 6) {
            alert('密码长度不小于6位')
            $scope.password = '';
            $scope.confirmpassword = '';
            return;
        }
        if (($scope.password) != ($scope.confirmpassword)) {
            alert('确认密码与密码不符请重新输入');
            $scope.password = '';
            $scope.confirmpassword = '';
            return;
        }
        alert();
        $http.post('/Login/ToRegister', {
            Email: $scope.email,
            Password: $scope.password,
            //ConfirmPassword: $scope.confirmpassword,
        }).success(function (d) {
            if (d == true) {
                alert('注册成功')
                window.location.href = '/Home/Index'
            } else {
                alert('注册失败')
            }
        }).error(function () {
            alert('服务器错误')
        });
    };
});

var LoginApp = angular.module("LoginApp", []);
LoginApp.controller('LoginCtrl', function ($scope, $http) {
    $scope.matching = function () {
        $http.post('/Login/ToLogin', {
            Email: $scope.email,
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