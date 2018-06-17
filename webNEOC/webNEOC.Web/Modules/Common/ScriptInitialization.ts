/// <reference path="../Common/Helpers/LanguageList.ts" />

namespace webNEOC.ScriptInitialization {
    Q.Config.responsiveDialogs = true;
    Q.Config.rootNamespaces.push('webNEOC');
    Serenity.EntityDialog.defaultLanguageList = LanguageList.getValue;
    Serenity.DataGrid.defaultPersistanceStorage = window.localStorage;
}