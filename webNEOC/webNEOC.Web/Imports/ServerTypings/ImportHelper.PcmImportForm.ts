namespace webNEOC.ImportHelper {
    export class PcmImportForm extends Serenity.PrefixedContext {
        static formKey = 'ImportHelper.PcmImport';

    }

    export interface PcmImportForm {
        FileName: Serenity.ImageUploadEditor;
    }

    [['FileName', () => Serenity.ImageUploadEditor]].forEach(x => Object.defineProperty(PcmImportForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}