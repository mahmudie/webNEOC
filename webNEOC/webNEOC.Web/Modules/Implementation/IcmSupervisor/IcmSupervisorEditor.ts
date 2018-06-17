
/// <reference path="../../Common/Helpers/GridEditorBase.ts" />

namespace webNEOC.Implementation {
    
    @Serenity.Decorators.registerClass()
    export class IcmSupervisorEditor extends Common.GridEditorBase<IcmSupervisorRow> {
        protected getColumnsKey() { return 'Implementation.IcmSupervisor'; }
        protected getDialogType() { return IcmSupervisorEditorDialog; }
                protected getLocalTextPrefix() { return IcmSupervisorRow.localTextPrefix; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}