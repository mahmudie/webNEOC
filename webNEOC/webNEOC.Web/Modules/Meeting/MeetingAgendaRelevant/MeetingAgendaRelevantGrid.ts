
namespace webNEOC.Meeting {
    
    @Serenity.Decorators.registerClass()
    export class MeetingAgendaRelevantGrid extends Serenity.EntityGrid<MeetingAgendaRelevantRow, any> {
        protected getColumnsKey() { return 'Meeting.MeetingAgendaRelevant'; }
        protected getDialogType() { return MeetingAgendaRelevantDialog; }
        protected getIdProperty() { return MeetingAgendaRelevantRow.idProperty; }
        protected getLocalTextPrefix() { return MeetingAgendaRelevantRow.localTextPrefix; }
        protected getService() { return MeetingAgendaRelevantService.baseUrl; }

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