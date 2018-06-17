
namespace webNEOC.Locations {
    
    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.filterable()
    export class DistrictGrid extends Serenity.EntityGrid<DistrictRow, any> {
        protected getColumnsKey() { return 'Locations.District'; }
        protected getDialogType() { return DistrictDialog; }
        protected getIdProperty() { return DistrictRow.idProperty; }
        protected getLocalTextPrefix() { return DistrictRow.localTextPrefix; }
        protected getService() { return DistrictService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }


        protected getButtons() {
            var buttons = super.getButtons();
            buttons.push(Common.ExcelExportHelper.createToolButton({
                grid: this,
                service: DistrictService.baseUrl + '/ListExcel',
                onViewSubmit: () => this.onViewSubmit(),
                separator: false,
                hint: "Export",
                title: "Export"
            }));
            buttons.splice(Q.indexOf(buttons, x => x.cssClass == "column-picker-button"), 1);
            return buttons;
        }
    }
}