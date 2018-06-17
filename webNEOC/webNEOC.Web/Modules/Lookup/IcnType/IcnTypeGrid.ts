
namespace webNEOC.Lookup {

    @Serenity.Decorators.registerClass()
    export class IcnTypeGrid extends Serenity.EntityGrid<IcnTypeRow, any> {
        protected getColumnsKey() { return 'Lookup.IcnType'; }
        protected getDialogType() { return IcnTypeDialog; }
        protected getIdProperty() { return IcnTypeRow.idProperty; }
        protected getLocalTextPrefix() { return IcnTypeRow.localTextPrefix; }
        protected getService() { return IcnTypeService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}