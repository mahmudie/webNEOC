
/// <reference path="../../Common/Helpers/GridEditorBase.ts" />

namespace webNEOC.Campaign {
    
    @Serenity.Decorators.registerClass()
    export class DailyVaccinationsEditor extends Common.GridEditorBase<DailyVaccinationsRow> {
        protected getColumnsKey() { return 'Campaign.DailyVaccinations'; }
        protected getDialogType() { return DailyVaccinationsEditorDialog; }
                protected getLocalTextPrefix() { return DailyVaccinationsRow.localTextPrefix; }

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
                            var item = <Campaign.DailyVaccinationsRow>{
                                ClusterId: sel.ClusterId,
                                D1VialDist: 0,
                                D1VialUse: 0,
                                D1Vac011Months: 0,
                                D1Vac1259months: 0,
                                D1RecAbsChildren: 0,
                                D1VacAbsChildren: 0,
                                D1RecNewbornSsc: 0,
                                D1VacNewbornSsc: 0,
                                D1RecRefusedChildren: 0,
                                D1RevacRefusedChildren: 0,
                                D1AfpCase: 0,
                                D2VialDist: 0,
                                D2VialUse: 0,
                                D2Vac011Months: 0,
                                D2Vac1259months: 0,
                                D2RecAbsChildren: 0,
                                D2VacAbsChildren: 0,
                                D2RecNewbornSsc: 0,
                                D2VacNewbornSsc: 0,
                                D2RecRefusedChildren: 0,
                                D2RevacRefusedChildren: 0,
                                D2AfpCase: 0,
                                D3VialDist: 0,
                                D3VialUse: 0,
                                D3Vac011Months: 0,
                                D3Vac1259months: 0,
                                D3RecAbsChildren: 0,
                                D3VacAbsChildren: 0,
                                D3RecNewbornSsc: 0,
                                D3VacNewbornSsc: 0,
                                D3RecRefusedChildren: 0,
                                D3RevacRefusedChildren: 0,
                                D3AfpCase: 0,
                                D5VialDist: 0,
                                D5VialUse: 0,
                                D5Vac011Months: 0,
                                D5Vac1259months: 0,
                                D5RecAbsChildren: 0,
                                D5VacAbsChildren: 0,
                                D5RecNewbornSsc: 0,
                                D5VacNewbornSsc: 0,
                                D5RecRefusedChildren: 0,
                                D5RevacRefusedChildren: 0,
                                D5AfpCase: 0

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

            return buttons;
        }
    }
}