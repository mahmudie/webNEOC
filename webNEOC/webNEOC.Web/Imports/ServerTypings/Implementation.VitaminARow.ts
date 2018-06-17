namespace webNEOC.Implementation {
    export interface VitaminARow {
        VitaminADayId?: number;
        RoundId?: number;
        ProvinceId?: number;
        DistrictId?: number;
        PemtremtManager?: string;
        RoundName?: string;
        DateFrom?: string;
        DateTo?: string;
        TenantId?: number;
        ProvincePcode?: string;
        ProvinceRegionId?: number;
        ProvincePname?: string;
        ProvincePAbrv?: string;
        ProvincePcenter?: string;
        ProvinceAreaKmSqr?: number;
        ProvinceNoOfDistricts?: number;
        DistrictDcode?: string;
        DistrictProvinceId?: number;
        DistrictDname?: string;
        DistrictTotalPop?: number;
        DistrictTargetPop?: number;
        DistrictType?: string;
        DistrictPriority?: number;
        DistrictPopYear?: number;
        VitaminAVaccinations?: VitaminAVaccinationsRow[];
    }

    export namespace VitaminARow {
        export const idProperty = 'VitaminADayId';
        export const nameProperty = 'PemtremtManager';
        export const localTextPrefix = 'Implementation.VitaminA';

        export namespace Fields {
            export declare const VitaminADayId: string;
            export declare const RoundId: string;
            export declare const ProvinceId: string;
            export declare const DistrictId: string;
            export declare const PemtremtManager: string;
            export declare const RoundName: string;
            export declare const DateFrom: string;
            export declare const DateTo: string;
            export declare const TenantId: string;
            export declare const ProvincePcode: string;
            export declare const ProvinceRegionId: string;
            export declare const ProvincePname: string;
            export declare const ProvincePAbrv: string;
            export declare const ProvincePcenter: string;
            export declare const ProvinceAreaKmSqr: string;
            export declare const ProvinceNoOfDistricts: string;
            export declare const DistrictDcode: string;
            export declare const DistrictProvinceId: string;
            export declare const DistrictDname: string;
            export declare const DistrictTotalPop: string;
            export declare const DistrictTargetPop: string;
            export declare const DistrictType: string;
            export declare const DistrictPriority: string;
            export declare const DistrictPopYear: string;
            export declare const VitaminAVaccinations: string;
        }

        [
            'VitaminADayId', 
            'RoundId', 
            'ProvinceId', 
            'DistrictId', 
            'PemtremtManager', 
            'RoundName', 
            'DateFrom', 
            'DateTo', 
            'TenantId', 
            'ProvincePcode', 
            'ProvinceRegionId', 
            'ProvincePname', 
            'ProvincePAbrv', 
            'ProvincePcenter', 
            'ProvinceAreaKmSqr', 
            'ProvinceNoOfDistricts', 
            'DistrictDcode', 
            'DistrictProvinceId', 
            'DistrictDname', 
            'DistrictTotalPop', 
            'DistrictTargetPop', 
            'DistrictType', 
            'DistrictPriority', 
            'DistrictPopYear', 
            'VitaminAVaccinations'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

