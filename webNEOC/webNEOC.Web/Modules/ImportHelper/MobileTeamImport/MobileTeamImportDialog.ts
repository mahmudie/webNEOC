
namespace webNEOC.ImportHelper {
    
    @Serenity.Decorators.registerClass()
    export class MobileTeamImportDialog extends Serenity.PropertyDialog<any, any> {

        private form: MobileTeamImportForm;

        constructor() {
            super();

            this.form = new MobileTeamImportForm(this.idPrefix);
        }

        protected getDialogTitle(): string {
            return "Excel Import";
        }

        protected getDialogButtons(): Serenity.DialogButton[] {
            return [
                {
                    text: 'Import',
                    click: () => {
                        if (!this.validateBeforeSave())
                            return;

                        if (this.form.FileName.value == null ||
                            Q.isEmptyOrNull(this.form.FileName.value.Filename)) {
                            Q.notifyError("Please select a file!");
                            return;
                        }

                        MobileTeamImportService.ExcelImport({
                            FileName: this.form.FileName.value.Filename
                        }, response => {
                            Q.notifyInfo(
                                'Inserted: ' + (response.Inserted || 0) +
                                ', Updated: ' + (response.Updated || 0));

                            if (response.ErrorList != null && response.ErrorList.length > 0) {
                                Q.notifyError(response.ErrorList.join(',\r\n '));
                            }

                            this.dialogClose();
                        });
                    },
                },
                {
                    text: 'Cancel',
                    click: () => this.dialogClose()
                }
            ];
        }
    }
}