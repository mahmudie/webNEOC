namespace webNEOC.Implementation {
    export class CommunicationForm extends Serenity.PrefixedContext {
        static formKey = 'Implementation.Communication';

    }

    export interface CommunicationForm {
        LanguageId: Serenity.IntegerEditor;
        MediaTypeId: Serenity.IntegerEditor;
        Duration: Serenity.IntegerEditor;
        MediaId: Serenity.IntegerEditor;
        BroadCastDate: Serenity.DateEditor;
        DaypartId: Serenity.IntegerEditor;
        Source: Serenity.StringEditor;
        TenantId: Serenity.IntegerEditor;
    }

    [['LanguageId', () => Serenity.IntegerEditor], ['MediaTypeId', () => Serenity.IntegerEditor], ['Duration', () => Serenity.IntegerEditor], ['MediaId', () => Serenity.IntegerEditor], ['BroadCastDate', () => Serenity.DateEditor], ['DaypartId', () => Serenity.IntegerEditor], ['Source', () => Serenity.StringEditor], ['TenantId', () => Serenity.IntegerEditor]].forEach(x => Object.defineProperty(CommunicationForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

