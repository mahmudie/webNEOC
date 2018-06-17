
/// <reference path="../../Common/Helpers/GridEditorDialog.ts" />

namespace webNEOC.Lookup {
    
    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class InAcsCategoryEditorDialog extends Common.GridEditorDialog<InAcsCategoryRow> {
        protected getFormKey() { return InAcsCategoryForm.formKey; }
                protected getLocalTextPrefix() { return InAcsCategoryRow.localTextPrefix; }
        protected getNameProperty() { return InAcsCategoryRow.nameProperty; }
        protected form = new InAcsCategoryForm(this.idPrefix);
    }
}