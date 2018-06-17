
namespace webNEOC.Implementation {

    @Serenity.Decorators.registerClass()
    export class IcnDeploymentGrid extends Serenity.EntityGrid<IcnDeploymentRow, any> {
        protected getColumnsKey() { return 'Implementation.IcnDeployment'; }
        protected getDialogType() { return IcnDeploymentDialog; }
        protected getIdProperty() { return IcnDeploymentRow.idProperty; }
        protected getLocalTextPrefix() { return IcnDeploymentRow.localTextPrefix; }
        protected getService() { return IcnDeploymentService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}