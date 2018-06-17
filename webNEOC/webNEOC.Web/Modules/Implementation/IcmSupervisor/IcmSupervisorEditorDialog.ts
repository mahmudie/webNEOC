
/// <reference path="../../Common/Helpers/GridEditorDialog.ts" />

namespace webNEOC.Implementation {
    
    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class IcmSupervisorEditorDialog extends Common.GridEditorDialog<IcmSupervisorRow> {
        protected getFormKey() { return IcmSupervisorForm.formKey; }
                protected getLocalTextPrefix() { return IcmSupervisorRow.localTextPrefix; }
        protected getNameProperty() { return IcmSupervisorRow.nameProperty; }
        protected form = new IcmSupervisorForm(this.idPrefix);
    }
}