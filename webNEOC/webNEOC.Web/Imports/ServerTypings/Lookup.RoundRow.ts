namespace webNEOC.Lookup {
    export interface RoundRow {
        RoundId?: number;
        DateFrom?: string;
        DateTo?: string;
        RoundName?: string;
        CampaignTypeId?: number;
        CampaignName?: string;
    }

    export namespace RoundRow {
        export const idProperty = 'RoundId';
        export const nameProperty = 'RoundName';
        export const localTextPrefix = 'Lookup.Round';
        export const lookupKey = 'Lookup.Round';

        export function getLookup(): Q.Lookup<RoundRow> {
            return Q.getLookup<RoundRow>('Lookup.Round');
        }

        export namespace Fields {
            export declare const RoundId: string;
            export declare const DateFrom: string;
            export declare const DateTo: string;
            export declare const RoundName: string;
            export declare const CampaignTypeId: string;
            export declare const CampaignName: string;
        }

        [
            'RoundId', 
            'DateFrom', 
            'DateTo', 
            'RoundName', 
            'CampaignTypeId', 
            'CampaignName'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

