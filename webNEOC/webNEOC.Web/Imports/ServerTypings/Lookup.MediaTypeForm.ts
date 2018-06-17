namespace webNEOC.Lookup {
    export class MediaTypeForm extends Serenity.PrefixedContext {
        static formKey = 'Lookup.MediaType';

    }

    export interface MediaTypeForm {
        MediaTypeName: Serenity.StringEditor;
    }

    [['MediaTypeName', () => Serenity.StringEditor]].forEach(x => Object.defineProperty(MediaTypeForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

