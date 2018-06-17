namespace webNEOC.Campaign {
    export class CampaignForm extends Serenity.PrefixedContext {
        static formKey = 'Campaign.Campaign';

    }

    export interface CampaignForm {
        CampgaignName: Serenity.StringEditor;
        DateFrom: Serenity.DateEditor;
        DateTo: Serenity.DateEditor;
        RoundId: Serenity.IntegerEditor;
        DateCreated: Serenity.DateEditor;
        Comment: Serenity.StringEditor;
        Status: Serenity.BooleanEditor;
    }

    [['CampgaignName', () => Serenity.StringEditor], ['DateFrom', () => Serenity.DateEditor], ['DateTo', () => Serenity.DateEditor], ['RoundId', () => Serenity.IntegerEditor], ['DateCreated', () => Serenity.DateEditor], ['Comment', () => Serenity.StringEditor], ['Status', () => Serenity.BooleanEditor]].forEach(x => Object.defineProperty(CampaignForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

