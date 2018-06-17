
/// <reference path="../../Common/Helpers/GridEditorDialog.ts" />

namespace webNEOC.Implementation {
    
    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class VitaminAEditorDialog extends Common.GridEditorDialog<VitaminARow> {
        protected getFormKey() { return VitaminAForm.formKey; }
                protected getLocalTextPrefix() { return VitaminARow.localTextPrefix; }
        protected getNameProperty() { return VitaminARow.nameProperty; }
        protected form = new VitaminAForm(this.idPrefix);
    }
}