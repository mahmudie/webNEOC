
/// <reference path="../../Common/Helpers/GridEditorDialog.ts" />

namespace webNEOC.ImportGate {
    
    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class TempVitaminAEditorDialog extends Common.GridEditorDialog<TempVitaminARow> {
        protected getFormKey() { return TempVitaminAForm.formKey; }
                protected getLocalTextPrefix() { return TempVitaminARow.localTextPrefix; }
        protected getNameProperty() { return TempVitaminARow.nameProperty; }
        protected form = new TempVitaminAForm(this.idPrefix);
    }
}