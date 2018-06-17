namespace webNEOC.Preparation {
    export class InAccessibleForm extends Serenity.PrefixedContext {
        static formKey = 'Preparation.InAccessible';

    }

    export interface InAccessibleForm {
        RoundId: Serenity.LookupEditor;
        DateFrom: Serenity.DateEditor;
        DateTo: Serenity.DateEditor;
        ProvinceId: Serenity.LookupEditor;
        DistrictId: Serenity.LookupEditor;
        ReportDate: Serenity.DateEditor;
        Target: Serenity.IntegerEditor;
        MissedClusters: Serenity.IntegerEditor;
        MissedChildren: Serenity.IntegerEditor;
        PartiallyMissed: Serenity.IntegerEditor;
        PartiallyMissedName: Serenity.TextAreaEditor;
        FullyMissed: Serenity.IntegerEditor;
        FullyMissedName: Serenity.TextAreaEditor;
        InAcsCategoryId: Serenity.LookupEditor;
        PlanToReduce: Serenity.TextAreaEditor;
        Remarks: Serenity.TextAreaEditor;
    }

    [['RoundId', () => Serenity.LookupEditor], ['DateFrom', () => Serenity.DateEditor], ['DateTo', () => Serenity.DateEditor], ['ProvinceId', () => Serenity.LookupEditor], ['DistrictId', () => Serenity.LookupEditor], ['ReportDate', () => Serenity.DateEditor], ['Target', () => Serenity.IntegerEditor], ['MissedClusters', () => Serenity.IntegerEditor], ['MissedChildren', () => Serenity.IntegerEditor], ['PartiallyMissed', () => Serenity.IntegerEditor], ['PartiallyMissedName', () => Serenity.TextAreaEditor], ['FullyMissed', () => Serenity.IntegerEditor], ['FullyMissedName', () => Serenity.TextAreaEditor], ['InAcsCategoryId', () => Serenity.LookupEditor], ['PlanToReduce', () => Serenity.TextAreaEditor], ['Remarks', () => Serenity.TextAreaEditor]].forEach(x => Object.defineProperty(InAccessibleForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

