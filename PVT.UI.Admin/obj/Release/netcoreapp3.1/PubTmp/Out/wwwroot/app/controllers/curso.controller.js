(function () {
    'use strict';

    angular
        .module('PjrPadrao')
        .controller('curso', cursocontroller);

    cursocontroller.$inject = ['$scope', 'cursoservice', 'moduloservice', 'aulaservice', 'disciplinaservice', 'DTOptionsBuilder'];

    function cursocontroller($scope, cursoservice, moduloservice, aulaservice, disciplinaservice, DTOptionsBuilder) {

        this.dtOptionsModalDisciplinas = DTOptionsBuilder.newOptions()
            .withOption('bLengthChange', false)
            .withOption('searching', true)
            .withDisplayLength(3)
            .withLanguageSource("/js/Portuguese-Brasil.json")
            .withButtons([
                {
                    text: 'Nova Disciplina',
                    key: '1',
                    className: 'btn btn-primary float-right mt-2 ml-3',
                    action: () => {
                        var posicao = 1;
                        $scope.TabelaDisciplinasPorCurso.map(
                            (x) => {
                                console.log(x)
                                if (posicao <= x.PRIORIDADE) {
                                    posicao = x.PRIORIDADE + 1
                                }
                            }
                        );
                        $scope.disciplina = { PRIORIDADE: posicao };
                        $scope.$apply();
                        angular.element("#modalAdicionarDisciplina").modal("show");
                    }
                }
            ]);

        this.dtOptionsModalAulas = DTOptionsBuilder.newOptions()
            .withOption('bLengthChange', false)
            .withOption('searching', true)
            .withDisplayLength(3)
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
        $scope.ListarAulasPorDisciplina = async (disciplina) => {
            console.log(disciplina)
            let resultado = await aulaservice.ListagemPorDisciplina(disciplina.ID)
            $scope.disciplina = disciplina;
            $scope.TabelaAulasPorDisciplina = resultado.data;
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
            $scope.$apply();           
            angular.element("#ModalRegistro").modal("show");
        }

        $scope.trocarPrioridadeCurso = (cursoView) => {
            var posicao = 1;            
            if (!cursoView.ID)
                $scope.Tabela.map(
                    (curso) => {
                        if (posicao <= curso.PRIORIDADE && curso.ID_MODULO === cursoView.ID_MODULO) {
                            posicao = curso.PRIORIDADE + 1
                        }
                    });
            $scope.curso = { ...cursoView, PRIORIDADE: posicao };
        } 

        //----- Abre a modal para editar um item -----//
        $scope.AbrirItemSelecionado = async (curso) => {
            $scope.curso = curso;
            $scope.tituloModal = "Editar Curso"
            $scope.Modulos = await obterModulos()
            $scope.$apply();
            angular.element("#editarCursoLink").tab("show");
        }

        //----- Abre a modal para gerenciar as diciplinas e aulas de um curso -----//
        $scope.AbrirGerenciarCurso = async (curso) => {
            $scope.curso = curso;
            console.log($scope.curso);
            $scope.ListagemDisciplinasPorCurso(curso.ID);
            angular.element("#modalGerenciarCurso").modal("show");
            angular.element('#disciplinaLink').tab('show');
        }

        //----- Modal de disciplina -----//
        $scope.AbrirModalCadastroDisciplina = () => {
            $scope.disciplina = undefined;
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
            if (!aula.ID) {
                aula = { ...aula, STATUS: true, DATA_CRIACAO: new Date(Date.now()), USUARIO_CRIACAO: "user web" }
                resultado = await aulaservice.inserir(aula)
                angular.element("#modalAdicionarAula").modal("hide");

            } else {
                resultado = await aulaservice.alterar(aula)
                angular.element("#modalEditarAula").modal("hide");

            }
            if (resultado.erro) {
                Swal.fire(
                    `Não foi possível ${(!aula.ID) ? "inserir" : "alterar"} a aula`,
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
            await $scope.ListarAulasPorDisciplina($scope.disciplina.ID);
        }

        //----- Método adicionar Disciplina -----//
        $scope.AdicionarDisciplina = async (disciplina) => {
            let resultado
            if (!disciplina.ID) {
                disciplina = { ...disciplina, ID_CURSO: $scope.curso.ID, STATUS: true, DATA_CRIACAO: new Date(Date.now()), USUARIO_CRIACAO: "User Web" }
                resultado = await disciplinaservice.inserir(disciplina);
                angular.element("#modalAdicionarDisciplina").modal("hide");
                $scope.disciplina = undefined;
            } else {
                resultado = await disciplinaservice.alterar(disciplina);
                angular.element("#modalEditarDisciplina").modal("hide");
            }
            if (resultado.erro) {
                Swal.fire(
                    `Não foi possível ${(!disciplina.ID) ? "inserir" : "alterar"} o curso`,
                    resultado.mensagem,
                    'error'
                );
                return
            }
            Swal.fire(
                'Salvo com Sucesso',
                '',
                'success'
            )
            $scope.$apply();
            $scope.formAdicionarDisciplina.$setPristine()
            await $scope.ListagemDisciplinasPorCurso($scope.curso.ID);
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
                    Swal.fire(
                        'Salvo com Sucesso',
                        '',
                        'success'
                    )
                }

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
            }
            angular.element('#ModalRegistro').modal('hide');
            $scope.cadastrarCursoForm.$setPristine();
            Swal.fire(
                'Salvo com Sucesso',
                '',
                'success'
            )
            angular.element('#disciplinaLink').tab('show');
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

        //----- Editar Disciplina -----//
        $scope.EditarDisciplina = async (disciplina) => {
            $scope.disciplina = disciplina;
            $scope.tituloModal = "Editar Disciplina"
            $scope.Modulos = await obterModulos();
            $scope.$apply();
            angular.element("#modalEditarDisciplina").modal("show");

        }

        //----- Editar Aula -----//
        $scope.EditarAula = async (aula) => {
            console.log(aula)
            $scope.aula = aula;
            $scope.tituloModal = "Editar Aula"
            $scope.TiposDeAula = await obterTipoAula();
            $scope.$apply();
            angular.element("#modalEditarAula").modal("show");
        }

        $scope.FechaModal = modal => {
            angular.element(`#${modal}`).modal("hide");            
        }

    }
})();
