namespace webNEOC.Implementation {
    export interface CommunicationRow {
        CommunicationId?: number;
        LanguageId?: number;
        MediaTypeId?: number;
        Duration?: number;
        MediaId?: number;
        BroadCastDate?: string;
        DaypartId?: number;
        Daypart?: string;
        Source?: string;
        TenantId?: number;
        LanguageLanguageName?: string;
        MediaTypeMediaTypeName?: string;
        MediaMediaName?: string;
        BroadCastTime?: string;
        CommunId?: string;
    }

    export namespace CommunicationRow {
        export const idProperty = 'CommunicationId';
        export const nameProperty = 'CommunId';
        export const localTextPrefix = 'Implementation.Communication';

        export namespace Fields {
            export declare const CommunicationId: string;
            export declare const LanguageId: string;
            export declare const MediaTypeId: string;
            export declare const Duration: string;
            export declare const MediaId: string;
            export declare const BroadCastDate: string;
            export declare const DaypartId: number;
            export declare const Daypart: string;
            export declare const Source: string;
            export declare const TenantId: string;
            export declare const LanguageLanguageName: string;
            export declare const MediaTypeMediaTypeName: string;
            export declare const MediaMediaName: string;
            export declare const BroadCastTime: string;
            export declare const CommunId: string;
        }

        [
            'CommunicationId', 
            'LanguageId', 
            'MediaTypeId', 
            'Duration', 
            'MediaId', 
            'BroadCastDate', 
            'DaypartId', 
            'Daypart',
            'Source', 
            'TenantId', 
            'LanguageLanguageName', 
            'MediaTypeMediaTypeName', 
            'MediaMediaName', 
            'BroadCastTime',
            'CommunId'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

