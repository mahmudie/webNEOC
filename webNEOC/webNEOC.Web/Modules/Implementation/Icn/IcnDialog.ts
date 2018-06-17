
namespace webNEOC.Implementation {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class IcnDialog extends Serenity.EntityDialog<IcnRow, any> {
        protected getFormKey() { return IcnForm.formKey; }
        protected getIdProperty() { return IcnRow.idProperty; }
        protected getLocalTextPrefix() { return IcnRow.localTextPrefix; }
        protected getNameProperty() { return IcnRow.nameProperty; }
        protected getService() { return IcnService.baseUrl; }

        protected form = new IcnForm(this.idPrefix);

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