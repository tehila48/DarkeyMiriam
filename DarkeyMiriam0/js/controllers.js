'use strict';
angular.module('myApp', []);

//angular.module('myApp').
angular.module('myApp').controller('AvailableTripsController', function ($scope) {
   
    $scope.initModel = function (myModel) {

        $scope.available = myModel;
         //$scope.search = myModel;
     
    };
   
});
//angular.module('myApp').controller('AvailableTripsController', function ($scope) {

//    $scope.initModel = function (myModel) {

//        $scope.search = myModel;

//    };

//});
angular.module('myApp').controller('AvailableTripTemporariesController', function ($scope) {


    $scope.initModel = function (myModel) {

        $scope.availabletemp = myModel;

    };

});
angular.module('myApp').controller('ExecutedTripsController', function ($scope) {


    $scope.initModel = function (myModel) {

        $scope.executed = myModel;

    };

});
angular.module('myApp').controller('NotExecutedTripsController', function ($scope) {


    $scope.initModel = function (myModel) {

        $scope.notexecuted = myModel;

    };

});
angular.module('myApp').controller('PatientsController', function ($scope) {


    $scope.initModel = function (myModel) {

        $scope.patient = myModel;

    };

});
angular.module('myApp').controller('RequestsController', function ($scope, $http) {
   
   
    $scope.initModel = function (myModel) {

        $scope.request = myModel;
       
     
    };
   
});

angular.module('myApp').controller('UsersPasswordsController', function ($scope) {


    $scope.initModel = function (myModel) {

        $scope.userpassword = myModel;

    };

});
angular.module('myApp').controller('VolunteersController', function ($scope) {


    $scope.initModel = function (myModel) {

        $scope.volunteers = myModel;

    };

});
