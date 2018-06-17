namespace webNEOC.ImportGate {
    export namespace TempVitaminAService {
        export const baseUrl = 'ImportGate/TempVitaminA';

        export declare function Create(request: Serenity.SaveRequest<TempVitaminARow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Update(request: Serenity.SaveRequest<TempVitaminARow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<TempVitaminARow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<TempVitaminARow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function ExecProcedure(request: Serenity.ServiceRequest, onSuccess?: (response: System.Int32) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;

        export namespace Methods {
            export declare const Create: string;
            export declare const Update: string;
            export declare const Delete: string;
            export declare const Retrieve: string;
            export declare const List: string;
            export declare const ExecProcedure: string;
        }

        [
            'Create', 
            'Update', 
            'Delete', 
            'Retrieve', 
            'List', 
            'ExecProcedure'
        ].forEach(x => {
            (<any>TempVitaminAService)[x] = function (r, s, o) {
                return Q.serviceRequest(baseUrl + '/' + x, r, s, o);
            };
            (<any>Methods)[x] = baseUrl + '/' + x;
        });
    }
}

