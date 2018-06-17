
/// <reference path="../../Common/Helpers/GridEditorDialog.ts" />

namespace webNEOC.Locations {
    
    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class ProvinceEditorDialog extends Common.GridEditorDialog<ProvinceRow> {
        protected getFormKey() { return ProvinceForm.formKey; }
                protected getLocalTextPrefix() { return ProvinceRow.localTextPrefix; }
        protected getNameProperty() { return ProvinceRow.nameProperty; }
        protected form = new ProvinceForm(this.idPrefix);
    }
}