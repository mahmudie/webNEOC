namespace webNEOC.ImportHelper {
    export class LQASImportForm extends Serenity.PrefixedContext {
        static formKey = 'ImportHelper.LQASImport';

    }

    export interface LQASImportForm {
        FileName: Serenity.ImageUploadEditor;
    }

    [['FileName', () => Serenity.ImageUploadEditor]].forEach(x => Object.defineProperty(LQASImportForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}