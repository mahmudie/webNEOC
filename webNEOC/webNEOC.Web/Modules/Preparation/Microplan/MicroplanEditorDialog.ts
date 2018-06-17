
/// <reference path="../../Common/Helpers/GridEditorDialog.ts" />

namespace webNEOC.Preparation {
    
    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class MicroplanEditorDialog extends Common.GridEditorDialog<MicroplanRow> {
        protected getFormKey() { return MicroplanForm.formKey; }
                protected getLocalTextPrefix() { return MicroplanRow.localTextPrefix; }
        protected form = new MicroplanForm(this.idPrefix);
    }
}