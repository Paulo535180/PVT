(function () {
    'use strict';

    angular
        .module('PjrPadrao')
        .service('disciplinaservice', disciplinaservice);

    disciplinaservice.$inject = ['httpPadrao'];

    function disciplinaservice(httpPadrao) {

        this.Listagem = async (curso) => {
            let resultado = await httpPadrao.get("/Disciplina/Listagem/" + curso.ID);

            if (resultado.status > 200)
                return { erro: true, mensagem: resultado.data }

            return { erro: false, data: resultado.data }
        }


        this.ListagemPorCurso = async (idCurso) => {
            let resultado = await httpPadrao.get("/Disciplina/Listagem/" + idCurso);

            if (resultado.status > 200)
                return { erro: true, mensagem: resultado.data }

            return { erro: false, data: resultado.data }
        }

        this.inserir = async (disciplina) => {

            //Regra

            let resultado = await httpPadrao.post("/Disciplina", disciplina);

            if (resultado.status === 422)
                return { erro: true, mensagem: "As informações de disciplina são invalidas" }
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


        this.alterarStatus = async (id) => {
            let resultado = await httpPadrao.patch("/Disciplina/" + id + "/AlterarStatus")
            if (resultado.status > 300)
                return { erro: true, mensagem: resultado.data }
            return { erro: false }
        }
    }
})();
