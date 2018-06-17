namespace webNEOC.Lookup {
    export interface MediaRow {
        MediaId?: number;
        MediaName?: string;
    }

    export namespace MediaRow {
        export const idProperty = 'MediaId';
        export const nameProperty = 'MediaName';
        export const localTextPrefix = 'Lookup.Media';

        export namespace Fields {
            export declare const MediaId: string;
            export declare const MediaName: string;
        }

        [
            'MediaId', 
            'MediaName'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

