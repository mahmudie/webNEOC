namespace webNEOC.Lookup {
    export interface VehicletypeRow {
        VehicletypeId?: number;
        Typename?: string;
    }

    export namespace VehicletypeRow {
        export const idProperty = 'VehicletypeId';
        export const nameProperty = 'Typename';
        export const localTextPrefix = 'Lookup.Vehicletype';
        export const lookupKey = 'Lookup.Vehicletype';

        export function getLookup(): Q.Lookup<VehicletypeRow> {
            return Q.getLookup<VehicletypeRow>('Lookup.Vehicletype');
        }

        export namespace Fields {
            export declare const VehicletypeId: string;
            export declare const Typename: string;
        }

        [
            'VehicletypeId', 
            'Typename'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

