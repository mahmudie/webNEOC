
/// <reference path="../../Common/Helpers/GridEditorBase.ts" />

namespace webNEOC.Lookup {
    
    @Serenity.Decorators.registerClass()
    export class PartEditor extends Common.GridEditorBase<PartRow> {
        protected getColumnsKey() { return 'Lookup.Part'; }
        protected getDialogType() { return PartEditorDialog; }
                protected getLocalTextPrefix() { return PartRow.localTextPrefix; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}