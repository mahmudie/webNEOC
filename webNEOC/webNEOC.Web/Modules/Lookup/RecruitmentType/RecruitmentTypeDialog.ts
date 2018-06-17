
namespace webNEOC.Lookup {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class RecruitmentTypeDialog extends Serenity.EntityDialog<RecruitmentTypeRow, any> {
        protected getFormKey() { return RecruitmentTypeForm.formKey; }
        protected getIdProperty() { return RecruitmentTypeRow.idProperty; }
        protected getLocalTextPrefix() { return RecruitmentTypeRow.localTextPrefix; }
        protected getNameProperty() { return RecruitmentTypeRow.nameProperty; }
        protected getService() { return RecruitmentTypeService.baseUrl; }

        protected form = new RecruitmentTypeForm(this.idPrefix);

    }
}