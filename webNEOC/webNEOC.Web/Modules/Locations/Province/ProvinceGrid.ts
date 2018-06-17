
namespace webNEOC.Locations {
    
    @Serenity.Decorators.registerClass()
    export class ProvinceGrid extends Serenity.EntityGrid<ProvinceRow, any> {
        protected getColumnsKey() { return 'Locations.Province'; }
        protected getDialogType() { return ProvinceDialog; }
        protected getIdProperty() { return ProvinceRow.idProperty; }
        protected getLocalTextPrefix() { return ProvinceRow.localTextPrefix; }
        protected getService() { return ProvinceService.baseUrl; }

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