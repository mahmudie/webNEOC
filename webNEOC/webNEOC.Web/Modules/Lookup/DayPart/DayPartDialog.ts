
namespace webNEOC.Lookup {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class DayPartDialog extends Serenity.EntityDialog<DayPartRow, any> {
        protected getFormKey() { return DayPartForm.formKey; }
        protected getIdProperty() { return DayPartRow.idProperty; }
        protected getLocalTextPrefix() { return DayPartRow.localTextPrefix; }
        protected getNameProperty() { return DayPartRow.nameProperty; }
        protected getService() { return DayPartService.baseUrl; }

        protected form = new DayPartForm(this.idPrefix);

    }
}