
namespace webNEOC.Locations {
    
    @Serenity.Decorators.registerClass()
    export class RegionGrid extends Serenity.EntityGrid<RegionRow, any> {
        protected getColumnsKey() { return 'Locations.Region'; }
        protected getDialogType() { return RegionDialog; }
        protected getIdProperty() { return RegionRow.idProperty; }
        protected getLocalTextPrefix() { return RegionRow.localTextPrefix; }
        protected getService() { return RegionService.baseUrl; }

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