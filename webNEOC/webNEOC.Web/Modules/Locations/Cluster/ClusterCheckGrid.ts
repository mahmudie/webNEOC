
/// <reference path="clustergrid.ts" />

namespace webNEOC.Locations {

    @Serenity.Decorators.registerClass()
    export class ClusterCheckGrid extends Serenity.EntityGrid<Locations.ClusterRow, any> {

        protected getColumnsKey() { return "Locations.Cluster"; }
        protected getDialogType() { return <any>Locations.ClusterDialog; }
        protected getIdProperty() { return Locations.ClusterRow.idProperty; }
        protected getLocalTextPrefix() { return Locations.ClusterRow.localTextPrefix; }
        protected getService() { return Locations.ClusterService.baseUrl; }

        private rowSelection: Serenity.GridRowSelectionMixin;

        constructor(container: JQuery) {
            super(container);

            this.rowSelection = new Serenity.GridRowSelectionMixin(this);
        }

        protected getColumns() {
            var columns = super.getColumns();
            columns.splice(0, 0, Serenity.GridRowSelectionMixin.createSelectColumn(() => this.rowSelection));
            return columns;
        }

        protected usePager() {
            return false;
        }

        protected getInitialTitle() {
            return null;
        }

        protected getButtons() {
            var buttons = super.getButtons();
            buttons = buttons.filter(x => x.cssClass != 'add-button');
            return buttons;
        }

        get selectedItems() {
            return this.rowSelection.getSelectedAsInt32().map(x => this.view.getItemById(x));
        }
    }
}