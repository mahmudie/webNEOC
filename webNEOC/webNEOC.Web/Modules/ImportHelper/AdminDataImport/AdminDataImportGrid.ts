﻿/// <reference path="../../campaign/admindata/admindatagrid.ts" />


namespace webNEOC.ImportHelper {

    @Serenity.Decorators.registerClass()
    export class AdminDataImportGrid extends Campaign.AdminDataGrid {

        constructor(container: JQuery) {
            super(container);
        }

        /**
         * This method is called to get list of buttons to be created.
         */
        protected getButtons(): Serenity.ToolButton[] {

            // call base method to get list of buttons
            var buttons = super.getButtons();

            // add our import button
            buttons.push({
                title: 'Import From Excel',
                cssClass: 'export-xlsx-button',
                onClick: () => {
                    // open import dialog, let it handle rest
                    var dialog = new AdminDataImportDialog();
                    dialog.element.on('dialogclose', () => {
                        this.refresh();
                        dialog = null;
                    });
                    dialog.dialogOpen();
                }
            });

            return buttons;
        }
    }
}