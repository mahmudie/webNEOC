namespace webNEOC.Campaign {
    export class CampaignDayForm extends Serenity.PrefixedContext {
        static formKey = 'Campaign.CampaignDay';

    }

    export interface CampaignDayForm {
        RoundId: Serenity.LookupEditor;
        ProvinceId: Serenity.LookupEditor;
        DistrictId: Serenity.LookupEditor;
        DateOfCampaign: Serenity.DateEditor;
        PemtremtManager: Serenity.StringEditor;
        VaccinationList: DailyVaccinationsEditor;
    }

    [['RoundId', () => Serenity.LookupEditor], ['ProvinceId', () => Serenity.LookupEditor], ['DistrictId', () => Serenity.LookupEditor], ['DateOfCampaign', () => Serenity.DateEditor], ['PemtremtManager', () => Serenity.StringEditor], ['VaccinationList', () => DailyVaccinationsEditor]].forEach(x => Object.defineProperty(CampaignDayForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

