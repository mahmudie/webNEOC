
namespace webNEOC.Lookup {

    @Serenity.Decorators.registerClass()
    export class LangGrid extends Serenity.EntityGrid<LangRow, any> {
        protected getColumnsKey() { return 'Lookup.Lang'; }
        protected getDialogType() { return LangDialog; }
        protected getIdProperty() { return LangRow.idProperty; }
        protected getLocalTextPrefix() { return LangRow.localTextPrefix; }
        protected getService() { return LangService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}