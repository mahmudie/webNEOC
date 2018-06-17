
/// <reference path="../../Common/Helpers/GridEditorDialog.ts" />

namespace webNEOC.Campaign {

    @Serenity.Decorators.maximizable()
    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class CampaignDayEditorDialog extends Common.GridEditorDialog<CampaignDayRow> {
        protected getFormKey() { return CampaignDayForm.formKey; }
        protected getLocalTextPrefix() { return CampaignDayRow.localTextPrefix; }
        protected getNameProperty() { return CampaignDayRow.nameProperty; }
        protected form = new CampaignDayForm(this.idPrefix);

        onDialogOpen() {
            super.onDialogOpen()
            this.element.closest('.ui-dialog').find('.ui-dialog-titlebar-maximize').click();
            }
        }
}