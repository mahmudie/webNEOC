
namespace webNEOC.Lookup {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class MediaTypeDialog extends Serenity.EntityDialog<MediaTypeRow, any> {
        protected getFormKey() { return MediaTypeForm.formKey; }
        protected getIdProperty() { return MediaTypeRow.idProperty; }
        protected getLocalTextPrefix() { return MediaTypeRow.localTextPrefix; }
        protected getNameProperty() { return MediaTypeRow.nameProperty; }
        protected getService() { return MediaTypeService.baseUrl; }

        protected form = new MediaTypeForm(this.idPrefix);

    }
}