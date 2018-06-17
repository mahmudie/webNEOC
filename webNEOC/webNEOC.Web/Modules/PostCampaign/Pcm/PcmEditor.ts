
/// <reference path="../../Common/Helpers/GridEditorBase.ts" />

namespace webNEOC.PostCampaign {
    
    @Serenity.Decorators.registerClass()
    export class PcmEditor extends Common.GridEditorBase<PcmRow> {
        protected getColumnsKey() { return 'PostCampaign.Pcm'; }
        protected getDialogType() { return PcmEditorDialog; }
                protected getLocalTextPrefix() { return PcmRow.localTextPrefix; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}