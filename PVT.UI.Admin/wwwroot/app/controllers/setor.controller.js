(function () {
    'use strict';

    angular
        .module('PjrPadrao')
        .controller('setor', setor);

    setor.$inject = ['$scope', '$http'];

    function setor($scope, $http) {

        $scope.ListagemSetores = [];
        $scope.filtro = '';

        $scope.BuscarSetores = () => {
            $http.get('/setor/listagem').then(resultado => {
                $scope.ListagemSetores = resultado.data;
            }).catch(erro => { console.log(erro) });
        };

        $scope.AdicionarSetor = (setor) => {
            let promessa
            if (!setor.ID) {
                setor.DATA_CRIACAO = new Date(Date.now());
                setor.USUARIO_CRIACAO = '';
                setor.STATUS = true;
                promessa = $http.post('/setor/AdicionarSetor', setor);
                alert("Setor Criado");
                $scope.BuscarSetores();
                
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

        $scope.AbrirModalEditar = (setor) => {
            $scope.setor = { ...setor };
            if (setor)
                $scope.tituloModal = 'Editar Setor'
            else
                $scope.tituloModal = 'Novo Setor'

            angular.element('#modalEdicao').modal('show');
        }
    }
})();



//Listagem
//Ativar / Desativar
//Inclusao
//Editar