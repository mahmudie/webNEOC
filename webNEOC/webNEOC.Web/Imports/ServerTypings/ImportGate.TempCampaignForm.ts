namespace webNEOC.ImportGate {
    export class TempCampaignForm extends Serenity.PrefixedContext {
        static formKey = 'ImportGate.TempCampaign';

    }

    export interface TempCampaignForm {
        RoundId: Serenity.LookupEditor;
        ProvinceId: Serenity.LookupEditor;
        DistrictId: Serenity.LookupEditor;
        ClusterId: Serenity.LookupEditor;
        LDPTypes: Serenity.StringEditor;
        PemtremtManager: Serenity.StringEditor;
        DateOfCampaign: Serenity.DateEditor;
        TargetU5Case: Serenity.IntegerEditor;
        TeamNo: Serenity.StringEditor;
        HhNo: Serenity.IntegerEditor;
        D1VialDist: Serenity.IntegerEditor;
        D1VialUse: Serenity.IntegerEditor;
        D1Vac011Months: Serenity.IntegerEditor;
        D1Vac1259months: Serenity.IntegerEditor;
        D1RecAbsChildren: Serenity.IntegerEditor;
        D1VacAbsChildren: Serenity.IntegerEditor;
        D1RecNewbornSsc: Serenity.IntegerEditor;
        D1VacNewbornSsc: Serenity.IntegerEditor;
        D1RecRefusedChildren: Serenity.IntegerEditor;
        D1RevacRefusedChildren: Serenity.IntegerEditor;
        D1AfpCase: Serenity.IntegerEditor;
        D2VialDist: Serenity.IntegerEditor;
        D2VialUse: Serenity.IntegerEditor;
        D2Vac011Months: Serenity.IntegerEditor;
        D2Vac1259months: Serenity.IntegerEditor;
        D2RecAbsChildren: Serenity.IntegerEditor;
        D2VacAbsChildren: Serenity.IntegerEditor;
        D2RecNewbornSsc: Serenity.IntegerEditor;
        D2VacNewbornSsc: Serenity.IntegerEditor;
        D2RecRefusedChildren: Serenity.IntegerEditor;
        D2RevacRefusedChildren: Serenity.IntegerEditor;
        D2AfpCase: Serenity.IntegerEditor;
        D3VialDist: Serenity.IntegerEditor;
        D3VialUse: Serenity.IntegerEditor;
        D3Vac011Months: Serenity.IntegerEditor;
        D3Vac1259months: Serenity.IntegerEditor;
        D3RecAbsChildren: Serenity.IntegerEditor;
        D3VacAbsChildren: Serenity.IntegerEditor;
        D3RecNewbornSsc: Serenity.IntegerEditor;
        D3VacNewbornSsc: Serenity.IntegerEditor;
        D3RecRefusedChildren: Serenity.IntegerEditor;
        D3RevacRefusedChildren: Serenity.IntegerEditor;
        D3AfpCase: Serenity.IntegerEditor;
        D5VialDist: Serenity.IntegerEditor;
        D5VialUse: Serenity.IntegerEditor;
        D5Vac011Months: Serenity.IntegerEditor;
        D5Vac1259months: Serenity.IntegerEditor;
        D5RecAbsChildren: Serenity.IntegerEditor;
        D5VacAbsChildren: Serenity.IntegerEditor;
        D5RecNewbornSsc: Serenity.IntegerEditor;
        D5VacNewbornSsc: Serenity.IntegerEditor;
        D5RecRefusedChildren: Serenity.IntegerEditor;
        D5RevacRefusedChildren: Serenity.IntegerEditor;
        D5AfpCase: Serenity.IntegerEditor;
        TenantId: Serenity.IntegerEditor;
    }

    [['RoundId', () => Serenity.LookupEditor], ['ProvinceId', () => Serenity.LookupEditor], ['DistrictId', () => Serenity.LookupEditor], ['ClusterId', () => Serenity.LookupEditor], ['LDPTypes', () => Serenity.StringEditor], ['PemtremtManager', () => Serenity.StringEditor], ['DateOfCampaign', () => Serenity.DateEditor], ['TargetU5Case', () => Serenity.IntegerEditor], ['TeamNo', () => Serenity.StringEditor], ['HhNo', () => Serenity.IntegerEditor], ['D1VialDist', () => Serenity.IntegerEditor], ['D1VialUse', () => Serenity.IntegerEditor], ['D1Vac011Months', () => Serenity.IntegerEditor], ['D1Vac1259months', () => Serenity.IntegerEditor], ['D1RecAbsChildren', () => Serenity.IntegerEditor], ['D1VacAbsChildren', () => Serenity.IntegerEditor], ['D1RecNewbornSsc', () => Serenity.IntegerEditor], ['D1VacNewbornSsc', () => Serenity.IntegerEditor], ['D1RecRefusedChildren', () => Serenity.IntegerEditor], ['D1RevacRefusedChildren', () => Serenity.IntegerEditor], ['D1AfpCase', () => Serenity.IntegerEditor], ['D2VialDist', () => Serenity.IntegerEditor], ['D2VialUse', () => Serenity.IntegerEditor], ['D2Vac011Months', () => Serenity.IntegerEditor], ['D2Vac1259months', () => Serenity.IntegerEditor], ['D2RecAbsChildren', () => Serenity.IntegerEditor], ['D2VacAbsChildren', () => Serenity.IntegerEditor], ['D2RecNewbornSsc', () => Serenity.IntegerEditor], ['D2VacNewbornSsc', () => Serenity.IntegerEditor], ['D2RecRefusedChildren', () => Serenity.IntegerEditor], ['D2RevacRefusedChildren', () => Serenity.IntegerEditor], ['D2AfpCase', () => Serenity.IntegerEditor], ['D3VialDist', () => Serenity.IntegerEditor], ['D3VialUse', () => Serenity.IntegerEditor], ['D3Vac011Months', () => Serenity.IntegerEditor], ['D3Vac1259months', () => Serenity.IntegerEditor], ['D3RecAbsChildren', () => Serenity.IntegerEditor], ['D3VacAbsChildren', () => Serenity.IntegerEditor], ['D3RecNewbornSsc', () => Serenity.IntegerEditor], ['D3VacNewbornSsc', () => Serenity.IntegerEditor], ['D3RecRefusedChildren', () => Serenity.IntegerEditor], ['D3RevacRefusedChildren', () => Serenity.IntegerEditor], ['D3AfpCase', () => Serenity.IntegerEditor], ['D5VialDist', () => Serenity.IntegerEditor], ['D5VialUse', () => Serenity.IntegerEditor], ['D5Vac011Months', () => Serenity.IntegerEditor], ['D5Vac1259months', () => Serenity.IntegerEditor], ['D5RecAbsChildren', () => Serenity.IntegerEditor], ['D5VacAbsChildren', () => Serenity.IntegerEditor], ['D5RecNewbornSsc', () => Serenity.IntegerEditor], ['D5VacNewbornSsc', () => Serenity.IntegerEditor], ['D5RecRefusedChildren', () => Serenity.IntegerEditor], ['D5RevacRefusedChildren', () => Serenity.IntegerEditor], ['D5AfpCase', () => Serenity.IntegerEditor], ['TenantId', () => Serenity.IntegerEditor]].forEach(x => Object.defineProperty(TempCampaignForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

