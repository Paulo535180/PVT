(function () {
    'use strict';

    angular.module('PjrPadrao')
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

        var _post = async function (url, registro) {
            let retorno
            await $http.post(url, registro).then(resultado => {
                retorno = resultado;
            }).catch(erro => { retorno = erro });
            return retorno
        };

        var _put = async function (url, registro) {
            let retorno
            await $http.put(url, registro).then(resultado => {
                retorno = resultado;
            }).catch(erro => { retorno = erro });
            return retorno
        };

        var _patch = async function (url, registro = null) {
            let retorno
            await $http.patch(url, registro).then(resultado => {
                retorno = resultado;
            }).catch(erro => { retorno = erro });
            return retorno
        };
        

        return {
            get: _get,
            post: _post,
            put: _put,
            patch: _patch,
        }
    }
})();