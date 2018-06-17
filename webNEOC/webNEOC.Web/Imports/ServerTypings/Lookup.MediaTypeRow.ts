namespace webNEOC.Lookup {
    export interface MediaTypeRow {
        MediaTypeId?: number;
        MediaTypeName?: string;
    }

    export namespace MediaTypeRow {
        export const idProperty = 'MediaTypeId';
        export const nameProperty = 'MediaTypeName';
        export const localTextPrefix = 'Lookup.MediaType';

        export namespace Fields {
            export declare const MediaTypeId: string;
            export declare const MediaTypeName: string;
        }

        [
            'MediaTypeId', 
            'MediaTypeName'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

