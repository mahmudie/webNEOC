
namespace webNEOC.Lookup {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class CampaignTypeDialog extends Serenity.EntityDialog<CampaignTypeRow, any> {
        protected getFormKey() { return CampaignTypeForm.formKey; }
        protected getIdProperty() { return CampaignTypeRow.idProperty; }
        protected getLocalTextPrefix() { return CampaignTypeRow.localTextPrefix; }
        protected getNameProperty() { return CampaignTypeRow.nameProperty; }
        protected getService() { return CampaignTypeService.baseUrl; }

        protected form = new CampaignTypeForm(this.idPrefix);

    }
}