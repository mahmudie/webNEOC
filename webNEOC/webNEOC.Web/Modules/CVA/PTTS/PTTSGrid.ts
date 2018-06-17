
namespace webNEOC.CVA {
    
    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.filterable()
    export class PTTSGrid extends Serenity.EntityGrid<PTTSRow, any> {
        protected getColumnsKey() { return 'CVA.PTTS'; }
        protected getDialogType() { return PTTSDialog; }
        protected getIdProperty() { return PTTSRow.idProperty; }
        protected getLocalTextPrefix() { return PTTSRow.localTextPrefix; }
        protected getService() { return PTTSService.baseUrl; }

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