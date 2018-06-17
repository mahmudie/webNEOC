
/// <reference path="../../Common/Helpers/GridEditorBase.ts" />

namespace webNEOC.Campaign {
    
    @Serenity.Decorators.registerClass()
    export class CampaignEditor extends Common.GridEditorBase<CampaignRow> {
        protected getColumnsKey() { return 'Campaign.Campaign'; }
        protected getDialogType() { return CampaignEditorDialog; }
                protected getLocalTextPrefix() { return CampaignRow.localTextPrefix; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}