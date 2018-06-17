
namespace webNEOC.Implementation {
    @Serenity.Decorators.filterable()
    @Serenity.Decorators.registerClass()
    export class IcnGrid extends Serenity.EntityGrid<IcnRow, any> {
        protected getColumnsKey() { return 'Implementation.Icn'; }
        protected getDialogType() { return IcnDialog; }
        protected getIdProperty() { return IcnRow.idProperty; }
        protected getLocalTextPrefix() { return IcnRow.localTextPrefix; }
        protected getService() { return IcnService.baseUrl; }

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
                    var dialog = new ImportHelper.ICNImportDialog();
                    dialog.element.on('dialogclose', () => {
                        this.refresh();
                        dialog = null;
                    });
                    dialog.dialogOpen();
                }
            });
            buttons.push(Common.ExcelExportHelper.createToolButton({
                grid: this,
                service: IcnService.baseUrl + '/ListExcel',
                onViewSubmit: () => this.onViewSubmit(),
                separator: false,
                hint: "Export",
                title: "Export"
            }));

            if (Authorization.hasPermission("Implementation:Icn:Modify")) {
                buttons.push({
                    title: 'Approve',
                    cssClass: 'approve-button',
                    hint: "Approve the records",
                    onClick: () => {
                        Q.confirm('This will clean all the data in this page. You will not able to undo it. Do you really want to proceed?', () => {
                            Q.serviceRequest(IcnService.baseUrl + '/ApproveICN', {}, (response) => {
                                window.location.href = Q.resolveUrl('~/Implementation/Icn');
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