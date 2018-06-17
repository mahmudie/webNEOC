
/// <reference path="../../Common/Helpers/GridEditorBase.ts" />

namespace webNEOC.Preparation {
    
    @Serenity.Decorators.registerClass()
    export class InAccessibleEditor extends Common.GridEditorBase<InAccessibleRow> {
        protected getColumnsKey() { return 'Preparation.InAccessible'; }
        protected getDialogType() { return InAccessibleEditorDialog; }
                protected getLocalTextPrefix() { return InAccessibleRow.localTextPrefix; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}