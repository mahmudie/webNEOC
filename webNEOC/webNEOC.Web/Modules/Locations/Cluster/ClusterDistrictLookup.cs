
namespace webNEOC.Locations
{
    using Entities;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Web;

    [LookupScript("Locations.District")]
    public class ClusterDistrictLookup : RowLookupScript<Entities.ClusterRow>
    {
        public ClusterDistrictLookup()
        {
            IdField = TextField = ClusterRow.Fields.DistrictId.PropertyName;
        }

        protected override void PrepareQuery(SqlQuery query)
        {
            var fld = Entities.ClusterRow.Fields;
            query.Distinct(true)
                .Select(fld.ProvinceId)
                .Select(fld.DistrictId)
                .Where(
                    new Criteria(fld.ProvinceId) != "" &
                    new Criteria(fld.ProvinceId).IsNotNull() &
                    new Criteria(fld.DistrictId) != "" &
                    new Criteria(fld.DistrictId).IsNotNull());
        }

        protected override void ApplyOrder(SqlQuery query)
        {
        }
    }
}