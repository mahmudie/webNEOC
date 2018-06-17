
/// <reference path="../../Common/Helpers/GridEditorBase.ts" />

namespace webNEOC.Lookup {
    
    @Serenity.Decorators.registerClass()
    export class MonthsEditor extends Common.GridEditorBase<MonthsRow> {
        protected getColumnsKey() { return 'Lookup.Months'; }
        protected getDialogType() { return MonthsEditorDialog; }
                protected getLocalTextPrefix() { return MonthsRow.localTextPrefix; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}