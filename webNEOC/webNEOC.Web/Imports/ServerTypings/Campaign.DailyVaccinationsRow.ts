namespace webNEOC.Campaign {
    export interface DailyVaccinationsRow {
        DailyVaccinationsId?: number;
        CampaignDayId?: number;
        ClusterId?: number;
        TargetU5Case?: number;
        D1VialDist?: number;
        D1VialUse?: number;
        D1Vac011Months?: number;
        D1Vac1259months?: number;
        D1RecAbsChildren?: number;
        D1VacAbsChildren?: number;
        D1RecNewbornSsc?: number;
        D1VacNewbornSsc?: number;
        D1RecRefusedChildren?: number;
        D1RevacRefusedChildren?: number;
        D1AfpCase?: number;
        D2VialDist?: number;
        D2VialUse?: number;
        D2Vac011Months?: number;
        D2Vac1259months?: number;
        D2RecAbsChildren?: number;
        D2VacAbsChildren?: number;
        D2RecNewbornSsc?: number;
        D2VacNewbornSsc?: number;
        D2RecRefusedChildren?: number;
        D2RevacRefusedChildren?: number;
        D2AfpCase?: number;
        D3VialDist?: number;
        D3VialUse?: number;
        D3Vac011Months?: number;
        D3Vac1259months?: number;
        D3RecAbsChildren?: number;
        D3VacAbsChildren?: number;
        D3RecNewbornSsc?: number;
        D3VacNewbornSsc?: number;
        D3RecRefusedChildren?: number;
        D3RevacRefusedChildren?: number;
        D3AfpCase?: number;
        D5VialDist?: number;
        D5VialUse?: number;
        D5Vac011Months?: number;
        D5Vac1259months?: number;
        D5RecAbsChildren?: number;
        D5VacAbsChildren?: number;
        D5RecNewbornSsc?: number;
        D5VacNewbornSsc?: number;
        D5RecRefusedChildren?: number;
        D5RevacRefusedChildren?: number;
        D5AfpCase?: number;
        DistrictId?: number;
        Cname?: string;
        TenantId?: number;
        LDPTypes?: string;
    }

    export namespace DailyVaccinationsRow {
        export const idProperty = 'DailyVaccinationsId';
        export const localTextPrefix = 'Campaign.DailyVaccinations';
        export const lookupKey = 'Campaign.DailyVaccinations';

        export function getLookup(): Q.Lookup<DailyVaccinationsRow> {
            return Q.getLookup<DailyVaccinationsRow>('Campaign.DailyVaccinations');
        }

        export namespace Fields {
            export declare const DailyVaccinationsId: string;
            export declare const CampaignDayId: string;
            export declare const ClusterId: string;
            export declare const TargetU5Case: string;
            export declare const D1VialDist: string;
            export declare const D1VialUse: string;
            export declare const D1Vac011Months: string;
            export declare const D1Vac1259months: string;
            export declare const D1RecAbsChildren: string;
            export declare const D1VacAbsChildren: string;
            export declare const D1RecNewbornSsc: string;
            export declare const D1VacNewbornSsc: string;
            export declare const D1RecRefusedChildren: string;
            export declare const D1RevacRefusedChildren: string;
            export declare const D1AfpCase: string;
            export declare const D2VialDist: string;
            export declare const D2VialUse: string;
            export declare const D2Vac011Months: string;
            export declare const D2Vac1259months: string;
            export declare const D2RecAbsChildren: string;
            export declare const D2VacAbsChildren: string;
            export declare const D2RecNewbornSsc: string;
            export declare const D2VacNewbornSsc: string;
            export declare const D2RecRefusedChildren: string;
            export declare const D2RevacRefusedChildren: string;
            export declare const D2AfpCase: string;
            export declare const D3VialDist: string;
            export declare const D3VialUse: string;
            export declare const D3Vac011Months: string;
            export declare const D3Vac1259months: string;
            export declare const D3RecAbsChildren: string;
            export declare const D3VacAbsChildren: string;
            export declare const D3RecNewbornSsc: string;
            export declare const D3VacNewbornSsc: string;
            export declare const D3RecRefusedChildren: string;
            export declare const D3RevacRefusedChildren: string;
            export declare const D3AfpCase: string;
            export declare const D5VialDist: string;
            export declare const D5VialUse: string;
            export declare const D5Vac011Months: string;
            export declare const D5Vac1259months: string;
            export declare const D5RecAbsChildren: string;
            export declare const D5VacAbsChildren: string;
            export declare const D5RecNewbornSsc: string;
            export declare const D5VacNewbornSsc: string;
            export declare const D5RecRefusedChildren: string;
            export declare const D5RevacRefusedChildren: string;
            export declare const D5AfpCase: string;
            export declare const DistrictId: string;
            export declare const Cname: string;
            export declare const TenantId: string;
            export declare const LDPTypes: string;
        }

        [
            'DailyVaccinationsId', 
            'CampaignDayId', 
            'ClusterId', 
            'TargetU5Case', 
            'D1VialDist', 
            'D1VialUse', 
            'D1Vac011Months', 
            'D1Vac1259months', 
            'D1RecAbsChildren', 
            'D1VacAbsChildren', 
            'D1RecNewbornSsc', 
            'D1VacNewbornSsc', 
            'D1RecRefusedChildren', 
            'D1RevacRefusedChildren', 
            'D1AfpCase', 
            'D2VialDist', 
            'D2VialUse', 
            'D2Vac011Months', 
            'D2Vac1259months', 
            'D2RecAbsChildren', 
            'D2VacAbsChildren', 
            'D2RecNewbornSsc', 
            'D2VacNewbornSsc', 
            'D2RecRefusedChildren', 
            'D2RevacRefusedChildren', 
            'D2AfpCase', 
            'D3VialDist', 
            'D3VialUse', 
            'D3Vac011Months', 
            'D3Vac1259months', 
            'D3RecAbsChildren', 
            'D3VacAbsChildren', 
            'D3RecNewbornSsc', 
            'D3VacNewbornSsc', 
            'D3RecRefusedChildren', 
            'D3RevacRefusedChildren', 
            'D3AfpCase', 
            'D5VialDist', 
            'D5VialUse', 
            'D5Vac011Months', 
            'D5Vac1259months', 
            'D5RecAbsChildren', 
            'D5VacAbsChildren', 
            'D5RecNewbornSsc', 
            'D5VacNewbornSsc', 
            'D5RecRefusedChildren', 
            'D5RevacRefusedChildren', 
            'D5AfpCase', 
            'DistrictId', 
            'Cname', 
            'TenantId', 
            'LDPTypes'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

