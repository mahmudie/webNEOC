
namespace webNEOC.PostCampaign {
    
    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.filterable()
    export class PcmGrid extends Serenity.EntityGrid<PcmRow, any> {
        protected getColumnsKey() { return 'PostCampaign.Pcm'; }
        protected getDialogType() { return PcmDialog; }
        protected getIdProperty() { return PcmRow.idProperty; }
        protected getLocalTextPrefix() { return PcmRow.localTextPrefix; }
        protected getService() { return PcmService.baseUrl; }

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
                    var dialog = new ImportHelper.PcmImportDialog();
                    dialog.element.on('dialogclose', () => {
                        this.refresh();
                        dialog = null;
                    });
                    dialog.dialogOpen();
                }
            });
            buttons.push(Common.ExcelExportHelper.createToolButton({
                grid: this,
                service: PcmService.baseUrl + '/ListExcel',
                onViewSubmit: () => this.onViewSubmit(),
                separator: false,
                hint: "Export",
                title: "Export"
            }));

            if (Authorization.hasPermission("PostCampaign:Pcm:Modify")) {
                buttons.push({
                    title: 'Approve',
                    cssClass: 'approve-button',
                    hint: "Approve the records",
                    onClick: () => {
                        Q.confirm('This will clean all the data in this page. You will not able to undo it. Do you really want to proceed?', () => {
                            Q.serviceRequest(PcmService.baseUrl + '/ApprovePcm', {}, (response) => {
                                window.location.href = Q.resolveUrl('~/Post Campaign/Pcm');
                            });
                        })
                    }
                });
                buttons.splice(Q.indexOf(buttons, x => x.cssClass == "add-button"), 1);
                buttons.splice(Q.indexOf(buttons, x => x.cssClass == "export-xlsx-button"), 1);
                buttons.splice(Q.indexOf(buttons, x => x.cssClass == "export-xlsx-button"), 1);
                buttons.splice(Q.indexOf(buttons, x => x.cssClass == "refresh-button"), 1);
            }
            buttons.splice(Q.indexOf(buttons, x => x.cssClass == "column-picker-button"), 1);
            return buttons;
        }
    }
}