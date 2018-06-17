namespace webNEOC.Implementation {
    export interface IcnRow {
        IcnId?: string;
        RoundId?: number;
        DistrictId?: number;
        ClusterId?: number;
        Area?: string;
        RegAbsent?: number;
        VacAbsent?: number;
        RegNss?: number;
        VacNss?: number;
        RegRefusal?: number;
        VacRefusal?: number;
        RegUnrecorded?: number;
        VacUnrecorded?: number;
        TenantId?: number;
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
        RoundName?: string;
        DateFrom?: string;
        DateTo?: string;
        Cname?: string;
    }

    export namespace IcnRow {
        export const idProperty = 'IcnId';
        export const nameProperty = 'Area';
        export const localTextPrefix = 'Implementation.Icn';

        export namespace Fields {
            export declare const IcnId: string;
            export declare const RoundId: string;
            export declare const DistrictId: string;
            export declare const ClusterId: string;
            export declare const Area: string;
            export declare const RegAbsent: string;
            export declare const VacAbsent: string;
            export declare const RegNss: string;
            export declare const VacNss: string;
            export declare const RegRefusal: string;
            export declare const VacRefusal: string;
            export declare const RegUnrecorded: string;
            export declare const VacUnrecorded: string;
            export declare const TenantId: string;
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
            export declare const RoundName: string;
            export declare const DateFrom: string;
            export declare const DateTo: string;
            export declare const Cname: string;
        }

        [
            'IcnId', 
            'RoundId', 
            'DistrictId', 
            'ClusterId', 
            'Area', 
            'RegAbsent', 
            'VacAbsent', 
            'RegNss', 
            'VacNss', 
            'RegRefusal', 
            'VacRefusal', 
            'RegUnrecorded', 
            'VacUnrecorded', 
            'TenantId', 
            'DistrictDcode', 
            'DistrictProvinceId', 
            'DistrictDname', 
            'DistrictTotalPop', 
            'DistrictTargetPop', 
            'DistrictType', 
            'DistrictPriority', 
            'DistrictPopYear', 
            'ProvinceId', 
            'Province', 
            'RoundName', 
            'DateFrom', 
            'DateTo', 
            'Cname'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

