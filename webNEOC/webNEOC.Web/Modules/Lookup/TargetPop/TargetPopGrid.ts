
namespace webNEOC.Lookup {
    
    @Serenity.Decorators.registerClass()
    export class TargetPopGrid extends Serenity.EntityGrid<TargetPopRow, any> {
        protected getColumnsKey() { return 'Lookup.TargetPop'; }
        protected getDialogType() { return TargetPopDialog; }
        protected getIdProperty() { return TargetPopRow.idProperty; }
        protected getLocalTextPrefix() { return TargetPopRow.localTextPrefix; }
        protected getService() { return TargetPopService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }

        protected getButtons() {
            var buttons = super.getButtons();

            buttons.push({
                title: 'Import',
                cssClass: 'export-xlsx-button',
                onClick: () => {
                    // open import dialog, let it handle rest
                    var dialog = new ImportHelper.TargetImportDialog();
                    dialog.element.on('dialogclose', () => {
                        this.refresh();
                        dialog = null;
                    });
                    dialog.dialogOpen();
                }
            });
            buttons.push(Common.ExcelExportHelper.createToolButton({
                grid: this,
                service: TargetPopService.baseUrl + '/ListExcel',
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