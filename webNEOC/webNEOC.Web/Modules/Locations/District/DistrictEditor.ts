
/// <reference path="../../Common/Helpers/GridEditorBase.ts" />

namespace webNEOC.Locations {
    
    @Serenity.Decorators.registerClass()
    export class DistrictEditor extends Common.GridEditorBase<DistrictRow> {
        protected getColumnsKey() { return 'Locations.District'; }
        protected getDialogType() { return DistrictEditorDialog; }
                protected getLocalTextPrefix() { return DistrictRow.localTextPrefix; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}