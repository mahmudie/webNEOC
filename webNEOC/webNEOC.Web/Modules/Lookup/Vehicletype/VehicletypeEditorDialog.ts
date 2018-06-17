
/// <reference path="../../Common/Helpers/GridEditorDialog.ts" />

namespace webNEOC.Lookup {
    
    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class VehicletypeEditorDialog extends Common.GridEditorDialog<VehicletypeRow> {
        protected getFormKey() { return VehicletypeForm.formKey; }
                protected getLocalTextPrefix() { return VehicletypeRow.localTextPrefix; }
        protected getNameProperty() { return VehicletypeRow.nameProperty; }
        protected form = new VehicletypeForm(this.idPrefix);
    }
}