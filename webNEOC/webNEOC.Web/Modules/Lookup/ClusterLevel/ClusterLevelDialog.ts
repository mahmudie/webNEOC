
namespace webNEOC.Lookup {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    @Serenity.Decorators.maximizable()
    export class ClusterLevelDialog extends Serenity.EntityDialog<ClusterLevelRow, any> {
        protected getFormKey() { return ClusterLevelForm.formKey; }
        protected getIdProperty() { return ClusterLevelRow.idProperty; }
        protected getLocalTextPrefix() { return ClusterLevelRow.localTextPrefix; }
        protected getNameProperty() { return ClusterLevelRow.nameProperty; }
        protected getService() { return ClusterLevelService.baseUrl; }

        protected form = new ClusterLevelForm(this.idPrefix);

        dialogOpen() {
                    super.dialogOpen();
                   this.element.closest(".ui-dialog").find(".ui-icon-maximize-window").click();
                 }
    }
}