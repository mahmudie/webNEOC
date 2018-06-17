namespace webNEOC.ImportHelper {
    export class VitaminAImportForm extends Serenity.PrefixedContext {
        static formKey = 'ImportHelper.VitaminAImport';

    }

    export interface VitaminAImportForm {
        FileName: Serenity.ImageUploadEditor;
    }

    [['FileName', () => Serenity.ImageUploadEditor]].forEach(x => Object.defineProperty(VitaminAImportForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}