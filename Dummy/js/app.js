var app = angular.module('myApp', []);
alert('hi');
app.controller('employeeController', ['$scope', '$http', employeeController]);

// Angularjs Controller
function employeeController($scope, $http) {
    // Declare variable
    $scope.loading = true;
    $scope.updateShow = false;
    $scope.addShow = true;
    $scope.UserDetail =
        {
            FirstName: '',
            LastName: '',
            Phone: '',
            email: '',
            Password: '',
            Role: '',
            IsActive: '',

        };
   

    //Insert Employee
    $scope.add = function () {
      // alert('hi');
        $scope.loading = true;
        $http.post('/api/User/Savedata', $scope.UserDetail).success(function (data) {
            $scope.employees = data;
            alert('Record Inserted Successfully');
            $scope.updateShow = false;
            $scope.addShow = true;
            $scope.newemployee = '';
        }).error(function (data) {
            $scope.error = "An Error has occured while Adding employee! " + data;            
        });
    }
    // Get All Employee
    $http.get('/api/EmployeeAPI/').success(function (data) {
        $scope.employees = data;
    }).error(function () {
        $scope.error = "An Error has occured while loading posts!";
    });

   
}