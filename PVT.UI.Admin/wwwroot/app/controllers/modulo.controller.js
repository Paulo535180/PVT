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
        $scope.ListarModulosPorSetor = [];

        //----- Busca todos os Módulos -----//
        $scope.BuscarModulos = () => {
            $http.get('/modulo/listagem').then(resultado => {
                $scope.ListarModulos = resultado.data;
            }).catch(erro => { console.log(erro) });
        };

        //----- Busca todos os Módulos de cada Usuario -----//
        $scope.BuscarModuloPorUsuario = (user) => {
            $scope.user = user;
            $http.get('/modulo/ListagemPorUser/').then(resultado => {
                $scope.ListarModulosPorUsuario = resultado.data;
            }).catch(erro => { console.log(erro) });
        }

        $scope.BuscarModuloPorSetor = () => {
            $http.get('/modulo/ListagemPorSetor/').then(resultado => {
                $scope.ListarModulosPorSetor = resultado.data;
            }).catch(erro => { console.log(erro) });
        }

        //----- Adicionar um Módulo -----//
        $scope.AdicionarModulo = async (modulo) => {
            let resultado
            if (!modulo.ID) {
                modulo.DATA_CRIACAO = new Date(Date.now());
                modulo.ID_GESTOR = '';
                modulo.USUARIO_CRIACAO = '';
                modulo.STATUS = true;
                resultado = await $http.post('/modulo/AdicionarModulo', modulo);
            } else
                resultado = await $http.put('/modulo/EditarModulo?id=' + modulo.ID, modulo)
            if (resultado.status < 400) {
                await $scope.BuscarModuloPorSetor();
                angular.element('#modalEdicao').modal('hide');

                Swal.fire(
                    'Salvo com Sucesso',
                    '',
                    'success'
                );
            }

        }

        //----- Botão que altera cor do status -----//
        $scope.botaoClass = (status) => {
            let classe = 'btn btn-sm btn-'
            if (status) {
                classe += 'success'
            } else {
                classe += 'danger'
            }
            return classe;
        }

        //----- Método que altera o Status -----//
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
                await $scope.BuscarModuloPorSetor();
                $scope.$apply();
            })

        }
        //----- Abrir Modal de edição -----//
        $scope.AbrirModalEditar = async (modulo) => {
            console.log(modulo)
            if (modulo) {
                let resultado = await $http.get('/modulo/Buscamodulo/' + modulo.ID_MODULO);
                $scope.modulo = { ...resultado.data };
                $scope.$apply();
            } else {
                $scope.modulo = undefined;
            }if ($scope.modulo)
                $scope.tituloModal = 'Editar Setor'
            else
                $scope.tituloModal = 'Novo Setor'
            angular.element('#modalEdicao').modal('show');
        }
    }

})();
