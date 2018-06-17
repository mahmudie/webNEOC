
/// <reference path="../../Common/Helpers/GridEditorDialog.ts" />

namespace webNEOC.Locations {
    
    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class ClusterEditorDialog extends Common.GridEditorDialog<ClusterRow> {
        protected getFormKey() { return ClusterForm.formKey; }
                protected getLocalTextPrefix() { return ClusterRow.localTextPrefix; }
        protected getNameProperty() { return ClusterRow.nameProperty; }
        protected form = new ClusterForm(this.idPrefix);
    }
}