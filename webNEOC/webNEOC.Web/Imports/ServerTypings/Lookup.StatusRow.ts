namespace webNEOC.Lookup {
    export interface StatusRow {
        StatusId?: number;
        StatusName?: string;
    }

    export namespace StatusRow {
        export const idProperty = 'StatusId';
        export const nameProperty = 'StatusName';
        export const localTextPrefix = 'Lookup.Status';
        export const lookupKey = 'Lookup.Status';

        export function getLookup(): Q.Lookup<StatusRow> {
            return Q.getLookup<StatusRow>('Lookup.Status');
        }

        export namespace Fields {
            export declare const StatusId: string;
            export declare const StatusName: string;
        }

        [
            'StatusId', 
            'StatusName'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

