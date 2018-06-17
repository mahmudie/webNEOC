
/// <reference path="../../Common/Helpers/GridEditorDialog.ts" />

namespace webNEOC.PostCampaign {
    
    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class PcmEditorDialog extends Common.GridEditorDialog<PcmRow> {
        protected getFormKey() { return PcmForm.formKey; }
                protected getLocalTextPrefix() { return PcmRow.localTextPrefix; }
        protected getNameProperty() { return PcmRow.nameProperty; }
        protected form = new PcmForm(this.idPrefix);
    }
}