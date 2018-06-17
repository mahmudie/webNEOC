
namespace webNEOC.Implementation {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    @Serenity.Decorators.panel()
    export class MobileTeamDialog extends Serenity.EntityDialog<MobileTeamRow, any> {
        protected getFormKey() { return MobileTeamForm.formKey; }
        protected getIdProperty() { return MobileTeamRow.idProperty; }
        protected getLocalTextPrefix() { return MobileTeamRow.localTextPrefix; }
        protected getService() { return MobileTeamService.baseUrl; }

        protected form = new MobileTeamForm(this.idPrefix);

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