namespace webNEOC.Implementation {
    export class IcmHouseholdForm extends Serenity.PrefixedContext {
        static formKey = 'Implementation.IcmHousehold';

    }

    export interface IcmHouseholdForm {
        RoundId: Serenity.LookupEditor;
        DateFrom: Serenity.DateEditor;
        DateTo: Serenity.DateEditor;
        ProvinceId: Serenity.LookupEditor;
        DistrictId: Serenity.LookupEditor;
        PartId: Serenity.LookupEditor;
        ClusterId: Serenity.LookupEditor;
        ReportDate: Serenity.DateEditor;
        Village: Serenity.StringEditor;
        Supervisor: Serenity.StringEditor;
        NoHhVisited: Serenity.IntegerEditor;
        NoChildrenInVisitedHh: Serenity.IntegerEditor;
        NoVaccInRecall: Serenity.IntegerEditor;
        MissedChildren: Serenity.IntegerEditor;
        TeamNotCome: Serenity.IntegerEditor;
        ChildrenAbsent: Serenity.IntegerEditor;
        NewbornSsChildren: Serenity.IntegerEditor;
        NoRefused: Serenity.IntegerEditor;
        NoIgnoredbyTeam: Serenity.IntegerEditor;
        TotUn5SeenByMonit: Serenity.IntegerEditor;
        NoSeenWithFingerMark: Serenity.IntegerEditor;
        NoCorrect: Serenity.IntegerEditor;
        NoIncorrect: Serenity.IntegerEditor;
        NoNotMarked: Serenity.IntegerEditor;
        NoChildFoundMissedRecall: Serenity.IntegerEditor;
        NoChildRecBackOfTally: Serenity.IntegerEditor;
    }

    [['RoundId', () => Serenity.LookupEditor], ['DateFrom', () => Serenity.DateEditor], ['DateTo', () => Serenity.DateEditor], ['ProvinceId', () => Serenity.LookupEditor], ['DistrictId', () => Serenity.LookupEditor], ['PartId', () => Serenity.LookupEditor], ['ClusterId', () => Serenity.LookupEditor], ['ReportDate', () => Serenity.DateEditor], ['Village', () => Serenity.StringEditor], ['Supervisor', () => Serenity.StringEditor], ['NoHhVisited', () => Serenity.IntegerEditor], ['NoChildrenInVisitedHh', () => Serenity.IntegerEditor], ['NoVaccInRecall', () => Serenity.IntegerEditor], ['MissedChildren', () => Serenity.IntegerEditor], ['TeamNotCome', () => Serenity.IntegerEditor], ['ChildrenAbsent', () => Serenity.IntegerEditor], ['NewbornSsChildren', () => Serenity.IntegerEditor], ['NoRefused', () => Serenity.IntegerEditor], ['NoIgnoredbyTeam', () => Serenity.IntegerEditor], ['TotUn5SeenByMonit', () => Serenity.IntegerEditor], ['NoSeenWithFingerMark', () => Serenity.IntegerEditor], ['NoCorrect', () => Serenity.IntegerEditor], ['NoIncorrect', () => Serenity.IntegerEditor], ['NoNotMarked', () => Serenity.IntegerEditor], ['NoChildFoundMissedRecall', () => Serenity.IntegerEditor], ['NoChildRecBackOfTally', () => Serenity.IntegerEditor]].forEach(x => Object.defineProperty(IcmHouseholdForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

