
/// <reference path="../../Common/Helpers/GridEditorBase.ts" />

namespace webNEOC.Implementation {
    
    @Serenity.Decorators.registerClass()
    export class IcmHouseholdEditor extends Common.GridEditorBase<IcmHouseholdRow> {
        protected getColumnsKey() { return 'Implementation.IcmHousehold'; }
        protected getDialogType() { return IcmHouseholdEditorDialog; }
                protected getLocalTextPrefix() { return IcmHouseholdRow.localTextPrefix; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}