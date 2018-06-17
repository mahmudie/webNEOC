namespace webNEOC.ImportHelper {
    export class CampaignImportForm extends Serenity.PrefixedContext {
        static formKey = 'ImportHelper.CampaignImport';

    }

    export interface CampaignImportForm {
        FileName: Serenity.ImageUploadEditor;
    }

    [['FileName', () => Serenity.ImageUploadEditor]].forEach(x => Object.defineProperty(CampaignImportForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}