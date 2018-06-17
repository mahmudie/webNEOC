
/// <reference path="../../Common/Helpers/GridEditorBase.ts" />

namespace webNEOC.Lookup {
    
    @Serenity.Decorators.registerClass()
    export class RoundEditor extends Common.GridEditorBase<RoundRow> {
        protected getColumnsKey() { return 'Lookup.Round'; }
        protected getDialogType() { return RoundEditorDialog; }
                protected getLocalTextPrefix() { return RoundRow.localTextPrefix; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}