
namespace webNEOC.Implementation {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class IcmHouseholdDialog extends Serenity.EntityDialog<IcmHouseholdRow, any> {
        protected getFormKey() { return IcmHouseholdForm.formKey; }
        protected getIdProperty() { return IcmHouseholdRow.idProperty; }
        protected getLocalTextPrefix() { return IcmHouseholdRow.localTextPrefix; }
        protected getNameProperty() { return IcmHouseholdRow.nameProperty; }
        protected getService() { return IcmHouseholdService.baseUrl; }

        protected form = new IcmHouseholdForm(this.idPrefix);
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