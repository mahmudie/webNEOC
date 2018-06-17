
/// <reference path="../../Common/Helpers/GridEditorDialog.ts" />

namespace webNEOC.Implementation {
    
    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class IcmHouseholdEditorDialog extends Common.GridEditorDialog<IcmHouseholdRow> {
        protected getFormKey() { return IcmHouseholdForm.formKey; }
                protected getLocalTextPrefix() { return IcmHouseholdRow.localTextPrefix; }
        protected getNameProperty() { return IcmHouseholdRow.nameProperty; }
        protected form = new IcmHouseholdForm(this.idPrefix);
    }
}