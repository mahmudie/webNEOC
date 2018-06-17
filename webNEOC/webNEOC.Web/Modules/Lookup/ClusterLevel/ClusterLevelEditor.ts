
/// <reference path="../../Common/Helpers/GridEditorBase.ts" />

namespace webNEOC.Lookup {
    
    @Serenity.Decorators.registerClass()
    export class ClusterLevelEditor extends Common.GridEditorBase<ClusterLevelRow> {
        protected getColumnsKey() { return 'Lookup.ClusterLevel'; }
        protected getDialogType() { return ClusterLevelEditorDialog; }
                protected getLocalTextPrefix() { return ClusterLevelRow.localTextPrefix; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}