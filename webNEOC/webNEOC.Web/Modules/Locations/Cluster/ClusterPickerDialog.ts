
namespace webNEOC.Locations {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class ClusterPickerDialog extends Serenity.EntityDialog<ClusterRow, any> {
        protected getFormKey() { return ClusterForm.formKey; }
        protected getIdProperty() { return ClusterRow.idProperty; }
        protected getLocalTextPrefix() { return ClusterRow.localTextPrefix; }
        protected getNameProperty() { return ClusterRow.nameProperty; }
        protected getService() { return ClusterService.baseUrl; }

        protected form = new ClusterForm(this.idPrefix);

        private checkGrid: ClusterCheckGrid;

        constructor() {
            super();

            this.checkGrid = new ClusterCheckGrid(this.byId("CheckGrid"));
            this.dialogTitle = "Select Clusters";
        }

        protected getTemplate() {
            return `<div id="~_CheckGrid"></div>`;
        }

        protected getDialogOptions() {
            var opt = super.getDialogOptions();
            opt.buttons = [
                {
                    text: Q.text("Dialogs.OkButton"),
                    click: () => {
                        var selected = this.checkGrid.selectedItems;
                        if (!selected.length) {
                            Q.notifyWarning("Please select clusters!");
                            return;
                        }

                        if (!this.onSuccess || this.onSuccess(selected))
                            this.dialogClose();
                    }
                },
                {
                    text: Q.text("Dialogs.CancelButton"),
                    click: () => {
                        this.dialogClose();
                    }
                }
            ];
            return opt;
        }

        get selectedItems() {
            return this.checkGrid.selectedItems;
        }
        public onSuccess: (selected: Locations.ClusterRow[]) => boolean;
    }
}