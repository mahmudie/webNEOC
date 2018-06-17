
namespace webNEOC.Lookup {
    
    @Serenity.Decorators.registerClass()
    export class MonthsGrid extends Serenity.EntityGrid<MonthsRow, any> {
        protected getColumnsKey() { return 'Lookup.Months'; }
        protected getDialogType() { return MonthsDialog; }
        protected getIdProperty() { return MonthsRow.idProperty; }
        protected getLocalTextPrefix() { return MonthsRow.localTextPrefix; }
        protected getService() { return MonthsService.baseUrl; }

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