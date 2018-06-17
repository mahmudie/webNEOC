
namespace webNEOC.Preparation {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class MicroplanDialog extends Serenity.EntityDialog<MicroplanRow, any> {
        protected getFormKey() { return MicroplanForm.formKey; }
        protected getIdProperty() { return MicroplanRow.idProperty; }
        protected getLocalTextPrefix() { return MicroplanRow.localTextPrefix; }
        protected getService() { return MicroplanService.baseUrl; }

        protected form = new MicroplanForm(this.idPrefix);
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