
namespace webNEOC.Lookup {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class MonthsDialog extends Serenity.EntityDialog<MonthsRow, any> {
        protected getFormKey() { return MonthsForm.formKey; }
        protected getIdProperty() { return MonthsRow.idProperty; }
        protected getLocalTextPrefix() { return MonthsRow.localTextPrefix; }
        protected getNameProperty() { return MonthsRow.nameProperty; }
        protected getService() { return MonthsService.baseUrl; }

        protected form = new MonthsForm(this.idPrefix);

    }
}