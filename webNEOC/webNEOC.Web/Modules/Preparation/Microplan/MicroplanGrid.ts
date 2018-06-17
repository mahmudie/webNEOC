
namespace webNEOC.Preparation {
    
    @Serenity.Decorators.registerClass()
    export class MicroplanGrid extends Serenity.EntityGrid<MicroplanRow, any> {
        protected getColumnsKey() { return 'Preparation.Microplan'; }
        protected getDialogType() { return MicroplanDialog; }
        protected getIdProperty() { return MicroplanRow.idProperty; }
        protected getLocalTextPrefix() { return MicroplanRow.localTextPrefix; }
        protected getService() { return MicroplanService.baseUrl; }

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
                service: MicroplanService.baseUrl + '/ListExcel',
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