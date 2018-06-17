
/// <reference path="../../Common/Helpers/GridEditorBase.ts" />

namespace webNEOC.ImportGate {
    
    @Serenity.Decorators.registerClass()
    export class TempCampaignEditor extends Common.GridEditorBase<TempCampaignRow> {
        protected getColumnsKey() { return 'ImportGate.TempCampaign'; }
        protected getDialogType() { return TempCampaignEditorDialog; }
                protected getLocalTextPrefix() { return TempCampaignRow.localTextPrefix; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}