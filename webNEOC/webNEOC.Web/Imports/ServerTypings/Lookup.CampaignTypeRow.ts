namespace webNEOC.Lookup {
    export interface CampaignTypeRow {
        CampaignTypeId?: number;
        CampaignName?: string;
    }

    export namespace CampaignTypeRow {
        export const idProperty = 'CampaignTypeId';
        export const nameProperty = 'CampaignName';
        export const localTextPrefix = 'Lookup.CampaignType';
        export const lookupKey = 'Lookup.CampaignType';

        export function getLookup(): Q.Lookup<CampaignTypeRow> {
            return Q.getLookup<CampaignTypeRow>('Lookup.CampaignType');
        }

        export namespace Fields {
            export declare const CampaignTypeId: string;
            export declare const CampaignName: string;
        }

        [
            'CampaignTypeId', 
            'CampaignName'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

