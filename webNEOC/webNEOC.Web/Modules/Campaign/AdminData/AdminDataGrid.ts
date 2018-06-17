
namespace webNEOC.Campaign {

    @Serenity.Decorators.registerClass()
    export class AdminDataGrid extends Serenity.EntityGrid<AdminDataRow, any> {
        protected getColumnsKey() { return 'Campaign.AdminData'; }
        protected getDialogType() { return AdminDataDialog; }
        protected getIdProperty() { return AdminDataRow.idProperty; }
        protected getLocalTextPrefix() { return AdminDataRow.localTextPrefix; }
        protected getService() { return AdminDataService.baseUrl; }

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
                    var dialog = new ImportHelper.AdminDataImportDialog();
                    dialog.element.on('dialogclose', () => {
                        this.refresh();
                        dialog = null;
                    });
                    dialog.dialogOpen();
                }
            });
            buttons.push(Common.ExcelExportHelper.createToolButton({
                grid: this,
                service: AdminDataService.baseUrl + '/ListExcel',
                onViewSubmit: () => this.onViewSubmit(),
                separator: false,
                hint: "Export",
                title: "Export"
            }));


            if (Authorization.hasPermission("Campaign:AdminData:Modify")) {
                buttons.push({
                    title: 'Approve',
                    cssClass: 'approve-button',
                    hint: "Approve the records",
                    onClick: () => {
                        Q.confirm('This will clean all the data in this page. You will not able to undo it. Do you really want to proceed?', () => {
                            Q.serviceRequest(AdminDataService.baseUrl + '/ApproveAdminData', {}, (response) => {
                                window.location.href = Q.resolveUrl('~/Campaign/AdminData');
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