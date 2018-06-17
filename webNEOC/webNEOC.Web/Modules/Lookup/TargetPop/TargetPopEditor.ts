
/// <reference path="../../Common/Helpers/GridEditorBase.ts" />

namespace webNEOC.Lookup {
    
    @Serenity.Decorators.registerClass()
    export class TargetPopEditor extends Common.GridEditorBase<TargetPopRow> {
        protected getColumnsKey() { return 'Lookup.TargetPop'; }
        protected getDialogType() { return TargetPopEditorDialog; }
                protected getLocalTextPrefix() { return TargetPopRow.localTextPrefix; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}