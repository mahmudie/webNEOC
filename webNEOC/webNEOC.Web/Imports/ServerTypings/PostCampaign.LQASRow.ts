namespace webNEOC.PostCampaign {
    export interface LQASRow {
        LqasId?: number;
        DistrictId?: number;
        LotNo?: number;
        NoVaccChildren?: number;
        RoundId?: number;
        Comments?: string;
        RoundName?: string;
        DateFrom?: string;
        DateTo?: string;
        TenantId?: number;
        DistrictDcode?: string;
        ProvinceId?: number;
        DistrictDname?: string;
        Province?: string;
        DistrictTotalPop?: number;
        DistrictTargetPop?: number;
        DistrictPriority?: number;
        DistrictPopYear?: number;
    }

    export namespace LQASRow {
        export const idProperty = 'LqasId';
        export const nameProperty = 'Comments';
        export const localTextPrefix = 'PostCampaign.LQAS';

        export namespace Fields {
            export declare const LqasId: string;
            export declare const DistrictId: string;
            export declare const LotNo: string;
            export declare const NoVaccChildren: string;
            export declare const RoundId: string;
            export declare const Comments: string;
            export declare const RoundName: string;
            export declare const DateFrom: string;
            export declare const DateTo: string;
            export declare const TenantId: string;
            export declare const DistrictDcode: string;
            export declare const ProvinceId: string;
            export declare const DistrictDname: string;
            export declare const Province: string;
            export declare const DistrictTotalPop: string;
            export declare const DistrictTargetPop: string;
            export declare const DistrictPriority: string;
            export declare const DistrictPopYear: string;
        }

        [
            'LqasId', 
            'DistrictId', 
            'LotNo', 
            'NoVaccChildren', 
            'RoundId', 
            'Comments', 
            'RoundName', 
            'DateFrom', 
            'DateTo', 
            'TenantId', 
            'DistrictDcode', 
            'ProvinceId', 
            'DistrictDname', 
            'Province', 
            'DistrictTotalPop', 
            'DistrictTargetPop', 
            'DistrictPriority', 
            'DistrictPopYear'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

