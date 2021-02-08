(function () {
    'use strict';

    angular
        .module('PjrPadrao')
        .controller('modulo', modulo);

    modulo.$inject = ['$scope', '$http'];

    function modulo($scope, $http) {
        $scope.ListarModulos = [];
        $scope.ListarSetores = [];
        $scope.ListarModulosPorUsuario = [];

        $scope.BuscarModulos = () => {
            $http.get('/modulo/listagem').then(resultado => {
                $scope.ListarModulos = resultado.data;
            }).catch(erro => { console.log(erro) });
        };

        $scope.BuscarModuloPorUsuario = (user) => {
            $scope.user = user;
            $http.get('/modulo/ListagemPorUser/').then(resultado => {
                $scope.ListarModulosPorUsuario = resultado.data;
            }).catch(erron => { console.log(erro) });
        }

        $scope.AdicionarModulo = async (modulo) => {
            let resultado
            if (!modulo.ID) {
                modulo.DATA_CRIACAO = new Date(Date.now());
                modulo.ID_GESTOR = '';
                modulo.USUARIO_CRIACAO = '';
                modulo.STATUS = true;
                resultado = await $http.post('/modulo/AdicionarModulo', modulo);
            } else 
                resultado = $http.put('/modulo/EditarModulo?id=' + modulo.ID, modulo)
            
            if (resultado.status < 400) {
                await $scope.BuscarModulos();
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

        $scope.botaoClass = (status) => {
            let classe = 'btn btn-lg btn-'
            console.log(status)
            if (status) {
                classe += 'success'
            } else {
                classe += 'danger'
            }
            return classe;
        }


        $scope.AlterarStatus = async (modulo) => {
            Swal.fire({
                title: 'Você deseja ' + (modulo.STATUS ? 'Desativar' : 'Ativar') + ' o Setor?',
                text: "Ativar ou Desativar o Setor da listagem",
                icon: 'danger',
                showCancelButton: true,
                confirmButtonColor: '#3085d6',
                cancelButtonColor: '#d33',
                cancelButtonText: 'Cancelar',
                confirmButtonText: 'Sim!',
            }).then(async (result) => {
                if (result.value) {
                    modulo.STATUS = !modulo.STATUS;
                    await $scope.AdicionarModulo(modulo);
                }
                $scope.$apply();
            })

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
