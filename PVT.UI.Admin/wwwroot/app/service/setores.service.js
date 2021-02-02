angular.module("setores").factory("setoresService", function ($http) {


    var _getSetores = function () {
        return $http.get('/setor/listagem');
    };
    var _adicionarSetor = function (setor) {
        return $http.post('/setor/AdicionarSetor', setor);
    };

    return {
        getSetores: _getSetores,
        adicionarSetor: _adicionarSetor
    }
});