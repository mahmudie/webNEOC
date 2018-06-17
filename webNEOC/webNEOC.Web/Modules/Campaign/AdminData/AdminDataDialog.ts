
namespace webNEOC.Campaign {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    @Serenity.Decorators.panel()
    export class AdminDataDialog extends Serenity.EntityDialog<AdminDataRow, any> {
        protected getFormKey() { return AdminDataForm.formKey; }
        protected getIdProperty() { return AdminDataRow.idProperty; }
        protected getLocalTextPrefix() { return AdminDataRow.localTextPrefix; }
        protected getNameProperty() { return AdminDataRow.nameProperty; }
        protected getService() { return AdminDataService.baseUrl; }

        protected form = new AdminDataForm(this.idPrefix);

    }
}