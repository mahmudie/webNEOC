
namespace webNEOC.Implementation {
    
    @Serenity.Decorators.registerClass()
    export class VitaminAVaccinationsGrid extends Serenity.EntityGrid<VitaminAVaccinationsRow, any> {
        protected getColumnsKey() { return 'Implementation.VitaminAVaccinations'; }
        protected getDialogType() { return VitaminAVaccinationsDialog; }
        protected getIdProperty() { return VitaminAVaccinationsRow.idProperty; }
        protected getLocalTextPrefix() { return VitaminAVaccinationsRow.localTextPrefix; }
        protected getService() { return VitaminAVaccinationsService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }

        protected getButtons() {
            var buttons = super.getButtons();

            //buttons.push({
            //    title: 'Import',
            //    cssClass: 'export-xlsx-button',
            //    onClick: () => {
            //        // open import dialog, let it handle rest
            //        var dialog = new ImportHelper.ICMHouseholdImportDialog();
            //        dialog.element.on('dialogclose', () => {
            //            this.refresh();
            //            dialog = null;
            //        });
            //        dialog.dialogOpen();
            //    }
            //});
            buttons.push(Common.ExcelExportHelper.createToolButton({
                grid: this,
                service: VitaminAVaccinationsService.baseUrl + '/ListExcel',
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