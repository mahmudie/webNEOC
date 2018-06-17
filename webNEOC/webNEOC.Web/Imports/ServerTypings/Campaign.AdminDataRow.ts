namespace webNEOC.Campaign {
    export interface AdminDataRow {
        AdminDataId?: number;
        RoundId?: number;
        DistrictId?: number;
        ClusterId?: number;
        DateOfCampaign?: string;
        PemtremtManager?: string;
        TeamNo?: string;
        D1VialsRecieved?: number;
        D1VialsReturned?: number;
        D1VaccByTransit?: number;
        D1NoOfHhsVisited?: number;
        D1Ch05resident?: number;
        D1Ch05guest?: number;
        D1Ch05VaccInHouse?: number;
        D1Ch05VaccOutHouse?: number;
        D1Ch05NomadVacc?: number;
        D1AbsentRecordDuring?: number;
        D1AbsentFoundVaccDuring?: number;
        D1AbsentVaccDuring?: number;
        D1AbsentRemainDuring?: number;
        D1AbsentRecordAfter?: number;
        D1AbsentFoundVaccAfter?: number;
        D1AbsentVaccAfter?: number;
        D1AbsentRemainAfter?: number;
        D1NssRecord?: number;
        D1NssFoundVacc?: number;
        D1NssVaccinated?: number;
        D1NssReamining?: number;
        D1RefusalRecord?: number;
        D1RefusalFoundVacc?: number;
        D1RefusalVacc?: number;
        D1RefusalRemaining?: number;
        D2VialsRecieved?: number;
        D2VialsReturned?: number;
        D2VaccByTransit?: number;
        D2NoOfHhsVisited?: number;
        D2Ch05resident?: number;
        D2Ch05guest?: number;
        D2Ch05VaccInHouse?: number;
        D2Ch05VaccOutHouse?: number;
        D2Ch05NomadVacc?: number;
        D2AbsentRecordDuring?: number;
        D2AbsentFoundVaccDuring?: number;
        D2AbsentVaccDuring?: number;
        D2AbsentRemainDuring?: number;
        D2AbsentRecordAfter?: number;
        D2AbsentFoundVaccAfter?: number;
        D2AbsentVaccAfter?: number;
        D2AbsentRemainAfter?: number;
        D2NssRecord?: number;
        D2NssFoundVacc?: number;
        D2NssVaccinated?: number;
        D2NssReamining?: number;
        D2RefusalRecord?: number;
        D2RefusalFoundVacc?: number;
        D2RefusalVacc?: number;
        D2RefusalRemaining?: number;
        D3VialsRecieved?: number;
        D3VialsReturned?: number;
        D3VaccByTransit?: number;
        D3NoOfHhsVisited?: number;
        D3Ch05resident?: number;
        D3Ch05guest?: number;
        D3Ch05VaccInHouse?: number;
        D3Ch05VaccOutHouse?: number;
        D3Ch05NomadVacc?: number;
        D3AbsentRecordDuring?: number;
        D3AbsentFoundVaccDuring?: number;
        D3AbsentVaccDuring?: number;
        D3AbsentRemainDuring?: number;
        D3AbsentRecordAfter?: number;
        D3AbsentFoundVaccAfter?: number;
        D3AbsentVaccAfter?: number;
        D3AbsentRemainAfter?: number;
        D3NssRecord?: number;
        D3NssFoundVacc?: number;
        D3NssVaccinated?: number;
        D3NssReamining?: number;
        D3RefusalRecord?: number;
        D3RefusalFoundVacc?: number;
        D3RefusalVacc?: number;
        D3RefusalRemaining?: number;
        D5VialsRecieved?: number;
        D5VialsReturned?: number;
        D5RemainAbsentDuring?: number;
        D5AbsentFoundVaccDuring5?: number;
        D5AbsentVaccDuring5?: number;
        D5AbsentRemainDuring5?: number;
        D5RemainAbsentAfter?: number;
        D5AbsentFoundVaccAfter5?: number;
        D5AbsentVaccAfter5?: number;
        D5AbsentRemainAfter5?: number;
        D5RemainNss?: number;
        D5FoundVaccNss5?: number;
        D5VaccNss5?: number;
        D5RemainNss5?: number;
        D5RemainRefusal?: number;
        D5FoundVaccRefusal5?: number;
        D5VaccRefusal5?: number;
        D5RemainRefusal5?: number;
        D5VaccOutofHouse?: number;
        DistrictDcode?: string;
        DistrictProvinceId?: number;
        DistrictDname?: string;
        Round?: string;
        Cluster?: string;
        Province?: string;
        TenantId?: number;
        UniqueId?:string;
    }

    export namespace AdminDataRow {
        export const idProperty = 'AdminDataId';
        export const nameProperty = 'UniqueId';
        export const localTextPrefix = 'Campaign.AdminData';

        export namespace Fields {
            export declare const AdminDataId: string;
            export declare const RoundId: string;
            export declare const DistrictId: string;
            export declare const ClusterId: string;
            export declare const DateOfCampaign: string;
            export declare const PemtremtManager: string;
            export declare const TeamNo: string;
            export declare const D1VialsRecieved: string;
            export declare const D1VialsReturned: string;
            export declare const D1VaccByTransit: string;
            export declare const D1NoOfHhsVisited: string;
            export declare const D1Ch05resident: string;
            export declare const D1Ch05guest: string;
            export declare const D1Ch05VaccInHouse: string;
            export declare const D1Ch05VaccOutHouse: string;
            export declare const D1Ch05NomadVacc: string;
            export declare const D1AbsentRecordDuring: string;
            export declare const D1AbsentFoundVaccDuring: string;
            export declare const D1AbsentVaccDuring: string;
            export declare const D1AbsentRemainDuring: string;
            export declare const D1AbsentRecordAfter: string;
            export declare const D1AbsentFoundVaccAfter: string;
            export declare const D1AbsentVaccAfter: string;
            export declare const D1AbsentRemainAfter: string;
            export declare const D1NssRecord: string;
            export declare const D1NssFoundVacc: string;
            export declare const D1NssVaccinated: string;
            export declare const D1NssReamining: string;
            export declare const D1RefusalRecord: string;
            export declare const D1RefusalFoundVacc: string;
            export declare const D1RefusalVacc: string;
            export declare const D1RefusalRemaining: string;
            export declare const D2VialsRecieved: string;
            export declare const D2VialsReturned: string;
            export declare const D2VaccByTransit: string;
            export declare const D2NoOfHhsVisited: string;
            export declare const D2Ch05resident: string;
            export declare const D2Ch05guest: string;
            export declare const D2Ch05VaccInHouse: string;
            export declare const D2Ch05VaccOutHouse: string;
            export declare const D2Ch05NomadVacc: string;
            export declare const D2AbsentRecordDuring: string;
            export declare const D2AbsentFoundVaccDuring: string;
            export declare const D2AbsentVaccDuring: string;
            export declare const D2AbsentRemainDuring: string;
            export declare const D2AbsentRecordAfter: string;
            export declare const D2AbsentFoundVaccAfter: string;
            export declare const D2AbsentVaccAfter: string;
            export declare const D2AbsentRemainAfter: string;
            export declare const D2NssRecord: string;
            export declare const D2NssFoundVacc: string;
            export declare const D2NssVaccinated: string;
            export declare const D2NssReamining: string;
            export declare const D2RefusalRecord: string;
            export declare const D2RefusalFoundVacc: string;
            export declare const D2RefusalVacc: string;
            export declare const D2RefusalRemaining: string;
            export declare const D3VialsRecieved: string;
            export declare const D3VialsReturned: string;
            export declare const D3VaccByTransit: string;
            export declare const D3NoOfHhsVisited: string;
            export declare const D3Ch05resident: string;
            export declare const D3Ch05guest: string;
            export declare const D3Ch05VaccInHouse: string;
            export declare const D3Ch05VaccOutHouse: string;
            export declare const D3Ch05NomadVacc: string;
            export declare const D3AbsentRecordDuring: string;
            export declare const D3AbsentFoundVaccDuring: string;
            export declare const D3AbsentVaccDuring: string;
            export declare const D3AbsentRemainDuring: string;
            export declare const D3AbsentRecordAfter: string;
            export declare const D3AbsentFoundVaccAfter: string;
            export declare const D3AbsentVaccAfter: string;
            export declare const D3AbsentRemainAfter: string;
            export declare const D3NssRecord: string;
            export declare const D3NssFoundVacc: string;
            export declare const D3NssVaccinated: string;
            export declare const D3NssReamining: string;
            export declare const D3RefusalRecord: string;
            export declare const D3RefusalFoundVacc: string;
            export declare const D3RefusalVacc: string;
            export declare const D3RefusalRemaining: string;
            export declare const D5VialsRecieved: string;
            export declare const D5VialsReturned: string;
            export declare const D5RemainAbsentDuring: string;
            export declare const D5AbsentFoundVaccDuring5: string;
            export declare const D5AbsentVaccDuring5: string;
            export declare const D5AbsentRemainDuring5: string;
            export declare const D5RemainAbsentAfter: string;
            export declare const D5AbsentFoundVaccAfter5: string;
            export declare const D5AbsentVaccAfter5: string;
            export declare const D5AbsentRemainAfter5: string;
            export declare const D5RemainNss: string;
            export declare const D5FoundVaccNss5: string;
            export declare const D5VaccNss5: string;
            export declare const D5RemainNss5: string;
            export declare const D5RemainRefusal: string;
            export declare const D5FoundVaccRefusal5: string;
            export declare const D5VaccRefusal5: string;
            export declare const D5RemainRefusal5: string;
            export declare const D5VaccOutofHouse: string;
            export declare const DistrictDcode: string;
            export declare const DistrictProvinceId: string;
            export declare const DistrictDname: string;
            export declare const Round: string;
            export declare const Cluster: string;
            export declare const Province: string;
            export declare const TenantId: string;
            export declare const UniqueId: string;
        }

        [
            'AdminDataId', 
            'RoundId', 
            'DistrictId', 
            'ClusterId', 
            'DateOfCampaign', 
            'PemtremtManager', 
            'TeamNo', 
            'D1VialsRecieved', 
            'D1VialsReturned', 
            'D1VaccByTransit', 
            'D1NoOfHhsVisited', 
            'D1Ch05resident', 
            'D1Ch05guest', 
            'D1Ch05VaccInHouse', 
            'D1Ch05VaccOutHouse', 
            'D1Ch05NomadVacc', 
            'D1AbsentRecordDuring', 
            'D1AbsentFoundVaccDuring', 
            'D1AbsentVaccDuring', 
            'D1AbsentRemainDuring', 
            'D1AbsentRecordAfter', 
            'D1AbsentFoundVaccAfter', 
            'D1AbsentVaccAfter', 
            'D1AbsentRemainAfter', 
            'D1NssRecord', 
            'D1NssFoundVacc', 
            'D1NssVaccinated', 
            'D1NssReamining', 
            'D1RefusalRecord', 
            'D1RefusalFoundVacc', 
            'D1RefusalVacc', 
            'D1RefusalRemaining', 
            'D2VialsRecieved', 
            'D2VialsReturned', 
            'D2VaccByTransit', 
            'D2NoOfHhsVisited', 
            'D2Ch05resident', 
            'D2Ch05guest', 
            'D2Ch05VaccInHouse', 
            'D2Ch05VaccOutHouse', 
            'D2Ch05NomadVacc', 
            'D2AbsentRecordDuring', 
            'D2AbsentFoundVaccDuring', 
            'D2AbsentVaccDuring', 
            'D2AbsentRemainDuring', 
            'D2AbsentRecordAfter', 
            'D2AbsentFoundVaccAfter', 
            'D2AbsentVaccAfter', 
            'D2AbsentRemainAfter', 
            'D2NssRecord', 
            'D2NssFoundVacc', 
            'D2NssVaccinated', 
            'D2NssReamining', 
            'D2RefusalRecord', 
            'D2RefusalFoundVacc', 
            'D2RefusalVacc', 
            'D2RefusalRemaining', 
            'D3VialsRecieved', 
            'D3VialsReturned', 
            'D3VaccByTransit', 
            'D3NoOfHhsVisited', 
            'D3Ch05resident', 
            'D3Ch05guest', 
            'D3Ch05VaccInHouse', 
            'D3Ch05VaccOutHouse', 
            'D3Ch05NomadVacc', 
            'D3AbsentRecordDuring', 
            'D3AbsentFoundVaccDuring', 
            'D3AbsentVaccDuring', 
            'D3AbsentRemainDuring', 
            'D3AbsentRecordAfter', 
            'D3AbsentFoundVaccAfter', 
            'D3AbsentVaccAfter', 
            'D3AbsentRemainAfter', 
            'D3NssRecord', 
            'D3NssFoundVacc', 
            'D3NssVaccinated', 
            'D3NssReamining', 
            'D3RefusalRecord', 
            'D3RefusalFoundVacc', 
            'D3RefusalVacc', 
            'D3RefusalRemaining', 
            'D5VialsRecieved', 
            'D5VialsReturned', 
            'D5RemainAbsentDuring', 
            'D5AbsentFoundVaccDuring5', 
            'D5AbsentVaccDuring5', 
            'D5AbsentRemainDuring5', 
            'D5RemainAbsentAfter', 
            'D5AbsentFoundVaccAfter5', 
            'D5AbsentVaccAfter5', 
            'D5AbsentRemainAfter5', 
            'D5RemainNss', 
            'D5FoundVaccNss5', 
            'D5VaccNss5', 
            'D5RemainNss5', 
            'D5RemainRefusal', 
            'D5FoundVaccRefusal5', 
            'D5VaccRefusal5', 
            'D5RemainRefusal5',
            'D5VaccOutofHouse', 
            'DistrictDcode', 
            'DistrictProvinceId', 
            'DistrictDname', 
            'Round', 
            'Cluster', 
            'Province', 
            'TenantId',
            'UniqueId'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

