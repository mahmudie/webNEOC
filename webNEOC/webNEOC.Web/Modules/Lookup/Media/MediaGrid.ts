
namespace webNEOC.Lookup {

    @Serenity.Decorators.registerClass()
    export class MediaGrid extends Serenity.EntityGrid<MediaRow, any> {
        protected getColumnsKey() { return 'Lookup.Media'; }
        protected getDialogType() { return MediaDialog; }
        protected getIdProperty() { return MediaRow.idProperty; }
        protected getLocalTextPrefix() { return MediaRow.localTextPrefix; }
        protected getService() { return MediaService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}