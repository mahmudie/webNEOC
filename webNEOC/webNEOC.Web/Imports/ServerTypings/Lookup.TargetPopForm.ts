namespace webNEOC.Lookup {
    export class TargetPopForm extends Serenity.PrefixedContext {
        static formKey = 'Lookup.TargetPop';

    }

    export interface TargetPopForm {
        ProvinceId: Serenity.LookupEditor;
        DistrictId: Serenity.LookupEditor;
        YearId: Serenity.IntegerEditor;
        Population: Serenity.StringEditor;
        Target: Serenity.IntegerEditor;
        LpDs: Serenity.StringEditor;
        Comment: Serenity.StringEditor;
    }

    [['ProvinceId', () => Serenity.LookupEditor], ['DistrictId', () => Serenity.LookupEditor], ['YearId', () => Serenity.IntegerEditor], ['Population', () => Serenity.StringEditor], ['Target', () => Serenity.IntegerEditor], ['LpDs', () => Serenity.StringEditor], ['Comment', () => Serenity.StringEditor]].forEach(x => Object.defineProperty(TargetPopForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

