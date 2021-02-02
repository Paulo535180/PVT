(function () {
    'use strict';

    angular.module('PjrPadrao').controller('gestor', gestor);

    gestor.$inject = ['$scope', '$http'];

    function gestor($scope, $http) {

        $scope.ListarSetores = [];
        $scope.ListarGestoresPorSetor = [];
        $scope.Editar = [];
        this.gestor

        $scope.BuscarSetores = () => {
            $http.get('/setor/listagem').then(resultado => {
                $scope.ListarSetores = resultado.data;
            }).catch(erro => { console.log(erro) });
        };

        $scope.BuscarGestoresPorSetor = (setor) => {
            $scope.setor = setor;
            $http.get('/gestor/listagem/' + setor.ID).then(resultado => {
                $scope.ListarGestoresPorSetor = resultado.data;
            }).catch(erron => { console.log(erro) });
        }

        $scope.Adicionar = (UserGestor) => {
            let promessa
            console.log($scope.setor)
            promessa = $http.post('/gestor/Adicionar', UserGestor)
            promessa.then(data => {
                angular.element('#modalEdicao').modal('hide');
                $scope.BuscarGestoresPorSetor($scope.setor);
                Swal.fire(
                    'Salvo com Sucesso',
                    '',
                    'success'
                );
            })
                .catch(erro => { console.log(erro) });
        }

        $scope.Desativar = (UserGestor) => {
            let promessa
            promessa = $http.put('/gestor/Desativar?id=' + UserGestor.ID, UserGestor)
            promessa.then(data => {
                $scope.BuscarGestoresPorSetor($scope.setor);
            });
        }

        $scope.AbrirModalEditar = (setor) => {
            $scope.UserSetor = { ID_SETOR: setor.ID };
            $http.get('/usuario/listagem').then(resultado => {
                $scope.ListaUsuarios = resultado.data;
                if (gestor)
                    $scope.tituloModal = 'Editar Setor ' + setor.NOME
                else
                    $scope.tituloModal = 'Novo Setor ' + setor.NOME

                angular.element('#modalEdicao').modal('show');

            }).catch(erro => { console.log(erro) });
        }

    }
})();
