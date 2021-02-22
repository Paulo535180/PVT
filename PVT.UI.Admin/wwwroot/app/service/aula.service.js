(function () {
    'use strict';

    angular
        .module('PjrPadrao')
        .service('aulaservice', aulaservice);

    aulaservice.$inject = ['httpPadrao'];

    function aulaservice(httpPadrao) {


        this.Listagem = async () => {
            let resultado = await httpPadrao.get("/Curso/listagem");

            if (resultado.status > 200)
                return { erro: true, mensagem: resultado.data }

            return { erro: false, data: resultado.data }
        }

        this.ListagemPorDisciplina = async (idDisciplina) => {
            let resultado = await httpPadrao.get("/Aula/listagem/" + idDisciplina);

            if (resultado.status > 200)
                return { erro: true, mensagem: resultado.data }

            return { erro: false, data: resultado.data }
        }

        this.ListagemTipoAula = async () => {
            let resultado = await httpPadrao.get("/TipoAula/Listagem")

            if (resultado.status > 200)
                return { erro: true, mnensagem: resultado.data }

            return { erro: false, data: resultado.data }
        }

        this.inserir = async (aula) => {

            let resultado = await httpPadrao.post("/Aula", aula);
            console.log(aula)
            if (resultado.status === 422)
                return { erro: true, mensagem: "As informações de curso são invalidas" }
            if (resultado.status > 300)
                return { erro: true, mensagem: resultado.data }

            return { erro: false }
        }

        this.alterar = async (curso) => {


            let resultado = await httpPadrao.put("/Curso/" + curso.ID, curso);

            if (resultado.status === 409)
                return { erro: true, mensagem: "A rota não condiz com o registro" }
            if (resultado.status === 422)
                return { erro: true, mensagem: "As informações de curso são invalidas" }
            if (resultado.status > 300)
                return { erro: true, mensagem: resultado.data }

            return { erro: false, data: resultado.data }
        }
    }
})();
