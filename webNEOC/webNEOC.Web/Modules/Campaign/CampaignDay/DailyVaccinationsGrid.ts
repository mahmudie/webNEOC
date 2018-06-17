
namespace webNEOC.Campaign {
    
    @Serenity.Decorators.registerClass()
    export class DailyVaccinationsGrid extends Serenity.EntityGrid<DailyVaccinationsRow, any> {
        protected getColumnsKey() { return 'Campaign.DailyVaccinations'; }
        protected getDialogType() { return DailyVaccinationsDialog; }
        protected getIdProperty() { return DailyVaccinationsRow.idProperty; }
        protected getLocalTextPrefix() { return DailyVaccinationsRow.localTextPrefix; }
        protected getService() { return DailyVaccinationsService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }

        protected getColumns(): Slick.Column[] {
            var columns = super.getColumns();

            var fld = Campaign.DailyVaccinationsRow.Fields;

            // adding a specific css class to UnitPrice column, 
            // to be able to format cell with a different background
            Q.first(columns, x => x.field == fld.TargetU5Case).cssClass += " col-unit-price";

            return columns;
        }
    }
}