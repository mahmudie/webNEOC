namespace webNEOC.Lookup {
    export class InAcsCategoryForm extends Serenity.PrefixedContext {
        static formKey = 'Lookup.InAcsCategory';

    }

    export interface InAcsCategoryForm {
        CategoryCode: Serenity.StringEditor;
        Description: Serenity.StringEditor;
    }

    [['CategoryCode', () => Serenity.StringEditor], ['Description', () => Serenity.StringEditor]].forEach(x => Object.defineProperty(InAcsCategoryForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

