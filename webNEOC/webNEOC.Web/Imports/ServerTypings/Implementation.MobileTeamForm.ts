namespace webNEOC.Implementation {
    export class MobileTeamForm extends Serenity.PrefixedContext {
        static formKey = 'Implementation.MobileTeam';

    }

    export interface MobileTeamForm {
        MobileTeamId: Serenity.IntegerEditor;
        RoundId: Serenity.LookupEditor;
        DateFrom: Serenity.DateEditor;
        DateTo: Serenity.DateEditor;
        ProvinceId: Serenity.LookupEditor;
        DistrictId: Serenity.LookupEditor;
        Nomads: Serenity.IntegerEditor;
        Gypsis: Serenity.IntegerEditor;
        BlueMosque: Serenity.IntegerEditor;
        IDPs: Serenity.IntegerEditor;
        Returnees: Serenity.IntegerEditor;
        Kindergarden: Serenity.IntegerEditor;
        Madrasa: Serenity.IntegerEditor;
        EPICenters: Serenity.IntegerEditor;
        BusStation: Serenity.IntegerEditor;
        Prison: Serenity.IntegerEditor;
        MobileTeams: Serenity.IntegerEditor;
        CheckPost: Serenity.IntegerEditor;
        PrivateClinics: Serenity.IntegerEditor;
        Daramsal: Serenity.IntegerEditor;
        HotelGuestHouses: Serenity.IntegerEditor;
        Crosborder: Serenity.IntegerEditor;
        School: Serenity.IntegerEditor;
        Others: Serenity.IntegerEditor;
    }

    [['MobileTeamId', () => Serenity.IntegerEditor], ['RoundId', () => Serenity.LookupEditor], ['DateFrom', () => Serenity.DateEditor], ['DateTo', () => Serenity.DateEditor], ['ProvinceId', () => Serenity.LookupEditor], ['DistrictId', () => Serenity.LookupEditor], ['Nomads', () => Serenity.IntegerEditor], ['Gypsis', () => Serenity.IntegerEditor], ['BlueMosque', () => Serenity.IntegerEditor], ['IDPs', () => Serenity.IntegerEditor], ['Returnees', () => Serenity.IntegerEditor], ['Kindergarden', () => Serenity.IntegerEditor], ['Madrasa', () => Serenity.IntegerEditor], ['EPICenters', () => Serenity.IntegerEditor], ['BusStation', () => Serenity.IntegerEditor], ['Prison', () => Serenity.IntegerEditor], ['MobileTeams', () => Serenity.IntegerEditor], ['CheckPost', () => Serenity.IntegerEditor], ['PrivateClinics', () => Serenity.IntegerEditor], ['Daramsal', () => Serenity.IntegerEditor], ['HotelGuestHouses', () => Serenity.IntegerEditor], ['Crosborder', () => Serenity.IntegerEditor], ['School', () => Serenity.IntegerEditor], ['Others', () => Serenity.IntegerEditor]].forEach(x => Object.defineProperty(MobileTeamForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

