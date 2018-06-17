
/// <reference path="../../Common/Helpers/GridEditorDialog.ts" />

namespace webNEOC.Locations {
    
    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class DistrictEditorDialog extends Common.GridEditorDialog<DistrictRow> {
        protected getFormKey() { return DistrictForm.formKey; }
                protected getLocalTextPrefix() { return DistrictRow.localTextPrefix; }
        protected getNameProperty() { return DistrictRow.nameProperty; }
        protected form = new DistrictForm(this.idPrefix);
    }
}