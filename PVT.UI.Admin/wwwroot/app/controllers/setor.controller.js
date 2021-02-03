(function () {
    'use strict';

    angular
        .module('PjrPadrao')
        .controller('setor', setor);

    setor.$inject = ['$scope', '$http', 'setorService'];

    function setor($scope, $http, setoresService) {

        $scope.ListagemSetores = [];
        $scope.filtro = '';
        $scope.ListarGestoresPorSetor = [];
        $scope.ListagemSetorPorId = [];


        //~----- Método que Lista todos os Setores -----//
        $scope.BuscarSetores = async () => {
            let resultado = await setoresService.getSetores();
            $scope.ListagemSetores = resultado.data;
            $scope.$apply();
        };

        //----- Método Buscar um Gestor por setor -----//
        $scope.BuscarGestoresPorSetor = (setor) => {
            $scope.setor = setor;
            $http.get('/gestor/listagem/' + setor.ID).then(resultado => {
                $scope.ListarGestoresPorSetor = resultado.data;
            }).catch(erron => { console.log(erro) });
        }

        //----- Método de Adicionar um Setor -----//
        $scope.AdicionarSetor = (setor) => {
            let promessa
            if (!setor.ID) {
                setor.DATA_CRIACAO = new Date(Date.now());
                setor.USUARIO_CRIACAO = '';
                setor.STATUS = true;
                promessa = $http.post('/setor/AdicionarSetor', setor);
                $scope.BuscarSetores();

            } else {
                promessa = $http.put('/setor/EditarSetor?id=' + setor.ID, setor)
            }
            promessa.then(data => {
                $scope.BuscarSetores();
                angular.element('#modalEdicao').modal('hide');
                Swal.fire(
                    'Salvo com Sucesso',
                    '',
                    'success'
                );
            })
                .catch(erro => { console.log(erro) });
        }

        //----- Método Adicionar um Gestor -----//
        $scope.AdicionarGestor = (UserGestor) => {
            let promessa
            console.log($scope.setor)
            promessa = $http.post('/gestor/Adicionar', UserGestor)
            promessa.then(data => {
                angular.element('#modalVinculoGestor').modal('hide');
                $scope.BuscarGestoresPorSetor($scope.setor);
                Swal.fire(
                    'Salvo com Sucesso',
                    '',
                    'success'
                );
            })
                .catch(erro => { console.log(erro) });
        }

        //----- Modal Editar Setor -----//
        $scope.AbrirModalEditar = (setor) => {
            $scope.setor = { ...setor };
            if (setor)
                $scope.tituloModal = 'Editar Setor'
            else
                $scope.tituloModal = 'Novo Setor'

            angular.element('#modalEdicao').modal('show');
        }

        //----- Modal Vincular Usuario Gestor -----//
        $scope.AbriModalAdicionarGestor = (setor) => {
            $scope.UserSetor = { ID_SETOR: setor.ID };
            console.log(setor)
            $http.get('/usuario/listagem').then(resultado => {
                $scope.ListaUsuarios = resultado.data;
                $scope.setor = { setor };
                $scope.tituloModalVinculo = 'Adicionar Gestor'
                angular.element('#modalVinculoGestor').modal('show');
            }).catch(erro => { console.log(erro) });
        }


        //----- Modal Principal Setor -----//
        $scope.AbrirModalPrincipal = (setor) => {
            $scope.Setor = { ID_SETOR: setor.ID };
            $http.get('/setor/ListagemPorSetor/' + setor.ID).then(resultado => {
                $scope.ListagemSetorPorId = resultado.data;
                $scope.tituloModalPrincipal = 'Detalhes Setor'
                angular.element('#modalPrincipal').modal('show');
            }).catch(erro => { console.log(erro) });
        }
    }
})();