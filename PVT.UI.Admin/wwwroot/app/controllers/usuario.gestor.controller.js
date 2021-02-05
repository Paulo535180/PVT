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

        //$scope.Desativar = (UserGestor) => {
        //    let promessa
        //    promessa = $http.put('/gestor/Desativar?id=' + UserGestor.ID, UserGestor)
        //    promessa.then(data => {
        //        $scope.BuscarGestoresPorSetor($scope.setor);
        //    });
        //}

        $scope.DesativarGestor = async (UserGestor) => {
            let resultado
            Swal.fire({
                title: 'Você deseja ' + (UserGestor.STATUS ? 'Desativar' : 'Ativar') + ' o Usuário ' + UserGestor.NOME_GESTOR + '?',
                text: "Ao desativar, o Gestor ficará disponível para outro Setor",
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
