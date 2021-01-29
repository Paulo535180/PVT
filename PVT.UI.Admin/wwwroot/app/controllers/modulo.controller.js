(function () {
    'use strict';

    angular
        .module('PjrPadrao')
        .controller('modulo', modulo);

    modulo.$inject = ['$scope', '$http'];

    function modulo($scope, $http) {
        $scope.ListarModulos = [];
        $scope.ListarSetores = [];

        $scope.BuscarModulos = () => {
            $http.get('/modulo/listagem').then(resultado => {
                $scope.ListarModulos = resultado.data;
            }).catch(erro => { console.log(erro) });
        };

        $scope.BuscarSetores = () => {
            $http.get('/setor/listagem').then(resultado => {
                $scope.ListarSetores = resultado.data;
            }).catch(erro => { console.log(erro) });
        };

        $scope.BuscarModuloPorSetor = (setor) => {
            $scope.setor = setor;
            $http.get('/modulo/listagem/' + setor.ID).then(resultado => {
                $scope.ListarGestoresPorSetor = resultado.data;
            }).catch(erron => { console.log(erro) });
        }

        $scope.AdicionarModulo = (modulo) => {
            let tarefa
            if (!modulo.ID) {
                modulo.DATA_CRIACAO = new Date(Date.now());
                modulo.ID_GESTOR = '';
                modulo.USUARIO_CRIACAO = '';
                modulo.STATUS = true;
                tarefa = $http.post('/modulo/AdicionarModulo', modulo);
            } else {
                tarefa = $http.put('/modulo/EditarModulo?id=' + modulo.ID, modulo)
            }
            tarefa.then(data => {
                $scope.BuscarModulos();
                angular.element('#modalEdicao').modal('hide');
                Swal.fire(
                    'Salvo com Sucesso',
                    '',
                    'success'
                );
            })
                .catch(erro => { console.log(erro) });
        }
        $scope.AbrirModalEditar = (modulo) => {
            $scope.modulo = { ...modulo };
            if (modulo)
                $scope.tituloModal = 'Editar Setor'
            else
                $scope.tituloModal = 'Novo Setor'

            angular.element('#modalEdicao').modal('show');
        }
    }

})();
