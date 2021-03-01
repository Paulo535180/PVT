(function () {
    angular
        .module('PjrPadrao')
        .controller('gestor', gestor);

    gestor.$inject = ['$scope', '$http', 'DTOptionsBuilder'];

    function gestor($scope, $http, DTOptionsBuilder) {

        this.dtOptionsGestores = DTOptionsBuilder.newOptions()
            .withOption('bLengthChange', false)
            .withOption('searching', true)
            .withDisplayLength(5)
            .withLanguageSource("/js/Portuguese-Brasil.json")

        $scope.ListarSetores = [];
        $scope.ListarGestoresPorSetor = [];
        $scope.Editar = [];
        this.gestor

        $scope.BuscarSetores = () => {
            console.log(BuscarSetores);
            $http.get('/setor/listagem').then(resultado => {
                $scope.ListarSetores = resultado.data;
            }).catch(erro => { console.log(erro) });
        };

        $scope.BuscarGestoresPorSetor = (setor) => {
            $scope.setor = setor;
            $http.get('/gestor/GestorPorSetor/').then(resultado => {
                $scope.ListarGestoresPorSetor = resultado.data;
            }).catch(erron => { console.log(erro) });
        }

        //Método que vincula um Gestor ao novo Setor
        $scope.Adicionar = (idUsuario) => {
            let promessa
            promessa = $http.post('/gestor/AdicionarGestor/', idUsuario)
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
            let classe = 'btn btn-sm btn-'
            if (status) {
                classe += 'success'
            } else {
                classe += 'danger'
            }
            return classe;
        }

        $scope.AbrirModalVisualizar = (setor) => {
            $scope.setor = { ...setor };
            if (setor)
                $scope.tituloModal = 'Editar Setor'
            else
                $scope.tituloModal = 'Novo Setor'

            angular.element('#modalPrincipal').modal('show');
            angular.element('#detalhesSetorLink').tab('show');
        }

        //Método abiri modal e Lista os Usuario Disponiveis
        $scope.AbriModalAdicionarGestor = () => {
            $http.get('/usuario/listagem').then(resultado => {
                $scope.ListaUsuarios = resultado.data;
                $scope.tituloModalVinculo = 'Adicionar Gestor'
                angular.element('#modalVinculoGestor').modal('show');
            }).catch(erro => { console.log(erro) });
        }
    }
})();
