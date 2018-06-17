
namespace webNEOC.Implementation {
    
    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.filterable()
    export class VitaminAGrid extends Serenity.EntityGrid<VitaminARow, any> {
        protected getColumnsKey() { return 'Implementation.VitaminA'; }
        protected getDialogType() { return VitaminADialog; }
        protected getIdProperty() { return VitaminARow.idProperty; }
        protected getLocalTextPrefix() { return VitaminARow.localTextPrefix; }
        protected getService() { return VitaminAService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }


        protected getButtons() {
            var buttons = super.getButtons();

            buttons.push({
                title: 'Import Dialog',
                cssClass: 'export-xlsx-button',
                onClick: () => {
                    // open import dialog, let it handle rest
                    window.location.href = Q.resolveUrl('~/ImportGate/TempVitaminA');
                }
            });

            if (Authorization.hasPermission("Implementation:VitaminA:Modify")) {
                buttons.push({
                    title: 'Approve',
                    cssClass: 'approve-button',
                    hint: "Approve the records",
                    onClick: () => {
                        Q.confirm('This will clean all the data in this page. You will not able to undo it. Do you really want to proceed?', () => {
                            Q.serviceRequest(VitaminAService.baseUrl + '/ApproveVitaminA', {}, (response) => {
                                window.location.href = Q.resolveUrl('~/Implementation/VitaminA');
                            });
                        })
                    }
                });
                buttons.splice(Q.indexOf(buttons, x => x.cssClass == "add-button"), 1);
                buttons.splice(Q.indexOf(buttons, x => x.cssClass == "refresh-button"), 1);
                buttons.splice(Q.indexOf(buttons, x => x.cssClass == "export-xlsx-button"), 1);
            }
            buttons.splice(Q.indexOf(buttons, x => x.cssClass == "column-picker-button"), 1);
            return buttons;
        }
    }
}