
/// <reference path="../../Common/Helpers/GridEditorBase.ts" />

namespace webNEOC.PostCampaign {
    
    @Serenity.Decorators.registerClass()
    export class OutOfHouseSurveyEditor extends Common.GridEditorBase<OutOfHouseSurveyRow> {
        protected getColumnsKey() { return 'PostCampaign.OutOfHouseSurvey'; }
        protected getDialogType() { return OutOfHouseSurveyEditorDialog; }
                protected getLocalTextPrefix() { return OutOfHouseSurveyRow.localTextPrefix; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}