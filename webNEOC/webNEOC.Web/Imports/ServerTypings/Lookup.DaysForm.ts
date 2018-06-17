namespace webNEOC.Lookup {
    export class DaysForm extends Serenity.PrefixedContext {
        static formKey = 'Lookup.Days';

    }

    export interface DaysForm {
        DayName: Serenity.StringEditor;
    }

    [['DayName', () => Serenity.StringEditor]].forEach(x => Object.defineProperty(DaysForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

