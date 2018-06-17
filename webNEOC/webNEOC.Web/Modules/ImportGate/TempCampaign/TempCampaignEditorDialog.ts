
/// <reference path="../../Common/Helpers/GridEditorDialog.ts" />

namespace webNEOC.ImportGate {
    
    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class TempCampaignEditorDialog extends Common.GridEditorDialog<TempCampaignRow> {
        protected getFormKey() { return TempCampaignForm.formKey; }
                protected getLocalTextPrefix() { return TempCampaignRow.localTextPrefix; }
        protected getNameProperty() { return TempCampaignRow.nameProperty; }
        protected form = new TempCampaignForm(this.idPrefix);
    }
}