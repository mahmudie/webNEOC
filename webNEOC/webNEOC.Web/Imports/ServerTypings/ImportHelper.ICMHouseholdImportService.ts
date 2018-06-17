namespace webNEOC.ImportHelper {
    export namespace ICMHouseholdImportService {
        export const baseUrl = 'ImportHelper/ICMHouseholdImport';

        export declare function ExcelImport(request: ExcelImportRequest, onSuccess?: (response: ExcelImportResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;

        export namespace Methods {
            export declare const ExcelImport: string;
        }

        [
            'ExcelImport'
        ].forEach(x => {
            (<any>ICMHouseholdImportService)[x] = function (r, s, o) {
                return Q.serviceRequest(baseUrl + '/' + x, r, s, o);
            };
            (<any>Methods)[x] = baseUrl + '/' + x;
        });
    }
}

