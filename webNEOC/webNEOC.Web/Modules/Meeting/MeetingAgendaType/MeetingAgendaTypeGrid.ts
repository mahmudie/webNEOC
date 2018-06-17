
namespace webNEOC.Meeting {
    
    @Serenity.Decorators.registerClass()
    export class MeetingAgendaTypeGrid extends Serenity.EntityGrid<MeetingAgendaTypeRow, any> {
        protected getColumnsKey() { return 'Meeting.MeetingAgendaType'; }
        protected getDialogType() { return MeetingAgendaTypeDialog; }
        protected getIdProperty() { return MeetingAgendaTypeRow.idProperty; }
        protected getLocalTextPrefix() { return MeetingAgendaTypeRow.localTextPrefix; }
        protected getService() { return MeetingAgendaTypeService.baseUrl; }

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