
namespace webNEOC.Lookup {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class DaysDialog extends Serenity.EntityDialog<DaysRow, any> {
        protected getFormKey() { return DaysForm.formKey; }
        protected getIdProperty() { return DaysRow.idProperty; }
        protected getLocalTextPrefix() { return DaysRow.localTextPrefix; }
        protected getNameProperty() { return DaysRow.nameProperty; }
        protected getService() { return DaysService.baseUrl; }

        protected form = new DaysForm(this.idPrefix);

    }
}