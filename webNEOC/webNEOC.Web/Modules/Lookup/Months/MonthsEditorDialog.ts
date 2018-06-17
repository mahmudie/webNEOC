
/// <reference path="../../Common/Helpers/GridEditorDialog.ts" />

namespace webNEOC.Lookup {
    
    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class MonthsEditorDialog extends Common.GridEditorDialog<MonthsRow> {
        protected getFormKey() { return MonthsForm.formKey; }
                protected getLocalTextPrefix() { return MonthsRow.localTextPrefix; }
        protected getNameProperty() { return MonthsRow.nameProperty; }
        protected form = new MonthsForm(this.idPrefix);
    }
}