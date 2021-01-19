(function () {
    'use strict';

    angular.module('PjrPadrao').controller('gestor', gestor);

    usuario.$inject = ['$scope', '$http'];

    function gestor($scope, $http) {

        $scope.ListarGestores = [];


        $scope.BuscarGestores = () => {
            $http.get('/gestor/listagem').then(resultado => {
                $scope.ListarGestores = resultado.data;
            }).catch(erro => { console.log(erro) });
        }

    }
})();
