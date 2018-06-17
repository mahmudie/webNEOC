
namespace webNEOC.ImportGate {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class TempVitaminADialog extends Serenity.EntityDialog<TempVitaminARow, any> {
        protected getFormKey() { return TempVitaminAForm.formKey; }
        protected getIdProperty() { return TempVitaminARow.idProperty; }
        protected getLocalTextPrefix() { return TempVitaminARow.localTextPrefix; }
        protected getNameProperty() { return TempVitaminARow.nameProperty; }
        protected getService() { return TempVitaminAService.baseUrl; }

        protected form = new TempVitaminAForm(this.idPrefix);

    }
}