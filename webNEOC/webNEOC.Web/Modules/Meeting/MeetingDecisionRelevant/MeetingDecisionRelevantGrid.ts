
namespace webNEOC.Meeting {
    
    @Serenity.Decorators.registerClass()
    export class MeetingDecisionRelevantGrid extends Serenity.EntityGrid<MeetingDecisionRelevantRow, any> {
        protected getColumnsKey() { return 'Meeting.MeetingDecisionRelevant'; }
        protected getDialogType() { return MeetingDecisionRelevantDialog; }
        protected getIdProperty() { return MeetingDecisionRelevantRow.idProperty; }
        protected getLocalTextPrefix() { return MeetingDecisionRelevantRow.localTextPrefix; }
        protected getService() { return MeetingDecisionRelevantService.baseUrl; }

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