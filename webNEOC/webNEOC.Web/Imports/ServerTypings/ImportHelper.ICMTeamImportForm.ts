namespace webNEOC.ImportHelper {
    export class ICMTeamImportForm extends Serenity.PrefixedContext {
        static formKey = 'ImportHelper.ICMTeamImport';

    }

    export interface ICMTeamImportForm {
        FileName: Serenity.ImageUploadEditor;
    }

    [['FileName', () => Serenity.ImageUploadEditor]].forEach(x => Object.defineProperty(ICMTeamImportForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}