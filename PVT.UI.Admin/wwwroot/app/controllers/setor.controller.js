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


        //----- Método que Lista todos os Setores -----//
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
        $scope.AdicionarSetor = async (setor) => {
            let resultado
            if (!setor.ID) {
                setor.DATA_CRIACAO = new Date(Date.now());
                setor.USUARIO_CRIACAO = '';
                setor.STATUS = true;
                resultado = await $http.post('/setor/AdicionarSetor', setor);
            } else
                resultado = await $http.put('/setor/EditarSetor?id=' + setor.ID, setor)

            if (resultado.status < 400) {
                await $scope.BuscarSetores();
                angular.element('#modalEdicao').modal('hide');
                Swal.fire(
                    'Salvo com Sucesso',
                    '',
                    'success'
                );
            }
            else
                console.log(promessa)
        }


        //----- Método Adicionar um Gestor -----//
        $scope.AdicionarGestor = async (UserGestor) => {
            let resultado
            console.log(UserGestor);
            resultado = await $http.post('/gestor/Adicionar', UserGestor);

            if (resultado.status < 400) {
                angular.element('#modalVinculoGestor').modal('hide');
                await $scope.BuscarGestoresPorSetor($scope.setor);
                Swal.fire(
                    'Salvo com Sucesso',
                    '',
                    'success'
                );
            } else console.log(resultado)
        }


        //----- Método Editar STATUS Setor -----//
        $scope.AlterarStatus = async (setor) => {
            Swal.fire({
                title: 'Você deseja ' + (setor.STATUS ? 'Desativar' : 'Ativar') + ' o Setor?',
                text: "Ativar ou Desativar o Setor da listagem",
                icon: 'danger',
                showCancelButton: true,
                confirmButtonColor: '#3085d6',
                cancelButtonColor: '#d33',
                cancelButtonText: 'Cancelar',
                confirmButtonText: 'Sim!',
            }).then(async (result) => {
                if (result.value) {
                    setor.STATUS = !setor.STATUS;
                    await $scope.AdicionarSetor(setor);
                }
                $scope.$apply();
            })
        }

        //----- Método Editar Status Usuario gestor -----//
        $scope.AlterarStatusGestor = async (UserGestor) => {
            let resultado
            Swal.fire({
                title: 'Você deseja ' + (UserGestor.STATUS ? 'Desativar' : 'Ativar') + ' o Usuário ' + UserGestor.NOME_GESTOR + '?',
                text: "Ao desativar, o Gestor ficará disponível para outro Setor!",
                icon: 'danger',
                showCancelButton: true,
                confirmButtonColor: '#3085d6',
                cancelButtonColor: '#d33',
                cancelButtonText: 'Cancelar',
                confirmButtonText: 'Sim!',
            }).then(async (result) => {
                console.log(UserGestor)
                if (result.value) {
                    UserGestor.STATUS = !UserGestor.STATUS;
                    resultado = await $http.put('/gestor/Desativar?id=' + UserGestor.ID, UserGestor);

                    if (resultado.status < 400) {
                        angular.element('#modalVinculoGestor').modal('hide');
                        await $scope.BuscarGestoresPorSetor($scope.setor);
                        Swal.fire(
                            'Salvo com Sucesso',
                            '',
                            'success'
                        );
                    } else console.log(resultado)
                }
                $scope.$apply();
            })
        }


        //----- Modal Editar Setor -----//
        $scope.AbrirModalVisualizar = (setor) => {
            $scope.setor = { ...setor };
            if (setor)
                $scope.tituloModal = 'Editar Setor'
            else
                $scope.tituloModal = 'Novo Setor'

            angular.element('#modalPrincipal').modal('show');
            
            angular.element('#detalhesSetorLink').tab('show');
        }


        //----- Função que altera a cor do botão -----//
        $scope.botaoClass = (status) => {
            let classe = 'btn btn-lg btn-'
            if (status) {
                classe += 'success'
            } else {
                classe += 'danger'
            }
            return classe;
        }

        //----- Modal Adicionar Setor -----//
        $scope.AbrirModalNovo = (setor) => {
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