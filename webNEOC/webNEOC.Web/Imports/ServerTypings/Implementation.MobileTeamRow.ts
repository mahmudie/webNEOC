namespace webNEOC.Implementation {
    export interface MobileTeamRow {
        MobileTeamId?: number;
        RoundId?: number;
        DistrictId?: number;
        Nomads?: number;
        Gypsis?: number;
        BlueMosque?: number;
        BusStation?: number;
        CheckPost?: number;
        IDPs?: number;
        Madrasa?: number;
        School?: number;
        Kindergarden?: number;
        Prison?: number;
        Daramsal?: number;
        Crosborder?: number;
        Returnees?: number;
        EPICenters?: number;
        MobileTeams?: number;
        PrivateClinics?: number;
        HotelGuestHouses?: number;
        Others?: number;
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

    export namespace MobileTeamRow {
        export const idProperty = 'MobileTeamId';
        export const localTextPrefix = 'Implementation.MobileTeam';

        export namespace Fields {
            export declare const MobileTeamId: string;
            export declare const RoundId: string;
            export declare const DistrictId: string;
            export declare const Nomads: string;
            export declare const Gypsis: string;
            export declare const BlueMosque: string;
            export declare const BusStation: string;
            export declare const CheckPost: string;
            export declare const IDPs: string;
            export declare const Madrasa: string;
            export declare const School: string;
            export declare const Kindergarden: string;
            export declare const Prison: string;
            export declare const Daramsal: string;
            export declare const Crosborder: string;
            export declare const Returnees: string;
            export declare const EPICenters: string;
            export declare const MobileTeams: string;
            export declare const PrivateClinics: string;
            export declare const HotelGuestHouses: string;
            export declare const Others: string;
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
            'MobileTeamId', 
            'RoundId', 
            'DistrictId', 
            'Nomads', 
            'Gypsis', 
            'BlueMosque', 
            'BusStation', 
            'CheckPost', 
            'IDPs', 
            'Madrasa', 
            'School', 
            'Kindergarden', 
            'Prison', 
            'Daramsal', 
            'Crosborder', 
            'Returnees', 
            'EPICenters', 
            'MobileTeams', 
            'PrivateClinics', 
            'HotelGuestHouses', 
            'Others', 
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

