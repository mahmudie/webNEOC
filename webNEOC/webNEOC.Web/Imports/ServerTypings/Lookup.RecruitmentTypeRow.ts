namespace webNEOC.Lookup {
    export interface RecruitmentTypeRow {
        RecruitmentTypeId?: number;
        RecruitmentType?: string;
    }

    export namespace RecruitmentTypeRow {
        export const idProperty = 'RecruitmentTypeId';
        export const nameProperty = 'RecruitmentType';
        export const localTextPrefix = 'Lookup.RecruitmentType';

        export namespace Fields {
            export declare const RecruitmentTypeId: string;
            export declare const RecruitmentType: string;
        }

        [
            'RecruitmentTypeId', 
            'RecruitmentType'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

