namespace webNEOC.Lookup {
    export class VehicletypeForm extends Serenity.PrefixedContext {
        static formKey = 'Lookup.Vehicletype';

    }

    export interface VehicletypeForm {
        Typename: Serenity.StringEditor;
    }

    [['Typename', () => Serenity.StringEditor]].forEach(x => Object.defineProperty(VehicletypeForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

