namespace webNEOC.Implementation {
    export class VitaminAForm extends Serenity.PrefixedContext {
        static formKey = 'Implementation.VitaminA';

    }

    export interface VitaminAForm {
        RoundId: Serenity.LookupEditor;
        DateFrom: Serenity.DateEditor;
        DateTo: Serenity.DateEditor;
        ProvinceId: Serenity.LookupEditor;
        DistrictId: Serenity.LookupEditor;
        PemtremtManager: Serenity.StringEditor;
        VitaminAVaccinations: VitaminAVaccinationsEditor;
    }

    [['RoundId', () => Serenity.LookupEditor], ['DateFrom', () => Serenity.DateEditor], ['DateTo', () => Serenity.DateEditor], ['ProvinceId', () => Serenity.LookupEditor], ['DistrictId', () => Serenity.LookupEditor], ['PemtremtManager', () => Serenity.StringEditor], ['VitaminAVaccinations', () => VitaminAVaccinationsEditor]].forEach(x => Object.defineProperty(VitaminAForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

