
namespace webNEOC.Lookup {
    
    @Serenity.Decorators.registerClass()
    export class ClusterLevelGrid extends Serenity.EntityGrid<ClusterLevelRow, any> {
        protected getColumnsKey() { return 'Lookup.ClusterLevel'; }
        protected getDialogType() { return ClusterLevelDialog; }
        protected getIdProperty() { return ClusterLevelRow.idProperty; }
        protected getLocalTextPrefix() { return ClusterLevelRow.localTextPrefix; }
        protected getService() { return ClusterLevelService.baseUrl; }

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