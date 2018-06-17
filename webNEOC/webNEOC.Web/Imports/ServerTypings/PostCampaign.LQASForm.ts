namespace webNEOC.PostCampaign {
    export class LQASForm extends Serenity.PrefixedContext {
        static formKey = 'PostCampaign.LQAS';

    }

    export interface LQASForm {
        RoundId: Serenity.LookupEditor;
        DateFrom: Serenity.DateEditor;
        DateTo: Serenity.DateEditor;
        ProvinceId: Serenity.LookupEditor;
        DistrictId: Serenity.LookupEditor;
        LotNo: Serenity.IntegerEditor;
        NoVaccChildren: Serenity.IntegerEditor;
        Comments: Serenity.TextAreaEditor;
    }

    [['RoundId', () => Serenity.LookupEditor], ['DateFrom', () => Serenity.DateEditor], ['DateTo', () => Serenity.DateEditor], ['ProvinceId', () => Serenity.LookupEditor], ['DistrictId', () => Serenity.LookupEditor], ['LotNo', () => Serenity.IntegerEditor], ['NoVaccChildren', () => Serenity.IntegerEditor], ['Comments', () => Serenity.TextAreaEditor]].forEach(x => Object.defineProperty(LQASForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

