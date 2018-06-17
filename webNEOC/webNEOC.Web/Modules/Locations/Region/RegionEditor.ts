
/// <reference path="../../Common/Helpers/GridEditorBase.ts" />

namespace webNEOC.Locations {
    
    @Serenity.Decorators.registerClass()
    export class RegionEditor extends Common.GridEditorBase<RegionRow> {
        protected getColumnsKey() { return 'Locations.Region'; }
        protected getDialogType() { return RegionEditorDialog; }
                protected getLocalTextPrefix() { return RegionRow.localTextPrefix; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}