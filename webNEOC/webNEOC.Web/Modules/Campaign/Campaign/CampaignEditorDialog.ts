
/// <reference path="../../Common/Helpers/GridEditorDialog.ts" />

namespace webNEOC.Campaign {
    
    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class CampaignEditorDialog extends Common.GridEditorDialog<CampaignRow> {
        protected getFormKey() { return CampaignForm.formKey; }
                protected getLocalTextPrefix() { return CampaignRow.localTextPrefix; }
        protected getNameProperty() { return CampaignRow.nameProperty; }
        protected form = new CampaignForm(this.idPrefix);
    }
}