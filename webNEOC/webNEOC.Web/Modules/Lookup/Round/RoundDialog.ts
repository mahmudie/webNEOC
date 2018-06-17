
namespace webNEOC.Lookup {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    @Serenity.Decorators.maximizable()
    export class RoundDialog extends Serenity.EntityDialog<RoundRow, any> {
        protected getFormKey() { return RoundForm.formKey; }
        protected getIdProperty() { return RoundRow.idProperty; }
        protected getLocalTextPrefix() { return RoundRow.localTextPrefix; }
        protected getNameProperty() { return RoundRow.nameProperty; }
        protected getService() { return RoundService.baseUrl; }

        protected form = new RoundForm(this.idPrefix);

        //dialogOpen() {
        //            super.dialogOpen();
        //           this.element.closest(".ui-dialog").find(".ui-icon-minimize-window").click();
        //         }
    }
}