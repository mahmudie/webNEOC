namespace webNEOC.PostCampaign {
    export class OutOfHouseSurveyForm extends Serenity.PrefixedContext {
        static formKey = 'PostCampaign.OutOfHouseSurvey';

    }

    export interface OutOfHouseSurveyForm {
        RoundId: Serenity.LookupEditor;
        DateFrom: Serenity.DateEditor;
        DateTo: Serenity.DateEditor;
        ProvinceId: Serenity.LookupEditor;
        DistrictId: Serenity.LookupEditor;
        ReportDate: Serenity.DateEditor;
        T059m: Serenity.IntegerEditor;
        Vac059m: Serenity.IntegerEditor;
        FM059m: Serenity.IntegerEditor;
        T059f: Serenity.IntegerEditor;
        Vac059f: Serenity.IntegerEditor;
        FM059f: Serenity.IntegerEditor;
        MissTmNotCome: Serenity.IntegerEditor;
        MissAbsent: Serenity.IntegerEditor;
        MissRefused: Serenity.IntegerEditor;
        MissNewBornSick: Serenity.IntegerEditor;
    }

    [['RoundId', () => Serenity.LookupEditor], ['DateFrom', () => Serenity.DateEditor], ['DateTo', () => Serenity.DateEditor], ['ProvinceId', () => Serenity.LookupEditor], ['DistrictId', () => Serenity.LookupEditor], ['ReportDate', () => Serenity.DateEditor], ['T059m', () => Serenity.IntegerEditor], ['Vac059m', () => Serenity.IntegerEditor], ['FM059m', () => Serenity.IntegerEditor], ['T059f', () => Serenity.IntegerEditor], ['Vac059f', () => Serenity.IntegerEditor], ['FM059f', () => Serenity.IntegerEditor], ['MissTmNotCome', () => Serenity.IntegerEditor], ['MissAbsent', () => Serenity.IntegerEditor], ['MissRefused', () => Serenity.IntegerEditor], ['MissNewBornSick', () => Serenity.IntegerEditor]].forEach(x => Object.defineProperty(OutOfHouseSurveyForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

