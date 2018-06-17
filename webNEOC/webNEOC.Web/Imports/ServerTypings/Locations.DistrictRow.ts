namespace webNEOC.Locations {
    export interface DistrictRow {
        DistrictId?: number;
        Dcode?: string;
        ProvinceId?: number;
        Dname?: string;
        TotalPop?: number;
        TargetPop?: number;
        Type?: string;
        Priority?: number;
        PopYear?: number;
        ProvincePcode?: string;
        ProvinceRegionId?: number;
        Pname?: string;
        ProvincePAbrv?: string;
        ProvincePcenter?: string;
        ProvinceAreaKmSqr?: number;
        ProvinceNoOfDistricts?: number;
    }

    export namespace DistrictRow {
        export const idProperty = 'DistrictId';
        export const nameProperty = 'Dname';
        export const localTextPrefix = 'Locations.District';
        export const lookupKey = 'Locations.District';

        export function getLookup(): Q.Lookup<DistrictRow> {
            return Q.getLookup<DistrictRow>('Locations.District');
        }

        export namespace Fields {
            export declare const DistrictId: string;
            export declare const Dcode: string;
            export declare const ProvinceId: string;
            export declare const Dname: string;
            export declare const TotalPop: string;
            export declare const TargetPop: string;
            export declare const Type: string;
            export declare const Priority: string;
            export declare const PopYear: string;
            export declare const ProvincePcode: string;
            export declare const ProvinceRegionId: string;
            export declare const Pname: string;
            export declare const ProvincePAbrv: string;
            export declare const ProvincePcenter: string;
            export declare const ProvinceAreaKmSqr: string;
            export declare const ProvinceNoOfDistricts: string;
        }

        [
            'DistrictId', 
            'Dcode', 
            'ProvinceId', 
            'Dname', 
            'TotalPop', 
            'TargetPop', 
            'Type', 
            'Priority', 
            'PopYear', 
            'ProvincePcode', 
            'ProvinceRegionId', 
            'Pname', 
            'ProvincePAbrv', 
            'ProvincePcenter', 
            'ProvinceAreaKmSqr', 
            'ProvinceNoOfDistricts'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

