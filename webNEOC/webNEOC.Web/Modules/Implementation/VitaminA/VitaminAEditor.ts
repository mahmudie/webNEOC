
/// <reference path="../../Common/Helpers/GridEditorBase.ts" />

namespace webNEOC.Implementation {
    
    @Serenity.Decorators.registerClass()
   
    export class VitaminAEditor extends Common.GridEditorBase<VitaminARow> {
        protected getColumnsKey() { return 'Implementation.VitaminA'; }
        protected getDialogType() { return VitaminAEditorDialog; }
                protected getLocalTextPrefix() { return VitaminARow.localTextPrefix; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}