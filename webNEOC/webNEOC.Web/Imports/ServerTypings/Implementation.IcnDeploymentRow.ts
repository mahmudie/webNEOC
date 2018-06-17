namespace webNEOC.Implementation {
    export interface IcnDeploymentRow {
        IcnDeploymentId?: number;
        DistrictId?: number;
        PlannedIcn?: number;
        RecruitedIcn?: number;
        RecruitedMale?: number;
        RecruitedFemale?: number;
        IcnTypeId?: number;
        RecruitmentTypeId?: number;
        MonthId?: number;
        Year?: number;
        TenantId?: number;
        DistrictDcode?: string;
        DistrictProvinceId?: number;
        DistrictDname?: string;
        DistrictTotalPop?: number;
        DistrictTargetPop?: number;
        DistrictType?: string;
        DistrictPriority?: number;
        DistrictPopYear?: number;
        DistrictLat?: number;
        DistrictLon?: number;
        DistrictBackupName?: string;
        DistrictMapName?: string;
        DistrictLdPs?: string;
        IcnType?: string;
        RecruitmentType?: string;
        MonthMonthshort?: string;
        MonthMonthlong?: string;
    }

    export namespace IcnDeploymentRow {
        export const idProperty = 'IcnDeploymentId';
        export const localTextPrefix = 'Implementation.IcnDeployment';

        export namespace Fields {
            export declare const IcnDeploymentId: string;
            export declare const DistrictId: string;
            export declare const PlannedIcn: string;
            export declare const RecruitedIcn: string;
            export declare const RecruitedMale: string;
            export declare const RecruitedFemale: string;
            export declare const IcnTypeId: string;
            export declare const RecruitmentTypeId: string;
            export declare const MonthId: string;
            export declare const Year: string;
            export declare const TenantId: string;
            export declare const DistrictDcode: string;
            export declare const DistrictProvinceId: string;
            export declare const DistrictDname: string;
            export declare const DistrictTotalPop: string;
            export declare const DistrictTargetPop: string;
            export declare const DistrictType: string;
            export declare const DistrictPriority: string;
            export declare const DistrictPopYear: string;
            export declare const DistrictLat: string;
            export declare const DistrictLon: string;
            export declare const DistrictBackupName: string;
            export declare const DistrictMapName: string;
            export declare const DistrictLdPs: string;
            export declare const IcnType: string;
            export declare const RecruitmentType: string;
            export declare const MonthMonthshort: string;
            export declare const MonthMonthlong: string;
        }

        [
            'IcnDeploymentId', 
            'DistrictId', 
            'PlannedIcn', 
            'RecruitedIcn', 
            'RecruitedMale', 
            'RecruitedFemale', 
            'IcnTypeId', 
            'RecruitmentTypeId', 
            'MonthId', 
            'Year', 
            'TenantId', 
            'DistrictDcode', 
            'DistrictProvinceId', 
            'DistrictDname', 
            'DistrictTotalPop', 
            'DistrictTargetPop', 
            'DistrictType', 
            'DistrictPriority', 
            'DistrictPopYear', 
            'DistrictLat', 
            'DistrictLon', 
            'DistrictBackupName', 
            'DistrictMapName', 
            'DistrictLdPs', 
            'IcnType', 
            'RecruitmentType', 
            'MonthMonthshort', 
            'MonthMonthlong'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

