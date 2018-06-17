
namespace webNEOC.Lookup {
    
    @Serenity.Decorators.registerClass()
    export class CampaignTypeGrid extends Serenity.EntityGrid<CampaignTypeRow, any> {
        protected getColumnsKey() { return 'Lookup.CampaignType'; }
        protected getDialogType() { return CampaignTypeDialog; }
        protected getIdProperty() { return CampaignTypeRow.idProperty; }
        protected getLocalTextPrefix() { return CampaignTypeRow.localTextPrefix; }
        protected getService() { return CampaignTypeService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
        protected getButtons(): Serenity.ToolButton[] {
            var buttons = super.getButtons();
            buttons.splice(Q.indexOf(buttons, x => x.cssClass == "column-picker-button"), 1);
            return buttons;
        }
    }
}