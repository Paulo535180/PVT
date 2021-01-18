(function () {
    'use strict';

    angular
        .module('PjrPadrao')
        .controller('modulo', modulo);

    modulo.$inject = ['$scope', '$http'];

    function modulo($scope, $http) {
        $scope.ListarModulos = [];

        $scope.BuscarModulos = () => {
            $http.get('/modulo/listagem').then(resultado => {
                $scope.ListarModulos = resultado.data;
            }).catch(erro => { console.log(erro) });
        };

        $scope.AdicionarModulo = (modulo) => {
            let promessa
            console.log(modulo)
            if (!modulo.ID) {
                modulo.DATA_CRIACAO = new Date(Date.now());
                modulo.ID_GESTOR = '';
                modulo.USUARIO_CRIACAO = '';
                modulo.STATUS = true;
                promessa = $http.post('/modulo/AdicionarModulo', modulo);

            } else {
                promessa = $http.put('/modulo/EditarModulo?id=' + modulo.ID, modulo)
            }
            promessa.then(data => {
                console.log(data);
                $scope.BuscarModulos();
                angular.element('#modalEdicao').modal('hide');
            })
                .catch(erro => { console.log(erro) });
            console.log(modulo);
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
