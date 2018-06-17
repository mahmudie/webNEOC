namespace webNEOC.Lookup {
    export class CampaignTypeForm extends Serenity.PrefixedContext {
        static formKey = 'Lookup.CampaignType';

    }

    export interface CampaignTypeForm {
        CampaignName: Serenity.StringEditor;
    }

    [['CampaignName', () => Serenity.StringEditor]].forEach(x => Object.defineProperty(CampaignTypeForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

