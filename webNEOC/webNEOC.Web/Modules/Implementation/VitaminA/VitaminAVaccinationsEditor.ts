
/// <reference path="../../Common/Helpers/GridEditorBase.ts" />

namespace webNEOC.Implementation {
    
    @Serenity.Decorators.registerClass()
    export class VitaminAVaccinationsEditor extends Common.GridEditorBase<VitaminAVaccinationsRow> {
        protected getColumnsKey() { return 'Implementation.VitaminAVaccinations'; }
        protected getDialogType() { return VitaminAVaccinationsEditorDialog; }
                protected getLocalTextPrefix() { return VitaminAVaccinationsRow.localTextPrefix; }

        constructor(container: JQuery) {
            super(container);
                }
        // Cluster picker
        protected getButtons(): Serenity.ToolButton[] {
            var buttons = super.getButtons();
            buttons.push({
                title: "Pick Clusters",
                cssClass: "add-button",
                onClick: () => {
                    var dlg = new Locations.ClusterPickerDialog();
                    dlg.onSuccess = (selected) => {
                        // filter already existing products
                        selected = selected.filter(x => !Q.any(this.view.getItems(), y => y.ClusterId == x.ClusterId));

                        for (var sel of selected) {
                            var item = <Implementation.VitaminAVaccinationsRow>{
                                ClusterId: sel.ClusterId,
                                TargetU5Cases: 0,
                                d1VitADist: 0,
                                d1VitAUse: 0,
                                d1C611Months: 0,
                                d1C1259Months: 0,
                                d2VitADist: 0,
                                d2VitAUse: 0,
                                d2C611Months: 0,
                                d2C1259Months: 0,
                                d3VitADist: 0,
                                d3VitAUse: 0,
                                d3C611Months: 0,
                                d3C1259Months: 0,
                                d5VitADist: 0,
                                d5VitAUse: 0,
                                d5C611Months: 0,
                                d5C1259Months: 0

                            };

                            var id = this.getNextId();
                            item[this.getIdProperty()] = id;
                            this.view.addItem(item);
                        }

                        return true;
                    };
                    dlg.dialogOpen();
                }
            });
            buttons.push(Common.ExcelExportHelper.createToolButton({
                grid: this,
                service: VitaminAVaccinationsService.baseUrl + '/ListExcel',
                onViewSubmit: () => this.onViewSubmit(),
                separator: false,
                hint: "Export",
                title: "Export"
            }));

            return buttons;
        }
    }
}