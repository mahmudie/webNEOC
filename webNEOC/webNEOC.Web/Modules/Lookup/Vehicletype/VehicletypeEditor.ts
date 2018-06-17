
/// <reference path="../../Common/Helpers/GridEditorBase.ts" />

namespace webNEOC.Lookup {
    
    @Serenity.Decorators.registerClass()
    export class VehicletypeEditor extends Common.GridEditorBase<VehicletypeRow> {
        protected getColumnsKey() { return 'Lookup.Vehicletype'; }
        protected getDialogType() { return VehicletypeEditorDialog; }
                protected getLocalTextPrefix() { return VehicletypeRow.localTextPrefix; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}