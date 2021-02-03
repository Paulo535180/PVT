(function () {
    'use strict';

    angular.module('PjrPadrao', [])
        .factory("httpPadrao", http);

    http.$inject = ['$http'];

    function http ($http) {
        var _get = async function (url) {
            let retorno
            await $http.get(url).then(resultado => {
                retorno = resultado;
            }).catch(erro => { retorno = erro });
            return retorno
        };
        var _adicionarSetor = function (setor) {
            return $http.post('/setor/AdicionarSetor', setor);
        };

        return {
            get: _get,
            adicionarSetor: _adicionarSetor
        }
    }
})();