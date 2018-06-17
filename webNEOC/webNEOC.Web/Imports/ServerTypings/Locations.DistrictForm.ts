namespace webNEOC.Locations {
    export class DistrictForm extends Serenity.PrefixedContext {
        static formKey = 'Locations.District';

    }

    export interface DistrictForm {
        Dcode: Serenity.StringEditor;
        ProvinceId: Serenity.LookupEditor;
        Dname: Serenity.StringEditor;
        TotalPop: Serenity.IntegerEditor;
        TargetPop: Serenity.IntegerEditor;
        Type: Serenity.StringEditor;
        Priority: Serenity.IntegerEditor;
        PopYear: Serenity.IntegerEditor;
    }

    [['Dcode', () => Serenity.StringEditor], ['ProvinceId', () => Serenity.LookupEditor], ['Dname', () => Serenity.StringEditor], ['TotalPop', () => Serenity.IntegerEditor], ['TargetPop', () => Serenity.IntegerEditor], ['Type', () => Serenity.StringEditor], ['Priority', () => Serenity.IntegerEditor], ['PopYear', () => Serenity.IntegerEditor]].forEach(x => Object.defineProperty(DistrictForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

