namespace webNEOC.Locations {
    export interface ProvinceRow {
        ProvinceId?: number;
        Pcode?: string;
        RegionId?: number;
        Pname?: string;
        PAbrv?: string;
        Pcenter?: string;
        AreaKmSqr?: number;
        NoOfDistricts?: number;
        Rname?: string;
        RegionRAbrv?: string;
    }

    export namespace ProvinceRow {
        export const idProperty = 'ProvinceId';
        export const nameProperty = 'Pname';
        export const localTextPrefix = 'Locations.Province';
        export const lookupKey = 'Locations.Province';

        export function getLookup(): Q.Lookup<ProvinceRow> {
            return Q.getLookup<ProvinceRow>('Locations.Province');
        }

        export namespace Fields {
            export declare const ProvinceId: string;
            export declare const Pcode: string;
            export declare const RegionId: string;
            export declare const Pname: string;
            export declare const PAbrv: string;
            export declare const Pcenter: string;
            export declare const AreaKmSqr: string;
            export declare const NoOfDistricts: string;
            export declare const Rname: string;
            export declare const RegionRAbrv: string;
        }

        [
            'ProvinceId', 
            'Pcode', 
            'RegionId', 
            'Pname', 
            'PAbrv', 
            'Pcenter', 
            'AreaKmSqr', 
            'NoOfDistricts', 
            'Rname', 
            'RegionRAbrv'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

