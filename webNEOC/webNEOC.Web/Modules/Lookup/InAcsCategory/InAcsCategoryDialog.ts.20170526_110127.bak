
namespace webNEOC.Lookup {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class InAcsCategoryDialog extends Serenity.EntityDialog<InAcsCategoryRow, any> {
        protected getFormKey() { return InAcsCategoryForm.formKey; }
        protected getIdProperty() { return InAcsCategoryRow.idProperty; }
        protected getLocalTextPrefix() { return InAcsCategoryRow.localTextPrefix; }
        protected getNameProperty() { return InAcsCategoryRow.nameProperty; }
        protected getService() { return InAcsCategoryService.baseUrl; }

        protected form = new InAcsCategoryForm(this.idPrefix);

    }
}