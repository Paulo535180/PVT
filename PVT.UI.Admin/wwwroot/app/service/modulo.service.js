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

            let resultado = await httpPadrao.get("/modulo/ListagemPorUserLogado");

            if (resultado.status > 200)
                return { erro: true, mensagem: resultado.data }

            
            console.log(resultado)
            let lista = resultado.data.filter(x => x.STATUS);

            return { erro: false, data: lista }

        }

        this.ListagemNaoVinculados = async () => {

            let resultado = await httpPadrao.get("/modulo/ListagemModulosSemVinculo");

            if (resultado.status > 200)
                return { erro: true, mensagem: resultado.data }

            console.log(resultado)

            return { erro: false, data: resultado.data }

        }

        this.inserir = async (modulo) => {

            let resultado = await httpPadrao.post("/Modulo", modulo);

            if (resultado.status === 422)
                return { erro: true, mensagem: "As informações de curso são invalidas" }
            if (resultado.status > 300)
                return { erro: true, mensagem: resultado.data }

            return { erro: false }
        }

        this.inserirVinculo = async (id) => {

            let resultado = await httpPadrao.post("/Modulo/" + id + "/VincularModulo");

            if (resultado.status === 422)
                return { erro: true, mensagem: "As informações de curso são invalidas" }
            if (resultado.status > 300)
                return { erro: true, mensagem: resultado.data }

            return { erro: false }
        }

        this.alterar = async (modulo) => {

            let resultado = await httpPadrao.put("/Modulo/" + modulo.ID,modulo);

            if (resultado.status === 409)
                return { erro: true, mensagem: "A rota não condiz com o registro" }
            if (resultado.status === 422)
                return { erro: true, mensagem: "As informações de módulo são invalidas" }
            if (resultado.status > 300)
                return { erro: true, mensagem: resultado.data }

            return { erro: false, data: resultado.data }
        }



        this.alterarStatus = async (id) => {
            let resultado = await httpPadrao.patch("/Modulo/" + id + "/AlterarStatus")
            if (resultado.status > 300)
                return { erro: true, mensagem: resultado.data }
            return { erro: false }
        }


    }
})();
