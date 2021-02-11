(function () {
    'use strict';

    angular
        .module('PjrPadrao')
        .service('moduloservice', moduloservice);

    moduloservice.$inject = ['httpPadrao'];

    //public class 
    function moduloservice(httpPadrao) {

        this.Listagem = async () => {

            let resultado = await httpPadrao.get("/modulo/ListagemPorSetor");

            if (resultado.status > 200)
                return { erro: true, mensagem: resultado.data }

            return { erro: false, data: resultado.data }

        }

        this.ListagemAtivos = async () => {

            let resultado = await httpPadrao.get("/modulo/ListagemPorSetor");

            if (resultado.status > 200)
                return { erro: true, mensagem: resultado.data }

            console.log(resultado)
            let lista = resultado.data.filter(x => x.STATUS);

            return { erro: false, data: lista }

        }


    }
})();
