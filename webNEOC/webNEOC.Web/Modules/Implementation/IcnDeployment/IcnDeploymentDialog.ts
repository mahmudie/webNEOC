
namespace webNEOC.Implementation {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class IcnDeploymentDialog extends Serenity.EntityDialog<IcnDeploymentRow, any> {
        protected getFormKey() { return IcnDeploymentForm.formKey; }
        protected getIdProperty() { return IcnDeploymentRow.idProperty; }
        protected getLocalTextPrefix() { return IcnDeploymentRow.localTextPrefix; }
        protected getService() { return IcnDeploymentService.baseUrl; }

        protected form = new IcnDeploymentForm(this.idPrefix);

    }
}