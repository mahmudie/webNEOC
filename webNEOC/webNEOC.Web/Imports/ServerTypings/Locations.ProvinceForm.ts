namespace webNEOC.Locations {
    export class ProvinceForm extends Serenity.PrefixedContext {
        static formKey = 'Locations.Province';

    }

    export interface ProvinceForm {
        Pcode: Serenity.StringEditor;
        RegionId: Serenity.LookupEditor;
        Pname: Serenity.StringEditor;
        PAbrv: Serenity.StringEditor;
        Pcenter: Serenity.StringEditor;
        AreaKmSqr: Serenity.IntegerEditor;
        NoOfDistricts: Serenity.IntegerEditor;
    }

    [['Pcode', () => Serenity.StringEditor], ['RegionId', () => Serenity.LookupEditor], ['Pname', () => Serenity.StringEditor], ['PAbrv', () => Serenity.StringEditor], ['Pcenter', () => Serenity.StringEditor], ['AreaKmSqr', () => Serenity.IntegerEditor], ['NoOfDistricts', () => Serenity.IntegerEditor]].forEach(x => Object.defineProperty(ProvinceForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

