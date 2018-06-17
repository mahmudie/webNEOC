namespace webNEOC.Lookup {
    export class RoundForm extends Serenity.PrefixedContext {
        static formKey = 'Lookup.Round';

    }

    export interface RoundForm {
        CampaignTypeId: Serenity.LookupEditor;
        DateFrom: Serenity.DateEditor;
        DateTo: Serenity.DateEditor;
        RoundName: Serenity.StringEditor;
    }

    [['CampaignTypeId', () => Serenity.LookupEditor], ['DateFrom', () => Serenity.DateEditor], ['DateTo', () => Serenity.DateEditor], ['RoundName', () => Serenity.StringEditor]].forEach(x => Object.defineProperty(RoundForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

