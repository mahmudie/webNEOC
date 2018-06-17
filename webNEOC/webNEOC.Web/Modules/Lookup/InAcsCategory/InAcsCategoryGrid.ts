
namespace webNEOC.Lookup {
    
    @Serenity.Decorators.registerClass()
    export class InAcsCategoryGrid extends Serenity.EntityGrid<InAcsCategoryRow, any> {
        protected getColumnsKey() { return 'Lookup.InAcsCategory'; }
        protected getDialogType() { return InAcsCategoryDialog; }
        protected getIdProperty() { return InAcsCategoryRow.idProperty; }
        protected getLocalTextPrefix() { return InAcsCategoryRow.localTextPrefix; }
        protected getService() { return InAcsCategoryService.baseUrl; }

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