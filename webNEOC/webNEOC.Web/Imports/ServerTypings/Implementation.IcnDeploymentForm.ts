namespace webNEOC.Implementation {
    export class IcnDeploymentForm extends Serenity.PrefixedContext {
        static formKey = 'Implementation.Implementation';

    }

    export interface IcnDeploymentForm {
        DistrictId: Serenity.IntegerEditor;
        PlannedIcn: Serenity.IntegerEditor;
        RecruitedIcn: Serenity.IntegerEditor;
        RecruitedMale: Serenity.IntegerEditor;
        RecruitedFemale: Serenity.IntegerEditor;
        IcnTypeId: Serenity.IntegerEditor;
        RecruitmentTypeId: Serenity.IntegerEditor;
        MonthId: Serenity.IntegerEditor;
        Year: Serenity.IntegerEditor;
        TenantId: Serenity.IntegerEditor;
    }

    [['DistrictId', () => Serenity.IntegerEditor], ['PlannedIcn', () => Serenity.IntegerEditor], ['RecruitedIcn', () => Serenity.IntegerEditor], ['RecruitedMale', () => Serenity.IntegerEditor], ['RecruitedFemale', () => Serenity.IntegerEditor], ['IcnTypeId', () => Serenity.IntegerEditor], ['RecruitmentTypeId', () => Serenity.IntegerEditor], ['MonthId', () => Serenity.IntegerEditor], ['Year', () => Serenity.IntegerEditor], ['TenantId', () => Serenity.IntegerEditor]].forEach(x => Object.defineProperty(IcnDeploymentForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

