
namespace webNEOC.CVA {


    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class PTTSDialog extends Serenity.EntityDialog<PTTSRow, any> {
        protected getFormKey() { return PTTSForm.formKey; }
        protected getIdProperty() { return PTTSRow.idProperty; }
        protected getLocalTextPrefix() { return PTTSRow.localTextPrefix; }
        protected getNameProperty() { return PTTSRow.nameProperty; }
        protected getService() { return PTTSService.baseUrl; }

        protected form = new PTTSForm(this.idPrefix);

    }
}