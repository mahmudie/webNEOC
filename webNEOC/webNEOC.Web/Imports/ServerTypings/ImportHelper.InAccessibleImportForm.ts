namespace webNEOC.ImportHelper {
    export class InAccessibleImportForm extends Serenity.PrefixedContext {
        static formKey = 'ImportHelper.InAccessibleImport';

    }

    export interface InAccessibleImportForm {
        FileName: Serenity.ImageUploadEditor;
    }

    [['FileName', () => Serenity.ImageUploadEditor]].forEach(x => Object.defineProperty(InAccessibleImportForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}