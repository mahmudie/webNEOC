
namespace webNEOC.Implementation {
    
    @Serenity.Decorators.registerClass()
    export class MobileTeamGrid extends Serenity.EntityGrid<MobileTeamRow, any> {
        protected getColumnsKey() { return 'Implementation.MobileTeam'; }
        protected getDialogType() { return MobileTeamDialog; }
        protected getIdProperty() { return MobileTeamRow.idProperty; }
        protected getLocalTextPrefix() { return MobileTeamRow.localTextPrefix; }
        protected getService() { return MobileTeamService.baseUrl; }

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
                    var dialog = new ImportHelper.MobileTeamImportDialog();
                    dialog.element.on('dialogclose', () => {
                        this.refresh();
                        dialog = null;
                    });
                    dialog.dialogOpen();
                }
            });
            buttons.push(Common.ExcelExportHelper.createToolButton({
                grid: this,
                service: MobileTeamService.baseUrl + '/ListExcel',
                onViewSubmit: () => this.onViewSubmit(),
                separator: false,
                hint: "Export",
                title: "Export"
            }));
            buttons.splice(Q.indexOf(buttons, x => x.cssClass == "column-picker-button"), 1);

            // *** Only add bulk operation button if Superuser or higher ***
            if (Authorization.hasPermission("Implementation:MobileTeam:Modify")) {
                buttons.push({
                    title: 'Approve',
                    cssClass: 'approve-button',
                    hint: "Approve the records",
                    onClick: () => {
                        Q.confirm('This will clean all the data in this page. You will not able to undo it. Do you really want to proceed?', () => {
                            Q.serviceRequest(MobileTeamService.baseUrl + '/ApproveMobileTeam', {}, (response) => {
                                window.location.href = Q.resolveUrl('~/Implementation/MobileTeam');
                            });
                        })
                    }
                });
                buttons.splice(Q.indexOf(buttons, x => x.cssClass == "add-button"), 1);
                buttons.splice(Q.indexOf(buttons, x => x.cssClass == "export-xlsx-button"), 1);
                buttons.splice(Q.indexOf(buttons, x => x.cssClass == "export-xlsx-button"), 1);
                buttons.splice(Q.indexOf(buttons, x => x.cssClass == "refresh-button"), 1);
            }   // *** End Authorize permissions ***
            return buttons;
        }
    }
}