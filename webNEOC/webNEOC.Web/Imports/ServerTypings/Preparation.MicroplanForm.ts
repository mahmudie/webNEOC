namespace webNEOC.Preparation {
    export class MicroplanForm extends Serenity.PrefixedContext {
        static formKey = 'Preparation.Microplan';

    }

    export interface MicroplanForm {
        RoundId: Serenity.LookupEditor;
        DateFrom: Serenity.DateEditor;
        DateTo: Serenity.DateEditor;
        ProvinceId: Serenity.LookupEditor;
        DistrictId: Serenity.LookupEditor;
        ReportDate: Serenity.DateEditor;
        Sno: Serenity.IntegerEditor;
        TotalPop: Serenity.IntegerEditor;
        OpvTarget: Serenity.IntegerEditor;
        MissedTarget: Serenity.IntegerEditor;
        VitATarget: Serenity.IntegerEditor;
        Teams: Serenity.IntegerEditor;
        NomadTeams: Serenity.IntegerEditor;
        FixVacTeams: Serenity.IntegerEditor;
        RemtpemTstaff: Serenity.IntegerEditor;
        Coordinators: Serenity.IntegerEditor;
        Pco: Serenity.IntegerEditor;
        Dpodco: Serenity.IntegerEditor;
        CcSs: Serenity.IntegerEditor;
        SMs: Serenity.IntegerEditor;
        Sup: Serenity.IntegerEditor;
        IntraNiDsMonitors: Serenity.IntegerEditor;
        PcAmonotors: Serenity.IntegerEditor;
        OpvDoses: Serenity.IntegerEditor;
        AlbendazTablet: Serenity.IntegerEditor;
        VitACapsules: Serenity.IntegerEditor;
        Banner: Serenity.IntegerEditor;
        Vehicle: Serenity.IntegerEditor;
        MotorBikes4Nomads: Serenity.IntegerEditor;
        Scissors: Serenity.IntegerEditor;
        AlbenVitSheetCoordinator: Serenity.IntegerEditor;
        AlbenVitSheetSupvervisor: Serenity.IntegerEditor;
    }

    [['RoundId', () => Serenity.LookupEditor], ['DateFrom', () => Serenity.DateEditor], ['DateTo', () => Serenity.DateEditor], ['ProvinceId', () => Serenity.LookupEditor], ['DistrictId', () => Serenity.LookupEditor], ['ReportDate', () => Serenity.DateEditor], ['Sno', () => Serenity.IntegerEditor], ['TotalPop', () => Serenity.IntegerEditor], ['OpvTarget', () => Serenity.IntegerEditor], ['MissedTarget', () => Serenity.IntegerEditor], ['VitATarget', () => Serenity.IntegerEditor], ['Teams', () => Serenity.IntegerEditor], ['NomadTeams', () => Serenity.IntegerEditor], ['FixVacTeams', () => Serenity.IntegerEditor], ['RemtpemTstaff', () => Serenity.IntegerEditor], ['Coordinators', () => Serenity.IntegerEditor], ['Pco', () => Serenity.IntegerEditor], ['Dpodco', () => Serenity.IntegerEditor], ['CcSs', () => Serenity.IntegerEditor], ['SMs', () => Serenity.IntegerEditor], ['Sup', () => Serenity.IntegerEditor], ['IntraNiDsMonitors', () => Serenity.IntegerEditor], ['PcAmonotors', () => Serenity.IntegerEditor], ['OpvDoses', () => Serenity.IntegerEditor], ['AlbendazTablet', () => Serenity.IntegerEditor], ['VitACapsules', () => Serenity.IntegerEditor], ['Banner', () => Serenity.IntegerEditor], ['Vehicle', () => Serenity.IntegerEditor], ['MotorBikes4Nomads', () => Serenity.IntegerEditor], ['Scissors', () => Serenity.IntegerEditor], ['AlbenVitSheetCoordinator', () => Serenity.IntegerEditor], ['AlbenVitSheetSupvervisor', () => Serenity.IntegerEditor]].forEach(x => Object.defineProperty(MicroplanForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

