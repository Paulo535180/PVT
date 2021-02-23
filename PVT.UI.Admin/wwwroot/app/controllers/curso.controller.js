(function () {
    'use strict';

    angular
        .module('PjrPadrao')
        .controller('curso', cursocontroller);

    cursocontroller.$inject = ['$scope', 'cursoservice', 'moduloservice', 'aulaservice', 'disciplinaservice', 'DTOptionsBuilder'];

    function cursocontroller($scope, cursoservice, moduloservice, aulaservice, disciplinaservice, DTOptionsBuilder) {

        //Atributos
        //$scope.Tabela
        //$scope.TabelaDisciplinas
        //$scope.curso
        //$scope.tituloModal
        //$scope.Modulos
        //$scope.dtOptions
        //$scope.disciplina
        //$scope.Cursos

        this.dtOptionsModalDisciplinasAulas = DTOptionsBuilder.newOptions()
                .withOption('bLengthChange', false)
                .withOption('searching', true)
                .withDisplayLength(5)
                .withLanguageSource("/js/Portuguese-Brasil.json")


        //----- Listagem dos cursos -----//
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

        //----- Listagem das disciplinas -----//
        $scope.ListagemDisciplinas = async () => {
            let resultado = await disciplinaservice.Listagem();
            if (resultado.erro) {
                Swal.fire(
                    'Não foi possível listar',
                    resultado.mensagem,
                    'error'
                );
                return
            }
            $scope.TabelaDisciplinas = resultado.data;
            $scope.$apply();
        }

        //----- Listando as disciplinas por Id do Curso -----//
        $scope.ListagemDisciplinasPorCurso = async (idCurso) => {
            console.log(idCurso)
            let resultado = await disciplinaservice.ListagemPorCurso(idCurso);
            if (resultado.erro) {
                Swal.fire(
                    'Não foi possível listar',
                    resultado.mensagem,
                    'error'
                );
                return
            }
            $scope.TabelaDisciplinasPorCurso = resultado.data;
            console.log($scope.TabelaDisciplinasPorCurso)
            $scope.$apply();
        }

        //----- Lista os Tipos de Aula -----//
        $scope.ListagemTiposAula = async () => {
            let resultado = await aulaservice.ListagemTipoAula();
            if (resultado.erro) {
                Swal.fire(
                    'Não foi possível listar',
                    resultado.mensagem,
                    'error'
                );
                return
            }
            $scope.TiposDeAula = resultado.data;
            $scope.$apply();
        }

        //----- Listagem das Aulas -----//
        $scope.ListarAulasPorDisciplina = async (idDisciplina) => {
            let resultado = await aulaservice.ListagemPorDisciplina(idDisciplina)
            $scope.TabelaAulasPorDisciplina = resultado.data;
            $scope.$apply();
            console.log(resultado)
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

        //----- Apenas guarda em obterTipoAula o serviço de Listagem dos Tipos de Aula -----//
        let obterTipoAula = async () => {
            let resultado = await aulaservice.ListagemTipoAula();
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
            console.log($scope.Modulos)
            $scope.$apply();
            angular.element("#ModalRegistro").modal("show");
        }

        //----- Abre a modal para editar um item -----//
        $scope.AbrirItemSelecionado = async (curso) => {
            $scope.curso = curso;
            $scope.tituloModal = "Editar Curso"
            $scope.Modulos = await obterModulos();
            $scope.$apply();
            angular.element("#editarCursoLink").tab("show");
        }

        //----- Abre a modal para gerenciar as diciplinas e aulas de um curso -----//
        $scope.AbrirGerenciarCurso = async (curso) => {
            $scope.curso = curso;
            $scope.ListagemDisciplinasPorCurso(curso.ID);
            angular.element("#modalGerenciarCurso").modal("show");
            angular.element('#disciplinaLink').tab('show');
        }

        //----- Modal de disciplina -----//
        $scope.AbrirModalCadastroDisciplina = async (idCurso) => {
            $scope.disciplina = { ID_CURSO: idCurso };
            angular.element("#modalAdicionarDisciplina").modal("show");
        }

        //----- Modal de Aulas -----//
        $scope.AbrirModalAdicionarAula = async (idDisciplina) => {
            console.log(idDisciplina)
            $scope.TiposDeAula = await obterTipoAula();
            $scope.aula = { ID_DISCIPLINA: idDisciplina };
            $scope.$apply();
            angular.element("#modalAdicionarAula").modal("show");
        }

        //----- Método adicionar Aula -----//
        $scope.AdicionarAula = async (aula) => {
            let resultado
            console.log(aula)
            aula = { ...aula, STATUS: true, DATA_CRIACAO: new Date(Date.now()), USUARIO_CRIACAO: "user web", /*ARQUIVO: "TESTE.COM", VIDEO: "TESTE.COM/YOUTUBE", TEXTO: "MU"*/ }
            resultado = await aulaservice.inserir(aula)
            if (resultado.erro) {
                Swal.fire(
                    `Não foi possível ${(!aula.ID) ? "inserir" : "alterar"} o curso`,
                    resultado.mensagem,
                    'error'
                );
                return
            } Swal.fire(
                'Salvo com Sucesso',
                '',
                'success'
            )
            $scope.$apply();
            angular.element("#modalAdicionarAula").modal("hide");
        }

        //----- Método adicionar Disciplina -----//
        $scope.AdicionarDisciplina = async (disciplina) => {
            let resultado
            disciplina = { ...disciplina, STATUS: true, DATA_CRIACAO: new Date(Date.now()), USUARIO_CRIACAO: "User Web" }
            resultado = await disciplinaservice.inserir(disciplina);
            if (resultado.erro) {
                Swal.fire(
                    `Não foi possível ${(!disciplina.ID) ? "inserir" : "alterar"} o curso`,
                    resultado.mensagem,
                    'error'
                );
                return
            } Swal.fire(
                'Salvo com Sucesso',
                '',
                'success'
            )
            angular.element("#modalAdicionarDisciplina").modal("hide");
            await $scope.ListagemDisciplinasPorCurso(disciplina.ID_CURSO);
            $scope.$apply();
        }

        //----- Mudar status do curso -----//
        $scope.AlterarStatus = async (item) => {
            console.log(item);
            Swal.fire({
                title: 'Você deseja ' + (item.STATUS ? 'Desativar' : 'Ativar') + ' o Módulo?',
                text: "Ativar ou Desativar o Módulo da listagem",
                icon: 'danger',
                showCancelButton: true,
                confirmButtonColor: '#3085d6',
                cancelButtonColor: '#d33',
                cancelButtonText: 'Cancelar',
                confirmButtonText: 'Sim!',
            }).then(async (result) => {
                if (result.value) {
                    let resultado = await moduloservice.alterarStatus(item.ID);
                    if (resultado.erro) {
                        Swal.fire(
                            'Você não pode fazer alterações neste Módulo',
                            '',
                            'error'
                        )
                    } else {
                        item.STATUS = !item.STATUS;
                        Swal.fire(
                            'Salvo com Sucesso',
                            '',
                            'success'
                        )
                    }
                }
                console.log(item)
                await $scope.Listagem();
                $scope.$apply();
            }

            )
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
                await $scope.Listagem();
                $scope.$apply();
            }

            )
        }

        //----- Finaliza a função de salvar do curso -----//
        $scope.Finalizar = async (curso) => {
            let resultado
            if (!curso.ID) {
                curso = { ...curso, STATUS: true, DATA_CRIACAO: new Date(Date.now()), USUARIO_CRIACAO: "User Web" }
                resultado = await cursoservice.inserir(curso);
            }
            else
                resultado = await cursoservice.alterar(curso);
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

        //----- Altera o Status da Disciplina -----//
        $scope.AlterarStatusDisciplina = async (item) => {
            console.log(item)
            Swal.fire({
                title: 'Você deseja ' + (item.STATUS ? 'Desativar' : 'Ativar') + ' o Módulo?',
                text: "Ativar ou Desativar o Módulo da listagem",
                icon: 'danger',
                showCancelButton: true,
                confirmButtonColor: '#3085d6',
                cancelButtonColor: '#d33',
                cancelButtonText: 'Cancelar',
                confirmButtonText: 'Sim!',
            }).then(async (result) => {
                if (result.value) {
                    let resultado = await disciplinaservice.alterarStatusDisciplina(item.ID);
                    if (resultado.erro) {
                        Swal.fire(
                            'Você não pode fazer alterações neste Módulo',
                            '',
                            'error'
                        )
                    } else {
                        item.STATUS = !item.STATUS;
                        Swal.fire(
                            'Salvo com Sucesso',
                            '',
                            'success'
                        )
                    }
                }
                console.log(item)
                await $scope.ListagemDisciplinasPorCurso(item.ID_CURSO);
                $scope.$apply();
            }

            )
        }

    }
})();
