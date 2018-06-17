
/// <reference path="../../Common/Helpers/GridEditorDialog.ts" />

namespace webNEOC.Lookup {
    
    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class RoundEditorDialog extends Common.GridEditorDialog<RoundRow> {
        protected getFormKey() { return RoundForm.formKey; }
                protected getLocalTextPrefix() { return RoundRow.localTextPrefix; }
        protected getNameProperty() { return RoundRow.nameProperty; }
        protected form = new RoundForm(this.idPrefix);
    }
}