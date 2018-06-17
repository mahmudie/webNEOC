
namespace webNEOC.ImportGate {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class TempCampaignDialog extends Serenity.EntityDialog<TempCampaignRow, any> {
        protected getFormKey() { return TempCampaignForm.formKey; }
        protected getIdProperty() { return TempCampaignRow.idProperty; }
        protected getLocalTextPrefix() { return TempCampaignRow.localTextPrefix; }
        protected getNameProperty() { return TempCampaignRow.nameProperty; }
        protected getService() { return TempCampaignService.baseUrl; }

        protected form = new TempCampaignForm(this.idPrefix);

    }
}