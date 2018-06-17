namespace webNEOC.Lookup {
    export interface IcnTypeRow {
        IcnTypeId?: number;
        IcnType?: string;
    }

    export namespace IcnTypeRow {
        export const idProperty = 'IcnTypeId';
        export const nameProperty = 'IcnType';
        export const localTextPrefix = 'Lookup.IcnType';

        export namespace Fields {
            export declare const IcnTypeId: string;
            export declare const IcnType: string;
        }

        [
            'IcnTypeId', 
            'IcnType'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

