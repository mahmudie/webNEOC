namespace webNEOC.Campaign {
    export interface CampaignDayRow {
        CampaignDayId?: number;
        RoundId?: number;
        ProvinceId?: number;
        DistrictId?: number;
        DateOfCampaign?: string;
        PemtremtManager?: string;
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
        TenantId?: number;
        RoundName?: string;
        VaccinationList?: DailyVaccinationsRow[];
    }

    export namespace CampaignDayRow {
        export const idProperty = 'CampaignDayId';
        export const nameProperty = 'RoundName';
        export const localTextPrefix = 'Campaign.CampaignDay';
        export const lookupKey = 'Campaign.CampaignDay';

        export function getLookup(): Q.Lookup<CampaignDayRow> {
            return Q.getLookup<CampaignDayRow>('Campaign.CampaignDay');
        }

        export namespace Fields {
            export declare const CampaignDayId: string;
            export declare const RoundId: string;
            export declare const ProvinceId: string;
            export declare const DistrictId: string;
            export declare const DateOfCampaign: string;
            export declare const PemtremtManager: string;
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
            export declare const TenantId: string;
            export declare const RoundName: string;
            export declare const VaccinationList: string;
        }

        [
            'CampaignDayId', 
            'RoundId', 
            'ProvinceId', 
            'DistrictId', 
            'DateOfCampaign', 
            'PemtremtManager', 
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
            'TenantId', 
            'RoundName', 
            'VaccinationList'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

