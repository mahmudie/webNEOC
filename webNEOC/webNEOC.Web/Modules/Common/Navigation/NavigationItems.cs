using Serenity.Navigation;
using Administration = webNEOC.Administration.Pages;
using Campaign = webNEOC.Campaign.Pages;
using implementation = webNEOC.Implementation.Pages;
using Preparation = webNEOC.Preparation.Pages;
using Post = webNEOC.PostCampaign.Pages;
using Location = webNEOC.Locations.Pages;
using Lookup = webNEOC.Lookup.Pages;
using Meeting = webNEOC.Meeting.Pages;
using Organization = webNEOC.Organization.Pages;
using dash = webNEOC.Controllers;

[assembly: NavigationLink(1000, "Dashboard", url: "~/", permission: "", icon: "fa fa-dashboard")]
[assembly: NavigationLink(1002, "Dashboard/Pre-Campaign", url: "/PreCamp", permission: typeof(dash.PreCampController), icon: "ion-ios-list")]
[assembly: NavigationLink(1002, "Dashboard/Intra-Campaign", url: "/IntraCamp", permission: typeof(dash.IntraCampController), icon: "ion-ios-list")]
[assembly: NavigationLink(1002, "Dashboard/Administrative Coverage", url: "/Regional", permission: typeof(dash.AdminCoverageController), icon: "ion-ios-list")]
//[assembly: NavigationLink(1003, "Dashboard/Coverage map", url: "/Dash/Dash", permission: typeof(dash.DashController), icon: "fa fa-arrow-circle-right")]
[assembly: NavigationLink(1003, "Dashboard/Surveillance", url: "/Dash/Surveillance", permission: typeof(dash.DashController), icon: "fa fa-arrow-circle-right")]
[assembly: NavigationLink(1004, "Dashboard/Vitamin A", url: "/Dash/VitA", permission: typeof(dash.DashController), icon: "fa fa-arrow-circle-right")]
[assembly: NavigationLink(1005, "Dashboard/Post Campaign Monitoring", url: "/Dash/pcm", permission: typeof(dash.DashController), icon: "fa fa-arrow-circle-right")]
[assembly: NavigationLink(1006, "Dashboard/WHO/Missed Children", url: "/Dash/mc", permission: typeof(dash.DashController), icon: "fa fa-arrow-circle-right")]
[assembly: NavigationLink(1007, "Dashboard/WHO/Children with FM", url: "/Dash/fm", permission: typeof(dash.DashController), icon: "fa fa-arrow-circle-right")]
[assembly: NavigationLink(1008, "Dashboard/WHO/LQAS Acceptance", url: "/Dash/lqas", permission: typeof(dash.DashController), icon: "fa fa-arrow-circle-right")]
[assembly: NavigationLink(1009, "Dashboard/WHO/Admin Coverage", url: "/Dash/admin", permission: typeof(dash.DashController), icon: "fa fa-arrow-circle-right")]
[assembly: NavigationLink(1009, "Dashboard/WHO/Admin Coverage-numeric", url: "/Dash/adminn", permission: typeof(dash.DashController), icon: "fa fa-arrow-circle-right")]
[assembly: NavigationLink(1010, "Dashboard/UNICEF/ICN catch-up vaccinated-%", url: "/Dash/icnp", permission: typeof(dash.DashController), icon: "fa fa-arrow-circle-right")]
[assembly: NavigationLink(1011, "Dashboard/UNICEF/ICN catch-up vaccinated-#", url: "/Dash/icnn", permission: typeof(dash.DashController), icon: "fa fa-arrow-circle-right")]
[assembly: NavigationLink(1012, "Dashboard/UNICEF/ICN catch-up by region", url: "/Dash/icnr", permission: typeof(dash.DashController), icon: "fa fa-arrow-circle-right")]
[assembly: NavigationLink(1013, "Dashboard/UNICEF/ICN catch-up by province", url: "/Dash/icnpp", permission: typeof(dash.DashController), icon: "fa fa-arrow-circle-right")]
[assembly: NavigationLink(1013, "Dashboard/UNICEF/ICN catch-up by district", url: "/Dash/icnd", permission: typeof(dash.DashController), icon: "fa fa-arrow-circle-right")]
[assembly: NavigationLink(1013, "Dashboard/UNICEF/ICN catch-up by cluster", url: "/Dash/icnc", permission: typeof(dash.DashController), icon: "fa fa-arrow-circle-right")]
[assembly: NavigationLink(1014, "Dashboard/UNICEF/Polio Media Coverage", url: "/Dash/media", permission: typeof(dash.DashController), icon: "fa fa-arrow-circle-right")]
[assembly: NavigationLink(1014, "Dashboard/UNICEF/Deployed Social Mobilizers", url: "/Dash/recruitment", permission: typeof(dash.DashController), icon: "fa fa-arrow-circle-right")]


