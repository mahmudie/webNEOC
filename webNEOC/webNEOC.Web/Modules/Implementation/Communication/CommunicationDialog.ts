
namespace webNEOC.Implementation {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class CommunicationDialog extends Serenity.EntityDialog<CommunicationRow, any> {
        protected getFormKey() { return CommunicationForm.formKey; }
        protected getIdProperty() { return CommunicationRow.idProperty; }
        protected getLocalTextPrefix() { return CommunicationRow.localTextPrefix; }
        protected getNameProperty() { return CommunicationRow.nameProperty; }
        protected getService() { return CommunicationService.baseUrl; }

        protected form = new CommunicationForm(this.idPrefix);

    }
}