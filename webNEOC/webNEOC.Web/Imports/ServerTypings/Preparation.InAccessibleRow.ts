namespace webNEOC.Preparation {
    export interface InAccessibleRow {
        InAccessibleId?: number;
        RoundId?: number;
        DistrictId?: number;
        ReportDate?: string;
        Target?: number;
        MissedClusters?: number;
        MissedChildren?: number;
        PartiallyMissed?: number;
        PartiallyMissedName?: string;
        FullyMissed?: number;
        FullyMissedName?: string;
        InAcsCategoryId?: number;
        PlanToReduce?: string;
        Remarks?: string;
        RoundName?: string;
        DateFrom?: string;
        DateTo?: string;
        TenantId?: number;
        DistrictDcode?: string;
        ProvinceId?: number;
        Province?: string;
        DistrictDname?: string;
        DistrictTotalPop?: number;
        DistrictTargetPop?: number;
        DistrictType?: string;
        DistrictPriority?: number;
        DistrictPopYear?: number;
        Description?: string;
    }

    export namespace InAccessibleRow {
        export const idProperty = 'InAccessibleId';
        export const nameProperty = 'PartiallyMissedName';
        export const localTextPrefix = 'Preparation.InAccessible';

        export namespace Fields {
            export declare const InAccessibleId: string;
            export declare const RoundId: string;
            export declare const DistrictId: string;
            export declare const ReportDate: string;
            export declare const Target: string;
            export declare const MissedClusters: string;
            export declare const MissedChildren: string;
            export declare const PartiallyMissed: string;
            export declare const PartiallyMissedName: string;
            export declare const FullyMissed: string;
            export declare const FullyMissedName: string;
            export declare const InAcsCategoryId: string;
            export declare const PlanToReduce: string;
            export declare const Remarks: string;
            export declare const RoundName: string;
            export declare const DateFrom: string;
            export declare const DateTo: string;
            export declare const TenantId: string;
            export declare const DistrictDcode: string;
            export declare const ProvinceId: string;
            export declare const Province: string;
            export declare const DistrictDname: string;
            export declare const DistrictTotalPop: string;
            export declare const DistrictTargetPop: string;
            export declare const DistrictType: string;
            export declare const DistrictPriority: string;
            export declare const DistrictPopYear: string;
            export declare const Description: string;
        }

        [
            'InAccessibleId', 
            'RoundId', 
            'DistrictId', 
            'ReportDate', 
            'Target', 
            'MissedClusters', 
            'MissedChildren', 
            'PartiallyMissed', 
            'PartiallyMissedName', 
            'FullyMissed', 
            'FullyMissedName', 
            'InAcsCategoryId', 
            'PlanToReduce', 
            'Remarks', 
            'RoundName', 
            'DateFrom', 
            'DateTo', 
            'TenantId', 
            'DistrictDcode', 
            'ProvinceId', 
            'Province', 
            'DistrictDname', 
            'DistrictTotalPop', 
            'DistrictTargetPop', 
            'DistrictType', 
            'DistrictPriority', 
            'DistrictPopYear', 
            'Description'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

