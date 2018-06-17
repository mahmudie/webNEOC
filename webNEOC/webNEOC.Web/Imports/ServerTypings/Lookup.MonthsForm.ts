namespace webNEOC.Lookup {
    export class MonthsForm extends Serenity.PrefixedContext {
        static formKey = 'Lookup.Months';

    }

    export interface MonthsForm {
        Monthshort: Serenity.StringEditor;
        Monthlong: Serenity.StringEditor;
    }

    [['Monthshort', () => Serenity.StringEditor], ['Monthlong', () => Serenity.StringEditor]].forEach(x => Object.defineProperty(MonthsForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

