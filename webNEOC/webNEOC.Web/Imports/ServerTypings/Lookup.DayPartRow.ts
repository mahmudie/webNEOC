namespace webNEOC.Lookup {
    export interface DayPartRow {
        DaypartId?: number;
        Daypart?: string;
    }

    export namespace DayPartRow {
        export const idProperty = 'DaypartId';
        export const nameProperty = 'Daypart';
        export const localTextPrefix = 'Lookup.DayPart';

        export namespace Fields {
            export declare const DaypartId: string;
            export declare const Daypart: string;
        }

        [
            'DaypartId', 
            'Daypart'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