[assembly: NavigationLink(1020, "Dashboard/Dashboard Panel", url: "http://localhost:64920", permission: "", icon: "fa fa-arrow-circle-right")]
//[assembly: NavigationLink(1005, "Dashboard/Dashboard Panel", url: "http://http://58.147.133.201:8080/", permission: "", icon: "fa fa-arrow-circle-right")]

[assembly: NavigationMenu(1050, "Indicators", icon: "glyphicon glyphicon-blackboard")]
[assembly: NavigationLink(1051, "Indicators/Type I-Compare Ind over Loc", url: "/Indicators/Index", permission: typeof(dash.IndicatorsController), icon: "ion-ios-list")]
[assembly: NavigationLink(1051, "Indicators/Type II-Compare Loc over period", url: "/Indicators/Typetwo", permission: typeof(dash.IndicatorsController), icon: "ion-ios-list")]
//[assembly: NavigationLink(1051, "Monitboard/PCM Result", url: "/PCMChart", permission: typeof(dash.PCMChartController), icon: "ion-ios-list")]


//[assembly: NavigationMenu(1060, "Pivotboard", icon: "fa fa-table")]
//[assembly: NavigationLink(1061, "Pivotboard/Opv Coverage data", url: "/Pivot/OpvData", permission: typeof(NEOCPivot.pivotClientController), icon: "fa fa-arrow-circle-right")]
//[assembly: NavigationLink(1062, "Pivotboard/Mobile Coverage", url: "/Pivot/MobileData", permission: typeof(NEOCPivot.pivotClientController), icon: "fa fa-arrow-circle-right")]
//[assembly: NavigationLink(1063, "Pivotboard/Vitamin A report", url: "/Pivot/VIT", permission: typeof(NEOCPivot.pivotClientController), icon: "fa fa-arrow-circle-right")]
//[assembly: NavigationLink(1064, "Pivotboard/ICN Records", url: "/Pivot/ICN", permission: typeof(NEOCPivot.pivotClientController), icon: "fa fa-arrow-circle-right")]

////[assembly: NavigationMenu(1060, "Mapboard", icon: "fa fa-map")]
////[assembly: NavigationLink(1061, "Mapboard/Map", url: "/TreeGrid", permission: typeof(dash.LQASChartController), icon: "fa fa-arrow-circle-right")]

[assembly: NavigationMenu(2000, "Preparation", icon: "ion-grid")]
[assembly: NavigationLink(2001, "Preparation/Microplan", typeof(Preparation.MicroplanController), icon: "fa fa-calendar")]
[assembly: NavigationLink(2002, "Preparation/Inaccessiblity", typeof(Preparation.InAccessibleController), icon: "fa fa-ban")]


[assembly: NavigationMenu(3000, "Implementation", icon: "icon-settings")]
[assembly: NavigationLink(3100, "Implementation/Admin data-new", typeof(Campaign.AdminDataController), icon: "ion-hammer")]
[assembly: NavigationLink(3200, "Implementation/Admin data-old", typeof(Campaign.CampaignDayController), icon: "fa fa-sun-o")]
[assembly: NavigationLink(3300, "Implementation/Vitamin A", typeof(implementation.VitaminAController), icon: "ion-happy")]
[assembly: NavigationLink(3400, "Implementation/Mobile Team", typeof(implementation.MobileTeamController), icon: "fa fa-mobile")]
[assembly: NavigationLink(3500, "Implementation/ICM Team", typeof(implementation.IcmTeamController), icon: "ion-ios-people")]
[assembly: NavigationLink(3600, "Implementation/ICM Household", typeof(implementation.IcmHouseholdController), icon: "fa fa-home")]
[assembly: NavigationLink(3700, "Implementation/ICM Supervisor", typeof(implementation.IcmSupervisorController), icon: "ion-android-contact")]
[assembly: NavigationLink(3700, "Implementation/ICN Records", typeof(implementation.IcnController), icon: "fa fa-book")]


[assembly: NavigationMenu(3800, "CVA Coverage", icon: "fa fa-sun-o")]
[assembly: NavigationLink(3801, "CVA Coverage/PTTS", typeof(webNEOC.CVA.Pages.PTTSController), icon: "fa fa-book")]

[assembly: NavigationMenu(4000, "Post Campaign", icon: "ion-loop")]
[assembly: NavigationLink(4001, "Post Campaign/PCM", typeof(Post.PcmController), icon: "fa fa-phone-square")]
[assembly: NavigationLink(4002, "Post Campaign/LQAS", typeof(Post.LQASController), icon: "ion-ios-list-outline")]
[assembly: NavigationLink(4003, "Post Campaign/Out of House", typeof(Post.OutOfHouseSurveyController), icon: "fa fa-paper-plane-o")]

