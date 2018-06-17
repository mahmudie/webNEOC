
namespace webNEOC.Locations {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class DistrictDialog extends Serenity.EntityDialog<DistrictRow, any> {
        protected getFormKey() { return DistrictForm.formKey; }
        protected getIdProperty() { return DistrictRow.idProperty; }
        protected getLocalTextPrefix() { return DistrictRow.localTextPrefix; }
        protected getNameProperty() { return DistrictRow.nameProperty; }
        protected getService() { return DistrictService.baseUrl; }

        protected form = new DistrictForm(this.idPrefix);

    }
}