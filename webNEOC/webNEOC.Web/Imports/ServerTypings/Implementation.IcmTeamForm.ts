namespace webNEOC.Implementation {
    export class IcmTeamForm extends Serenity.PrefixedContext {
        static formKey = 'Implementation.IcmTeam';

    }

    export interface IcmTeamForm {
        RoundId: Serenity.LookupEditor;
        DateFrom: Serenity.DateEditor;
        DateTo: Serenity.DateEditor;
        ProvinceId: Serenity.LookupEditor;
        DistrictId: Serenity.LookupEditor;
        PartId: Serenity.LookupEditor;
        ClusterId: Serenity.LookupEditor;
        MonitorName: Serenity.StringEditor;
        TeamMemberName: Serenity.StringEditor;
        TeamNo: Serenity.StringEditor;
        ReportDate: Serenity.DateEditor;
        MonitVisitTime: Serenity.StringEditor;
        IsTeamResident: Serenity.BooleanEditor;
        BothTrained: Serenity.BooleanEditor;
        HaveClearMap: Serenity.BooleanEditor;
        AbleKnowArea: Serenity.BooleanEditor;
        TeamGHtoH: Serenity.BooleanEditor;
        OpvVialsKeptDry: Serenity.BooleanEditor;
        UsingOpvStage3or4: Serenity.BooleanEditor;
        AskingAbout011C: Serenity.BooleanEditor;
        AskingforGnssc: Serenity.BooleanEditor;
        RecNameOfAbsentRefC: Serenity.BooleanEditor;
        AskingAfpCases: Serenity.BooleanEditor;
        VistedBySupervisor: Serenity.BooleanEditor;
        TeamHasAchw: Serenity.BooleanEditor;
        TeamHasFemale: Serenity.BooleanEditor;
        SocMobAccompanyTeam: Serenity.BooleanEditor;
    }

    [['RoundId', () => Serenity.LookupEditor], ['DateFrom', () => Serenity.DateEditor], ['DateTo', () => Serenity.DateEditor], ['ProvinceId', () => Serenity.LookupEditor], ['DistrictId', () => Serenity.LookupEditor], ['PartId', () => Serenity.LookupEditor], ['ClusterId', () => Serenity.LookupEditor], ['MonitorName', () => Serenity.StringEditor], ['TeamMemberName', () => Serenity.StringEditor], ['TeamNo', () => Serenity.StringEditor], ['ReportDate', () => Serenity.DateEditor], ['MonitVisitTime', () => Serenity.StringEditor], ['IsTeamResident', () => Serenity.BooleanEditor], ['BothTrained', () => Serenity.BooleanEditor], ['HaveClearMap', () => Serenity.BooleanEditor], ['AbleKnowArea', () => Serenity.BooleanEditor], ['TeamGHtoH', () => Serenity.BooleanEditor], ['OpvVialsKeptDry', () => Serenity.BooleanEditor], ['UsingOpvStage3or4', () => Serenity.BooleanEditor], ['AskingAbout011C', () => Serenity.BooleanEditor], ['AskingforGnssc', () => Serenity.BooleanEditor], ['RecNameOfAbsentRefC', () => Serenity.BooleanEditor], ['AskingAfpCases', () => Serenity.BooleanEditor], ['VistedBySupervisor', () => Serenity.BooleanEditor], ['TeamHasAchw', () => Serenity.BooleanEditor], ['TeamHasFemale', () => Serenity.BooleanEditor], ['SocMobAccompanyTeam', () => Serenity.BooleanEditor]].forEach(x => Object.defineProperty(IcmTeamForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

