namespace webNEOC.Implementation {
    export class IcmSupervisorForm extends Serenity.PrefixedContext {
        static formKey = 'Implementation.IcmSupervisor';

    }

    export interface IcmSupervisorForm {
        RoundId: Serenity.LookupEditor;
        DateFrom: Serenity.DateEditor;
        DateTo: Serenity.DateEditor;
        ProvinceId: Serenity.LookupEditor;
        DistrictId: Serenity.LookupEditor;
        PartId: Serenity.LookupEditor;
        ClusterId: Serenity.LookupEditor;
        ReportDate: Serenity.DateEditor;
        Supervisor: Serenity.StringEditor;
        MonitorName: Serenity.StringEditor;
        IsSuperResidentOfArea: Serenity.BooleanEditor;
        IsSuperTrained: Serenity.BooleanEditor;
        IsSuperCarryOpv: Serenity.BooleanEditor;
        IsSuperHasClearMap: Serenity.BooleanEditor;
        IsSuperFillingHhChecklist: Serenity.BooleanEditor;
        IsTransProviddToSuper: Serenity.BooleanEditor;
        VehicletypeId: Serenity.LookupEditor;
    }

    [['RoundId', () => Serenity.LookupEditor], ['DateFrom', () => Serenity.DateEditor], ['DateTo', () => Serenity.DateEditor], ['ProvinceId', () => Serenity.LookupEditor], ['DistrictId', () => Serenity.LookupEditor], ['PartId', () => Serenity.LookupEditor], ['ClusterId', () => Serenity.LookupEditor], ['ReportDate', () => Serenity.DateEditor], ['Supervisor', () => Serenity.StringEditor], ['MonitorName', () => Serenity.StringEditor], ['IsSuperResidentOfArea', () => Serenity.BooleanEditor], ['IsSuperTrained', () => Serenity.BooleanEditor], ['IsSuperCarryOpv', () => Serenity.BooleanEditor], ['IsSuperHasClearMap', () => Serenity.BooleanEditor], ['IsSuperFillingHhChecklist', () => Serenity.BooleanEditor], ['IsTransProviddToSuper', () => Serenity.BooleanEditor], ['VehicletypeId', () => Serenity.LookupEditor]].forEach(x => Object.defineProperty(IcmSupervisorForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

