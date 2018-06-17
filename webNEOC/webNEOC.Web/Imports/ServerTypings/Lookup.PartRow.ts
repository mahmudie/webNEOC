namespace webNEOC.Lookup {
    export interface PartRow {
        PartId?: number;
        PartName?: string;
    }

    export namespace PartRow {
        export const idProperty = 'PartId';
        export const nameProperty = 'PartName';
        export const localTextPrefix = 'Lookup.Part';
        export const lookupKey = 'Lookup.Part';

        export function getLookup(): Q.Lookup<PartRow> {
            return Q.getLookup<PartRow>('Lookup.Part');
        }

        export namespace Fields {
            export declare const PartId: string;
            export declare const PartName: string;
        }

        [
            'PartId', 
            'PartName'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

