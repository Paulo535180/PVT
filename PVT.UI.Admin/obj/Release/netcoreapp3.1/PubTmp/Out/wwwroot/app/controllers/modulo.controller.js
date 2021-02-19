(function () {
    angular
        .module('PjrPadrao')
        .controller('modulo', modulo);

    modulo.$inject = ['$scope', 'moduloservice'];

    function modulo($scope, moduloservice) {

        $scope.Tabela
        $scope.modulo
        $scope.tituloModal
        $scope.NaoVinculados
        $scope.dtOptions


        //----- Apenas guarda em obterModulo o serviço de Listagem dos Módulos -----//
        let obterModulos = async () => {
            let resultado = await moduloservice.Listagem();
            console.log(resultado)
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


        //-----Modal Abrir novo Cadastro -----//
        $scope.AbrirCadastrarNovo = () => {
            $scope.modulo = undefined;
            $scope.tituloModal = "Novo Módulo"
            angular.element('#ModalRegistro').modal('show');
        }

        //-----Modal Vincular Novo Módulo-----//
        $scope.AbrirModalVincularModulo = async () => {
            let resultado = await moduloservice.ListagemNaoVinculados();
            $scope.NaoVinculados = await resultado.data;
            console.log(resultado)
            $scope.tituloModal = "Novo Vinculo"
            $scope.$apply();
            angular.element('#ModalVinculoModulo').modal('show');
        }

        //----- Função de Vincular módulo a Setor -----//
        $scope.VincularModulo = async (modulo) => {
            $scope.modulo = undefined;
            console.log(modulo)
            let resultado = await moduloservice.inserirVinculo(modulo.ID_MODULO)
            console.log(resultado);
            await $scope.Listagem();
            $scope.$apply();
            angular.element('#ModalVinculoModulo').modal('hide');
            Swal.fire(
                'Salvo com Sucesso',
                '',
                'success'
            )
        }

        //----- Listagem dos Módulos -----//
        $scope.Listagem = async () => {
            let resultado = await obterModulos();
            $scope.Tabela = resultado
            console.log(resultado)
            $scope.$apply();
        }

        //----- Abrir Modal de edição -----//
        $scope.AbrirItemSelecionado = (item) => {
            console.log(typeof item) //--> object
            console.log(item)
            $scope.modulo = item;
            $scope.tituloModal = "Editar Módulo"
            angular.element("#ModalRegistro").modal("show");
        }



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

        //----- Chama os métodos para alterar os registros em banco -----//
        $scope.Finalizar = async (modulo) => {
            console.log(modulo)
            let resultado
            if (!modulo.ID) {
                modulo = { ...modulo, STATUS: true, DATA_CRIACAO: new Date(Date.now()), USUARIO_CRIACAO: "teste" }
                resultado = await moduloservice.inserir(modulo);
            }
            else {
                resultado = await moduloservice.alterar(modulo);
            }
            console.log(resultado);
            if (resultado.erro) {
                Swal.fire(
                    `Não foi possível ${(!modulo.ID) ? "inserir" : "alterar"} o modulo`,
                    resultado.mensagem,
                    'error'
                );
                return
            }
            angular.element("#ModalRegistro").modal("hide"); Swal.fire(
                'Salvo com Sucesso',
                '',
                'success'
            )
            $scope.$apply();
            await $scope.Listagem()
        }


        //----- Botão que altera cor do status -----//
        $scope.botaoClass = (status) => {
            let classe = 'btn btn-sm btn-'
            if (status) {
                classe += 'success'
            } else {
                classe += 'danger'
            }
            return classe;
        }
    }
})();
