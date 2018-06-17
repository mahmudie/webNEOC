
namespace webNEOC.PostCampaign {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class OutOfHouseSurveyDialog extends Serenity.EntityDialog<OutOfHouseSurveyRow, any> {
        protected getFormKey() { return OutOfHouseSurveyForm.formKey; }
        protected getIdProperty() { return OutOfHouseSurveyRow.idProperty; }
        protected getLocalTextPrefix() { return OutOfHouseSurveyRow.localTextPrefix; }
        protected getService() { return OutOfHouseSurveyService.baseUrl; }

        protected form = new OutOfHouseSurveyForm(this.idPrefix);

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