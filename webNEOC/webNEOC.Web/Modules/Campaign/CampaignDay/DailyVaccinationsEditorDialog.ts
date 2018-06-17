
/// <reference path="../../Common/Helpers/GridEditorDialog.ts" />

namespace webNEOC.Campaign {
    
    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class DailyVaccinationsEditorDialog extends Common.GridEditorDialog<DailyVaccinationsRow> {
        protected getFormKey() { return DailyVaccinationsForm.formKey; }
                protected getLocalTextPrefix() { return DailyVaccinationsRow.localTextPrefix; }
        protected form = new DailyVaccinationsForm(this.idPrefix);
    }
}