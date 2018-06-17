namespace webNEOC.Implementation {
    export interface IcmTeamRow {
        IcmTeamId?: number;
        RoundId?: number;
        DistrictId?: number;
        PartId?: number;
        ClusterId?: number;
        TeamMemberName?: string;
        TeamNo?: string;
        ReportDate?: string;
        MonitorName?: string;
        MonitVisitTime?: string;
        IsTeamResident?: boolean;
        BothTrained?: boolean;
        HaveClearMap?: boolean;
        AbleKnowArea?: boolean;
        TeamGHtoH?: boolean;
        OpvVialsKeptDry?: boolean;
        UsingOpvStage3or4?: boolean;
        AskingAbout011C?: boolean;
        AskingforGnssc?: boolean;
        RecNameOfAbsentRefC?: boolean;
        AskingAfpCases?: boolean;
        VistedBySupervisor?: boolean;
        TeamHasAchw?: boolean;
        TeamHasFemale?: boolean;
        SocMobAccompanyTeam?: boolean;
        RoundName?: string;
        DateFrom?: string;
        DateTo?: string;
        TenantId?: number;
        PartName?: string;
        Cname?: string;
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

    export namespace IcmTeamRow {
        export const idProperty = 'IcmTeamId';
        export const nameProperty = 'TeamMemberName';
        export const localTextPrefix = 'Implementation.IcmTeam';

        export namespace Fields {
            export declare const IcmTeamId: string;
            export declare const RoundId: string;
            export declare const DistrictId: string;
            export declare const PartId: string;
            export declare const ClusterId: string;
            export declare const TeamMemberName: string;
            export declare const TeamNo: string;
            export declare const ReportDate: string;
            export declare const MonitorName: string;
            export declare const MonitVisitTime: string;
            export declare const IsTeamResident: string;
            export declare const BothTrained: string;
            export declare const HaveClearMap: string;
            export declare const AbleKnowArea: string;
            export declare const TeamGHtoH: string;
            export declare const OpvVialsKeptDry: string;
            export declare const UsingOpvStage3or4: string;
            export declare const AskingAbout011C: string;
            export declare const AskingforGnssc: string;
            export declare const RecNameOfAbsentRefC: string;
            export declare const AskingAfpCases: string;
            export declare const VistedBySupervisor: string;
            export declare const TeamHasAchw: string;
            export declare const TeamHasFemale: string;
            export declare const SocMobAccompanyTeam: string;
            export declare const RoundName: string;
            export declare const DateFrom: string;
            export declare const DateTo: string;
            export declare const TenantId: string;
            export declare const PartName: string;
            export declare const Cname: string;
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
            'IcmTeamId', 
            'RoundId', 
            'DistrictId', 
            'PartId', 
            'ClusterId', 
            'TeamMemberName', 
            'TeamNo', 
            'ReportDate', 
            'MonitorName', 
            'MonitVisitTime', 
            'IsTeamResident', 
            'BothTrained', 
            'HaveClearMap', 
            'AbleKnowArea', 
            'TeamGHtoH', 
            'OpvVialsKeptDry', 
            'UsingOpvStage3or4', 
            'AskingAbout011C', 
            'AskingforGnssc', 
            'RecNameOfAbsentRefC', 
            'AskingAfpCases', 
            'VistedBySupervisor', 
            'TeamHasAchw', 
            'TeamHasFemale', 
            'SocMobAccompanyTeam', 
            'RoundName', 
            'DateFrom', 
            'DateTo', 
            'TenantId', 
            'PartName', 
            'Cname', 
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

