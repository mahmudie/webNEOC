namespace webNEOC.PostCampaign {
    export interface OutOfHouseSurveyRow {
        OutOfHouseSurveyId?: number;
        RoundId?: number;
        DistrictId?: number;
        ReportDate?: string;
        T059m?: number;
        Vac059m?: number;
        FM059m?: number;
        T059f?: number;
        Vac059f?: number;
        FM059f?: number;
        MissTmNotCome?: number;
        MissAbsent?: number;
        MissRefused?: number;
        MissNewBornSick?: number;
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
    }

    export namespace OutOfHouseSurveyRow {
        export const idProperty = 'OutOfHouseSurveyId';
        export const localTextPrefix = 'PostCampaign.OutOfHouseSurvey';

        export namespace Fields {
            export declare const OutOfHouseSurveyId: string;
            export declare const RoundId: string;
            export declare const DistrictId: string;
            export declare const ReportDate: string;
            export declare const T059m: string;
            export declare const Vac059m: string;
            export declare const FM059m: string;
            export declare const T059f: string;
            export declare const Vac059f: string;
            export declare const FM059f: string;
            export declare const MissTmNotCome: string;
            export declare const MissAbsent: string;
            export declare const MissRefused: string;
            export declare const MissNewBornSick: string;
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
        }

        [
            'OutOfHouseSurveyId', 
            'RoundId', 
            'DistrictId', 
            'ReportDate', 
            'T059m', 
            'Vac059m', 
            'FM059m', 
            'T059f', 
            'Vac059f', 
            'FM059f', 
            'MissTmNotCome', 
            'MissAbsent', 
            'MissRefused', 
            'MissNewBornSick', 
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
            'DistrictPopYear'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

