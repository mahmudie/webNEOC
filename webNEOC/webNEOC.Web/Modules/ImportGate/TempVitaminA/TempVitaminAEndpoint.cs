
namespace webNEOC.ImportGate.Endpoints
{
    using Serenity;
    using Serenity.Data;
    using Serenity.Services;
    using Serenity.Web;
    using System.Data;
    using System.Web.Mvc;
    using MyRepository = Repositories.TempVitaminARepository;
    using MyRow = Entities.TempVitaminARow;

    [RoutePrefix("Services/ImportGate/TempVitaminA"), Route("{action}")]
    [ConnectionKey(typeof(MyRow)), ServiceAuthorize(typeof(MyRow))]
    public class TempVitaminAController : ServiceEndpoint
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
            var report = new Serenity.Reporting.DynamicDataReport(data, request.IncludeColumns, typeof(Columns.TempVitaminAColumns));
            var bytes = new ReportRepository().Render(report);
            return ExcelContentResult.Create(bytes, "TempVitaminA_" +
                System.DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".xlsx");
        }

        public int ExecProcedure(IDbConnection connection)
        {
            connection.Execute("VitAVaccinations", commandType: CommandType.StoredProcedure);
            connection.Execute("InsVitaminADailyVaccinations", commandType: CommandType.StoredProcedure);
            connection.Execute("DelTempVitaminA", commandType: CommandType.StoredProcedure);
            return 0;
        }
    }
}
