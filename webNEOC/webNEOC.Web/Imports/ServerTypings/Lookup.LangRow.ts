
namespace webNEOC.Lookup {
    export interface LangRow {
        LanguageId?: number;
        LanguageName?: string;
    }

    export namespace LangRow {
        export const idProperty = 'LanguageId';
        export const nameProperty = 'LanguageName';
        export const localTextPrefix = 'Lookup.Lang';

        export namespace Fields {
            export declare const LanguageId;
            export declare const LanguageName;
        }

        [
            'LanguageId',
            'LanguageName'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}