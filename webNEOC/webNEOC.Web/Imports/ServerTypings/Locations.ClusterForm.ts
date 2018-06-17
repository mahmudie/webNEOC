namespace webNEOC.Locations {
    export class ClusterForm extends Serenity.PrefixedContext {
        static formKey = 'Locations.Cluster';

    }

    export interface ClusterForm {
        ProvinceId: Serenity.LookupEditor;
        DistrictId: Serenity.LookupEditor;
        Ccode: Serenity.StringEditor;
        Cname: Serenity.StringEditor;
        Targetpop: Serenity.IntegerEditor;
    }

    [['ProvinceId', () => Serenity.LookupEditor], ['DistrictId', () => Serenity.LookupEditor], ['Ccode', () => Serenity.StringEditor], ['Cname', () => Serenity.StringEditor], ['Targetpop', () => Serenity.IntegerEditor]].forEach(x => Object.defineProperty(ClusterForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

