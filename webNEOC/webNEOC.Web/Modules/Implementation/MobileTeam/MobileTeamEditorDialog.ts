
/// <reference path="../../Common/Helpers/GridEditorDialog.ts" />

namespace webNEOC.Implementation {
    
    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class MobileTeamEditorDialog extends Common.GridEditorDialog<MobileTeamRow> {
        protected getFormKey() { return MobileTeamForm.formKey; }
                protected getLocalTextPrefix() { return MobileTeamRow.localTextPrefix; }
        protected form = new MobileTeamForm(this.idPrefix);
    }
}