namespace webNEOC.ImportGate {
    export interface TempVitaminARow {
        TempVitaminAId?: number;
        RoundId?: number;
        ProvinceId?: number;
        DistrictId?: number;
        PemtremtManager?: string;
        ClusterId?: number;
        TargetU5Cases?: number;
        D1VitADist?: number;
        D1VitAUse?: number;
        D1C611Months?: number;
        D1C1259Months?: number;
        D2VitADist?: number;
        D2VitAUse?: number;
        D2C611Months?: number;
        D2C1259Months?: number;
        D3VitADist?: number;
        D3VitAUse?: number;
        D3C611Months?: number;
        D3C1259Months?: number;
        D5VitADist?: number;
        D5VitAUse?: number;
        D5C611Months?: number;
        D5C1259Months?: number;
        TenantId?: number;
        RoundName?: string;
        ProvinceName?: string;
        DistrictName?: string;
        ClusterName?: string;
    }

    export namespace TempVitaminARow {
        export const idProperty = 'TempVitaminAId';
        export const nameProperty = 'PemtremtManager';
        export const localTextPrefix = 'ImportGate.TempVitaminA';

        export namespace Fields {
            export declare const TempVitaminAId: string;
            export declare const RoundId: string;
            export declare const ProvinceId: string;
            export declare const DistrictId: string;
            export declare const PemtremtManager: string;
            export declare const ClusterId: string;
            export declare const TargetU5Cases: string;
            export declare const D1VitADist: string;
            export declare const D1VitAUse: string;
            export declare const D1C611Months: string;
            export declare const D1C1259Months: string;
            export declare const D2VitADist: string;
            export declare const D2VitAUse: string;
            export declare const D2C611Months: string;
            export declare const D2C1259Months: string;
            export declare const D3VitADist: string;
            export declare const D3VitAUse: string;
            export declare const D3C611Months: string;
            export declare const D3C1259Months: string;
            export declare const D5VitADist: string;
            export declare const D5VitAUse: string;
            export declare const D5C611Months: string;
            export declare const D5C1259Months: string;
            export declare const TenantId: string;
            export declare const RoundName: string;
            export declare const ProvinceName: string;
            export declare const DistrictName: string;
            export declare const ClusterName: string;
        }

        [
            'TempVitaminAId', 
            'RoundId', 
            'ProvinceId', 
            'DistrictId', 
            'PemtremtManager', 
            'ClusterId', 
            'TargetU5Cases', 
            'D1VitADist', 
            'D1VitAUse', 
            'D1C611Months', 
            'D1C1259Months', 
            'D2VitADist', 
            'D2VitAUse', 
            'D2C611Months', 
            'D2C1259Months', 
            'D3VitADist', 
            'D3VitAUse', 
            'D3C611Months', 
            'D3C1259Months', 
            'D5VitADist', 
            'D5VitAUse', 
            'D5C611Months', 
            'D5C1259Months', 
            'TenantId', 
            'RoundName', 
            'ProvinceName', 
            'DistrictName', 
            'ClusterName'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

