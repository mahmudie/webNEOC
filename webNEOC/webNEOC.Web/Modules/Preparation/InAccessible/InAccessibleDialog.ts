
namespace webNEOC.Preparation {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class InAccessibleDialog extends Serenity.EntityDialog<InAccessibleRow, any> {
        protected getFormKey() { return InAccessibleForm.formKey; }
        protected getIdProperty() { return InAccessibleRow.idProperty; }
        protected getLocalTextPrefix() { return InAccessibleRow.localTextPrefix; }
        protected getNameProperty() { return InAccessibleRow.nameProperty; }
        protected getService() { return InAccessibleService.baseUrl; }

        protected form = new InAccessibleForm(this.idPrefix);
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