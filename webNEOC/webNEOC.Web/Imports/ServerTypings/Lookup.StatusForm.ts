namespace webNEOC.Lookup {
    export class StatusForm extends Serenity.PrefixedContext {
        static formKey = 'Lookup.Status';

    }

    export interface StatusForm {
        StatusName: Serenity.StringEditor;
    }

    [['StatusName', () => Serenity.StringEditor]].forEach(x => Object.defineProperty(StatusForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

