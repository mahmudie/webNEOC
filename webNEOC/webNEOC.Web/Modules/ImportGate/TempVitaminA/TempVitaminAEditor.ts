
/// <reference path="../../Common/Helpers/GridEditorBase.ts" />

namespace webNEOC.ImportGate {
    
    @Serenity.Decorators.registerClass()
    export class TempVitaminAEditor extends Common.GridEditorBase<TempVitaminARow> {
        protected getColumnsKey() { return 'ImportGate.TempVitaminA'; }
        protected getDialogType() { return TempVitaminAEditorDialog; }
                protected getLocalTextPrefix() { return TempVitaminARow.localTextPrefix; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}