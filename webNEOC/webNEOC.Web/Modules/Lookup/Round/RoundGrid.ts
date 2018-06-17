
namespace webNEOC.Lookup {
    
    @Serenity.Decorators.registerClass()
    export class RoundGrid extends Serenity.EntityGrid<RoundRow, any> {
        protected getColumnsKey() { return 'Lookup.Round'; }
        protected getDialogType() { return RoundDialog; }
        protected getIdProperty() { return RoundRow.idProperty; }
        protected getLocalTextPrefix() { return RoundRow.localTextPrefix; }
        protected getService() { return RoundService.baseUrl; }

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