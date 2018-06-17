namespace webNEOC.Locations {
    export interface ClusterRow {
        ClusterId?: number;
        DistrictId?: number;
        Ccode?: string;
        Cname?: string;
        Targetpop?: number;
        DistrictDcode?: string;
        ProvinceId?: number;
        Dname?: string;
        DistrictTotalPop?: number;
        DistrictTargetPop?: number;
        DistrictType?: string;
        DistrictPriority?: number;
        DistrictPopYear?: number;
        Province?: string;
    }

    export namespace ClusterRow {
        export const idProperty = 'ClusterId';
        export const nameProperty = 'Cname';
        export const localTextPrefix = 'Locations.Cluster';
        export const lookupKey = 'Locations.Cluster';

        export function getLookup(): Q.Lookup<ClusterRow> {
            return Q.getLookup<ClusterRow>('Locations.Cluster');
        }

        export namespace Fields {
            export declare const ClusterId: string;
            export declare const DistrictId: string;
            export declare const Ccode: string;
            export declare const Cname: string;
            export declare const Targetpop: string;
            export declare const DistrictDcode: string;
            export declare const ProvinceId: string;
            export declare const Dname: string;
            export declare const DistrictTotalPop: string;
            export declare const DistrictTargetPop: string;
            export declare const DistrictType: string;
            export declare const DistrictPriority: string;
            export declare const DistrictPopYear: string;
            export declare const Province: string;
        }

        [
            'ClusterId', 
            'DistrictId', 
            'Ccode', 
            'Cname', 
            'Targetpop', 
            'DistrictDcode', 
            'ProvinceId', 
            'Dname', 
            'DistrictTotalPop', 
            'DistrictTargetPop', 
            'DistrictType', 
            'DistrictPriority', 
            'DistrictPopYear', 
            'Province'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

