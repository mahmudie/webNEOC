namespace webNEOC.Implementation {
    export interface IcmHouseholdRow {
        IcmHouseholdId?: number;
        RoundId?: number;
        DistrictId?: number;
        PartId?: number;
        ClusterId?: number;
        ReportDate?: string;
        Village?: string;
        Supervisor?: string;
        NoHhVisited?: number;
        NoChildrenInVisitedHh?: number;
        NoVaccInRecall?: number;
        MissedChildren?: number;
        TeamNotCome?: number;
        ChildrenAbsent?: number;
        NewbornSsChildren?: number;
        NoRefused?: number;
        NoIgnoredbyTeam?: number;
        TotUn5SeenByMonit?: number;
        NoSeenWithFingerMark?: number;
        NoCorrect?: number;
        NoIncorrect?: number;
        NoNotMarked?: number;
        NoChildFoundMissedRecall?: number;
        NoChildRecBackOfTally?: number;
        RoundName?: string;
        DateFrom?: string;
        DateTo?: string;
        TenantId?: number;
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
        PartPartName?: string;
    }

    export namespace IcmHouseholdRow {
        export const idProperty = 'IcmHouseholdId';
        export const nameProperty = 'Village';
        export const localTextPrefix = 'Implementation.IcmHousehold';

        export namespace Fields {
            export declare const IcmHouseholdId: string;
            export declare const RoundId: string;
            export declare const DistrictId: string;
            export declare const PartId: string;
            export declare const ClusterId: string;
            export declare const ReportDate: string;
            export declare const Village: string;
            export declare const Supervisor: string;
            export declare const NoHhVisited: string;
            export declare const NoChildrenInVisitedHh: string;
            export declare const NoVaccInRecall: string;
            export declare const MissedChildren: string;
            export declare const TeamNotCome: string;
            export declare const ChildrenAbsent: string;
            export declare const NewbornSsChildren: string;
            export declare const NoRefused: string;
            export declare const NoIgnoredbyTeam: string;
            export declare const TotUn5SeenByMonit: string;
            export declare const NoSeenWithFingerMark: string;
            export declare const NoCorrect: string;
            export declare const NoIncorrect: string;
            export declare const NoNotMarked: string;
            export declare const NoChildFoundMissedRecall: string;
            export declare const NoChildRecBackOfTally: string;
            export declare const RoundName: string;
            export declare const DateFrom: string;
            export declare const DateTo: string;
            export declare const TenantId: string;
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
            export declare const PartPartName: string;
        }

        [
            'IcmHouseholdId', 
            'RoundId', 
            'DistrictId', 
            'PartId', 
            'ClusterId', 
            'ReportDate', 
            'Village', 
            'Supervisor', 
            'NoHhVisited', 
            'NoChildrenInVisitedHh', 
            'NoVaccInRecall', 
            'MissedChildren', 
            'TeamNotCome', 
            'ChildrenAbsent', 
            'NewbornSsChildren', 
            'NoRefused', 
            'NoIgnoredbyTeam', 
            'TotUn5SeenByMonit', 
            'NoSeenWithFingerMark', 
            'NoCorrect', 
            'NoIncorrect', 
            'NoNotMarked', 
            'NoChildFoundMissedRecall', 
            'NoChildRecBackOfTally', 
            'RoundName', 
            'DateFrom', 
            'DateTo', 
            'TenantId', 
            'Cname', 
            'DistrictDcode', 
            'ProvinceId', 
            'Province', 
            'DistrictDname', 
            'DistrictTotalPop', 
            'DistrictTargetPop', 
            'DistrictType', 
            'DistrictPriority', 
            'DistrictPopYear', 
            'PartPartName'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

