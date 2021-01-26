(function () {
    'use strict';

    angular.module('PjrPadrao').controller('gestor', gestor);

    gestor.$inject = ['$scope', '$http'];

    function gestor($scope, $http) {

        $scope.ListarGestores = [];
        $scope.ListarSetor = [];
        $scope.ListarGestoresPorSetor = [];
        this.gestor


        $scope.BuscarGestor = () => {
            $http.get('/gestor/listagem').then(resultado => {
                $scope.ListarGestores = resultado.data;
                console.log(resultado)
            }).catch(erro => { console.log(erro) });
        }

        $scope.BuscarSetores = () => {
            $http.get('/setor/listagem').then(resultado => {
                $scope.ListarSetor = resultado.data;

            }).catch(erro => { console.log(erro) });
        };

        $scope.BuscarGestoresPorSetor = (setor) => {
            console.log(setor);
            $http.get('/gestor/listagem/' + setor.ID).then(resultado => {
                $scope.ListarGestoresPorSetor = resultado.data;
            }).catch(erron => { console.log(erro) });
        }

        $scope.Vincular = (UserGestor) => {
            let promessa
            promessa = $http.get('/gestor/Adcionar', UserGestor)
            promessa.then(data => {
                console.log(data);
                $scope.BuscarSetores();
                angular.element('#modalEdicao').modal('hide');
            })
                .catch(erro => { console.log(erro) });
            console.log(setor);
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
