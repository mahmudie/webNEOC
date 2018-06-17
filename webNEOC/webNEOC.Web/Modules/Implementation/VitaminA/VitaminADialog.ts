
namespace webNEOC.Implementation {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    @Serenity.Decorators.maximizable()
    @Serenity.Decorators.panel()
    export class VitaminADialog extends Serenity.EntityDialog<VitaminARow, any> {
        protected getFormKey() { return VitaminAForm.formKey; }
        protected getIdProperty() { return VitaminARow.idProperty; }
        protected getLocalTextPrefix() { return VitaminARow.localTextPrefix; }
        protected getNameProperty() { return VitaminARow.nameProperty; }
        protected getService() { return VitaminAService.baseUrl; }

        protected form = new VitaminAForm(this.idPrefix);

        constructor() {
            super();

            this.form.RoundId.changeSelect2(e => {
                var roundId = this.form.RoundId.value;
                if (roundId == null || roundId == undefined) {
                    this.setDateDetails({});
                    return;
                }
                var id = Serenity.EditorUtils.getValue(this.form.RoundId)

                webNEOC.Lookup.RoundService.Retrieve({
                    EntityId: id
                }, response => {
                    this.setDateDetails(response.Entity);
                });
            });
        }

        private setDateDetails(details: webNEOC.Lookup.RoundRow) {
            this.form.DateFrom.value = details.DateFrom;
            this.form.DateTo.value = details.DateTo;
        }
        dialogOpen() {
            super.dialogOpen();
            this.element.closest(".ui-dialog").find(".ui-icon-maximize-window").click();
        }
    }
}