//Managmeent
[assembly: NavigationMenu(4100, "Management", icon: "fa-tasks")]
[assembly: NavigationLink(4001, "Management/ICN Deployment", typeof(implementation.IcnDeploymentController), icon: "fa fa-cog")]
[assembly: NavigationLink(4001, "Management/Communication", typeof(implementation.CommunicationController), icon: "fa fa-bullhorn")]
//locations
[assembly: NavigationMenu(5000, "Location", icon: "ion-ios-location")]
[assembly: NavigationLink(5001, "Location/Region", typeof(Location.RegionController), icon: "fa fa-thumb-tack")]
[assembly: NavigationLink(5002, "Location/Province", typeof(Location.ProvinceController), icon: "fa fa-thumb-tack")]
[assembly: NavigationLink(5003, "Location/District", typeof(Location.DistrictController), icon: "fa fa-thumb-tack")]
[assembly: NavigationLink(5004, "Location/Cluster", typeof(Location.ClusterController), icon: "fa fa-thumb-tack")]

//Lookups
[assembly: NavigationMenu(6000, "Lookup", icon: "fa fa-th-list")]
[assembly: NavigationLink(6001, "Lookup/Round", typeof(Lookup.RoundController), icon: "fa fa-list-alt")]
[assembly: NavigationLink(6002, "Lookup/Part", typeof(Lookup.PartController), icon: "fa fa-list-alt")]
[assembly: NavigationLink(6003, "Lookup/Campaign Type", typeof(Lookup.CampaignTypeController), icon: "fa fa-list-alt")]
[assembly: NavigationLink(6004, "Lookup/Vehicle Type", typeof(Lookup.VehicletypeController), icon: "fa fa-list-alt")]
[assembly: NavigationLink(6005, "Lookup/Inaccess Reasons", typeof(Lookup.InAcsCategoryController), icon: "fa fa-list-alt")]
[assembly: NavigationLink(6006, "Lookup/Cluster Level", typeof(Lookup.ClusterLevelController), icon: "fa fa-list-alt")]
[assembly: NavigationLink(6007, "Lookup/LQAS Status", typeof(Lookup.StatusController), icon: "fa fa-list-alt")]
[assembly: NavigationLink(6007, "Lookup/Target Population", typeof(Lookup.TargetPopController), icon: "fa fa-users")]
[assembly: NavigationLink(6008, "Lookup/Media Type", typeof(Lookup.MediaTypeController), icon: "fa fa-comment")]
[assembly: NavigationLink(6008, "Lookup/Media List", typeof(Lookup.MediaController), icon: "fa fa-bicycle")]
[assembly: NavigationLink(6010, "Lookup/ICN Type", typeof(Lookup.IcnTypeController), icon: "fa fa-list-alt")]
[assembly: NavigationLink(6011, "Lookup/Recruitment Type", typeof(Lookup.RecruitmentTypeController), icon: "fa fa-street-view")]
[assembly: NavigationLink(6012, "Lookup/Days", typeof(Lookup.DaysController), icon: "fa fa-calendar")]
[assembly: NavigationLink(6013, "Lookup/Day Part", typeof(Lookup.DayPartController), icon: "fa fa-calendar")]

[assembly: NavigationMenu(6600, "Meeting", icon: "fa-comments")]
[assembly: NavigationLink(6610, "Meeting/Meetings", typeof(Meeting.MeetingController))]
[assembly: NavigationLink(6620, "Meeting/Meeting Agenda Types", typeof(Meeting.MeetingAgendaTypeController))]
[assembly: NavigationLink(6630, "Meeting/Meeting Locations", typeof(Meeting.MeetingLocationController))]
[assembly: NavigationLink(6640, "Meeting/Meeting Types", typeof(Meeting.MeetingTypeController))]
[assembly: NavigationLink(6650, "Meeting/Business Units", typeof(Organization.BusinessUnitController), icon: "fa-sitemap")]
[assembly: NavigationLink(6660, "Meeting/Contacts", typeof(Organization.ContactController), icon: "fa-address-book")]


[assembly: NavigationMenu(7000, "Administration", icon: "icon-screen-desktop")]
[assembly: NavigationLink(7001, "Administration/Exceptions Log", url: "~/errorlog.axd", permission: webNEOC.Administration.PermissionKeys.Security, icon: "icon-ban", Target = "_blank")]
[assembly: NavigationLink(7002, "Administration/Mail Queue", typeof(webNEOC.Common.Pages.MailController), icon: "icon-envelope-letter")]
//[assembly: NavigationLink(7003, "Administration/Languages", typeof(Administration.LanguageController), icon: "icon-bubbles")]
[assembly: NavigationLink(7004, "Administration/Translations", typeof(Administration.TranslationController), icon: "icon-speech")]
[assembly: NavigationLink(7005, "Administration/Roles", typeof(Administration.RoleController), icon: "icon-lock")]
[assembly: NavigationLink(7006, "Administration/User Management", typeof(Administration.UserController), icon: "icon-people")]
[assembly: NavigationLink(7007, "Administration/Approve Records", typeof(webNEOC.Controllers.ManagesController), icon: "fa fa-check")]
[assembly: NavigationLink(7007, "Administration/Manage Tenants", typeof(MultiTenancy.Administration.Pages.TenantController), icon: "icon-people")]
