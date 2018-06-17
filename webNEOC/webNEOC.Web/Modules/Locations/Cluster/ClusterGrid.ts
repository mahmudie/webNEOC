
namespace webNEOC.Locations {
    
    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.filterable()
    export class ClusterGrid extends Serenity.EntityGrid<ClusterRow, any> {
        protected getColumnsKey() { return 'Locations.Cluster'; }
        protected getDialogType() { return ClusterDialog; }
        protected getIdProperty() { return ClusterRow.idProperty; }
        protected getLocalTextPrefix() { return ClusterRow.localTextPrefix; }
        protected getService() { return ClusterService.baseUrl; }

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