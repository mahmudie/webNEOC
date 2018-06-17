namespace webNEOC.Implementation {
    export interface VitaminAVaccinationsRow {
        VitaminAVaccinationsId?: number;
        VitaminADayId?: number;
        ClusterId?: number;
        TargetU5Cases?: number;
        d1VitADist?: number;
        d1VitAUse?: number;
        d1C611Months?: number;
        d1C1259Months?: number;
        d2VitADist?: number;
        d2VitAUse?: number;
        d2C611Months?: number;
        d2C1259Months?: number;
        d3VitADist?: number;
        d3VitAUse?: number;
        d3C611Months?: number;
        d3C1259Months?: number;
        d5VitADist?: number;
        d5VitAUse?: number;
        d5C611Months?: number;
        d5C1259Months?: number;
        VitaminADayCampaignId?: number;
        VitaminADayProvinceId?: number;
        VitaminADayDistrictId?: number;
        VitaminADayDayNumber?: number;
        VitaminADayDateOfCampaign?: string;
        VitaminADayPemtremtManager?: string;
        ClusterName?: string;
        TenantId?: number;
    }

    export namespace VitaminAVaccinationsRow {
        export const idProperty = 'VitaminAVaccinationsId';
        export const localTextPrefix = 'Implementation.VitaminAVaccinations';

        export namespace Fields {
            export declare const VitaminAVaccinationsId: string;
            export declare const VitaminADayId: string;
            export declare const ClusterId: string;
            export declare const TargetU5Cases: string;
            export declare const d1VitADist: string;
            export declare const d1VitAUse: string;
            export declare const d1C611Months: string;
            export declare const d1C1259Months: string;
            export declare const d2VitADist: string;
            export declare const d2VitAUse: string;
            export declare const d2C611Months: string;
            export declare const d2C1259Months: string;
            export declare const d3VitADist: string;
            export declare const d3VitAUse: string;
            export declare const d3C611Months: string;
            export declare const d3C1259Months: string;
            export declare const d5VitADist: string;
            export declare const d5VitAUse: string;
            export declare const d5C611Months: string;
            export declare const d5C1259Months: string;
            export declare const VitaminADayCampaignId: string;
            export declare const VitaminADayProvinceId: string;
            export declare const VitaminADayDistrictId: string;
            export declare const VitaminADayDayNumber: string;
            export declare const VitaminADayDateOfCampaign: string;
            export declare const VitaminADayPemtremtManager: string;
            export declare const ClusterName: string;
            export declare const TenantId: string;
        }

        [
            'VitaminAVaccinationsId', 
            'VitaminADayId', 
            'ClusterId', 
            'TargetU5Cases', 
            'd1VitADist', 
            'd1VitAUse', 
            'd1C611Months', 
            'd1C1259Months', 
            'd2VitADist', 
            'd2VitAUse', 
            'd2C611Months', 
            'd2C1259Months', 
            'd3VitADist', 
            'd3VitAUse', 
            'd3C611Months', 
            'd3C1259Months', 
            'd5VitADist', 
            'd5VitAUse', 
            'd5C611Months', 
            'd5C1259Months', 
            'VitaminADayCampaignId', 
            'VitaminADayProvinceId', 
            'VitaminADayDistrictId', 
            'VitaminADayDayNumber', 
            'VitaminADayDateOfCampaign', 
            'VitaminADayPemtremtManager', 
            'ClusterName', 
            'TenantId'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

