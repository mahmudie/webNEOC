
/// <reference path="../../Common/Helpers/GridEditorDialog.ts" />

namespace webNEOC.Preparation {
    
    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class InAccessibleEditorDialog extends Common.GridEditorDialog<InAccessibleRow> {
        protected getFormKey() { return InAccessibleForm.formKey; }
                protected getLocalTextPrefix() { return InAccessibleRow.localTextPrefix; }
        protected getNameProperty() { return InAccessibleRow.nameProperty; }
        protected form = new InAccessibleForm(this.idPrefix);
    }
}