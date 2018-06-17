namespace webNEOC.ImportHelper {
    export class MobileTeamImportForm extends Serenity.PrefixedContext {
        static formKey = 'ImportHelper.MobileTeamImport';

    }

    export interface MobileTeamImportForm {
        FileName: Serenity.ImageUploadEditor;
    }

    [['FileName', () => Serenity.ImageUploadEditor]].forEach(x => Object.defineProperty(MobileTeamImportForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}