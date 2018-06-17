namespace webNEOC.PostCampaign {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class PcmDialog extends Serenity.EntityDialog<PcmRow, any> {
        protected getFormKey() { return PcmForm.formKey; }
        protected getIdProperty() { return PcmRow.idProperty; }
        protected getLocalTextPrefix() { return PcmRow.localTextPrefix; }
        protected getNameProperty() { return PcmRow.nameProperty; }
        protected getService() { return PcmService.baseUrl; }

        protected form = new PcmForm(this.idPrefix);

       constructor() {
           super();

            this.form.RoundId.changeSelect2(e => {
                var roundId = this.form.RoundId.value;
                if (roundId == null || roundId == undefined) {
                    this.setDateDetails({});
                    return;
                }
                ///var id = Q.first(Lookup.RoundRow.getLookup().items, x => x.RoundId == roundId).RoundId;
                var id = Serenity.EditorUtils.getValue(this.form.RoundId)

                webNEOC.Lookup.RoundService.Retrieve({
                    EntityId: id
                }, response => {
                    this.setDateDetails(response.Entity);
                    //Serenity.EditorUtils.setValue(this.form.T059m, 2999);
                    //Serenity.EditorUtils.setValue(this.form.V059m, 20001);
                });
            });
        }

        private setDateDetails(details: webNEOC.Lookup.RoundRow) {
            this.form.DateFrom.value = details.DateFrom;
            this.form.DateTo.value = details.DateTo;
        }
    }
}