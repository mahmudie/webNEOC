
/// <reference path="../../Common/Helpers/GridEditorBase.ts" />

namespace webNEOC.Preparation {
    
    @Serenity.Decorators.registerClass()
    export class MicroplanEditor extends Common.GridEditorBase<MicroplanRow> {
        protected getColumnsKey() { return 'Preparation.Microplan'; }
        protected getDialogType() { return MicroplanEditorDialog; }
                protected getLocalTextPrefix() { return MicroplanRow.localTextPrefix; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}