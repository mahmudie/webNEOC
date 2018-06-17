
/// <reference path="../../Common/Helpers/GridEditorDialog.ts" />

namespace webNEOC.Locations {
    
    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class RegionEditorDialog extends Common.GridEditorDialog<RegionRow> {
        protected getFormKey() { return RegionForm.formKey; }
                protected getLocalTextPrefix() { return RegionRow.localTextPrefix; }
        protected getNameProperty() { return RegionRow.nameProperty; }
        protected form = new RegionForm(this.idPrefix);
    }
}