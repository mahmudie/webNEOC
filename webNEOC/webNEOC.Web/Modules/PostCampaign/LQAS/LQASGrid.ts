
namespace webNEOC.PostCampaign {
    
    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.filterable()
    export class LQASGrid extends Serenity.EntityGrid<LQASRow, any> {
        protected getColumnsKey() { return 'PostCampaign.LQAS'; }
        protected getDialogType() { return LQASDialog; }
        protected getIdProperty() { return LQASRow.idProperty; }
        protected getLocalTextPrefix() { return LQASRow.localTextPrefix; }
        protected getService() { return LQASService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }


        protected addButtonClick() {
            this.editItem(<PostCampaign.LQASRow>{
                PartId: Lookup.PartRow.getLookup().items
                    .filter(x => x.PartName === 'NA')[0].PartId
            });
        }

        protected getButtons() {
            var buttons = super.getButtons();

            buttons.push({
                title: 'Import',
                cssClass: 'export-xlsx-button',
                onClick: () => {
                    // open import dialog, let it handle rest
                    var dialog = new ImportHelper.LQASImportDialog();
                    dialog.element.on('dialogclose', () => {
                        this.refresh();
                        dialog = null;
                    });
                    dialog.dialogOpen();
                }
            });
            buttons.push(Common.ExcelExportHelper.createToolButton({
                grid: this,
                service: LQASService.baseUrl + '/ListExcel',
                onViewSubmit: () => this.onViewSubmit(),
                separator: false,
                hint: "Export",
                title: "Export"
            }));

            if (Authorization.hasPermission("PostCampaign:LQAS:Modify")) {
                buttons.push({
                    title: 'Approve',
                    cssClass: 'approve-button',
                    hint: "Approve the records",
                    onClick: () => {
                        Q.confirm('This will clean all the data in this page. You will not able to undo it. Do you really want to proceed?', () => {
                            Q.serviceRequest(LQASService.baseUrl + '/ApproveLqas', {}, (response) => {
                                window.location.href = Q.resolveUrl('~/Post Campaign/LQAS');
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