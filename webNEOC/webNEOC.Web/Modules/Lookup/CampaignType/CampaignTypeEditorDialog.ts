
/// <reference path="../../Common/Helpers/GridEditorDialog.ts" />

namespace webNEOC.Lookup {
    
    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class CampaignTypeEditorDialog extends Common.GridEditorDialog<CampaignTypeRow> {
        protected getFormKey() { return CampaignTypeForm.formKey; }
                protected getLocalTextPrefix() { return CampaignTypeRow.localTextPrefix; }
        protected getNameProperty() { return CampaignTypeRow.nameProperty; }
        protected form = new CampaignTypeForm(this.idPrefix);
    }
}