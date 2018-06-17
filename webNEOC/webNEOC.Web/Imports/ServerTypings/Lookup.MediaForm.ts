namespace webNEOC.Lookup {
    export class MediaForm extends Serenity.PrefixedContext {
        static formKey = 'Lookup.Media';

    }

    export interface MediaForm {
        MediaName: Serenity.StringEditor;
    }

    [['MediaName', () => Serenity.StringEditor]].forEach(x => Object.defineProperty(MediaForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

