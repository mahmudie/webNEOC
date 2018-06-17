namespace webNEOC.Lookup {
    export interface InAcsCategoryRow {
        InAcsCategoryId?: number;
        CategoryCode?: string;
        Description?: string;
    }

    export namespace InAcsCategoryRow {
        export const idProperty = 'InAcsCategoryId';
        export const nameProperty = 'Description';
        export const localTextPrefix = 'Lookup.InAcsCategory';
        export const lookupKey = 'Lookup.InAcsCategory';

        export function getLookup(): Q.Lookup<InAcsCategoryRow> {
            return Q.getLookup<InAcsCategoryRow>('Lookup.InAcsCategory');
        }

        export namespace Fields {
            export declare const InAcsCategoryId: string;
            export declare const CategoryCode: string;
            export declare const Description: string;
        }

        [
            'InAcsCategoryId', 
            'CategoryCode', 
            'Description'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

