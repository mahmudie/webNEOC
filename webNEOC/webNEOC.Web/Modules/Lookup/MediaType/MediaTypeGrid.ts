
namespace webNEOC.Lookup {

    @Serenity.Decorators.registerClass()
    export class MediaTypeGrid extends Serenity.EntityGrid<MediaTypeRow, any> {
        protected getColumnsKey() { return 'Lookup.MediaType'; }
        protected getDialogType() { return MediaTypeDialog; }
        protected getIdProperty() { return MediaTypeRow.idProperty; }
        protected getLocalTextPrefix() { return MediaTypeRow.localTextPrefix; }
        protected getService() { return MediaTypeService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}