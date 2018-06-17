
/// <reference path="../../Common/Helpers/GridEditorDialog.ts" />

namespace webNEOC.Lookup {
    
    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class TargetPopEditorDialog extends Common.GridEditorDialog<TargetPopRow> {
        protected getFormKey() { return TargetPopForm.formKey; }
                protected getLocalTextPrefix() { return TargetPopRow.localTextPrefix; }
        protected getNameProperty() { return TargetPopRow.nameProperty; }
        protected form = new TargetPopForm(this.idPrefix);
    }
}