
namespace webNEOC.Lookup {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class LangDialog extends Serenity.EntityDialog<LangRow, any> {
        protected getFormKey() { return LangForm.formKey; }
        protected getIdProperty() { return LangRow.idProperty; }
        protected getLocalTextPrefix() { return LangRow.localTextPrefix; }
        protected getNameProperty() { return LangRow.nameProperty; }
        protected getService() { return LangService.baseUrl; }

        protected form = new LangForm(this.idPrefix);

    }
}