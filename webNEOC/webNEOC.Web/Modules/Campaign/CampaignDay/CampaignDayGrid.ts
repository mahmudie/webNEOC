
namespace webNEOC.Campaign {
    
    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.filterable()
    export class CampaignDayGrid extends Serenity.EntityGrid<CampaignDayRow, any> {
        protected getColumnsKey() { return 'Campaign.CampaignDay'; }
        protected getDialogType() { return CampaignDayDialog; }
        protected getIdProperty() { return CampaignDayRow.idProperty; }
        protected getLocalTextPrefix() { return CampaignDayRow.localTextPrefix; }
        protected getService() { return CampaignDayService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }

        protected getButtons() {
            var buttons = super.getButtons();

            buttons.push({
                title: 'Import Dialog',
                cssClass: 'export-xlsx-button',
                onClick: () => {
                    // open import dialog, let it handle rest
                    window.location.href = Q.resolveUrl('~/ImportGate/TempCampaign');
                }
            });
            return buttons;
        }
    }
}