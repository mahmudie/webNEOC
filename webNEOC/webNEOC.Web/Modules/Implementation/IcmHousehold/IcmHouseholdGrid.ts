
namespace webNEOC.Implementation {
    
    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.filterable()
    export class IcmHouseholdGrid extends Serenity.EntityGrid<IcmHouseholdRow, any> {
        protected getColumnsKey() { return 'Implementation.IcmHousehold'; }
        protected getDialogType() { return IcmHouseholdDialog; }
        protected getIdProperty() { return IcmHouseholdRow.idProperty; }
        protected getLocalTextPrefix() { return IcmHouseholdRow.localTextPrefix; }
        protected getService() { return IcmHouseholdService.baseUrl; }

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
                    var dialog = new ImportHelper.ICMHouseholdImportDialog();
                    dialog.element.on('dialogclose', () => {
                        this.refresh();
                        dialog = null;
                    });
                    dialog.dialogOpen();
                }
            });
            buttons.push(Common.ExcelExportHelper.createToolButton({
                grid: this,
                service: IcmHouseholdService.baseUrl + '/ListExcel',
                onViewSubmit: () => this.onViewSubmit(),
                separator: false,
                hint: "Export",
                title: "Export"
            }));
            if (Authorization.hasPermission("Implementation:IcmHousehold:Modify")) {
                buttons.push({
                    title: 'Approve',
                    cssClass: 'approve-button',
                    hint: "Approve the records",
                    onClick: () => {
                        Q.confirm('This will clean all the data in this page. You will not able to undo it. Do you really want to proceed?', () => {
                            Q.serviceRequest(IcmHouseholdService.baseUrl + '/ApproveICMHousehold', {}, (response) => {
                                window.location.href = Q.resolveUrl('~/Implementation/IcmHousehold');
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