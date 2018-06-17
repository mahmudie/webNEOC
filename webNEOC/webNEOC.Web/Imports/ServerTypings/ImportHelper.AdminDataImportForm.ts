namespace webNEOC.ImportHelper {
    export class AdminDataImportForm extends Serenity.PrefixedContext {
        static formKey = 'ImportHelper.AdminDataImport';

    }

    export interface AdminDataImportForm {
        FileName: Serenity.ImageUploadEditor;
    }

    [['FileName', () => Serenity.ImageUploadEditor]].forEach(x => Object.defineProperty(AdminDataImportForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}