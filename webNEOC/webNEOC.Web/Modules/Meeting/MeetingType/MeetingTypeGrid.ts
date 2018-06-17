
namespace webNEOC.Meeting {
    
    @Serenity.Decorators.registerClass()
    export class MeetingTypeGrid extends Serenity.EntityGrid<MeetingTypeRow, any> {
        protected getColumnsKey() { return 'Meeting.MeetingType'; }
        protected getDialogType() { return MeetingTypeDialog; }
        protected getIdProperty() { return MeetingTypeRow.idProperty; }
        protected getLocalTextPrefix() { return MeetingTypeRow.localTextPrefix; }
        protected getService() { return MeetingTypeService.baseUrl; }

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