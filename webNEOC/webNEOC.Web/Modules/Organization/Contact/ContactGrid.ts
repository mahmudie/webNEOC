
namespace webNEOC.Organization {
    
    @Serenity.Decorators.registerClass()
    export class ContactGrid extends Serenity.EntityGrid<ContactRow, any> {
        protected getColumnsKey() { return 'Organization.Contact'; }
        protected getDialogType() { return ContactDialog; }
        protected getIdProperty() { return ContactRow.idProperty; }
        protected getLocalTextPrefix() { return ContactRow.localTextPrefix; }
        protected getService() { return ContactService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
        protected getButtons(): Serenity.ToolButton[] {
            var buttons = super.getButtons();
            buttons.splice(Q.indexOf(buttons, x => x.cssClass == "column-picker-button"), 1);
            return buttons;
        }
    }
}