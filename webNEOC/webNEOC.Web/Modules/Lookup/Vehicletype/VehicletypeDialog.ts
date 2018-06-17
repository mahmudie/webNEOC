
namespace webNEOC.Lookup {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class VehicletypeDialog extends Serenity.EntityDialog<VehicletypeRow, any> {
        protected getFormKey() { return VehicletypeForm.formKey; }
        protected getIdProperty() { return VehicletypeRow.idProperty; }
        protected getLocalTextPrefix() { return VehicletypeRow.localTextPrefix; }
        protected getNameProperty() { return VehicletypeRow.nameProperty; }
        protected getService() { return VehicletypeService.baseUrl; }

        protected form = new VehicletypeForm(this.idPrefix);

    }
}