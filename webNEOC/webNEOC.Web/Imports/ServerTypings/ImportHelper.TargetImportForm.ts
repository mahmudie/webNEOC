﻿namespace webNEOC.ImportHelper {
    export class TargetImportForm extends Serenity.PrefixedContext {
        static formKey = 'ImportHelper.TargetImport';

    }

    export interface TargetImportForm {
        FileName: Serenity.ImageUploadEditor;
    }

    [['FileName', () => Serenity.ImageUploadEditor]].forEach(x => Object.defineProperty(TargetImportForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

