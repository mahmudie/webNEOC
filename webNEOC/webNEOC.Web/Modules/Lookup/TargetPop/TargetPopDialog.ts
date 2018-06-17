
namespace webNEOC.Lookup {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class TargetPopDialog extends Serenity.EntityDialog<TargetPopRow, any> {
        protected getFormKey() { return TargetPopForm.formKey; }
        protected getIdProperty() { return TargetPopRow.idProperty; }
        protected getLocalTextPrefix() { return TargetPopRow.localTextPrefix; }
        protected getNameProperty() { return TargetPopRow.nameProperty; }
        protected getService() { return TargetPopService.baseUrl; }

        protected form = new TargetPopForm(this.idPrefix);

    }
}