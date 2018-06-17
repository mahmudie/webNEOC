
/// <reference path="../../Common/Helpers/GridEditorBase.ts" />

namespace webNEOC.Implementation {
    
    @Serenity.Decorators.registerClass()
    export class IcnEditor extends Common.GridEditorBase<IcnRow> {
        protected getColumnsKey() { return 'Implementation.Icn'; }
        protected getDialogType() { return IcnEditorDialog; }
                protected getLocalTextPrefix() { return IcnRow.localTextPrefix; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}