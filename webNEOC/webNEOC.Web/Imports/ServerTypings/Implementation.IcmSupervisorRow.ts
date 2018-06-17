namespace webNEOC.Implementation {
    export interface IcmSupervisorRow {
        IcmSupervisorId?: number;
        RoundId?: number;
        DistrictId?: number;
        PartId?: number;
        ClusterId?: number;
        ReportDate?: string;
        Supervisor?: string;
        MonitorName?: string;
        IsSuperResidentOfArea?: boolean;
        IsSuperTrained?: boolean;
        IsSuperCarryOpv?: boolean;
        IsSuperHasClearMap?: boolean;
        IsSuperFillingHhChecklist?: boolean;
        IsTransProviddToSuper?: boolean;
        VehicletypeId?: number;
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
        VehicletypeTypename?: string;
        PartPartName?: string;
    }

    export namespace IcmSupervisorRow {
        export const idProperty = 'IcmSupervisorId';
        export const nameProperty = 'Supervisor';
        export const localTextPrefix = 'Implementation.IcmSupervisor';

        export namespace Fields {
            export declare const IcmSupervisorId: string;
            export declare const RoundId: string;
            export declare const DistrictId: string;
            export declare const PartId: string;
            export declare const ClusterId: string;
            export declare const ReportDate: string;
            export declare const Supervisor: string;
            export declare const MonitorName: string;
            export declare const IsSuperResidentOfArea: string;
            export declare const IsSuperTrained: string;
            export declare const IsSuperCarryOpv: string;
            export declare const IsSuperHasClearMap: string;
            export declare const IsSuperFillingHhChecklist: string;
            export declare const IsTransProviddToSuper: string;
            export declare const VehicletypeId: string;
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
            export declare const VehicletypeTypename: string;
            export declare const PartPartName: string;
        }

        [
            'IcmSupervisorId', 
            'RoundId', 
            'DistrictId', 
            'PartId', 
            'ClusterId', 
            'ReportDate', 
            'Supervisor', 
            'MonitorName', 
            'IsSuperResidentOfArea', 
            'IsSuperTrained', 
            'IsSuperCarryOpv', 
            'IsSuperHasClearMap', 
            'IsSuperFillingHhChecklist', 
            'IsTransProviddToSuper', 
            'VehicletypeId', 
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
            'VehicletypeTypename', 
            'PartPartName'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

