
/// <reference path="../../Common/Helpers/GridEditorDialog.ts" />

namespace webNEOC.Implementation {
    
    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class IcmTeamEditorDialog extends Common.GridEditorDialog<IcmTeamRow> {
        protected getFormKey() { return IcmTeamForm.formKey; }
                protected getLocalTextPrefix() { return IcmTeamRow.localTextPrefix; }
        protected getNameProperty() { return IcmTeamRow.nameProperty; }
        protected form = new IcmTeamForm(this.idPrefix);
    }
}