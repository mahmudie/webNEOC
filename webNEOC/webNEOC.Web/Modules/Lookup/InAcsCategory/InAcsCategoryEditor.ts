
/// <reference path="../../Common/Helpers/GridEditorBase.ts" />

namespace webNEOC.Lookup {
    
    @Serenity.Decorators.registerClass()
    export class InAcsCategoryEditor extends Common.GridEditorBase<InAcsCategoryRow> {
        protected getColumnsKey() { return 'Lookup.InAcsCategory'; }
        protected getDialogType() { return InAcsCategoryEditorDialog; }
                protected getLocalTextPrefix() { return InAcsCategoryRow.localTextPrefix; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}