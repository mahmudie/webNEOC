
/// <reference path="../../Common/Helpers/GridEditorBase.ts" />

namespace webNEOC.CVA {
    
    @Serenity.Decorators.registerClass()
    export class PTTSEditor extends Common.GridEditorBase<PTTSRow> {
        protected getColumnsKey() { return 'CVA.PTTS'; }
        protected getDialogType() { return PTTSEditorDialog; }
                protected getLocalTextPrefix() { return PTTSRow.localTextPrefix; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}