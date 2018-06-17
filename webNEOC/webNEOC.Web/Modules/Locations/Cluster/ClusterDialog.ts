
namespace webNEOC.Locations {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class ClusterDialog extends Serenity.EntityDialog<ClusterRow, any> {
        protected getFormKey() { return ClusterForm.formKey; }
        protected getIdProperty() { return ClusterRow.idProperty; }
        protected getLocalTextPrefix() { return ClusterRow.localTextPrefix; }
        protected getNameProperty() { return ClusterRow.nameProperty; }
        protected getService() { return ClusterService.baseUrl; }

        protected form = new ClusterForm(this.idPrefix);
    }
}