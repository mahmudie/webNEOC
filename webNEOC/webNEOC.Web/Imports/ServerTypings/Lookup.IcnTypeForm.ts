namespace webNEOC.Lookup {
    export class IcnTypeForm extends Serenity.PrefixedContext {
        static formKey = 'Lookup.IcnType';

    }

    export interface IcnTypeForm {
        IcnType: Serenity.StringEditor;
    }

    [['IcnType', () => Serenity.StringEditor]].forEach(x => Object.defineProperty(IcnTypeForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

