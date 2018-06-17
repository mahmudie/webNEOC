
/// <reference path="../../Common/Helpers/GridEditorBase.ts" />

namespace webNEOC.Locations {
    
    @Serenity.Decorators.registerClass()
    export class ProvinceEditor extends Common.GridEditorBase<ProvinceRow> {
        protected getColumnsKey() { return 'Locations.Province'; }
        protected getDialogType() { return ProvinceEditorDialog; }
                protected getLocalTextPrefix() { return ProvinceRow.localTextPrefix; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}