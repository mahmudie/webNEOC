
/// <reference path="../../Common/Helpers/GridEditorDialog.ts" />

namespace webNEOC.PostCampaign {
    
    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class OutOfHouseSurveyEditorDialog extends Common.GridEditorDialog<OutOfHouseSurveyRow> {
        protected getFormKey() { return OutOfHouseSurveyForm.formKey; }
                protected getLocalTextPrefix() { return OutOfHouseSurveyRow.localTextPrefix; }
        protected form = new OutOfHouseSurveyForm(this.idPrefix);
    }
}