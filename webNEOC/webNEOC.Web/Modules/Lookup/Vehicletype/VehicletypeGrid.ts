
namespace webNEOC.Lookup {
    
    @Serenity.Decorators.registerClass()
    export class VehicletypeGrid extends Serenity.EntityGrid<VehicletypeRow, any> {
        protected getColumnsKey() { return 'Lookup.Vehicletype'; }
        protected getDialogType() { return VehicletypeDialog; }
        protected getIdProperty() { return VehicletypeRow.idProperty; }
        protected getLocalTextPrefix() { return VehicletypeRow.localTextPrefix; }
        protected getService() { return VehicletypeService.baseUrl; }

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