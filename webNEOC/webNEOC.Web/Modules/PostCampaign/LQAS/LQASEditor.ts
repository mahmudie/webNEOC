
/// <reference path="../../Common/Helpers/GridEditorBase.ts" />

namespace webNEOC.PostCampaign {
    
    @Serenity.Decorators.registerClass()
    export class LQASEditor extends Common.GridEditorBase<LQASRow> {
        protected getColumnsKey() { return 'PostCampaign.LQAS'; }
        protected getDialogType() { return LQASEditorDialog; }
                protected getLocalTextPrefix() { return LQASRow.localTextPrefix; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}