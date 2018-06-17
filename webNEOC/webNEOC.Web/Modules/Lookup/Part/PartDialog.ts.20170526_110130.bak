
namespace webNEOC.Lookup {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class PartDialog extends Serenity.EntityDialog<PartRow, any> {
        protected getFormKey() { return PartForm.formKey; }
        protected getIdProperty() { return PartRow.idProperty; }
        protected getLocalTextPrefix() { return PartRow.localTextPrefix; }
        protected getNameProperty() { return PartRow.nameProperty; }
        protected getService() { return PartService.baseUrl; }

        protected form = new PartForm(this.idPrefix);

    }
}