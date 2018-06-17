namespace webNEOC.Lookup {
    export interface DaysRow {
        DayId?: number;
        DayName?: string;
    }

    export namespace DaysRow {
        export const idProperty = 'DayId';
        export const nameProperty = 'DayName';
        export const localTextPrefix = 'Lookup.Days';

        export namespace Fields {
            export declare const DayId: string;
            export declare const DayName: string;
        }

        [
            'DayId', 
            'DayName'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

