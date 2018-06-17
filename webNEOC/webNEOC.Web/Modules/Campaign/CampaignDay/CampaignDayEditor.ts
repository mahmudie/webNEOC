
/// <reference path="../../Common/Helpers/GridEditorBase.ts" />

namespace webNEOC.Campaign {
    
    @Serenity.Decorators.registerClass()
    export class CampaignDayEditor extends Common.GridEditorBase<CampaignDayRow> {
        protected getColumnsKey() { return 'Campaign.CampaignDay'; }
        protected getDialogType() { return CampaignDayEditorDialog; }
                protected getLocalTextPrefix() { return CampaignDayRow.localTextPrefix; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}