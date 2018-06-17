
namespace webNEOC.Campaign {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class CampaignDialog extends Serenity.EntityDialog<CampaignRow, any> {
        protected getFormKey() { return CampaignForm.formKey; }
        protected getIdProperty() { return CampaignRow.idProperty; }
        protected getLocalTextPrefix() { return CampaignRow.localTextPrefix; }
        protected getNameProperty() { return CampaignRow.nameProperty; }
        protected getService() { return CampaignService.baseUrl; }

        protected form = new CampaignForm(this.idPrefix);

    }
}