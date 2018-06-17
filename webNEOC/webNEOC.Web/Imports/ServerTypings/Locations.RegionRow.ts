namespace webNEOC.Locations {
    export interface RegionRow {
        RegionId?: number;
        Rname?: string;
        RAbrv?: string;
    }

    export namespace RegionRow {
        export const idProperty = 'RegionId';
        export const nameProperty = 'Rname';
        export const localTextPrefix = 'Locations.Region';
        export const lookupKey = 'Locations.Region';

        export function getLookup(): Q.Lookup<RegionRow> {
            return Q.getLookup<RegionRow>('Locations.Region');
        }

        export namespace Fields {
            export declare const RegionId: string;
            export declare const Rname: string;
            export declare const RAbrv: string;
        }

        [
            'RegionId', 
            'Rname', 
            'RAbrv'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

