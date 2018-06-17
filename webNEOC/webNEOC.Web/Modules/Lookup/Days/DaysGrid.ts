
namespace webNEOC.Lookup {

    @Serenity.Decorators.registerClass()
    export class DaysGrid extends Serenity.EntityGrid<DaysRow, any> {
        protected getColumnsKey() { return 'Lookup.Days'; }
        protected getDialogType() { return DaysDialog; }
        protected getIdProperty() { return DaysRow.idProperty; }
        protected getLocalTextPrefix() { return DaysRow.localTextPrefix; }
        protected getService() { return DaysService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}