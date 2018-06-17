
namespace webNEOC.Lookup {
    
    @Serenity.Decorators.registerClass()
    export class PartGrid extends Serenity.EntityGrid<PartRow, any> {
        protected getColumnsKey() { return 'Lookup.Part'; }
        protected getDialogType() { return PartDialog; }
        protected getIdProperty() { return PartRow.idProperty; }
        protected getLocalTextPrefix() { return PartRow.localTextPrefix; }
        protected getService() { return PartService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
        protected getButtons(): Serenity.ToolButton[] {
            var buttons = super.getButtons();
            buttons.splice(Q.indexOf(buttons, x => x.cssClass == "column-picker-button"), 1);
            return buttons;
        }
    }
}