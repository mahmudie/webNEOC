namespace webNEOC.ImportHelper {
    export class CommunicationImportForm extends Serenity.PrefixedContext {
        static formKey = 'ImportHelper.CommunicationImport';

    }

    export interface CommunicationImportForm {
        FileName: Serenity.ImageUploadEditor;
    }

    [['FileName', () => Serenity.ImageUploadEditor]].forEach(x => Object.defineProperty(CommunicationImportForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}