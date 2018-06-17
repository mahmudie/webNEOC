
namespace webNEOC.Implementation {
    
    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.filterable()
    export class IcmSupervisorGrid extends Serenity.EntityGrid<IcmSupervisorRow, any> {
        protected getColumnsKey() { return 'Implementation.IcmSupervisor'; }
        protected getDialogType() { return IcmSupervisorDialog; }
        protected getIdProperty() { return IcmSupervisorRow.idProperty; }
        protected getLocalTextPrefix() { return IcmSupervisorRow.localTextPrefix; }
        protected getService() { return IcmSupervisorService.baseUrl; }

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
                    var dialog = new ImportHelper.ICMSupervisorImportDialog();
                    dialog.element.on('dialogclose', () => {
                        this.refresh();
                        dialog = null;
                    });
                    dialog.dialogOpen();
                }
            });
            buttons.push(Common.ExcelExportHelper.createToolButton({
                grid: this,
                service: IcmSupervisorService.baseUrl + '/ListExcel',
                onViewSubmit: () => this.onViewSubmit(),
                separator: false,
                hint: "Export",
                title: "Export"
            }));

            if (Authorization.hasPermission("Implementation:IcmSupervisor:Modify")) {
                buttons.push({
                    title: 'Approve',
                    cssClass: 'approve-button',
                    hint: "Approve the records",
                    onClick: () => {
                        Q.confirm('This will clean all the data in this page. You will not able to undo it. Do you really want to proceed?', () => {
                            Q.serviceRequest(IcmSupervisorService.baseUrl + '/ApproveIcmSupervisor', {}, (response) => {
                                window.location.href = Q.resolveUrl('~/Implementation/IcmSupervisor');
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