namespace webNEOC.ImportHelper {
    export class ICMSupervisorImportForm extends Serenity.PrefixedContext {
        static formKey = 'ImportHelper.ICMSupervisorImport';

    }

    export interface ICMSupervisorImportForm {
        FileName: Serenity.ImageUploadEditor;
    }

    [['FileName', () => Serenity.ImageUploadEditor]].forEach(x => Object.defineProperty(ICMSupervisorImportForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}