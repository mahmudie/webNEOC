namespace webNEOC.ImportGate {
    export class TempVitaminAForm extends Serenity.PrefixedContext {
        static formKey = 'ImportGate.TempVitaminA';

    }

    export interface TempVitaminAForm {
        RoundId: Serenity.LookupEditor;
        ProvinceId: Serenity.LookupEditor;
        DistrictId: Serenity.LookupEditor;
        ClusterId: Serenity.LookupEditor;
        PemtremtManager: Serenity.StringEditor;
        TargetU5Cases: Serenity.IntegerEditor;
        D1VitADist: Serenity.IntegerEditor;
        D1VitAUse: Serenity.IntegerEditor;
        D1C611Months: Serenity.IntegerEditor;
        D1C1259Months: Serenity.IntegerEditor;
        D2VitADist: Serenity.IntegerEditor;
        D2VitAUse: Serenity.IntegerEditor;
        D2C611Months: Serenity.IntegerEditor;
        D2C1259Months: Serenity.IntegerEditor;
        D3VitADist: Serenity.IntegerEditor;
        D3VitAUse: Serenity.IntegerEditor;
        D3C611Months: Serenity.IntegerEditor;
        D3C1259Months: Serenity.IntegerEditor;
        D5VitADist: Serenity.IntegerEditor;
        D5VitAUse: Serenity.IntegerEditor;
        D5C611Months: Serenity.IntegerEditor;
        D5C1259Months: Serenity.IntegerEditor;
        TenantId: Serenity.IntegerEditor;
    }

    [['RoundId', () => Serenity.LookupEditor], ['ProvinceId', () => Serenity.LookupEditor], ['DistrictId', () => Serenity.LookupEditor], ['ClusterId', () => Serenity.LookupEditor], ['PemtremtManager', () => Serenity.StringEditor], ['TargetU5Cases', () => Serenity.IntegerEditor], ['D1VitADist', () => Serenity.IntegerEditor], ['D1VitAUse', () => Serenity.IntegerEditor], ['D1C611Months', () => Serenity.IntegerEditor], ['D1C1259Months', () => Serenity.IntegerEditor], ['D2VitADist', () => Serenity.IntegerEditor], ['D2VitAUse', () => Serenity.IntegerEditor], ['D2C611Months', () => Serenity.IntegerEditor], ['D2C1259Months', () => Serenity.IntegerEditor], ['D3VitADist', () => Serenity.IntegerEditor], ['D3VitAUse', () => Serenity.IntegerEditor], ['D3C611Months', () => Serenity.IntegerEditor], ['D3C1259Months', () => Serenity.IntegerEditor], ['D5VitADist', () => Serenity.IntegerEditor], ['D5VitAUse', () => Serenity.IntegerEditor], ['D5C611Months', () => Serenity.IntegerEditor], ['D5C1259Months', () => Serenity.IntegerEditor], ['TenantId', () => Serenity.IntegerEditor]].forEach(x => Object.defineProperty(TempVitaminAForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

