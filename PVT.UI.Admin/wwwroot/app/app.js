(function () {
    angular.module('PjrPadrao', ['datatables'])
        .run(App);

    App.$inject = ['$rootScope', 'DTOptionsBuilder'];

    function App($rootScope, DTOptionsBuilder) {
        $rootScope.dtOptions = DTOptionsBuilder.newOptions()
            .withDisplayLength(10)
            .withOption('bLengthChange', false)
            .withOption('searching', true)
            .withLanguageSource("/js/Portuguese-Brasil.json")
    }

})();