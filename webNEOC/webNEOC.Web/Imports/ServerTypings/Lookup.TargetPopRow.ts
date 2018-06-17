namespace webNEOC.Lookup {
    export interface TargetPopRow {
        TargetId?: number;
        DistrictId?: number;
        YearId?: number;
        Population?: number;
        Target?: number;
        LpDs?: string;
        Comment?: string;
        DistrictDcode?: string;
        DistrictProvinceId?: number;
        DistrictDname?: string;
        DistrictTotalPop?: number;
        DistrictTargetPop?: number;
        DistrictType?: string;
        DistrictPriority?: number;
        DistrictPopYear?: number;
        ProvinceId?: number;
        Province?: string;
    }

    export namespace TargetPopRow {
        export const idProperty = 'TargetId';
        export const nameProperty = 'LpDs';
        export const localTextPrefix = 'Lookup.TargetPop';

        export namespace Fields {
            export declare const TargetId: string;
            export declare const DistrictId: string;
            export declare const YearId: string;
            export declare const Population: string;
            export declare const Target: string;
            export declare const LpDs: string;
            export declare const Comment: string;
            export declare const DistrictDcode: string;
            export declare const DistrictProvinceId: string;
            export declare const DistrictDname: string;
            export declare const DistrictTotalPop: string;
            export declare const DistrictTargetPop: string;
            export declare const DistrictType: string;
            export declare const DistrictPriority: string;
            export declare const DistrictPopYear: string;
            export declare const ProvinceId: string;
            export declare const Province: string;
        }

        [
            'TargetId', 
            'DistrictId', 
            'YearId', 
            'Population', 
            'Target', 
            'LpDs', 
            'Comment', 
            'DistrictDcode', 
            'DistrictProvinceId', 
            'DistrictDname', 
            'DistrictTotalPop', 
            'DistrictTargetPop', 
            'DistrictType', 
            'DistrictPriority', 
            'DistrictPopYear', 
            'ProvinceId', 
            'Province'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

