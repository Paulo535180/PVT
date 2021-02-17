(function () {
    'use strict';

    angular
        .module('PjrPadrao')
        .controller('curso', cursocontroller);

    cursocontroller.$inject = ['$scope', 'cursoservice', 'moduloservice','disciplinaservice'];

    function cursocontroller($scope, cursoservice, moduloservice, disciplinaservice) {

        //Atributos
        $scope.Tabela
        $scope.curso
        $scope.tituloModal
        $scope.Modulos
        $scope.dtOptions
        $scope.disciplina
        $scope.Cursos

        //Metodos
        $scope.Listagem = async () => {
            let resultado = await cursoservice.Listagem();

            if (resultado.erro) {
                Swal.fire(
                    'Não foi possível listar',
                    resultado.mensagem,
                    'error'
                );
                return
            }
            $scope.Tabela = resultado.data;
            $scope.$apply();
        }

        //----- Apenas guarda em obterModulo o serviço de Listagem dos Módulos -----//
        let obterModulos = async () => {
            let resultado = await moduloservice.ListagemAtivos();
            if (resultado.erro) {
                Swal.fire(
                    'Não foi possível listar os modulos',
                    resultado.mensagem,
                    'error'
                );
                return
            }
            return resultado.data;
        }

        //----- Abre a modal para cadastrar um novo curso -----//
        $scope.AbrirCadastroNovo = async () => {
            $scope.curso = undefined;
            $scope.tituloModal = "Novo Curso"
            $scope.Modulos = await obterModulos()
            $scope.$apply();
            angular.element("#ModalRegistro").modal("show");
        }

        //----- Abre a modal para gerenciar as diciplinas e aulas de um curso -----//
        $scope.AbrirGerenciarCurso = async (item) => {
            console.log(item)
            $scope.disciplina = { ID_CURSO: item };
            console.log(disciplina);
            angular.element("#modalGerenciarCurso").modal("show");
        }

        $scope.AdicionarDisciplina = async (disciplina) => {
            console.log(disciplina)
            let resultado
            if (!disciplina.ID) {
                disciplina = { ...disciplina, STATUS: true, DATA_CRIACAO: new Date(Date.now()), USUARIO_CRIACAO: "User Web" }
                resultado = await disciplinaservice.inserir(disciplina);
            } Swal.fire(
                'Salvo com Sucesso',
                '',
                'success'
            )
            angular.element("#modalGerenciarCurso").modal("hide");
           //console.log(resultado)
            //if (resultado.erro) {
            //    Swal.fire(
            //        `Não foi possível ${(!curso.ID) ? "inserir" : "alterar"} o curso`,
            //        resultado.mensagem,
            //        'error'
            //    );
            //    return
            //} Swal.fire(
            //    'Salvo com Sucesso',
            //    '',
            //    'success'
            //)
        }
    


    //----- Muda a cor do botão -----//
    $scope.botaoClass = (status) => {
        let classe = 'btn btn-sm btn-'
        if (status) {
            classe += 'success'
        } else {
            classe += 'danger'
        }
        return classe;
    }

    //----- Método que desativa o status do curso -----//
    $scope.DesativarCurso = async (item) => {
        console.log(item);
        Swal.fire({
            title: 'Você deseja ' + (item.STATUS ? 'Desativar' : 'Ativar') + ' o Curso?',
            text: "Ativar ou Desativar o Setor da listagem",
            icon: 'danger',
            showCancelButton: true,
            confirmButtonColor: '#3085d6',
            cancelButtonColor: '#d33',
            cancelButtonText: 'Cancelar',
            confirmButtonText: 'Sim!',
        }).then(async (result) => {
            if (result.value) {
                item.STATUS = !item.STATUS;
                await $scope.Finalizar(item);
            } Swal.fire(
                'Salvo com Sucesso',
                '',
                'success'
            )
            console.log(item)
            await $scope.Listagem();
            $scope.$apply();
        }

        )
    }


    //----- Abre a modal para editar um item -----//
    $scope.AbrirItemSelecionado = async (item) => {
        console.log(item)
        $scope.curso = item;
        $scope.tituloModal = "Editar Curso"
        $scope.Modulos = await obterModulos();
        $scope.$apply();
        angular.element("#ModalRegistro").modal("show");
    }

    //----- Finaliza a função de salvar do curso -----//
    $scope.Finalizar = async (curso) => {
        console.log(curso)
        let resultado
        if (!curso.ID) {
            curso = { ...curso, STATUS: true, DATA_CRIACAO: new Date(Date.now()), USUARIO_CRIACAO: "User Web" }
            resultado = await cursoservice.inserir(curso);
        }
        else
            resultado = await cursoservice.alterar(curso);
        console.log(resultado);
        if (resultado.erro) {
            Swal.fire(
                `Não foi possível ${(!curso.ID) ? "inserir" : "alterar"} o curso`,
                resultado.mensagem,
                'error'
            );
            return
        } Swal.fire(
            'Salvo com Sucesso',
            '',
            'success'
        )
        angular.element("#ModalRegistro").modal("hide");
        $scope.$apply();
        await $scope.Listagem()
    }

}
}) ();
