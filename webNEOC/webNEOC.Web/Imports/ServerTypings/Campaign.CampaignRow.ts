namespace webNEOC.Campaign {
    export interface CampaignRow {
        CampaignId?: number;
        CampgaignName?: string;
        DateFrom?: string;
        DateTo?: string;
        RoundId?: number;
        DateCreated?: string;
        Comment?: string;
        Status?: boolean;
    }

    export namespace CampaignRow {
        export const idProperty = 'CampaignId';
        export const nameProperty = 'CampgaignName';
        export const localTextPrefix = 'Campaign.Campaign';
        export const lookupKey = 'Campaign.Campaign';

        export function getLookup(): Q.Lookup<CampaignRow> {
            return Q.getLookup<CampaignRow>('Campaign.Campaign');
        }

        export namespace Fields {
            export declare const CampaignId: string;
            export declare const CampgaignName: string;
            export declare const DateFrom: string;
            export declare const DateTo: string;
            export declare const RoundId: string;
            export declare const DateCreated: string;
            export declare const Comment: string;
            export declare const Status: string;
        }

        [
            'CampaignId', 
            'CampgaignName', 
            'DateFrom', 
            'DateTo', 
            'RoundId', 
            'DateCreated', 
            'Comment', 
            'Status'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

