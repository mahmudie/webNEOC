namespace webNEOC.Lookup {
    export class DayPartForm extends Serenity.PrefixedContext {
        static formKey = 'Lookup.DayPart';

    }

    export interface DayPartForm {
        Daypart: Serenity.StringEditor;
    }

    [['Daypart', () => Serenity.StringEditor]].forEach(x => Object.defineProperty(DayPartForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

