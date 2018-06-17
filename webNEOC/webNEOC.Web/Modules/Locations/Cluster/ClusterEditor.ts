
/// <reference path="../../Common/Helpers/GridEditorBase.ts" />

namespace webNEOC.Locations {
    
    @Serenity.Decorators.registerClass()
    export class ClusterEditor extends Common.GridEditorBase<ClusterRow> {
        protected getColumnsKey() { return 'Locations.Cluster'; }
        protected getDialogType() { return ClusterEditorDialog; }
                protected getLocalTextPrefix() { return ClusterRow.localTextPrefix; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}