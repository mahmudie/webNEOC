
namespace webNEOC.Implementation {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class VitaminAVaccinationsDialog extends Serenity.EntityDialog<VitaminAVaccinationsRow, any> {
        protected getFormKey() { return VitaminAVaccinationsForm.formKey; }
        protected getIdProperty() { return VitaminAVaccinationsRow.idProperty; }
        protected getLocalTextPrefix() { return VitaminAVaccinationsRow.localTextPrefix; }
        protected getService() { return VitaminAVaccinationsService.baseUrl; }

        protected form = new VitaminAVaccinationsForm(this.idPrefix);

    }
}