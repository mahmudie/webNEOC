
/// <reference path="../../Common/Helpers/GridEditorBase.ts" />

namespace webNEOC.Implementation {
    
    @Serenity.Decorators.registerClass()
    export class IcmTeamEditor extends Common.GridEditorBase<IcmTeamRow> {
        protected getColumnsKey() { return 'Implementation.IcmTeam'; }
        protected getDialogType() { return IcmTeamEditorDialog; }
                protected getLocalTextPrefix() { return IcmTeamRow.localTextPrefix; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}