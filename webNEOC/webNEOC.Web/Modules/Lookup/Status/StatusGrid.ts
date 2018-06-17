
namespace webNEOC.Lookup {
    
    @Serenity.Decorators.registerClass()
    export class StatusGrid extends Serenity.EntityGrid<StatusRow, any> {
        protected getColumnsKey() { return 'Lookup.Status'; }
        protected getDialogType() { return StatusDialog; }
        protected getIdProperty() { return StatusRow.idProperty; }
        protected getLocalTextPrefix() { return StatusRow.localTextPrefix; }
        protected getService() { return StatusService.baseUrl; }

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