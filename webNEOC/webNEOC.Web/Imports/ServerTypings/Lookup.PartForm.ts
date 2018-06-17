namespace webNEOC.Lookup {
    export class PartForm extends Serenity.PrefixedContext {
        static formKey = 'Lookup.Part';

    }

    export interface PartForm {
        PartName: Serenity.StringEditor;
    }

    [['PartName', () => Serenity.StringEditor]].forEach(x => Object.defineProperty(PartForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

