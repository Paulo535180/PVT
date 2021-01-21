(function () {
    'use strict';

    angular.module('PjrPadrao').controller('gestor', gestor);

    gestor.$inject = ['$scope', '$http'];

    function gestor($scope, $http) {

        $scope.ListarGestores = [];
        $scope.ListarSetor = [];
        $scope.ListarGestoresPorSetor = [];


        $scope.BuscarUsuarios = () => {
            $http.get('/gestor/listagem').then(resultado => {
                $scope.ListarGestores = resultado.data;
                console.log(resultado)
            }).catch(erro => { console.log(erro) });
        }

        $scope.BuscarSetores = () => {
            $http.get('/setor/listagem').then(resultado => {
                $scope.ListarSetor = resultado.data;
                
            }).catch(erro => { console.log(erro) });
        };

        $scope.BuscarGestoresPorSetor = (idSetor) => {
            $http.get('/gestor/listagem/' + idSetor).then(resultado => {
                $scope.ListarGestoresPorSetor = resultado.data;
            }).catch(erron => { console.log(erro) });
        }

        $scope.AbrirModalEditar = (gestor) => {
            $scope.setor = { ...gestor };
            if (gestor)
                $scope.tituloModal = 'Editar Setor'
            else
                $scope.tituloModal = 'Novo Setor'

            angular.element('#modalEdicao').modal('show');
        }

    }
})();
