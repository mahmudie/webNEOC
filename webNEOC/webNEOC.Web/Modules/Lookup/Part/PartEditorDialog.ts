
/// <reference path="../../Common/Helpers/GridEditorDialog.ts" />

namespace webNEOC.Lookup {
    
    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class PartEditorDialog extends Common.GridEditorDialog<PartRow> {
        protected getFormKey() { return PartForm.formKey; }
                protected getLocalTextPrefix() { return PartRow.localTextPrefix; }
        protected getNameProperty() { return PartRow.nameProperty; }
        protected form = new PartForm(this.idPrefix);
    }
}