
/// <reference path="../../Common/Helpers/GridEditorDialog.ts" />

namespace webNEOC.CVA {
    
    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class PTTSEditorDialog extends Common.GridEditorDialog<PTTSRow> {
        protected getFormKey() { return PTTSForm.formKey; }
                protected getLocalTextPrefix() { return PTTSRow.localTextPrefix; }
        protected getNameProperty() { return PTTSRow.nameProperty; }
        protected form = new PTTSForm(this.idPrefix);
    }
}