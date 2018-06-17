namespace webNEOC.Lookup {
    export class RecruitmentTypeForm extends Serenity.PrefixedContext {
        static formKey = 'Lookup.RecruitmentType';

    }

    export interface RecruitmentTypeForm {
        RecruitmentType: Serenity.StringEditor;
    }

    [['RecruitmentType', () => Serenity.StringEditor]].forEach(x => Object.defineProperty(RecruitmentTypeForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

