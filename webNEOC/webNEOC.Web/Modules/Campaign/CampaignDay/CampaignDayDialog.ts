
namespace webNEOC.Campaign {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    @Serenity.Decorators.maximizable()
    @Serenity.Decorators.panel()
    export class CampaignDayDialog extends Serenity.EntityDialog<CampaignDayRow, any> {
        protected getFormKey() { return CampaignDayForm.formKey; }
        protected getIdProperty() { return CampaignDayRow.idProperty; }
        protected getLocalTextPrefix() { return CampaignDayRow.localTextPrefix; }
        protected getNameProperty() { return CampaignDayRow.nameProperty; }
        protected getService() { return CampaignDayService.baseUrl; }

        protected form = new CampaignDayForm(this.idPrefix);

        onDialogOpen() {
            super.onDialogOpen()
            this.element.closest('.ui-dialog').find('.ui-dialog-titlebar-maximize').click();
        }
    }
}