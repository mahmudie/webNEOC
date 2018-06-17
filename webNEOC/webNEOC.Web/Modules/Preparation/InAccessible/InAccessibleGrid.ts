
namespace webNEOC.Preparation {
    
    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.filterable()
    export class InAccessibleGrid extends Serenity.EntityGrid<InAccessibleRow, any> {
        protected getColumnsKey() { return 'Preparation.InAccessible'; }
        protected getDialogType() { return InAccessibleDialog; }
        protected getIdProperty() { return InAccessibleRow.idProperty; }
        protected getLocalTextPrefix() { return InAccessibleRow.localTextPrefix; }
        protected getService() { return InAccessibleService.baseUrl; }

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
                    var dialog = new ImportHelper.InAccessibleImportDialog();
                    dialog.element.on('dialogclose', () => {
                        this.refresh();
                        dialog = null;
                    });
                    dialog.dialogOpen();
                }
            });
            buttons.push(Common.ExcelExportHelper.createToolButton({
                grid: this,
                service: InAccessibleService.baseUrl + '/ListExcel',
                onViewSubmit: () => this.onViewSubmit(),
                separator: false,
                hint: "Export",
                title: "Export"
            }));

            if (Authorization.hasPermission("Preparation:InAccessible:Modify")) {
                buttons.push({
                    title: 'Approve',
                    cssClass: 'approve-button',
                    hint: "Approve the records",
                    onClick: () => {
                        Q.confirm('This will clean all the data in this page. You will not able to undo it. Do you really want to proceed?', () => {
                            Q.serviceRequest(InAccessibleService.baseUrl + '/ApproveInAccessible', {}, (response) => {
                                window.location.href = Q.resolveUrl('~/Preparation/InAccessible');
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