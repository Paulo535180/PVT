(function () {
    'use strict';

    angular
        .module('PjrPadrao')
        .controller('setor', setor);

    setor.$inject = ['$scope', '$http'];

    function setor($scope, $http) {

        $scope.ListagemSetores = [];
        $scope.filtro = '';

        $scope.Listagem = () => {
            $http.get('/setor/listagem').then(resultado => {
                $scope.ListagemSetores = resultado.data;
            }).catch(erro => { console.log(erro) });
        };
    }


})();



//Listagem
//Ativar / Desativar
//Inclusao
//Editar