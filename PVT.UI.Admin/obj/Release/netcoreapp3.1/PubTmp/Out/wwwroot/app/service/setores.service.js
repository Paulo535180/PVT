(function () {
    angular.module('PjrPadrao').service("setorService", setorService)

    setorService.$inject = ['httpPadrao'];

    function setorService(httpPadrao) {

        this.getSetores = async () => {
            return await httpPadrao.get('/setor/listagem')
        }
    }        
})();