namespace webNEOC.Implementation {
    export class IcnForm extends Serenity.PrefixedContext {
        static formKey = 'Implementation.Icn';

    }

    export interface IcnForm {
        RoundId: Serenity.LookupEditor;
        DateFrom: Serenity.DateEditor;
        DateTo: Serenity.DateEditor;
        ProvinceId: Serenity.LookupEditor;
        DistrictId: Serenity.LookupEditor;
        ClusterId: Serenity.LookupEditor;
        Area: Serenity.StringEditor;
        RegAbsent: Serenity.IntegerEditor;
        VacAbsent: Serenity.IntegerEditor;
        RegNss: Serenity.IntegerEditor;
        VacNss: Serenity.IntegerEditor;
        RegRefusal: Serenity.IntegerEditor;
        VacRefusal: Serenity.IntegerEditor;
        RegUnrecorded: Serenity.IntegerEditor;
        VacUnrecorded: Serenity.IntegerEditor;
    }

    [['RoundId', () => Serenity.LookupEditor], ['DateFrom', () => Serenity.DateEditor], ['DateTo', () => Serenity.DateEditor], ['ProvinceId', () => Serenity.LookupEditor], ['DistrictId', () => Serenity.LookupEditor], ['ClusterId', () => Serenity.LookupEditor], ['Area', () => Serenity.StringEditor], ['RegAbsent', () => Serenity.IntegerEditor], ['VacAbsent', () => Serenity.IntegerEditor], ['RegNss', () => Serenity.IntegerEditor], ['VacNss', () => Serenity.IntegerEditor], ['RegRefusal', () => Serenity.IntegerEditor], ['VacRefusal', () => Serenity.IntegerEditor], ['RegUnrecorded', () => Serenity.IntegerEditor], ['VacUnrecorded', () => Serenity.IntegerEditor]].forEach(x => Object.defineProperty(IcnForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

