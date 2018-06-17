namespace webNEOC.ImportHelper {
    export class ICMHouseholdImportForm extends Serenity.PrefixedContext {
        static formKey = 'ImportHelper.ICMHouseholdImport';

    }

    export interface ICMHouseholdImportForm {
        FileName: Serenity.ImageUploadEditor;
    }

    [['FileName', () => Serenity.ImageUploadEditor]].forEach(x => Object.defineProperty(ICMHouseholdImportForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}