namespace webNEOC.PostCampaign {
    export class PcmForm extends Serenity.PrefixedContext {
        static formKey = 'PostCampaign.Pcm';

    }

    export interface PcmForm {
        RoundId: Serenity.LookupEditor;
        DateFrom: Serenity.DateEditor;
        DateTo: Serenity.DateEditor;
        ProvinceId: Serenity.LookupEditor;
        DistrictId: Serenity.LookupEditor;
        ClusterId: Serenity.LookupEditor;
        ClusterLevelId: Serenity.LookupEditor;
        CampaignTypeId: Serenity.LookupEditor;
        ClusterCode: Serenity.StringEditor;
        Village: Serenity.StringEditor;
        VistedHouses: Serenity.IntegerEditor;
        T059m: Serenity.IntegerEditor;
        V059m: Serenity.IntegerEditor;
        T011Seen: Serenity.IntegerEditor;
        Fm011HvFm: Serenity.IntegerEditor;
        T1259Seen: Serenity.IntegerEditor;
        Fm1259HvFm: Serenity.IntegerEditor;
        TChildrenNoFm: Serenity.IntegerEditor;
        R1TeamNoVisit: Serenity.IntegerEditor;
        R21: Serenity.IntegerEditor;
        R22: Serenity.IntegerEditor;
        R23: Serenity.IntegerEditor;
        R24: Serenity.IntegerEditor;
        R31: Serenity.IntegerEditor;
        R32: Serenity.IntegerEditor;
        R33: Serenity.IntegerEditor;
        R4NewBorn: Serenity.IntegerEditor;
        R5Sleep: Serenity.IntegerEditor;
        R6Sick: Serenity.IntegerEditor;
        R7Other: Serenity.IntegerEditor;
        DmCorrect: Serenity.IntegerEditor;
        DmIncorrect: Serenity.IntegerEditor;
        NoDm: Serenity.IntegerEditor;
        FmHeard: Serenity.IntegerEditor;
        FmNotHeard: Serenity.IntegerEditor;
        Radio: Serenity.IntegerEditor;
        Tv: Serenity.IntegerEditor;
        MullahElders: Serenity.IntegerEditor;
        Teacher: Serenity.IntegerEditor;
        Chw: Serenity.IntegerEditor;
        CElders: Serenity.IntegerEditor;
        PbLeaflet: Serenity.IntegerEditor;
        Sm: Serenity.IntegerEditor;
        Other: Serenity.IntegerEditor;
        ChVacByMonitor: Serenity.IntegerEditor;
        RCallCoverage: Serenity.IntegerEditor;
        Fm059Coverage: Serenity.IntegerEditor;
        Fm011Coverage: Serenity.IntegerEditor;
        InAcesChildren: Serenity.IntegerEditor;
    }

    [['RoundId', () => Serenity.LookupEditor], ['DateFrom', () => Serenity.DateEditor], ['DateTo', () => Serenity.DateEditor], ['ProvinceId', () => Serenity.LookupEditor], ['DistrictId', () => Serenity.LookupEditor], ['ClusterId', () => Serenity.LookupEditor], ['ClusterLevelId', () => Serenity.LookupEditor], ['CampaignTypeId', () => Serenity.LookupEditor], ['ClusterCode', () => Serenity.StringEditor], ['Village', () => Serenity.StringEditor], ['VistedHouses', () => Serenity.IntegerEditor], ['T059m', () => Serenity.IntegerEditor], ['V059m', () => Serenity.IntegerEditor], ['T011Seen', () => Serenity.IntegerEditor], ['Fm011HvFm', () => Serenity.IntegerEditor], ['T1259Seen', () => Serenity.IntegerEditor], ['Fm1259HvFm', () => Serenity.IntegerEditor], ['TChildrenNoFm', () => Serenity.IntegerEditor], ['R1TeamNoVisit', () => Serenity.IntegerEditor], ['R21', () => Serenity.IntegerEditor], ['R22', () => Serenity.IntegerEditor], ['R23', () => Serenity.IntegerEditor], ['R24', () => Serenity.IntegerEditor], ['R31', () => Serenity.IntegerEditor], ['R32', () => Serenity.IntegerEditor], ['R33', () => Serenity.IntegerEditor], ['R4NewBorn', () => Serenity.IntegerEditor], ['R5Sleep', () => Serenity.IntegerEditor], ['R6Sick', () => Serenity.IntegerEditor], ['R7Other', () => Serenity.IntegerEditor], ['DmCorrect', () => Serenity.IntegerEditor], ['DmIncorrect', () => Serenity.IntegerEditor], ['NoDm', () => Serenity.IntegerEditor], ['FmHeard', () => Serenity.IntegerEditor], ['FmNotHeard', () => Serenity.IntegerEditor], ['Radio', () => Serenity.IntegerEditor], ['Tv', () => Serenity.IntegerEditor], ['MullahElders', () => Serenity.IntegerEditor], ['Teacher', () => Serenity.IntegerEditor], ['Chw', () => Serenity.IntegerEditor], ['CElders', () => Serenity.IntegerEditor], ['PbLeaflet', () => Serenity.IntegerEditor], ['Sm', () => Serenity.IntegerEditor], ['Other', () => Serenity.IntegerEditor], ['ChVacByMonitor', () => Serenity.IntegerEditor], ['RCallCoverage', () => Serenity.IntegerEditor], ['Fm059Coverage', () => Serenity.IntegerEditor], ['Fm011Coverage', () => Serenity.IntegerEditor], ['InAcesChildren', () => Serenity.IntegerEditor]].forEach(x => Object.defineProperty(PcmForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

