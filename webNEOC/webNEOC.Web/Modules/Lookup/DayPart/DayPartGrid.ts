
namespace webNEOC.Lookup {

    @Serenity.Decorators.registerClass()
    export class DayPartGrid extends Serenity.EntityGrid<DayPartRow, any> {
        protected getColumnsKey() { return 'Lookup.DayPart'; }
        protected getDialogType() { return DayPartDialog; }
        protected getIdProperty() { return DayPartRow.idProperty; }
        protected getLocalTextPrefix() { return DayPartRow.localTextPrefix; }
        protected getService() { return DayPartService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}