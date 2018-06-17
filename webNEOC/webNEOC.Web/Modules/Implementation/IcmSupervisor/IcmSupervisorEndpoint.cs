
namespace webNEOC.Implementation.Endpoints
{
    using Serenity;
    using Serenity.Data;
    using Serenity.Services;
    using Serenity.Web;
    using System.Data;
    using System.Web.Mvc;
    using MyRepository = Repositories.IcmSupervisorRepository;
    using MyRow = Entities.IcmSupervisorRow;

    [RoutePrefix("Services/Implementation/IcmSupervisor"), Route("{action}")]
    [ConnectionKey(typeof(MyRow)), ServiceAuthorize(typeof(MyRow))]
    public class IcmSupervisorController : ServiceEndpoint
    {
        [HttpPost, AuthorizeCreate(typeof(MyRow))]
        public SaveResponse Create(IUnitOfWork uow, SaveRequest<MyRow> request)
        {
            return new MyRepository().Create(uow, request);
        }

        [HttpPost, AuthorizeUpdate(typeof(MyRow))]
        public SaveResponse Update(IUnitOfWork uow, SaveRequest<MyRow> request)
        {
            return new MyRepository().Update(uow, request);
        }
 
        [HttpPost, AuthorizeDelete(typeof(MyRow))]
        public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
        {
            return new MyRepository().Delete(uow, request);
        }

        public RetrieveResponse<MyRow> Retrieve(IDbConnection connection, RetrieveRequest request)
        {
            return new MyRepository().Retrieve(connection, request);
        }

        public ListResponse<MyRow> List(IDbConnection connection, ListRequest request)
        {
            return new MyRepository().List(connection, request);
        }

        public FileContentResult ListExcel(IDbConnection connection, ListRequest request)
        {
            var data = List(connection, request).Entities;
            var report = new Serenity.Reporting.DynamicDataReport(data, request.IncludeColumns, typeof(Columns.IcmSupervisorColumns));
            var bytes = new ReportRepository().Render(report);
            return ExcelContentResult.Create(bytes, "ICMSupervisor_" +
                System.DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".xlsx");
        }

        public int ApproveIcmSupervisor(IDbConnection connection)
        {
            int? UserId = 0;
            int? TenantId = 0;
            var user = User.Identity.Name;
            var usr = Administration.Entities.UserRow.Fields;
            if (!string.IsNullOrWhiteSpace(user))
            {
                var Users = connection.TryFirst<Administration.Entities.UserRow>(q => q
                    .Select(usr.UserId)
                    .Select(usr.TenantId)
                    .Where(usr.Username == user));
                UserId = Users.UserId;
                TenantId = Users.TenantId;
            }

            connection.Execute("ApproveIcmSupervisor",
                        param: new
                        {
                            UserId = UserId,
                            Approved = true,
                            TenantId = TenantId
                        }, commandType: CommandType.StoredProcedure);
            return 0;
        }
    }
}
