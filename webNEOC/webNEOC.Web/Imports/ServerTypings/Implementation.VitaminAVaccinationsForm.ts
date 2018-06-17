namespace webNEOC.Implementation {
    export class VitaminAVaccinationsForm extends Serenity.PrefixedContext {
        static formKey = 'Implementation.VitaminAVaccinations';

    }

    export interface VitaminAVaccinationsForm {
        ClusterId: Serenity.LookupEditor;
        TargetU5Cases: Serenity.IntegerEditor;
        d1VitADist: Serenity.IntegerEditor;
        d1VitAUse: Serenity.IntegerEditor;
        d1C611Months: Serenity.IntegerEditor;
        d1C1259Months: Serenity.IntegerEditor;
        d2VitADist: Serenity.IntegerEditor;
        d2VitAUse: Serenity.IntegerEditor;
        d2C611Months: Serenity.IntegerEditor;
        d2C1259Months: Serenity.IntegerEditor;
        d3VitADist: Serenity.IntegerEditor;
        d3VitAUse: Serenity.IntegerEditor;
        d3C611Months: Serenity.IntegerEditor;
        d3C1259Months: Serenity.IntegerEditor;
        d5VitADist: Serenity.IntegerEditor;
        d5VitAUse: Serenity.IntegerEditor;
        d5C611Months: Serenity.IntegerEditor;
        d5C1259Months: Serenity.IntegerEditor;
    }

    [['ClusterId', () => Serenity.LookupEditor], ['TargetU5Cases', () => Serenity.IntegerEditor], ['d1VitADist', () => Serenity.IntegerEditor], ['d1VitAUse', () => Serenity.IntegerEditor], ['d1C611Months', () => Serenity.IntegerEditor], ['d1C1259Months', () => Serenity.IntegerEditor], ['d2VitADist', () => Serenity.IntegerEditor], ['d2VitAUse', () => Serenity.IntegerEditor], ['d2C611Months', () => Serenity.IntegerEditor], ['d2C1259Months', () => Serenity.IntegerEditor], ['d3VitADist', () => Serenity.IntegerEditor], ['d3VitAUse', () => Serenity.IntegerEditor], ['d3C611Months', () => Serenity.IntegerEditor], ['d3C1259Months', () => Serenity.IntegerEditor], ['d5VitADist', () => Serenity.IntegerEditor], ['d5VitAUse', () => Serenity.IntegerEditor], ['d5C611Months', () => Serenity.IntegerEditor], ['d5C1259Months', () => Serenity.IntegerEditor]].forEach(x => Object.defineProperty(VitaminAVaccinationsForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

