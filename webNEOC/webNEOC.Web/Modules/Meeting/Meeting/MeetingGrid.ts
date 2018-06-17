
namespace webNEOC.Meeting {
    
    @Serenity.Decorators.registerClass()
    export class MeetingGrid extends Serenity.EntityGrid<MeetingRow, any> {
        protected getColumnsKey() { return 'Meeting.Meeting'; }
        protected getDialogType() { return MeetingDialog; }
        protected getIdProperty() { return MeetingRow.idProperty; }
        protected getLocalTextPrefix() { return MeetingRow.localTextPrefix; }
        protected getService() { return MeetingService.baseUrl; }

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