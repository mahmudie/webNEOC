
namespace webNEOC.Lookup {

    @Serenity.Decorators.registerClass()
    export class RecruitmentTypeGrid extends Serenity.EntityGrid<RecruitmentTypeRow, any> {
        protected getColumnsKey() { return 'Lookup.RecruitmentType'; }
        protected getDialogType() { return RecruitmentTypeDialog; }
        protected getIdProperty() { return RecruitmentTypeRow.idProperty; }
        protected getLocalTextPrefix() { return RecruitmentTypeRow.localTextPrefix; }
        protected getService() { return RecruitmentTypeService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}