namespace webNEOC.Lookup {
    export class ClusterLevelForm extends Serenity.PrefixedContext {
        static formKey = 'Lookup.ClusterLevel';

    }

    export interface ClusterLevelForm {
        ClusterName: Serenity.StringEditor;
    }

    [['ClusterName', () => Serenity.StringEditor]].forEach(x => Object.defineProperty(ClusterLevelForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

