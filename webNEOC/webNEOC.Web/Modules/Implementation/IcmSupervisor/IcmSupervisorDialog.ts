
namespace webNEOC.Implementation {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class IcmSupervisorDialog extends Serenity.EntityDialog<IcmSupervisorRow, any> {
        protected getFormKey() { return IcmSupervisorForm.formKey; }
        protected getIdProperty() { return IcmSupervisorRow.idProperty; }
        protected getLocalTextPrefix() { return IcmSupervisorRow.localTextPrefix; }
        protected getNameProperty() { return IcmSupervisorRow.nameProperty; }
        protected getService() { return IcmSupervisorService.baseUrl; }

        protected form = new IcmSupervisorForm(this.idPrefix);

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