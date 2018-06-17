
namespace webNEOC.ImportGate {
    
    @Serenity.Decorators.registerClass()
    export class TempVitaminAGrid extends Serenity.EntityGrid<TempVitaminARow, any> {
        protected getColumnsKey() { return 'ImportGate.TempVitaminA'; }
        protected getDialogType() { return TempVitaminADialog; }
        protected getIdProperty() { return TempVitaminARow.idProperty; }
        protected getLocalTextPrefix() { return TempVitaminARow.localTextPrefix; }
        protected getService() { return TempVitaminAService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }

        protected getButtons() {
            var buttons = super.getButtons();

            buttons.push({
                title: 'Upload',
                cssClass: 'export-xlsx-button',
                onClick: () => {
                    // open import dialog, let it handle rest
                    var dialog = new ImportHelper.VitaminAImportDialog();
                    dialog.element.on('dialogclose', () => {
                        this.refresh();
                        dialog = null;
                    });
                    dialog.dialogOpen();
                }
            });
            buttons.push({
                title: 'Import',
                cssClass: 'approve-button',
                onClick: () => {
                    Q.confirm('Delete record?', () => {
                        Q.serviceRequest(TempVitaminAService.baseUrl + '/ExecProcedure', {}, (response) => {
                            window.location.href = Q.resolveUrl('~/Implementation/VitaminA');
                        });
                    })
                }
            });

            buttons.push(Common.ExcelExportHelper.createToolButton({
                grid: this,
                service: TempVitaminAService.baseUrl + '/ListExcel',
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