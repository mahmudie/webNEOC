namespace webNEOC.ImportGate {
    
    @Serenity.Decorators.registerClass()
    export class TempCampaignGrid extends Serenity.EntityGrid<TempCampaignRow, any> {
        protected getColumnsKey() { return 'ImportGate.TempCampaign'; }
        protected getDialogType() { return TempCampaignDialog; }
        protected getIdProperty() { return TempCampaignRow.idProperty; }
        protected getLocalTextPrefix() { return TempCampaignRow.localTextPrefix; }
        protected getService() { return TempCampaignService.baseUrl; }

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
                    var dialog = new ImportHelper.CampaignImportDialog();
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
                        Q.serviceRequest(TempCampaignService.baseUrl + '/ExecProcedure', {}, (response) => {
                            window.location.href = Q.resolveUrl('~/Implementation/CampaignDay');
                        });
                    })
                }
            });

            buttons.push(Common.ExcelExportHelper.createToolButton({
                grid: this,
                service: TempCampaignService.baseUrl + '/ListExcel',
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