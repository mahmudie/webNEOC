namespace webNEOC.Lookup {
    export interface MonthsRow {
        MonthId?: number;
        Monthshort?: string;
        Monthlong?: string;
    }

    export namespace MonthsRow {
        export const idProperty = 'MonthId';
        export const nameProperty = 'Monthlong';
        export const localTextPrefix = 'Lookup.Months';
        export const lookupKey = 'Lookup.Months';

        export function getLookup(): Q.Lookup<MonthsRow> {
            return Q.getLookup<MonthsRow>('Lookup.Months');
        }

        export namespace Fields {
            export declare const MonthId: string;
            export declare const Monthshort: string;
            export declare const Monthlong: string;
        }

        [
            'MonthId', 
            'Monthshort', 
            'Monthlong'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

