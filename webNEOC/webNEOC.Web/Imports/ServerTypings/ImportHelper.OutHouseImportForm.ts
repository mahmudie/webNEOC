namespace webNEOC.ImportHelper {
    export class OutHouseImportForm extends Serenity.PrefixedContext {
        static formKey = 'ImportHelper.OutHouseImport';

    }

    export interface OutHouseImportForm {
        FileName: Serenity.ImageUploadEditor;
    }

    [['FileName', () => Serenity.ImageUploadEditor]].forEach(x => Object.defineProperty(OutHouseImportForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}