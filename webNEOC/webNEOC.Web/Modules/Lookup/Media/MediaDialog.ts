
namespace webNEOC.Lookup {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class MediaDialog extends Serenity.EntityDialog<MediaRow, any> {
        protected getFormKey() { return MediaForm.formKey; }
        protected getIdProperty() { return MediaRow.idProperty; }
        protected getLocalTextPrefix() { return MediaRow.localTextPrefix; }
        protected getNameProperty() { return MediaRow.nameProperty; }
        protected getService() { return MediaService.baseUrl; }

        protected form = new MediaForm(this.idPrefix);

    }
}