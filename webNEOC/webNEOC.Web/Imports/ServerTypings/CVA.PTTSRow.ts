namespace webNEOC.CVA {
    export interface PTTSRow {
        PttsId?: number;
        DistrictId?: number;
        Year?: number;
        MonthId?: number;
        Type?: string;
        Subtype?: string;
        NoOfTeam?: number;
        TeamName?: string;
        Boys011?: number;
        Girls011?: number;
        Boys1259?: number;
        Girls1259?: number;
        Remarks?: string;
        DistrictDcode?: string;
        ProvinceId?: number;
        DistrictDname?: string;
        DistrictTotalPop?: number;
        DistrictTargetPop?: number;
        DistrictType?: string;
        DistrictPriority?: number;
        DistrictPopYear?: number;
        DistrictLat?: number;
        DistrictLon?: number;
        ProvName?: string;
        MonthName?: string;
        TenantId?: number;
    }

    export namespace PTTSRow {
        export const idProperty = 'PttsId';
        export const nameProperty = 'TeamName';
        export const localTextPrefix = 'CVA.PTTS';

        export namespace Fields {
            export declare const PttsId: string;
            export declare const DistrictId: string;
            export declare const Year: string;
            export declare const MonthId: string;
            export declare const Type: string;
            export declare const Subtype: string;
            export declare const NoOfTeam: string;
            export declare const TeamName: string;
            export declare const Boys011: string;
            export declare const Girls011: string;
            export declare const Boys1259: string;
            export declare const Girls1259: string;
            export declare const Remarks: string;
            export declare const DistrictDcode: string;
            export declare const ProvinceId: string;
            export declare const DistrictDname: string;
            export declare const DistrictTotalPop: string;
            export declare const DistrictTargetPop: string;
            export declare const DistrictType: string;
            export declare const DistrictPriority: string;
            export declare const DistrictPopYear: string;
            export declare const DistrictLat: string;
            export declare const DistrictLon: string;
            export declare const ProvName: string;
            export declare const MonthName: string;
            export declare const TenantId: string;
        }

        [
            'PttsId', 
            'DistrictId', 
            'Year', 
            'MonthId', 
            'Type', 
            'Subtype', 
            'NoOfTeam', 
            'TeamName', 
            'Boys011', 
            'Girls011', 
            'Boys1259', 
            'Girls1259', 
            'Remarks', 
            'DistrictDcode', 
            'ProvinceId', 
            'DistrictDname', 
            'DistrictTotalPop', 
            'DistrictTargetPop', 
            'DistrictType', 
            'DistrictPriority', 
            'DistrictPopYear', 
            'DistrictLat', 
            'DistrictLon', 
            'ProvName', 
            'MonthName', 
            'TenantId'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

