namespace webNEOC.Implementation {
    export namespace MobileTeamService {
        export const baseUrl = 'Implementation/MobileTeam';

        export declare function Create(request: Serenity.SaveRequest<MobileTeamRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Update(request: Serenity.SaveRequest<MobileTeamRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<MobileTeamRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<MobileTeamRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function ApproveMobileTeam(request: Serenity.ServiceRequest, onSuccess?: (response: System.Int32) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;

        export namespace Methods {
            export declare const Create: string;
            export declare const Update: string;
            export declare const Delete: string;
            export declare const Retrieve: string;
            export declare const List: string;
            export declare const ApproveMobileTeam: string;
        }

        [
            'Create', 
            'Update', 
            'Delete', 
            'Retrieve', 
            'List',
            'ApproveMobileTeam'
        ].forEach(x => {
            (<any>MobileTeamService)[x] = function (r, s, o) {
                return Q.serviceRequest(baseUrl + '/' + x, r, s, o);
            };
            (<any>Methods)[x] = baseUrl + '/' + x;
        });
    }
}

