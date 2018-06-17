namespace webNEOC.ImportHelper {
    export class ICNImportForm extends Serenity.PrefixedContext {
        static formKey = 'ImportHelper.ICNImport';

    }

    export interface ICNImportForm {
        FileName: Serenity.ImageUploadEditor;
    }

    [['FileName', () => Serenity.ImageUploadEditor]].forEach(x => Object.defineProperty(ICNImportForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}