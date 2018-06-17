
namespace webNEOC.Locations
{
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Web;

    [LookupScript("Locations.Province")]
    public class ClusterProvinceLookup : RowLookupScript<Entities.ClusterRow>
    {
        public ClusterProvinceLookup()
        {
            IdField = TextField = "ProvinceId";
        }

        protected override void PrepareQuery(SqlQuery query)
        {
            var fld = Entities.ClusterRow.Fields;
            query.Distinct(true)
                .Select(fld.ProvinceId)
                .Where(
                    new Criteria(fld.ProvinceId) != "" &
                    new Criteria(fld.ProvinceId).IsNotNull());
        }

        protected override void ApplyOrder(SqlQuery query)
        {
        }
    }
}