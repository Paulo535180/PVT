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
            if (!modulo.ID) {
                modulo.DATA_CRIACAO = new Date(Date.now());
                modulo.USUARIO_CRIACAO = '';
                modulo.STATUS = true;
                promessa = $http.post('/setor/AdicionarModulo', modulo);
                alert("Modulo Criado");
                $scope.BuscarModulos();

            } else {
                promessa = $http.put('/setor/EditarSetor?id=' + setor.ID, setor)
                alert("Setor Alterado");
            }
            promessa.then(data => {
                console.log(data);
                $scope.BuscarSetores();
                angular.element('#modalEdicao').modal('hide');
            })
                .catch(erro => { console.log(erro) });
            console.log(setor);
        }
    }

})();
