namespace webNEOC.Preparation {
    export interface MicroplanRow {
        MicroplanId?: number;
        RoundId?: number;
        DistrictId?: number;
        ReportDate?: string;
        Sno?: number;
        TotalPop?: number;
        OpvTarget?: number;
        MissedTarget?: number;
        VitATarget?: number;
        Teams?: number;
        NomadTeams?: number;
        FixVacTeams?: number;
        RemtpemTstaff?: number;
        Coordinators?: number;
        Pco?: number;
        Dpodco?: number;
        CcSs?: number;
        SMs?: number;
        Sup?: number;
        NoOfTeams?: number;
        Volunteers?: number;
        IntraNiDsMonitors?: number;
        PcAmonotors?: number;
        OpvDoses?: number;
        OpvVials?: number;
        AlbendazTablet?: number;
        VitACapsules?: number;
        ColdBoxes?: number;
        Thermos?: number;
        IcePacks?: number;
        Banner?: number;
        Vehicle?: number;
        MotorBikes4Monitors?: number;
        MotorBikes4Nomads?: number;
        Leflet?: number;
        Scissors?: number;
        FingerMarkers?: number;
        PlasticBagNo?: number;
        PenNo?: number;
        ChalkNo?: number;
        AlbenVitSheetCoordinator?: number;
        AlbenVitSheetSupvervisor?: number;
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

    export namespace MicroplanRow {
        export const idProperty = 'MicroplanId';
        export const localTextPrefix = 'Preparation.Microplan';

        export namespace Fields {
            export declare const MicroplanId: string;
            export declare const RoundId: string;
            export declare const DistrictId: string;
            export declare const ReportDate: string;
            export declare const Sno: string;
            export declare const TotalPop: string;
            export declare const OpvTarget: string;
            export declare const MissedTarget: string;
            export declare const VitATarget: string;
            export declare const Teams: string;
            export declare const NomadTeams: string;
            export declare const FixVacTeams: string;
            export declare const RemtpemTstaff: string;
            export declare const Coordinators: string;
            export declare const Pco: string;
            export declare const Dpodco: string;
            export declare const CcSs: string;
            export declare const SMs: string;
            export declare const Sup: string;
            export declare const NoOfTeams: string;
            export declare const Volunteers: string;
            export declare const IntraNiDsMonitors: string;
            export declare const PcAmonotors: string;
            export declare const OpvDoses: string;
            export declare const OpvVials: string;
            export declare const AlbendazTablet: string;
            export declare const VitACapsules: string;
            export declare const ColdBoxes: string;
            export declare const Thermos: string;
            export declare const IcePacks: string;
            export declare const Banner: string;
            export declare const Vehicle: string;
            export declare const MotorBikes4Monitors: string;
            export declare const MotorBikes4Nomads: string;
            export declare const Leflet: string;
            export declare const Scissors: string;
            export declare const FingerMarkers: string;
            export declare const PlasticBagNo: string;
            export declare const PenNo: string;
            export declare const ChalkNo: string;
            export declare const AlbenVitSheetCoordinator: string;
            export declare const AlbenVitSheetSupvervisor: string;
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
            'MicroplanId', 
            'RoundId', 
            'DistrictId', 
            'ReportDate', 
            'Sno', 
            'TotalPop', 
            'OpvTarget', 
            'MissedTarget', 
            'VitATarget', 
            'Teams', 
            'NomadTeams', 
            'FixVacTeams', 
            'RemtpemTstaff', 
            'Coordinators', 
            'Pco', 
            'Dpodco', 
            'CcSs', 
            'SMs', 
            'Sup', 
            'NoOfTeams', 
            'Volunteers', 
            'IntraNiDsMonitors', 
            'PcAmonotors', 
            'OpvDoses', 
            'OpvVials', 
            'AlbendazTablet', 
            'VitACapsules', 
            'ColdBoxes', 
            'Thermos', 
            'IcePacks', 
            'Banner', 
            'Vehicle', 
            'MotorBikes4Monitors', 
            'MotorBikes4Nomads', 
            'Leflet', 
            'Scissors', 
            'FingerMarkers', 
            'PlasticBagNo', 
            'PenNo', 
            'ChalkNo', 
            'AlbenVitSheetCoordinator', 
            'AlbenVitSheetSupvervisor', 
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

