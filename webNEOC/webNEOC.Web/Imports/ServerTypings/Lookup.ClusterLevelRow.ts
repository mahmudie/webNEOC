namespace webNEOC.Lookup {
    export interface ClusterLevelRow {
        ClusterLevelId?: number;
        ClusterName?: string;
    }

    export namespace ClusterLevelRow {
        export const idProperty = 'ClusterLevelId';
        export const nameProperty = 'ClusterName';
        export const localTextPrefix = 'Lookup.ClusterLevel';
        export const lookupKey = 'Lookup.ClusterLevel';

        export function getLookup(): Q.Lookup<ClusterLevelRow> {
            return Q.getLookup<ClusterLevelRow>('Lookup.ClusterLevel');
        }

        export namespace Fields {
            export declare const ClusterLevelId: string;
            export declare const ClusterName: string;
        }

        [
            'ClusterLevelId', 
            'ClusterName'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

