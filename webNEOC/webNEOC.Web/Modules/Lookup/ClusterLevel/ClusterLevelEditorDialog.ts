
/// <reference path="../../Common/Helpers/GridEditorDialog.ts" />

namespace webNEOC.Lookup {
    
    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class ClusterLevelEditorDialog extends Common.GridEditorDialog<ClusterLevelRow> {
        protected getFormKey() { return ClusterLevelForm.formKey; }
                protected getLocalTextPrefix() { return ClusterLevelRow.localTextPrefix; }
        protected getNameProperty() { return ClusterLevelRow.nameProperty; }
        protected form = new ClusterLevelForm(this.idPrefix);
    }
}