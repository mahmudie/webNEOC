
/// <reference path="../../Common/Helpers/GridEditorBase.ts" />

namespace webNEOC.Lookup {
    
    @Serenity.Decorators.registerClass()
    export class CampaignTypeEditor extends Common.GridEditorBase<CampaignTypeRow> {
        protected getColumnsKey() { return 'Lookup.CampaignType'; }
        protected getDialogType() { return CampaignTypeEditorDialog; }
                protected getLocalTextPrefix() { return CampaignTypeRow.localTextPrefix; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}