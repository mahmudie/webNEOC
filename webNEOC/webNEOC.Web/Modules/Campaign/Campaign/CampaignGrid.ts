
namespace webNEOC.Campaign {
    
    @Serenity.Decorators.registerClass()
    export class CampaignGrid extends Serenity.EntityGrid<CampaignRow, any> {
        protected getColumnsKey() { return 'Campaign.Campaign'; }
        protected getDialogType() { return CampaignDialog; }
        protected getIdProperty() { return CampaignRow.idProperty; }
        protected getLocalTextPrefix() { return CampaignRow.localTextPrefix; }
        protected getService() { return CampaignService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}