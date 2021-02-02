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

        $scope.AlterarStatus = (modulo) =>
        {
            Swal.fire({
                title: 'Você deseja ' + (modulo.STATUS?'Desativar': 'Ativar')+ ' o Módulo?',
                text: "Ativar ou Desativar o Módulo da listagem",
                icon: 'danger',
                showCancelButton: true,
                confirmButtonColor: '#3085d6',
                cancelButtonColor: '#d33',
                confirmButtonText: 'Yes, delete it!'
            }).then((result) => {
                if (result.isConfirmed) {
                    Swal.fire(
                        'Deleted!',
                        'Your file has been deleted.',
                        'success'
                    )
                } else {
                    modulo.STATUS =!modulo.STATUS
                }
                
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
