
namespace webNEOC.Campaign {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    @Serenity.Decorators.maximizable()
    export class DailyVaccinationsDialog extends Serenity.EntityDialog<DailyVaccinationsRow, any> {
        protected getFormKey() { return DailyVaccinationsForm.formKey; }
        protected getIdProperty() { return DailyVaccinationsRow.idProperty; }
        protected getLocalTextPrefix() { return DailyVaccinationsRow.localTextPrefix; }
        protected getService() { return DailyVaccinationsService.baseUrl; }

        protected form = new DailyVaccinationsForm(this.idPrefix);

        dialogOpen() {
            super.dialogOpen();
            this.element.closest(".ui-dialog").find(".ui-icon-maximize-window").click();
        }
    }
}