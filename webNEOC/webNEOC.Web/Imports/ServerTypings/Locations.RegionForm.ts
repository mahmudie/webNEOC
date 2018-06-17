namespace webNEOC.Locations {
    export class RegionForm extends Serenity.PrefixedContext {
        static formKey = 'Locations.Region';

    }

    export interface RegionForm {
        Rname: Serenity.StringEditor;
        RAbrv: Serenity.StringEditor;
    }

    [['Rname', () => Serenity.StringEditor], ['RAbrv', () => Serenity.StringEditor]].forEach(x => Object.defineProperty(RegionForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

