
namespace webNEOC.Implementation {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class IcmTeamDialog extends Serenity.EntityDialog<IcmTeamRow, any> {
        protected getFormKey() { return IcmTeamForm.formKey; }
        protected getIdProperty() { return IcmTeamRow.idProperty; }
        protected getLocalTextPrefix() { return IcmTeamRow.localTextPrefix; }
        protected getNameProperty() { return IcmTeamRow.nameProperty; }
        protected getService() { return IcmTeamService.baseUrl; }

        protected form = new IcmTeamForm(this.idPrefix);

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