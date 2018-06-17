
/// <reference path="../../Common/Helpers/GridEditorDialog.ts" />

namespace webNEOC.Implementation {
    
    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class IcnEditorDialog extends Common.GridEditorDialog<IcnRow> {
        protected getFormKey() { return IcnForm.formKey; }
                protected getLocalTextPrefix() { return IcnRow.localTextPrefix; }
        protected getNameProperty() { return IcnRow.nameProperty; }
        protected form = new IcnForm(this.idPrefix);
    }
}