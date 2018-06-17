
namespace webNEOC.Lookup {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class IcnTypeDialog extends Serenity.EntityDialog<IcnTypeRow, any> {
        protected getFormKey() { return IcnTypeForm.formKey; }
        protected getIdProperty() { return IcnTypeRow.idProperty; }
        protected getLocalTextPrefix() { return IcnTypeRow.localTextPrefix; }
        protected getNameProperty() { return IcnTypeRow.nameProperty; }
        protected getService() { return IcnTypeService.baseUrl; }

        protected form = new IcnTypeForm(this.idPrefix);

    }
}