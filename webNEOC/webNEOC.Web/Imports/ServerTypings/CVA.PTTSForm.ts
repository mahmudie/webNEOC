namespace webNEOC.CVA {
    export class PTTSForm extends Serenity.PrefixedContext {
        static formKey = 'CVA.PTTS';

    }

    export interface PTTSForm {
        ProvinceId: Serenity.LookupEditor;
        DistrictId: Serenity.LookupEditor;
        Year: Serenity.IntegerEditor;
        MonthId: Serenity.LookupEditor;
        Type: Serenity.StringEditor;
        Subtype: Serenity.StringEditor;
        NoOfTeam: Serenity.IntegerEditor;
        TeamName: Serenity.StringEditor;
        Boys011: Serenity.IntegerEditor;
        Girls011: Serenity.IntegerEditor;
        Boys1259: Serenity.IntegerEditor;
        Girls1259: Serenity.IntegerEditor;
        Remarks: Serenity.TextAreaEditor;
        TenantId: Serenity.IntegerEditor;
    }

    [['ProvinceId', () => Serenity.LookupEditor], ['DistrictId', () => Serenity.LookupEditor], ['Year', () => Serenity.IntegerEditor], ['MonthId', () => Serenity.LookupEditor], ['Type', () => Serenity.StringEditor], ['Subtype', () => Serenity.StringEditor], ['NoOfTeam', () => Serenity.IntegerEditor], ['TeamName', () => Serenity.StringEditor], ['Boys011', () => Serenity.IntegerEditor], ['Girls011', () => Serenity.IntegerEditor], ['Boys1259', () => Serenity.IntegerEditor], ['Girls1259', () => Serenity.IntegerEditor], ['Remarks', () => Serenity.TextAreaEditor], ['TenantId', () => Serenity.IntegerEditor]].forEach(x => Object.defineProperty(PTTSForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

