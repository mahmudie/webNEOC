
namespace webNEOC.Lookup {
    export class LangForm extends Serenity.PrefixedContext {
        static formKey = 'Lookup.Lang';
    }

    export interface LangForm {
        LanguageName: Serenity.StringEditor;
    }

    [,
        ['LanguageName', () => Serenity.StringEditor]
    ].forEach(x => Object.defineProperty(LangForm.prototype, <string>x[0], {
        get: function () {
            return this.w(x[0], (x[1] as any)());
        },
        enumerable: true,
        configurable: true
    }));
}