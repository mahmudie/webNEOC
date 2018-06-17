namespace webNEOC.PostCampaign {
    export interface PcmRow {
        PcmId?: number;
        RoundId?: number;
        DistrictId?: number;
        ClusterLevelId?: number;
        ClusterId?: number;
        CampaignTypeId?: number;
        ClusterCode?: string;
        Village?: string;
        VistedHouses?: number;
        T059m?: number;
        V059m?: number;
        T011Seen?: number;
        Fm011HvFm?: number;
        T1259Seen?: number;
        Fm1259HvFm?: number;
        TChildrenNoFm?: number;
        R1TeamNoVisit?: number;
        R21?: number;
        R22?: number;
        R23?: number;
        R24?: number;
        R31?: number;
        R32?: number;
        R33?: number;
        R4NewBorn?: number;
        R5Sleep?: number;
        R6Sick?: number;
        R7Other?: number;
        DmCorrect?: number;
        DmIncorrect?: number;
        NoDm?: number;
        FmHeard?: number;
        FmNotHeard?: number;
        Radio?: number;
        Tv?: number;
        MullahElders?: number;
        Teacher?: number;
        Chw?: number;
        CElders?: number;
        PbLeaflet?: number;
        Sm?: number;
        Other?: number;
        ChVacByMonitor?: number;
        RCallCoverage?: number;
        Fm059Coverage?: number;
        Fm011Coverage?: number;
        InAcesChildren?: number;
        DateFrom?: string;
        DateTo?: string;
        RoundName?: string;
        ClusterName?: string;
        LevelName?: string;
        CampaignTypeName?: string;
        TenantId?: number;
        DistrictDcode?: string;
        ProvinceId?: number;
        DistrictDname?: string;
        Province?: string;
        DistrictTotalPop?: number;
        DistrictTargetPop?: number;
        DistrictType?: string;
        DistrictPriority?: number;
        DistrictPopYear?: number;
    }

    export namespace PcmRow {
        export const idProperty = 'PcmId';
        export const nameProperty = 'Village';
        export const localTextPrefix = 'PostCampaign.Pcm';

        export namespace Fields {
            export declare const PcmId: string;
            export declare const RoundId: string;
            export declare const DistrictId: string;
            export declare const ClusterLevelId: string;
            export declare const ClusterId: string;
            export declare const CampaignTypeId: string;
            export declare const ClusterCode: string;
            export declare const Village: string;
            export declare const VistedHouses: string;
            export declare const T059m: string;
            export declare const V059m: string;
            export declare const T011Seen: string;
            export declare const Fm011HvFm: string;
            export declare const T1259Seen: string;
            export declare const Fm1259HvFm: string;
            export declare const TChildrenNoFm: string;
            export declare const R1TeamNoVisit: string;
            export declare const R21: string;
            export declare const R22: string;
            export declare const R23: string;
            export declare const R24: string;
            export declare const R31: string;
            export declare const R32: string;
            export declare const R33: string;
            export declare const R4NewBorn: string;
            export declare const R5Sleep: string;
            export declare const R6Sick: string;
            export declare const R7Other: string;
            export declare const DmCorrect: string;
            export declare const DmIncorrect: string;
            export declare const NoDm: string;
            export declare const FmHeard: string;
            export declare const FmNotHeard: string;
            export declare const Radio: string;
            export declare const Tv: string;
            export declare const MullahElders: string;
            export declare const Teacher: string;
            export declare const Chw: string;
            export declare const CElders: string;
            export declare const PbLeaflet: string;
            export declare const Sm: string;
            export declare const Other: string;
            export declare const ChVacByMonitor: string;
            export declare const RCallCoverage: string;
            export declare const Fm059Coverage: string;
            export declare const Fm011Coverage: string;
            export declare const InAcesChildren: string;
            export declare const DateFrom: string;
            export declare const DateTo: string;
            export declare const RoundName: string;
            export declare const ClusterName: string;
            export declare const LevelName: string;
            export declare const CampaignTypeName: string;
            export declare const TenantId: string;
            export declare const DistrictDcode: string;
            export declare const ProvinceId: string;
            export declare const DistrictDname: string;
            export declare const Province: string;
            export declare const DistrictTotalPop: string;
            export declare const DistrictTargetPop: string;
            export declare const DistrictType: string;
            export declare const DistrictPriority: string;
            export declare const DistrictPopYear: string;
        }

        [
            'PcmId', 
            'RoundId', 
            'DistrictId', 
            'ClusterLevelId', 
            'ClusterId', 
            'CampaignTypeId', 
            'ClusterCode', 
            'Village', 
            'VistedHouses', 
            'T059m', 
            'V059m', 
            'T011Seen', 
            'Fm011HvFm', 
            'T1259Seen', 
            'Fm1259HvFm', 
            'TChildrenNoFm', 
            'R1TeamNoVisit', 
            'R21', 
            'R22', 
            'R23', 
            'R24', 
            'R31', 
            'R32', 
            'R33', 
            'R4NewBorn', 
            'R5Sleep', 
            'R6Sick', 
            'R7Other', 
            'DmCorrect', 
            'DmIncorrect', 
            'NoDm', 
            'FmHeard', 
            'FmNotHeard', 
            'Radio', 
            'Tv', 
            'MullahElders', 
            'Teacher', 
            'Chw', 
            'CElders', 
            'PbLeaflet', 
            'Sm', 
            'Other', 
            'ChVacByMonitor', 
            'RCallCoverage', 
            'Fm059Coverage', 
            'Fm011Coverage', 
            'InAcesChildren', 
            'DateFrom', 
            'DateTo', 
            'RoundName', 
            'ClusterName', 
            'LevelName', 
            'CampaignTypeName', 
            'TenantId', 
            'DistrictDcode', 
            'ProvinceId', 
            'DistrictDname', 
            'Province', 
            'DistrictTotalPop', 
            'DistrictTargetPop', 
            'DistrictType', 
            'DistrictPriority', 
            'DistrictPopYear'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

