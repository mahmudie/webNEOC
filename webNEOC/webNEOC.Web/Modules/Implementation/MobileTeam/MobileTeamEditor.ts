
/// <reference path="../../Common/Helpers/GridEditorBase.ts" />

namespace webNEOC.Implementation {
    
    @Serenity.Decorators.registerClass()
    export class MobileTeamEditor extends Common.GridEditorBase<MobileTeamRow> {
        protected getColumnsKey() { return 'Implementation.MobileTeam'; }
        protected getDialogType() { return MobileTeamEditorDialog; }
                protected getLocalTextPrefix() { return MobileTeamRow.localTextPrefix; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}