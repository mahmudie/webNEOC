
/// <reference path="../../Common/Helpers/GridEditorDialog.ts" />

namespace webNEOC.PostCampaign {
    
    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class LQASEditorDialog extends Common.GridEditorDialog<LQASRow> {
        protected getFormKey() { return LQASForm.formKey; }
                protected getLocalTextPrefix() { return LQASRow.localTextPrefix; }
        protected getNameProperty() { return LQASRow.nameProperty; }
        protected form = new LQASForm(this.idPrefix);
    }
}