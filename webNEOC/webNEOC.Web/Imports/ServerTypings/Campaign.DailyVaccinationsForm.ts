namespace webNEOC.Campaign {
    export class DailyVaccinationsForm extends Serenity.PrefixedContext {
        static formKey = 'Campaign.DailyVaccinations';

    }

    export interface DailyVaccinationsForm {
        ClusterId: Serenity.LookupEditor;
        LDPTypes: Serenity.StringEditor;
        TargetU5Case: Serenity.IntegerEditor;
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
    }

    [['ClusterId', () => Serenity.LookupEditor], ['LDPTypes', () => Serenity.StringEditor], ['TargetU5Case', () => Serenity.IntegerEditor], ['D1VialDist', () => Serenity.IntegerEditor], ['D1VialUse', () => Serenity.IntegerEditor], ['D1Vac011Months', () => Serenity.IntegerEditor], ['D1Vac1259months', () => Serenity.IntegerEditor], ['D1RecAbsChildren', () => Serenity.IntegerEditor], ['D1VacAbsChildren', () => Serenity.IntegerEditor], ['D1RecNewbornSsc', () => Serenity.IntegerEditor], ['D1VacNewbornSsc', () => Serenity.IntegerEditor], ['D1RecRefusedChildren', () => Serenity.IntegerEditor], ['D1RevacRefusedChildren', () => Serenity.IntegerEditor], ['D1AfpCase', () => Serenity.IntegerEditor], ['D2VialDist', () => Serenity.IntegerEditor], ['D2VialUse', () => Serenity.IntegerEditor], ['D2Vac011Months', () => Serenity.IntegerEditor], ['D2Vac1259months', () => Serenity.IntegerEditor], ['D2RecAbsChildren', () => Serenity.IntegerEditor], ['D2VacAbsChildren', () => Serenity.IntegerEditor], ['D2RecNewbornSsc', () => Serenity.IntegerEditor], ['D2VacNewbornSsc', () => Serenity.IntegerEditor], ['D2RecRefusedChildren', () => Serenity.IntegerEditor], ['D2RevacRefusedChildren', () => Serenity.IntegerEditor], ['D2AfpCase', () => Serenity.IntegerEditor], ['D3VialDist', () => Serenity.IntegerEditor], ['D3VialUse', () => Serenity.IntegerEditor], ['D3Vac011Months', () => Serenity.IntegerEditor], ['D3Vac1259months', () => Serenity.IntegerEditor], ['D3RecAbsChildren', () => Serenity.IntegerEditor], ['D3VacAbsChildren', () => Serenity.IntegerEditor], ['D3RecNewbornSsc', () => Serenity.IntegerEditor], ['D3VacNewbornSsc', () => Serenity.IntegerEditor], ['D3RecRefusedChildren', () => Serenity.IntegerEditor], ['D3RevacRefusedChildren', () => Serenity.IntegerEditor], ['D3AfpCase', () => Serenity.IntegerEditor], ['D5VialDist', () => Serenity.IntegerEditor], ['D5VialUse', () => Serenity.IntegerEditor], ['D5Vac011Months', () => Serenity.IntegerEditor], ['D5Vac1259months', () => Serenity.IntegerEditor], ['D5RecAbsChildren', () => Serenity.IntegerEditor], ['D5VacAbsChildren', () => Serenity.IntegerEditor], ['D5RecNewbornSsc', () => Serenity.IntegerEditor], ['D5VacNewbornSsc', () => Serenity.IntegerEditor], ['D5RecRefusedChildren', () => Serenity.IntegerEditor], ['D5RevacRefusedChildren', () => Serenity.IntegerEditor], ['D5AfpCase', () => Serenity.IntegerEditor]].forEach(x => Object.defineProperty(DailyVaccinationsForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

