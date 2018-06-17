
namespace webNEOC.PostCampaign {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class LQASDialog extends Serenity.EntityDialog<LQASRow, any> {
        protected getFormKey() { return LQASForm.formKey; }
        protected getIdProperty() { return LQASRow.idProperty; }
        protected getLocalTextPrefix() { return LQASRow.localTextPrefix; }
        protected getNameProperty() { return LQASRow.nameProperty; }
        protected getService() { return LQASService.baseUrl; }

        protected form = new LQASForm(this.idPrefix);

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
    }
}