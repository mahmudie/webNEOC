
/// <reference path="../../Common/Helpers/GridEditorDialog.ts" />

namespace webNEOC.Implementation {
    
    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class VitaminAVaccinationsEditorDialog extends Common.GridEditorDialog<VitaminAVaccinationsRow> {
        protected getFormKey() { return VitaminAVaccinationsForm.formKey; }
                protected getLocalTextPrefix() { return VitaminAVaccinationsRow.localTextPrefix; }
        protected form = new VitaminAVaccinationsForm(this.idPrefix);
    }
}