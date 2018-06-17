/// <reference types="jquery" />
/// <reference types="jqueryui" />
declare namespace webNEOC.Preparation {
    class MicroplanDialog extends Serenity.EntityDialog<MicroplanRow, any> {
        protected getFormKey(): string;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getService(): string;
        protected form: MicroplanForm;
        constructor();
        private setDateDetails(details);
    }
}
declare namespace webNEOC.Common {
    class GridEditorBase<TEntity> extends Serenity.EntityGrid<TEntity, any> implements Serenity.IGetEditValue, Serenity.ISetEditValue {
        protected getIdProperty(): string;
        protected nextId: number;
        constructor(container: JQuery);
        protected id(entity: TEntity): any;
        protected getNextId(): string;
        protected setNewId(entity: TEntity): void;
        protected save(opt: Serenity.ServiceOptions<any>, callback: (r: Serenity.ServiceResponse) => void): void;
        protected deleteEntity(id: number): boolean;
        protected validateEntity(row: TEntity, id: number): boolean;
        protected setEntities(items: TEntity[]): void;
        protected getNewEntity(): TEntity;
        protected getButtons(): Serenity.ToolButton[];
        protected editItem(entityOrId: any): void;
        getEditValue(property: any, target: any): void;
        setEditValue(source: any, property: any): void;
        value: TEntity[];
        protected getGridCanLoad(): boolean;
        protected usePager(): boolean;
        protected getInitialTitle(): any;
        protected createQuickSearchInput(): void;
    }
}
declare namespace webNEOC.Preparation {
    class MicroplanEditor extends Common.GridEditorBase<MicroplanRow> {
        protected getColumnsKey(): string;
        protected getDialogType(): typeof MicroplanEditorDialog;
        protected getLocalTextPrefix(): string;
        constructor(container: JQuery);
    }
}
declare namespace webNEOC.Common {
    class GridEditorDialog<TEntity> extends Serenity.EntityDialog<TEntity, any> {
        protected getIdProperty(): string;
        onSave: (options: Serenity.ServiceOptions<Serenity.SaveResponse>, callback: (response: Serenity.SaveResponse) => void) => void;
        onDelete: (options: Serenity.ServiceOptions<Serenity.DeleteResponse>, callback: (response: Serenity.DeleteResponse) => void) => void;
        destroy(): void;
        protected updateInterface(): void;
        protected saveHandler(options: Serenity.ServiceOptions<Serenity.SaveResponse>, callback: (response: Serenity.SaveResponse) => void): void;
        protected deleteHandler(options: Serenity.ServiceOptions<Serenity.DeleteResponse>, callback: (response: Serenity.DeleteResponse) => void): void;
    }
}
declare namespace webNEOC.Preparation {
    class MicroplanEditorDialog extends Common.GridEditorDialog<MicroplanRow> {
        protected getFormKey(): string;
        protected getLocalTextPrefix(): string;
        protected form: MicroplanForm;
    }
}
declare namespace webNEOC.Preparation {
    class MicroplanGrid extends Serenity.EntityGrid<MicroplanRow, any> {
        protected getColumnsKey(): string;
        protected getDialogType(): typeof MicroplanDialog;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getService(): string;
        constructor(container: JQuery);
        protected getButtons(): Serenity.ToolButton[];
    }
}
declare namespace webNEOC.Preparation {
    class InAccessibleDialog extends Serenity.EntityDialog<InAccessibleRow, any> {
        protected getFormKey(): string;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getNameProperty(): string;
        protected getService(): string;
        protected form: InAccessibleForm;
        constructor();
        private setDateDetails(details);
    }
}
declare namespace webNEOC.Preparation {
    class InAccessibleEditor extends Common.GridEditorBase<InAccessibleRow> {
        protected getColumnsKey(): string;
        protected getDialogType(): typeof InAccessibleEditorDialog;
        protected getLocalTextPrefix(): string;
        constructor(container: JQuery);
    }
}
declare namespace webNEOC.Preparation {
    class InAccessibleEditorDialog extends Common.GridEditorDialog<InAccessibleRow> {
        protected getFormKey(): string;
        protected getLocalTextPrefix(): string;
        protected getNameProperty(): string;
        protected form: InAccessibleForm;
    }
}
declare namespace webNEOC.Preparation {
    class InAccessibleGrid extends Serenity.EntityGrid<InAccessibleRow, any> {
        protected getColumnsKey(): string;
        protected getDialogType(): typeof InAccessibleDialog;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getService(): string;
        constructor(container: JQuery);
        protected getButtons(): Serenity.ToolButton[];
    }
}
declare namespace webNEOC.PostCampaign {
    class PcmDialog extends Serenity.EntityDialog<PcmRow, any> {
        protected getFormKey(): string;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getNameProperty(): string;
        protected getService(): string;
        protected form: PcmForm;
        constructor();
        private setDateDetails(details);
    }
}
declare namespace webNEOC.PostCampaign {
    class PcmEditor extends Common.GridEditorBase<PcmRow> {
        protected getColumnsKey(): string;
        protected getDialogType(): typeof PcmEditorDialog;
        protected getLocalTextPrefix(): string;
        constructor(container: JQuery);
    }
}
declare namespace webNEOC.PostCampaign {
    class PcmEditorDialog extends Common.GridEditorDialog<PcmRow> {
        protected getFormKey(): string;
        protected getLocalTextPrefix(): string;
        protected getNameProperty(): string;
        protected form: PcmForm;
    }
}
declare namespace webNEOC.PostCampaign {
    class PcmGrid extends Serenity.EntityGrid<PcmRow, any> {
        protected getColumnsKey(): string;
        protected getDialogType(): typeof PcmDialog;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getService(): string;
        constructor(container: JQuery);
        protected getButtons(): Serenity.ToolButton[];
    }
}
declare namespace webNEOC.PostCampaign {
    class OutOfHouseSurveyDialog extends Serenity.EntityDialog<OutOfHouseSurveyRow, any> {
        protected getFormKey(): string;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getService(): string;
        protected form: OutOfHouseSurveyForm;
        constructor();
        private setDateDetails(details);
    }
}
declare namespace webNEOC.PostCampaign {
    class OutOfHouseSurveyEditor extends Common.GridEditorBase<OutOfHouseSurveyRow> {
        protected getColumnsKey(): string;
        protected getDialogType(): typeof OutOfHouseSurveyEditorDialog;
        protected getLocalTextPrefix(): string;
        constructor(container: JQuery);
    }
}
declare namespace webNEOC.PostCampaign {
    class OutOfHouseSurveyEditorDialog extends Common.GridEditorDialog<OutOfHouseSurveyRow> {
        protected getFormKey(): string;
        protected getLocalTextPrefix(): string;
        protected form: OutOfHouseSurveyForm;
    }
}
declare namespace webNEOC.PostCampaign {
    class OutOfHouseSurveyGrid extends Serenity.EntityGrid<OutOfHouseSurveyRow, any> {
        protected getColumnsKey(): string;
        protected getDialogType(): typeof OutOfHouseSurveyDialog;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getService(): string;
        constructor(container: JQuery);
        protected getButtons(): Serenity.ToolButton[];
    }
}
declare namespace webNEOC.PostCampaign {
    class LQASDialog extends Serenity.EntityDialog<LQASRow, any> {
        protected getFormKey(): string;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getNameProperty(): string;
        protected getService(): string;
        protected form: LQASForm;
        constructor();
        private setDateDetails(details);
    }
}
declare namespace webNEOC.PostCampaign {
    class LQASEditor extends Common.GridEditorBase<LQASRow> {
        protected getColumnsKey(): string;
        protected getDialogType(): typeof LQASEditorDialog;
        protected getLocalTextPrefix(): string;
        constructor(container: JQuery);
    }
}
declare namespace webNEOC.PostCampaign {
    class LQASEditorDialog extends Common.GridEditorDialog<LQASRow> {
        protected getFormKey(): string;
        protected getLocalTextPrefix(): string;
        protected getNameProperty(): string;
        protected form: LQASForm;
    }
}
declare namespace webNEOC.PostCampaign {
    class LQASGrid extends Serenity.EntityGrid<LQASRow, any> {
        protected getColumnsKey(): string;
        protected getDialogType(): typeof LQASDialog;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getService(): string;
        constructor(container: JQuery);
        protected addButtonClick(): void;
        protected getButtons(): Serenity.ToolButton[];
    }
}
declare namespace webNEOC.Organization {
    class ContactDialog extends Serenity.EntityDialog<ContactRow, any> {
        protected getFormKey(): string;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getNameProperty(): string;
        protected getService(): string;
        protected form: ContactForm;
    }
}
declare namespace webNEOC.Organization {
    class ContactGrid extends Serenity.EntityGrid<ContactRow, any> {
        protected getColumnsKey(): string;
        protected getDialogType(): typeof ContactDialog;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getService(): string;
        constructor(container: JQuery);
        protected getButtons(): Serenity.ToolButton[];
    }
}
declare namespace webNEOC.Organization {
    class BusinessUnitDialog extends Serenity.EntityDialog<BusinessUnitRow, any> {
        protected getFormKey(): string;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getNameProperty(): string;
        protected getService(): string;
        protected form: BusinessUnitForm;
    }
}
declare namespace webNEOC.Organization {
    class BusinessUnitEditor extends Serenity.LookupEditorBase<Serenity.LookupEditorOptions, BusinessUnitRow> {
        constructor(hidden: JQuery, opt: Serenity.LookupEditorOptions);
        protected getLookupKey(): string;
        protected getItemText(item: BusinessUnitRow, lookup: Q.Lookup<BusinessUnitRow>): string;
    }
}
declare namespace webNEOC.Organization {
    class BusinessUnitGrid extends Serenity.EntityGrid<BusinessUnitRow, any> {
        protected getColumnsKey(): string;
        protected getDialogType(): typeof BusinessUnitDialog;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getService(): string;
        constructor(container: JQuery);
        protected subDialogDataChange(): void;
        protected usePager(): boolean;
        protected getColumns(): Slick.Column[];
        protected onClick(e: JQueryEventObject, row: number, cell: number): void;
        protected getButtons(): Serenity.ToolButton[];
    }
}
declare namespace webNEOC.Northwind {
    class TerritoryDialog extends Serenity.EntityDialog<TerritoryRow, any> {
        protected getFormKey(): string;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getNameProperty(): string;
        protected getService(): string;
        protected form: TerritoryForm;
        protected getLanguages(): string[][];
    }
}
declare namespace webNEOC.Northwind {
    class TerritoryGrid extends Serenity.EntityGrid<TerritoryRow, any> {
        protected getColumnsKey(): string;
        protected getDialogType(): any;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getService(): string;
        constructor(container: JQuery);
    }
}
declare namespace webNEOC.Northwind {
    class SupplierDialog extends Serenity.EntityDialog<SupplierRow, any> {
        protected getFormKey(): string;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getNameProperty(): string;
        protected getService(): string;
        protected form: SupplierForm;
        protected getLanguages(): string[][];
    }
}
declare namespace webNEOC.Northwind {
    class SupplierGrid extends Serenity.EntityGrid<SupplierRow, any> {
        protected getColumnsKey(): string;
        protected getDialogType(): any;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getService(): string;
        constructor(container: JQuery);
    }
}
declare namespace webNEOC.Northwind {
    class ShipperDialog extends Serenity.EntityDialog<ShipperRow, any> {
        protected getFormKey(): string;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getNameProperty(): string;
        protected getService(): string;
        protected form: ShipperForm;
        protected getLanguages(): string[][];
    }
}
declare namespace webNEOC.Northwind {
    class ShipperFormatter implements Slick.Formatter {
        format(ctx: Slick.FormatterContext): string;
    }
}
declare namespace webNEOC.Northwind {
    class ShipperGrid extends Serenity.EntityGrid<ShipperRow, any> {
        protected getColumnsKey(): string;
        protected getDialogType(): any;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getService(): string;
        constructor(container: JQuery);
    }
}
declare namespace webNEOC.Northwind {
    class PhoneEditor extends Serenity.StringEditor {
        constructor(input: JQuery);
        protected formatValue(): void;
        protected getFormattedValue(): string;
        multiple: boolean;
        get_value(): string;
        set_value(value: string): void;
        static validate(phone: string, isMultiple: boolean): string;
        static isValidPhone(phone: string): boolean;
        static formatPhone(phone: any): any;
        static formatMulti(phone: string, format: (s: string) => string): string;
        static isValidMulti(phone: string, check: (s: string) => boolean): boolean;
    }
}
declare namespace webNEOC.Northwind {
    class RegionDialog extends Serenity.EntityDialog<RegionRow, any> {
        protected getFormKey(): string;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getNameProperty(): string;
        protected getService(): string;
        protected form: RegionForm;
        protected getLanguages(): string[][];
    }
}
declare namespace webNEOC.Northwind {
    class RegionGrid extends Serenity.EntityGrid<RegionRow, any> {
        protected getColumnsKey(): string;
        protected getDialogType(): any;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getService(): string;
        constructor(container: JQuery);
    }
}
declare namespace webNEOC.Northwind {
    class ProductDialog extends Serenity.EntityDialog<ProductRow, any> {
        protected getFormKey(): string;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getNameProperty(): string;
        protected getService(): string;
        protected form: ProductForm;
    }
}
declare namespace webNEOC.Northwind {
    class ProductGrid extends Serenity.EntityGrid<ProductRow, any> {
        protected getColumnsKey(): string;
        protected getDialogType(): any;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getService(): string;
        private pendingChanges;
        constructor(container: JQuery);
        protected getButtons(): Serenity.ToolButton[];
        protected onViewProcessData(response: any): Serenity.ListResponse<ProductRow>;
        /**
         * It would be nice if we could use autonumeric, Serenity editors etc. here, to control input validation,
         * but it's not supported by SlickGrid as we are only allowed to return a string, and should attach
         * no event handlers to rendered cell contents
         */
        private numericInputFormatter(ctx);
        private stringInputFormatter(ctx);
        /**
         * Sorry but you cannot use LookupEditor, e.g. Select2 here, only possible is a SELECT element
         */
        private selectFormatter(ctx, idField, lookup);
        private getEffectiveValue(item, field);
        protected getColumns(): Slick.Column[];
        private inputsChange(e);
        private setSaveButtonState();
        private saveClick();
        protected getQuickFilters(): Serenity.QuickFilter<Serenity.Widget<any>, any>[];
    }
}
declare namespace webNEOC.Northwind {
    class OrderDetailDialog extends Common.GridEditorDialog<OrderDetailRow> {
        protected getFormKey(): string;
        protected getLocalTextPrefix(): string;
        protected form: OrderDetailForm;
        constructor();
    }
}
declare namespace webNEOC.Northwind {
    class OrderDetailsEditor extends Common.GridEditorBase<OrderDetailRow> {
        protected getColumnsKey(): string;
        protected getDialogType(): typeof OrderDetailDialog;
        protected getLocalTextPrefix(): string;
        constructor(container: JQuery);
        validateEntity(row: any, id: any): boolean;
    }
}
declare namespace webNEOC.Northwind {
    class FreightFormatter implements Slick.Formatter {
        format(ctx: Slick.FormatterContext): string;
    }
}
declare namespace webNEOC.Northwind {
    class OrderDialog extends Serenity.EntityDialog<OrderRow, any> {
        protected getFormKey(): string;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getNameProperty(): string;
        protected getService(): string;
        protected form: OrderForm;
        constructor();
        getToolbarButtons(): Serenity.ToolButton[];
        protected updateInterface(): void;
    }
}
declare namespace webNEOC.Northwind {
    class OrderGrid extends Serenity.EntityGrid<OrderRow, any> {
        protected getColumnsKey(): string;
        protected getDialogType(): any;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getService(): string;
        protected shippingStateFilter: Serenity.EnumEditor;
        constructor(container: JQuery);
        protected getQuickFilters(): Serenity.QuickFilter<Serenity.Widget<any>, any>[];
        protected createQuickFilters(): void;
        protected getButtons(): Serenity.ToolButton[];
        protected getColumns(): Slick.Column[];
        protected onClick(e: JQueryEventObject, row: number, cell: number): void;
        set_shippingState(value: number): void;
        protected addButtonClick(): void;
    }
}
declare namespace webNEOC.Northwind {
    class NoteDialog extends Serenity.TemplatedDialog<any> {
        private textEditor;
        constructor();
        protected getTemplate(): string;
        protected getDialogOptions(): JQueryUI.DialogOptions;
        text: string;
        okClick: () => void;
    }
}
declare namespace webNEOC.Northwind {
    class NotesEditor extends Serenity.TemplatedWidget<any> implements Serenity.IGetEditValue, Serenity.ISetEditValue {
        private isDirty;
        private items;
        constructor(div: JQuery);
        protected getTemplate(): string;
        protected updateContent(): void;
        protected addClick(): void;
        protected editClick(e: any): void;
        deleteClick(e: any): void;
        value: NoteRow[];
        getEditValue(prop: Serenity.PropertyItem, target: any): void;
        setEditValue(source: any, prop: Serenity.PropertyItem): void;
        get_isDirty(): boolean;
        set_isDirty(value: any): void;
        onChange: () => void;
    }
}
declare namespace webNEOC.Northwind {
    class EmployeeFormatter implements Slick.Formatter {
        format(ctx: Slick.FormatterContext): string;
        genderProperty: string;
        initializeColumn(column: Slick.Column): void;
    }
}
declare namespace webNEOC.Northwind {
    class CustomerDialog extends Serenity.EntityDialog<CustomerRow, any> {
        protected getFormKey(): string;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getNameProperty(): string;
        protected getService(): string;
        protected form: CustomerForm;
        private ordersGrid;
        private loadedState;
        constructor();
        getSaveState(): string;
        loadResponse(data: any): void;
        loadEntity(entity: CustomerRow): void;
        onSaveSuccess(response: any): void;
    }
}
declare namespace webNEOC.Northwind {
    class CustomerEditor extends Serenity.LookupEditorBase<Serenity.LookupEditorOptions, CustomerRow> {
        constructor(hidden: JQuery);
        protected getLookupKey(): string;
        protected getItemText(item: any, lookup: any): string;
    }
}
declare namespace webNEOC.Northwind {
    class CustomerGrid extends Serenity.EntityGrid<CustomerRow, any> {
        protected getColumnsKey(): string;
        protected getDialogType(): any;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getService(): string;
        constructor(container: JQuery);
        getButtons(): Serenity.ToolButton[];
    }
}
declare namespace webNEOC.Northwind {
    class CustomerOrderDialog extends OrderDialog {
        constructor();
        updateInterface(): void;
    }
}
declare namespace webNEOC.Northwind {
    class CustomerOrdersGrid extends OrderGrid {
        protected getDialogType(): typeof CustomerOrderDialog;
        constructor(container: JQuery);
        protected getColumns(): Slick.Column[];
        protected initEntityDialog(itemType: any, dialog: any): void;
        protected addButtonClick(): void;
        protected getInitialTitle(): any;
        protected getGridCanLoad(): boolean;
        private _customerID;
        customerID: string;
    }
}
declare namespace webNEOC.Northwind {
    class EmployeeListFormatter implements Slick.Formatter {
        format(ctx: Slick.FormatterContext): string;
    }
}
declare namespace webNEOC.Northwind {
    class CategoryDialog extends Serenity.EntityDialog<CategoryRow, any> {
        protected getFormKey(): string;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getNameProperty(): string;
        protected getService(): string;
        protected form: CategoryForm;
    }
}
declare namespace webNEOC.Northwind {
    class CategoryGrid extends Serenity.EntityGrid<CategoryRow, any> {
        protected getColumnsKey(): string;
        protected getDialogType(): any;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getService(): string;
        constructor(container: JQuery);
    }
}
declare namespace webNEOC.Membership {
    class SignUpPanel extends Serenity.PropertyPanel<SignUpRequest, any> {
        protected getFormKey(): string;
        private form;
        constructor(container: JQuery);
    }
}
declare namespace webNEOC.Membership {
    class ResetPasswordPanel extends Serenity.PropertyPanel<ResetPasswordRequest, any> {
        protected getFormKey(): string;
        private form;
        constructor(container: JQuery);
    }
}
declare namespace webNEOC.Membership {
    class ForgotPasswordPanel extends Serenity.PropertyPanel<ForgotPasswordRequest, any> {
        protected getFormKey(): string;
        private form;
        constructor(container: JQuery);
    }
}
declare namespace webNEOC.Membership {
    class ChangePasswordPanel extends Serenity.PropertyPanel<ChangePasswordRequest, any> {
        protected getFormKey(): string;
        private form;
        constructor(container: JQuery);
    }
}
declare namespace webNEOC.Meeting {
    class MeetingTypeDialog extends Serenity.EntityDialog<MeetingTypeRow, any> {
        protected getFormKey(): string;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getNameProperty(): string;
        protected getService(): string;
        protected form: MeetingTypeForm;
    }
}
declare namespace webNEOC.Meeting {
    class MeetingTypeGrid extends Serenity.EntityGrid<MeetingTypeRow, any> {
        protected getColumnsKey(): string;
        protected getDialogType(): typeof MeetingTypeDialog;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getService(): string;
        constructor(container: JQuery);
        protected getButtons(): Serenity.ToolButton[];
    }
}
declare namespace webNEOC.Meeting {
    class MeetingLocationDialog extends Serenity.EntityDialog<MeetingLocationRow, any> {
        protected getFormKey(): string;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getNameProperty(): string;
        protected getService(): string;
        protected form: MeetingLocationForm;
    }
}
declare namespace webNEOC.Meeting {
    class MeetingLocationGrid extends Serenity.EntityGrid<MeetingLocationRow, any> {
        protected getColumnsKey(): string;
        protected getDialogType(): typeof MeetingLocationDialog;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getService(): string;
        constructor(container: JQuery);
        protected getButtons(): Serenity.ToolButton[];
    }
}
declare namespace webNEOC.Meeting {
    class MeetingDecisionRelevantDialog extends Serenity.EntityDialog<MeetingDecisionRelevantRow, any> {
        protected getFormKey(): string;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getService(): string;
        protected form: MeetingDecisionRelevantForm;
    }
}
declare namespace webNEOC.Meeting {
    class MeetingDecisionRelevantGrid extends Serenity.EntityGrid<MeetingDecisionRelevantRow, any> {
        protected getColumnsKey(): string;
        protected getDialogType(): typeof MeetingDecisionRelevantDialog;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getService(): string;
        constructor(container: JQuery);
        protected getButtons(): Serenity.ToolButton[];
    }
}
declare namespace webNEOC.Meeting {
    class MeetingDecisionDialog extends Serenity.EntityDialog<MeetingDecisionRow, any> {
        protected getFormKey(): string;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getNameProperty(): string;
        protected getService(): string;
        protected form: MeetingDecisionForm;
    }
}
declare namespace webNEOC.Meeting {
    class MeetingDecisionGrid extends Serenity.EntityGrid<MeetingDecisionRow, any> {
        protected getColumnsKey(): string;
        protected getDialogType(): typeof MeetingDecisionDialog;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getService(): string;
        constructor(container: JQuery);
        protected addButtonClick(): void;
        protected getInitialTitle(): any;
        protected getGridCanLoad(): boolean;
        private _meetingId;
        meetingId: string;
        protected getButtons(): Serenity.ToolButton[];
    }
}
declare namespace webNEOC.Meeting {
    class MeetingAttendeeDialog extends Common.GridEditorDialog<MeetingAttendeeRow> {
        protected getFormKey(): string;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected form: MeetingAttendeeForm;
    }
}
declare namespace webNEOC.Meeting {
    class MeetingAttendeeEditor extends Common.GridEditorBase<MeetingAttendeeRow> {
        protected getColumnsKey(): string;
        protected getDialogType(): typeof MeetingAttendeeDialog;
        protected getLocalTextPrefix(): string;
        constructor(container: JQuery);
        protected getButtons(): any[];
        protected createToolbarExtensions(): void;
        protected getColumns(): Slick.Column[];
        protected onClick(e: JQueryEventObject, row: number, cell: number): void;
    }
}
declare namespace webNEOC.Meeting {
    class MeetingAgendaTypeDialog extends Serenity.EntityDialog<MeetingAgendaTypeRow, any> {
        protected getFormKey(): string;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getNameProperty(): string;
        protected getService(): string;
        protected form: MeetingAgendaTypeForm;
    }
}
declare namespace webNEOC.Meeting {
    class MeetingAgendaTypeGrid extends Serenity.EntityGrid<MeetingAgendaTypeRow, any> {
        protected getColumnsKey(): string;
        protected getDialogType(): typeof MeetingAgendaTypeDialog;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getService(): string;
        constructor(container: JQuery);
        protected getButtons(): Serenity.ToolButton[];
    }
}
declare namespace webNEOC.Meeting {
    class MeetingAgendaRelevantDialog extends Serenity.EntityDialog<MeetingAgendaRelevantRow, any> {
        protected getFormKey(): string;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getService(): string;
        protected form: MeetingAgendaRelevantForm;
    }
}
declare namespace webNEOC.Meeting {
    class MeetingAgendaRelevantGrid extends Serenity.EntityGrid<MeetingAgendaRelevantRow, any> {
        protected getColumnsKey(): string;
        protected getDialogType(): typeof MeetingAgendaRelevantDialog;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getService(): string;
        constructor(container: JQuery);
        protected getButtons(): Serenity.ToolButton[];
    }
}
declare namespace webNEOC.Meeting {
    class MeetingAgendaDialog extends Serenity.EntityDialog<MeetingAgendaRow, any> {
        protected getFormKey(): string;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getNameProperty(): string;
        protected getService(): string;
        protected form: MeetingAgendaForm;
    }
}
declare namespace webNEOC.Meeting {
    class MeetingAgendaGrid extends Serenity.EntityGrid<MeetingAgendaRow, any> {
        protected getColumnsKey(): string;
        protected getDialogType(): typeof MeetingAgendaDialog;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getService(): string;
        constructor(container: JQuery);
        protected addButtonClick(): void;
        protected getInitialTitle(): any;
        protected getGridCanLoad(): boolean;
        private _meetingId;
        meetingId: string;
        protected getButtons(): Serenity.ToolButton[];
    }
}
declare namespace webNEOC.Meeting {
    class MeetingDialog extends Serenity.EntityDialog<MeetingRow, any> {
        protected getFormKey(): string;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getNameProperty(): string;
        protected getService(): string;
        protected form: MeetingForm;
        private agendaGrid;
        private decisionGrid;
        constructor();
        protected arrange(): void;
        loadEntity(entity: MeetingRow): void;
    }
}
declare namespace webNEOC.Meeting {
    class MeetingGrid extends Serenity.EntityGrid<MeetingRow, any> {
        protected getColumnsKey(): string;
        protected getDialogType(): typeof MeetingDialog;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getService(): string;
        constructor(container: JQuery);
        protected getButtons(): Serenity.ToolButton[];
    }
}
declare namespace webNEOC.Lookup {
    class VehicletypeDialog extends Serenity.EntityDialog<VehicletypeRow, any> {
        protected getFormKey(): string;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getNameProperty(): string;
        protected getService(): string;
        protected form: VehicletypeForm;
    }
}
declare namespace webNEOC.Lookup {
    class VehicletypeEditor extends Common.GridEditorBase<VehicletypeRow> {
        protected getColumnsKey(): string;
        protected getDialogType(): typeof VehicletypeEditorDialog;
        protected getLocalTextPrefix(): string;
        constructor(container: JQuery);
    }
}
declare namespace webNEOC.Lookup {
    class VehicletypeEditorDialog extends Common.GridEditorDialog<VehicletypeRow> {
        protected getFormKey(): string;
        protected getLocalTextPrefix(): string;
        protected getNameProperty(): string;
        protected form: VehicletypeForm;
    }
}
declare namespace webNEOC.Lookup {
    class VehicletypeGrid extends Serenity.EntityGrid<VehicletypeRow, any> {
        protected getColumnsKey(): string;
        protected getDialogType(): typeof VehicletypeDialog;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getService(): string;
        constructor(container: JQuery);
        protected getButtons(): Serenity.ToolButton[];
    }
}
declare namespace webNEOC.Lookup {
    class TargetPopDialog extends Serenity.EntityDialog<TargetPopRow, any> {
        protected getFormKey(): string;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getNameProperty(): string;
        protected getService(): string;
        protected form: TargetPopForm;
    }
}
declare namespace webNEOC.Lookup {
    class TargetPopEditor extends Common.GridEditorBase<TargetPopRow> {
        protected getColumnsKey(): string;
        protected getDialogType(): typeof TargetPopEditorDialog;
        protected getLocalTextPrefix(): string;
        constructor(container: JQuery);
    }
}
declare namespace webNEOC.Lookup {
    class TargetPopEditorDialog extends Common.GridEditorDialog<TargetPopRow> {
        protected getFormKey(): string;
        protected getLocalTextPrefix(): string;
        protected getNameProperty(): string;
        protected form: TargetPopForm;
    }
}
declare namespace webNEOC.Lookup {
    class TargetPopGrid extends Serenity.EntityGrid<TargetPopRow, any> {
        protected getColumnsKey(): string;
        protected getDialogType(): typeof TargetPopDialog;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getService(): string;
        constructor(container: JQuery);
        protected getButtons(): Serenity.ToolButton[];
    }
}
declare namespace webNEOC.Lookup {
    class StatusDialog extends Serenity.EntityDialog<StatusRow, any> {
        protected getFormKey(): string;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getNameProperty(): string;
        protected getService(): string;
        protected form: StatusForm;
        dialogOpen(): void;
    }
}
declare namespace webNEOC.Lookup {
    class StatusEditor extends Common.GridEditorBase<StatusRow> {
        protected getColumnsKey(): string;
        protected getDialogType(): typeof StatusEditorDialog;
        protected getLocalTextPrefix(): string;
        constructor(container: JQuery);
    }
}
declare namespace webNEOC.Lookup {
    class StatusEditorDialog extends Common.GridEditorDialog<StatusRow> {
        protected getFormKey(): string;
        protected getLocalTextPrefix(): string;
        protected getNameProperty(): string;
        protected form: StatusForm;
    }
}
declare namespace webNEOC.Lookup {
    class StatusGrid extends Serenity.EntityGrid<StatusRow, any> {
        protected getColumnsKey(): string;
        protected getDialogType(): typeof StatusDialog;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getService(): string;
        constructor(container: JQuery);
        protected getButtons(): Serenity.ToolButton[];
    }
}
declare namespace webNEOC.Lookup {
    class RoundDialog extends Serenity.EntityDialog<RoundRow, any> {
        protected getFormKey(): string;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getNameProperty(): string;
        protected getService(): string;
        protected form: RoundForm;
    }
}
declare namespace webNEOC.Lookup {
    class RoundEditor extends Common.GridEditorBase<RoundRow> {
        protected getColumnsKey(): string;
        protected getDialogType(): typeof RoundEditorDialog;
        protected getLocalTextPrefix(): string;
        constructor(container: JQuery);
    }
}
declare namespace webNEOC.Lookup {
    class RoundEditorDialog extends Common.GridEditorDialog<RoundRow> {
        protected getFormKey(): string;
        protected getLocalTextPrefix(): string;
        protected getNameProperty(): string;
        protected form: RoundForm;
    }
}
declare namespace webNEOC.Lookup {
    class RoundGrid extends Serenity.EntityGrid<RoundRow, any> {
        protected getColumnsKey(): string;
        protected getDialogType(): typeof RoundDialog;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getService(): string;
        constructor(container: JQuery);
        protected getButtons(): Serenity.ToolButton[];
    }
}
declare namespace webNEOC.Lookup {
    class RecruitmentTypeDialog extends Serenity.EntityDialog<RecruitmentTypeRow, any> {
        protected getFormKey(): string;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getNameProperty(): string;
        protected getService(): string;
        protected form: RecruitmentTypeForm;
    }
}
declare namespace webNEOC.Lookup {
    class RecruitmentTypeGrid extends Serenity.EntityGrid<RecruitmentTypeRow, any> {
        protected getColumnsKey(): string;
        protected getDialogType(): typeof RecruitmentTypeDialog;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getService(): string;
        constructor(container: JQuery);
    }
}
declare namespace webNEOC.Lookup {
    class PartDialog extends Serenity.EntityDialog<PartRow, any> {
        protected getFormKey(): string;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getNameProperty(): string;
        protected getService(): string;
        protected form: PartForm;
    }
}
declare namespace webNEOC.Lookup {
    class PartEditor extends Common.GridEditorBase<PartRow> {
        protected getColumnsKey(): string;
        protected getDialogType(): typeof PartEditorDialog;
        protected getLocalTextPrefix(): string;
        constructor(container: JQuery);
    }
}
declare namespace webNEOC.Lookup {
    class PartEditorDialog extends Common.GridEditorDialog<PartRow> {
        protected getFormKey(): string;
        protected getLocalTextPrefix(): string;
        protected getNameProperty(): string;
        protected form: PartForm;
    }
}
declare namespace webNEOC.Lookup {
    class PartGrid extends Serenity.EntityGrid<PartRow, any> {
        protected getColumnsKey(): string;
        protected getDialogType(): typeof PartDialog;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getService(): string;
        constructor(container: JQuery);
        protected getButtons(): Serenity.ToolButton[];
    }
}
declare namespace webNEOC.Lookup {
    class MonthsDialog extends Serenity.EntityDialog<MonthsRow, any> {
        protected getFormKey(): string;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getNameProperty(): string;
        protected getService(): string;
        protected form: MonthsForm;
    }
}
declare namespace webNEOC.Lookup {
    class MonthsEditor extends Common.GridEditorBase<MonthsRow> {
        protected getColumnsKey(): string;
        protected getDialogType(): typeof MonthsEditorDialog;
        protected getLocalTextPrefix(): string;
        constructor(container: JQuery);
    }
}
declare namespace webNEOC.Lookup {
    class MonthsEditorDialog extends Common.GridEditorDialog<MonthsRow> {
        protected getFormKey(): string;
        protected getLocalTextPrefix(): string;
        protected getNameProperty(): string;
        protected form: MonthsForm;
    }
}
declare namespace webNEOC.Lookup {
    class MonthsGrid extends Serenity.EntityGrid<MonthsRow, any> {
        protected getColumnsKey(): string;
        protected getDialogType(): typeof MonthsDialog;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getService(): string;
        constructor(container: JQuery);
        protected getButtons(): Serenity.ToolButton[];
    }
}
declare namespace webNEOC.Lookup {
    class MediaTypeDialog extends Serenity.EntityDialog<MediaTypeRow, any> {
        protected getFormKey(): string;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getNameProperty(): string;
        protected getService(): string;
        protected form: MediaTypeForm;
    }
}
declare namespace webNEOC.Lookup {
    class MediaTypeGrid extends Serenity.EntityGrid<MediaTypeRow, any> {
        protected getColumnsKey(): string;
        protected getDialogType(): typeof MediaTypeDialog;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getService(): string;
        constructor(container: JQuery);
    }
}
declare namespace webNEOC.Lookup {
    class MediaDialog extends Serenity.EntityDialog<MediaRow, any> {
        protected getFormKey(): string;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getNameProperty(): string;
        protected getService(): string;
        protected form: MediaForm;
    }
}
declare namespace webNEOC.Lookup {
    class MediaGrid extends Serenity.EntityGrid<MediaRow, any> {
        protected getColumnsKey(): string;
        protected getDialogType(): typeof MediaDialog;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getService(): string;
        constructor(container: JQuery);
    }
}
declare namespace webNEOC.Lookup {
    class LangDialog extends Serenity.EntityDialog<LangRow, any> {
        protected getFormKey(): string;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getNameProperty(): string;
        protected getService(): string;
        protected form: LangForm;
    }
}
declare namespace webNEOC.Lookup {
    class LangGrid extends Serenity.EntityGrid<LangRow, any> {
        protected getColumnsKey(): string;
        protected getDialogType(): typeof LangDialog;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getService(): string;
        constructor(container: JQuery);
    }
}
declare namespace webNEOC.Lookup {
    class InAcsCategoryDialog extends Serenity.EntityDialog<InAcsCategoryRow, any> {
        protected getFormKey(): string;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getNameProperty(): string;
        protected getService(): string;
        protected form: InAcsCategoryForm;
    }
}
declare namespace webNEOC.Lookup {
    class InAcsCategoryEditor extends Common.GridEditorBase<InAcsCategoryRow> {
        protected getColumnsKey(): string;
        protected getDialogType(): typeof InAcsCategoryEditorDialog;
        protected getLocalTextPrefix(): string;
        constructor(container: JQuery);
    }
}
declare namespace webNEOC.Lookup {
    class InAcsCategoryEditorDialog extends Common.GridEditorDialog<InAcsCategoryRow> {
        protected getFormKey(): string;
        protected getLocalTextPrefix(): string;
        protected getNameProperty(): string;
        protected form: InAcsCategoryForm;
    }
}
declare namespace webNEOC.Lookup {
    class InAcsCategoryGrid extends Serenity.EntityGrid<InAcsCategoryRow, any> {
        protected getColumnsKey(): string;
        protected getDialogType(): typeof InAcsCategoryDialog;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getService(): string;
        constructor(container: JQuery);
        protected getButtons(): Serenity.ToolButton[];
    }
}
declare namespace webNEOC.Lookup {
    class IcnTypeDialog extends Serenity.EntityDialog<IcnTypeRow, any> {
        protected getFormKey(): string;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getNameProperty(): string;
        protected getService(): string;
        protected form: IcnTypeForm;
    }
}
declare namespace webNEOC.Lookup {
    class IcnTypeGrid extends Serenity.EntityGrid<IcnTypeRow, any> {
        protected getColumnsKey(): string;
        protected getDialogType(): typeof IcnTypeDialog;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getService(): string;
        constructor(container: JQuery);
    }
}
declare namespace webNEOC.Lookup {
    class DaysDialog extends Serenity.EntityDialog<DaysRow, any> {
        protected getFormKey(): string;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getNameProperty(): string;
        protected getService(): string;
        protected form: DaysForm;
    }
}
declare namespace webNEOC.Lookup {
    class DaysGrid extends Serenity.EntityGrid<DaysRow, any> {
        protected getColumnsKey(): string;
        protected getDialogType(): typeof DaysDialog;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getService(): string;
        constructor(container: JQuery);
    }
}
declare namespace webNEOC.Lookup {
    class DayPartDialog extends Serenity.EntityDialog<DayPartRow, any> {
        protected getFormKey(): string;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getNameProperty(): string;
        protected getService(): string;
        protected form: DayPartForm;
    }
}
declare namespace webNEOC.Lookup {
    class DayPartGrid extends Serenity.EntityGrid<DayPartRow, any> {
        protected getColumnsKey(): string;
        protected getDialogType(): typeof DayPartDialog;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getService(): string;
        constructor(container: JQuery);
    }
}
declare namespace webNEOC.Lookup {
    class ClusterLevelDialog extends Serenity.EntityDialog<ClusterLevelRow, any> {
        protected getFormKey(): string;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getNameProperty(): string;
        protected getService(): string;
        protected form: ClusterLevelForm;
        dialogOpen(): void;
    }
}
declare namespace webNEOC.Lookup {
    class ClusterLevelEditor extends Common.GridEditorBase<ClusterLevelRow> {
        protected getColumnsKey(): string;
        protected getDialogType(): typeof ClusterLevelEditorDialog;
        protected getLocalTextPrefix(): string;
        constructor(container: JQuery);
    }
}
declare namespace webNEOC.Lookup {
    class ClusterLevelEditorDialog extends Common.GridEditorDialog<ClusterLevelRow> {
        protected getFormKey(): string;
        protected getLocalTextPrefix(): string;
        protected getNameProperty(): string;
        protected form: ClusterLevelForm;
    }
}
declare namespace webNEOC.Lookup {
    class ClusterLevelGrid extends Serenity.EntityGrid<ClusterLevelRow, any> {
        protected getColumnsKey(): string;
        protected getDialogType(): typeof ClusterLevelDialog;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getService(): string;
        constructor(container: JQuery);
        protected getButtons(): Serenity.ToolButton[];
    }
}
declare namespace webNEOC.Lookup {
    class CampaignTypeDialog extends Serenity.EntityDialog<CampaignTypeRow, any> {
        protected getFormKey(): string;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getNameProperty(): string;
        protected getService(): string;
        protected form: CampaignTypeForm;
    }
}
declare namespace webNEOC.Lookup {
    class CampaignTypeEditor extends Common.GridEditorBase<CampaignTypeRow> {
        protected getColumnsKey(): string;
        protected getDialogType(): typeof CampaignTypeEditorDialog;
        protected getLocalTextPrefix(): string;
        constructor(container: JQuery);
    }
}
declare namespace webNEOC.Lookup {
    class CampaignTypeEditorDialog extends Common.GridEditorDialog<CampaignTypeRow> {
        protected getFormKey(): string;
        protected getLocalTextPrefix(): string;
        protected getNameProperty(): string;
        protected form: CampaignTypeForm;
    }
}
declare namespace webNEOC.Lookup {
    class CampaignTypeGrid extends Serenity.EntityGrid<CampaignTypeRow, any> {
        protected getColumnsKey(): string;
        protected getDialogType(): typeof CampaignTypeDialog;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getService(): string;
        constructor(container: JQuery);
        protected getButtons(): Serenity.ToolButton[];
    }
}
declare namespace webNEOC.Locations {
    class RegionDialog extends Serenity.EntityDialog<RegionRow, any> {
        protected getFormKey(): string;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getNameProperty(): string;
        protected getService(): string;
        protected form: RegionForm;
    }
}
declare namespace webNEOC.Locations {
    class RegionEditor extends Common.GridEditorBase<RegionRow> {
        protected getColumnsKey(): string;
        protected getDialogType(): typeof RegionEditorDialog;
        protected getLocalTextPrefix(): string;
        constructor(container: JQuery);
    }
}
declare namespace webNEOC.Locations {
    class RegionEditorDialog extends Common.GridEditorDialog<RegionRow> {
        protected getFormKey(): string;
        protected getLocalTextPrefix(): string;
        protected getNameProperty(): string;
        protected form: RegionForm;
    }
}
declare namespace webNEOC.Locations {
    class RegionGrid extends Serenity.EntityGrid<RegionRow, any> {
        protected getColumnsKey(): string;
        protected getDialogType(): typeof RegionDialog;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getService(): string;
        constructor(container: JQuery);
        protected getButtons(): Serenity.ToolButton[];
    }
}
declare namespace webNEOC.Locations {
    class ProvinceDialog extends Serenity.EntityDialog<ProvinceRow, any> {
        protected getFormKey(): string;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getNameProperty(): string;
        protected getService(): string;
        protected form: ProvinceForm;
    }
}
declare namespace webNEOC.Locations {
    class ProvinceEditor extends Common.GridEditorBase<ProvinceRow> {
        protected getColumnsKey(): string;
        protected getDialogType(): typeof ProvinceEditorDialog;
        protected getLocalTextPrefix(): string;
        constructor(container: JQuery);
    }
}
declare namespace webNEOC.Locations {
    class ProvinceEditorDialog extends Common.GridEditorDialog<ProvinceRow> {
        protected getFormKey(): string;
        protected getLocalTextPrefix(): string;
        protected getNameProperty(): string;
        protected form: ProvinceForm;
    }
}
declare namespace webNEOC.Locations {
    class ProvinceGrid extends Serenity.EntityGrid<ProvinceRow, any> {
        protected getColumnsKey(): string;
        protected getDialogType(): typeof ProvinceDialog;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getService(): string;
        constructor(container: JQuery);
        protected getButtons(): Serenity.ToolButton[];
    }
}
declare namespace webNEOC.Locations {
    class DistrictDialog extends Serenity.EntityDialog<DistrictRow, any> {
        protected getFormKey(): string;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getNameProperty(): string;
        protected getService(): string;
        protected form: DistrictForm;
    }
}
declare namespace webNEOC.Locations {
    class DistrictEditor extends Common.GridEditorBase<DistrictRow> {
        protected getColumnsKey(): string;
        protected getDialogType(): typeof DistrictEditorDialog;
        protected getLocalTextPrefix(): string;
        constructor(container: JQuery);
    }
}
declare namespace webNEOC.Locations {
    class DistrictEditorDialog extends Common.GridEditorDialog<DistrictRow> {
        protected getFormKey(): string;
        protected getLocalTextPrefix(): string;
        protected getNameProperty(): string;
        protected form: DistrictForm;
    }
}
declare namespace webNEOC.Locations {
    class DistrictGrid extends Serenity.EntityGrid<DistrictRow, any> {
        protected getColumnsKey(): string;
        protected getDialogType(): typeof DistrictDialog;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getService(): string;
        constructor(container: JQuery);
        protected getButtons(): Serenity.ToolButton[];
    }
}
declare namespace webNEOC.Locations {
    class ClusterGrid extends Serenity.EntityGrid<ClusterRow, any> {
        protected getColumnsKey(): string;
        protected getDialogType(): typeof ClusterDialog;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getService(): string;
        constructor(container: JQuery);
        protected getButtons(): Serenity.ToolButton[];
    }
}
declare namespace webNEOC.Locations {
    class ClusterCheckGrid extends Serenity.EntityGrid<Locations.ClusterRow, any> {
        protected getColumnsKey(): string;
        protected getDialogType(): any;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getService(): string;
        private rowSelection;
        constructor(container: JQuery);
        protected getColumns(): Slick.Column[];
        protected usePager(): boolean;
        protected getInitialTitle(): any;
        protected getButtons(): Serenity.ToolButton[];
        readonly selectedItems: ClusterRow[];
    }
}
declare namespace webNEOC.Locations {
    class ClusterDialog extends Serenity.EntityDialog<ClusterRow, any> {
        protected getFormKey(): string;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getNameProperty(): string;
        protected getService(): string;
        protected form: ClusterForm;
    }
}
declare namespace webNEOC.Locations {
    class ClusterEditor extends Common.GridEditorBase<ClusterRow> {
        protected getColumnsKey(): string;
        protected getDialogType(): typeof ClusterEditorDialog;
        protected getLocalTextPrefix(): string;
        constructor(container: JQuery);
    }
}
declare namespace webNEOC.Locations {
    class ClusterEditorDialog extends Common.GridEditorDialog<ClusterRow> {
        protected getFormKey(): string;
        protected getLocalTextPrefix(): string;
        protected getNameProperty(): string;
        protected form: ClusterForm;
    }
}
declare namespace webNEOC.Locations {
    class ClusterPickerDialog extends Serenity.EntityDialog<ClusterRow, any> {
        protected getFormKey(): string;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getNameProperty(): string;
        protected getService(): string;
        protected form: ClusterForm;
        private checkGrid;
        constructor();
        protected getTemplate(): string;
        protected getDialogOptions(): JQueryUI.DialogOptions;
        readonly selectedItems: ClusterRow[];
        onSuccess: (selected: Locations.ClusterRow[]) => boolean;
    }
}
declare namespace webNEOC.ImportHelper {
    class VitaminAImportDialog extends Serenity.PropertyDialog<any, any> {
        private form;
        constructor();
        protected getDialogTitle(): string;
        protected getDialogButtons(): Serenity.DialogButton[];
    }
}
declare namespace webNEOC.ImportGate {
    class TempVitaminAGrid extends Serenity.EntityGrid<TempVitaminARow, any> {
        protected getColumnsKey(): string;
        protected getDialogType(): typeof TempVitaminADialog;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getService(): string;
        constructor(container: JQuery);
        protected getButtons(): Serenity.ToolButton[];
    }
}
declare namespace webNEOC.ImportHelper {
    class VitaminAImportGrid extends ImportGate.TempVitaminAGrid {
        constructor(container: JQuery);
        /**
         * This method is called to get list of buttons to be created.
         */
        protected getButtons(): Serenity.ToolButton[];
    }
}
declare namespace webNEOC.ImportHelper {
    class TargetImportDialog extends Serenity.PropertyDialog<any, any> {
        private form;
        constructor();
        protected getDialogTitle(): string;
        protected getDialogButtons(): Serenity.DialogButton[];
    }
}
declare namespace webNEOC.ImportHelper {
    class TargetImportGrid extends Lookup.TargetPopGrid {
        constructor(container: JQuery);
        /**
         * This method is called to get list of buttons to be created.
         */
        protected getButtons(): Serenity.ToolButton[];
    }
}
declare namespace webNEOC.ImportHelper {
    class PcmImportDialog extends Serenity.PropertyDialog<any, any> {
        private form;
        constructor();
        protected getDialogTitle(): string;
        protected getDialogButtons(): Serenity.DialogButton[];
    }
}
declare namespace webNEOC.ImportHelper {
    class PcmImporttGrid extends PostCampaign.PcmGrid {
        constructor(container: JQuery);
        /**
         * This method is called to get list of buttons to be created.
         */
        protected getButtons(): Serenity.ToolButton[];
    }
}
declare namespace webNEOC.ImportHelper {
    class OutHouseImportDialog extends Serenity.PropertyDialog<any, any> {
        private form;
        constructor();
        protected getDialogTitle(): string;
        protected getDialogButtons(): Serenity.DialogButton[];
    }
}
declare namespace webNEOC.ImportHelper {
    class OutHouseImportGrid extends PostCampaign.OutOfHouseSurveyGrid {
        constructor(container: JQuery);
        /**
         * This method is called to get list of buttons to be created.
         */
        protected getButtons(): Serenity.ToolButton[];
    }
}
declare namespace webNEOC.ImportHelper {
    class MobileTeamImportDialog extends Serenity.PropertyDialog<any, any> {
        private form;
        constructor();
        protected getDialogTitle(): string;
        protected getDialogButtons(): Serenity.DialogButton[];
    }
}
declare namespace webNEOC.Implementation {
    class MobileTeamGrid extends Serenity.EntityGrid<MobileTeamRow, any> {
        protected getColumnsKey(): string;
        protected getDialogType(): typeof MobileTeamDialog;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getService(): string;
        constructor(container: JQuery);
        protected getButtons(): Serenity.ToolButton[];
    }
}
declare namespace webNEOC.ImportHelper {
    class MobileTeamImportGrid extends Implementation.MobileTeamGrid {
        constructor(container: JQuery);
        /**
         * This method is called to get list of buttons to be created.
         */
        protected getButtons(): Serenity.ToolButton[];
    }
}
declare namespace webNEOC.ImportHelper {
    class LQASImportDialog extends Serenity.PropertyDialog<any, any> {
        private form;
        constructor();
        protected getDialogTitle(): string;
        protected getDialogButtons(): Serenity.DialogButton[];
    }
}
declare namespace webNEOC.ImportHelper {
    class LQASImportGrid extends PostCampaign.LQASGrid {
        constructor(container: JQuery);
        /**
         * This method is called to get list of buttons to be created.
         */
        protected getButtons(): Serenity.ToolButton[];
    }
}
declare namespace webNEOC.ImportHelper {
    class InAccessibleImportDialog extends Serenity.PropertyDialog<any, any> {
        private form;
        constructor();
        protected getDialogTitle(): string;
        protected getDialogButtons(): Serenity.DialogButton[];
    }
}
declare namespace webNEOC.ImportHelper {
    class InAccessibleImportGrid extends Preparation.InAccessibleGrid {
        constructor(container: JQuery);
        /**
         * This method is called to get list of buttons to be created.
         */
        protected getButtons(): Serenity.ToolButton[];
    }
}
declare namespace webNEOC.ImportHelper {
    class ICNImportDialog extends Serenity.PropertyDialog<any, any> {
        private form;
        constructor();
        protected getDialogTitle(): string;
        protected getDialogButtons(): Serenity.DialogButton[];
    }
}
declare namespace webNEOC.Implementation {
    class IcnGrid extends Serenity.EntityGrid<IcnRow, any> {
        protected getColumnsKey(): string;
        protected getDialogType(): typeof IcnDialog;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getService(): string;
        constructor(container: JQuery);
        protected getButtons(): Serenity.ToolButton[];
    }
}
declare namespace webNEOC.ImportHelper {
    class ICNImportGrid extends Implementation.IcnGrid {
        constructor(container: JQuery);
        /**
         * This method is called to get list of buttons to be created.
         */
        protected getButtons(): Serenity.ToolButton[];
    }
}
declare namespace webNEOC.ImportHelper {
    class ICMTeamImportDialog extends Serenity.PropertyDialog<any, any> {
        private form;
        constructor();
        protected getDialogTitle(): string;
        protected getDialogButtons(): Serenity.DialogButton[];
    }
}
declare namespace webNEOC.Implementation {
    class IcmTeamGrid extends Serenity.EntityGrid<IcmTeamRow, any> {
        protected getColumnsKey(): string;
        protected getDialogType(): typeof IcmTeamDialog;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getService(): string;
        constructor(container: JQuery);
        protected getButtons(): Serenity.ToolButton[];
    }
}
declare namespace webNEOC.ImportHelper {
    class ICMTeamImporttGrid extends Implementation.IcmTeamGrid {
        constructor(container: JQuery);
        /**
         * This method is called to get list of buttons to be created.
         */
        protected getButtons(): Serenity.ToolButton[];
    }
}
declare namespace webNEOC.ImportHelper {
    class ICMSupervisorImportDialog extends Serenity.PropertyDialog<any, any> {
        private form;
        constructor();
        protected getDialogTitle(): string;
        protected getDialogButtons(): Serenity.DialogButton[];
    }
}
declare namespace webNEOC.Implementation {
    class IcmSupervisorGrid extends Serenity.EntityGrid<IcmSupervisorRow, any> {
        protected getColumnsKey(): string;
        protected getDialogType(): typeof IcmSupervisorDialog;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getService(): string;
        constructor(container: JQuery);
        protected getButtons(): Serenity.ToolButton[];
    }
}
declare namespace webNEOC.ImportHelper {
    class ICMSupervisorImportGrid extends Implementation.IcmSupervisorGrid {
        constructor(container: JQuery);
        /**
         * This method is called to get list of buttons to be created.
         */
        protected getButtons(): Serenity.ToolButton[];
    }
}
declare namespace webNEOC.ImportHelper {
    class ICMHouseholdImportDialog extends Serenity.PropertyDialog<any, any> {
        private form;
        constructor();
        protected getDialogTitle(): string;
        protected getDialogButtons(): Serenity.DialogButton[];
    }
}
declare namespace webNEOC.Implementation {
    class IcmHouseholdGrid extends Serenity.EntityGrid<IcmHouseholdRow, any> {
        protected getColumnsKey(): string;
        protected getDialogType(): typeof IcmHouseholdDialog;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getService(): string;
        constructor(container: JQuery);
        protected getButtons(): Serenity.ToolButton[];
    }
}
declare namespace webNEOC.ImportHelper {
    class ICMHouseholdImportGrid extends Implementation.IcmHouseholdGrid {
        constructor(container: JQuery);
        /**
         * This method is called to get list of buttons to be created.
         */
        protected getButtons(): Serenity.ToolButton[];
    }
}
declare namespace webNEOC.ImportHelper {
    class CommunicationImportDialog extends Serenity.PropertyDialog<any, any> {
        private form;
        constructor();
        protected getDialogTitle(): string;
        protected getDialogButtons(): Serenity.DialogButton[];
    }
}
declare namespace webNEOC.Implementation {
    class CommunicationGrid extends Serenity.EntityGrid<CommunicationRow, any> {
        protected getColumnsKey(): string;
        protected getDialogType(): typeof CommunicationDialog;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getService(): string;
        constructor(container: JQuery);
        protected getButtons(): Serenity.ToolButton[];
    }
}
declare namespace webNEOC.ImportHelper {
    class CommunicationImportGrid extends Implementation.CommunicationGrid {
        constructor(container: JQuery);
        /**
         * This method is called to get list of buttons to be created.
         */
        protected getButtons(): Serenity.ToolButton[];
    }
}
declare namespace webNEOC.ImportHelper {
    class CampaignImportDialog extends Serenity.PropertyDialog<any, any> {
        private form;
        constructor();
        protected getDialogTitle(): string;
        protected getDialogButtons(): Serenity.DialogButton[];
    }
}
declare namespace webNEOC.ImportGate {
    class TempCampaignGrid extends Serenity.EntityGrid<TempCampaignRow, any> {
        protected getColumnsKey(): string;
        protected getDialogType(): typeof TempCampaignDialog;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getService(): string;
        constructor(container: JQuery);
        protected getButtons(): Serenity.ToolButton[];
    }
}
declare namespace webNEOC.ImportHelper {
    class CampaignImportGrid extends ImportGate.TempCampaignGrid {
        constructor(container: JQuery);
        /**
         * This method is called to get list of buttons to be created.
         */
        protected getButtons(): Serenity.ToolButton[];
    }
}
declare namespace webNEOC.ImportHelper {
    class AdminDataImportDialog extends Serenity.PropertyDialog<any, any> {
        private form;
        constructor();
        protected getDialogTitle(): string;
        protected getDialogButtons(): Serenity.DialogButton[];
    }
}
declare namespace webNEOC.Campaign {
    class AdminDataGrid extends Serenity.EntityGrid<AdminDataRow, any> {
        protected getColumnsKey(): string;
        protected getDialogType(): typeof AdminDataDialog;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getService(): string;
        constructor(container: JQuery);
        protected getButtons(): Serenity.ToolButton[];
    }
}
declare namespace webNEOC.ImportHelper {
    class AdminDataImportGrid extends Campaign.AdminDataGrid {
        constructor(container: JQuery);
        /**
         * This method is called to get list of buttons to be created.
         */
        protected getButtons(): Serenity.ToolButton[];
    }
}
declare namespace webNEOC.ImportGate {
    class TempVitaminADialog extends Serenity.EntityDialog<TempVitaminARow, any> {
        protected getFormKey(): string;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getNameProperty(): string;
        protected getService(): string;
        protected form: TempVitaminAForm;
    }
}
declare namespace webNEOC.ImportGate {
    class TempVitaminAEditor extends Common.GridEditorBase<TempVitaminARow> {
        protected getColumnsKey(): string;
        protected getDialogType(): typeof TempVitaminAEditorDialog;
        protected getLocalTextPrefix(): string;
        constructor(container: JQuery);
    }
}
declare namespace webNEOC.ImportGate {
    class TempVitaminAEditorDialog extends Common.GridEditorDialog<TempVitaminARow> {
        protected getFormKey(): string;
        protected getLocalTextPrefix(): string;
        protected getNameProperty(): string;
        protected form: TempVitaminAForm;
    }
}
declare namespace webNEOC.ImportGate {
    class TempCampaignDialog extends Serenity.EntityDialog<TempCampaignRow, any> {
        protected getFormKey(): string;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getNameProperty(): string;
        protected getService(): string;
        protected form: TempCampaignForm;
    }
}
declare namespace webNEOC.ImportGate {
    class TempCampaignEditor extends Common.GridEditorBase<TempCampaignRow> {
        protected getColumnsKey(): string;
        protected getDialogType(): typeof TempCampaignEditorDialog;
        protected getLocalTextPrefix(): string;
        constructor(container: JQuery);
    }
}
declare namespace webNEOC.ImportGate {
    class TempCampaignEditorDialog extends Common.GridEditorDialog<TempCampaignRow> {
        protected getFormKey(): string;
        protected getLocalTextPrefix(): string;
        protected getNameProperty(): string;
        protected form: TempCampaignForm;
    }
}
declare namespace webNEOC.Implementation {
    class VitaminADialog extends Serenity.EntityDialog<VitaminARow, any> {
        protected getFormKey(): string;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getNameProperty(): string;
        protected getService(): string;
        protected form: VitaminAForm;
        constructor();
        private setDateDetails(details);
        dialogOpen(): void;
    }
}
declare namespace webNEOC.Implementation {
    class VitaminAEditor extends Common.GridEditorBase<VitaminARow> {
        protected getColumnsKey(): string;
        protected getDialogType(): typeof VitaminAEditorDialog;
        protected getLocalTextPrefix(): string;
        constructor(container: JQuery);
    }
}
declare namespace webNEOC.Implementation {
    class VitaminAEditorDialog extends Common.GridEditorDialog<VitaminARow> {
        protected getFormKey(): string;
        protected getLocalTextPrefix(): string;
        protected getNameProperty(): string;
        protected form: VitaminAForm;
    }
}
declare namespace webNEOC.Implementation {
    class VitaminAGrid extends Serenity.EntityGrid<VitaminARow, any> {
        protected getColumnsKey(): string;
        protected getDialogType(): typeof VitaminADialog;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getService(): string;
        constructor(container: JQuery);
        protected getButtons(): Serenity.ToolButton[];
    }
}
declare namespace webNEOC.Implementation {
    class VitaminAVaccinationsDialog extends Serenity.EntityDialog<VitaminAVaccinationsRow, any> {
        protected getFormKey(): string;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getService(): string;
        protected form: VitaminAVaccinationsForm;
    }
}
declare namespace webNEOC.Implementation {
    class VitaminAVaccinationsEditor extends Common.GridEditorBase<VitaminAVaccinationsRow> {
        protected getColumnsKey(): string;
        protected getDialogType(): typeof VitaminAVaccinationsEditorDialog;
        protected getLocalTextPrefix(): string;
        constructor(container: JQuery);
        protected getButtons(): Serenity.ToolButton[];
    }
}
declare namespace webNEOC.Implementation {
    class VitaminAVaccinationsEditorDialog extends Common.GridEditorDialog<VitaminAVaccinationsRow> {
        protected getFormKey(): string;
        protected getLocalTextPrefix(): string;
        protected form: VitaminAVaccinationsForm;
    }
}
declare namespace webNEOC.Implementation {
    class VitaminAVaccinationsGrid extends Serenity.EntityGrid<VitaminAVaccinationsRow, any> {
        protected getColumnsKey(): string;
        protected getDialogType(): typeof VitaminAVaccinationsDialog;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getService(): string;
        constructor(container: JQuery);
        protected getButtons(): Serenity.ToolButton[];
    }
}
declare namespace webNEOC.Implementation {
    class MobileTeamDialog extends Serenity.EntityDialog<MobileTeamRow, any> {
        protected getFormKey(): string;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getService(): string;
        protected form: MobileTeamForm;
        constructor();
        private setDateDetails(details);
    }
}
declare namespace webNEOC.Implementation {
    class MobileTeamEditor extends Common.GridEditorBase<MobileTeamRow> {
        protected getColumnsKey(): string;
        protected getDialogType(): typeof MobileTeamEditorDialog;
        protected getLocalTextPrefix(): string;
        constructor(container: JQuery);
    }
}
declare namespace webNEOC.Implementation {
    class MobileTeamEditorDialog extends Common.GridEditorDialog<MobileTeamRow> {
        protected getFormKey(): string;
        protected getLocalTextPrefix(): string;
        protected form: MobileTeamForm;
    }
}
declare namespace webNEOC.Implementation {
    class IcnDeploymentDialog extends Serenity.EntityDialog<IcnDeploymentRow, any> {
        protected getFormKey(): string;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getService(): string;
        protected form: IcnDeploymentForm;
    }
}
declare namespace webNEOC.Implementation {
    class IcnDeploymentGrid extends Serenity.EntityGrid<IcnDeploymentRow, any> {
        protected getColumnsKey(): string;
        protected getDialogType(): typeof IcnDeploymentDialog;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getService(): string;
        constructor(container: JQuery);
    }
}
declare namespace webNEOC.Implementation {
    class IcnDialog extends Serenity.EntityDialog<IcnRow, any> {
        protected getFormKey(): string;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getNameProperty(): string;
        protected getService(): string;
        protected form: IcnForm;
        constructor();
        private setDateDetails(details);
    }
}
declare namespace webNEOC.Implementation {
    class IcnEditor extends Common.GridEditorBase<IcnRow> {
        protected getColumnsKey(): string;
        protected getDialogType(): typeof IcnEditorDialog;
        protected getLocalTextPrefix(): string;
        constructor(container: JQuery);
    }
}
declare namespace webNEOC.Implementation {
    class IcnEditorDialog extends Common.GridEditorDialog<IcnRow> {
        protected getFormKey(): string;
        protected getLocalTextPrefix(): string;
        protected getNameProperty(): string;
        protected form: IcnForm;
    }
}
declare namespace webNEOC.Implementation {
    class IcmTeamDialog extends Serenity.EntityDialog<IcmTeamRow, any> {
        protected getFormKey(): string;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getNameProperty(): string;
        protected getService(): string;
        protected form: IcmTeamForm;
        constructor();
        private setDateDetails(details);
    }
}
declare namespace webNEOC.Implementation {
    class IcmTeamEditor extends Common.GridEditorBase<IcmTeamRow> {
        protected getColumnsKey(): string;
        protected getDialogType(): typeof IcmTeamEditorDialog;
        protected getLocalTextPrefix(): string;
        constructor(container: JQuery);
    }
}
declare namespace webNEOC.Implementation {
    class IcmTeamEditorDialog extends Common.GridEditorDialog<IcmTeamRow> {
        protected getFormKey(): string;
        protected getLocalTextPrefix(): string;
        protected getNameProperty(): string;
        protected form: IcmTeamForm;
    }
}
declare namespace webNEOC.Implementation {
    class IcmSupervisorDialog extends Serenity.EntityDialog<IcmSupervisorRow, any> {
        protected getFormKey(): string;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getNameProperty(): string;
        protected getService(): string;
        protected form: IcmSupervisorForm;
        constructor();
        private setDateDetails(details);
    }
}
declare namespace webNEOC.Implementation {
    class IcmSupervisorEditor extends Common.GridEditorBase<IcmSupervisorRow> {
        protected getColumnsKey(): string;
        protected getDialogType(): typeof IcmSupervisorEditorDialog;
        protected getLocalTextPrefix(): string;
        constructor(container: JQuery);
    }
}
declare namespace webNEOC.Implementation {
    class IcmSupervisorEditorDialog extends Common.GridEditorDialog<IcmSupervisorRow> {
        protected getFormKey(): string;
        protected getLocalTextPrefix(): string;
        protected getNameProperty(): string;
        protected form: IcmSupervisorForm;
    }
}
declare namespace webNEOC.Implementation {
    class IcmHouseholdDialog extends Serenity.EntityDialog<IcmHouseholdRow, any> {
        protected getFormKey(): string;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getNameProperty(): string;
        protected getService(): string;
        protected form: IcmHouseholdForm;
        constructor();
        private setDateDetails(details);
    }
}
declare namespace webNEOC.Implementation {
    class IcmHouseholdEditor extends Common.GridEditorBase<IcmHouseholdRow> {
        protected getColumnsKey(): string;
        protected getDialogType(): typeof IcmHouseholdEditorDialog;
        protected getLocalTextPrefix(): string;
        constructor(container: JQuery);
    }
}
declare namespace webNEOC.Implementation {
    class IcmHouseholdEditorDialog extends Common.GridEditorDialog<IcmHouseholdRow> {
        protected getFormKey(): string;
        protected getLocalTextPrefix(): string;
        protected getNameProperty(): string;
        protected form: IcmHouseholdForm;
    }
}
declare namespace webNEOC.Implementation {
    class CommunicationDialog extends Serenity.EntityDialog<CommunicationRow, any> {
        protected getFormKey(): string;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getNameProperty(): string;
        protected getService(): string;
        protected form: CommunicationForm;
    }
}
declare namespace webNEOC.Default {
    class FormsbsDialog extends Serenity.EntityDialog<FormsbsRow, any> {
        protected getFormKey(): string;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getNameProperty(): string;
        protected getService(): string;
        protected form: FormsbsForm;
    }
}
declare namespace webNEOC.Default {
    class FormsbsGrid extends Serenity.EntityGrid<FormsbsRow, any> {
        protected getColumnsKey(): string;
        protected getDialogType(): typeof FormsbsDialog;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getService(): string;
        constructor(container: JQuery);
    }
}
declare namespace webNEOC.CVA {
    class PTTSDialog extends Serenity.EntityDialog<PTTSRow, any> {
        protected getFormKey(): string;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getNameProperty(): string;
        protected getService(): string;
        protected form: PTTSForm;
    }
}
declare namespace webNEOC.CVA {
    class PTTSEditor extends Common.GridEditorBase<PTTSRow> {
        protected getColumnsKey(): string;
        protected getDialogType(): typeof PTTSEditorDialog;
        protected getLocalTextPrefix(): string;
        constructor(container: JQuery);
    }
}
declare namespace webNEOC.CVA {
    class PTTSEditorDialog extends Common.GridEditorDialog<PTTSRow> {
        protected getFormKey(): string;
        protected getLocalTextPrefix(): string;
        protected getNameProperty(): string;
        protected form: PTTSForm;
    }
}
declare namespace webNEOC.CVA {
    class PTTSGrid extends Serenity.EntityGrid<PTTSRow, any> {
        protected getColumnsKey(): string;
        protected getDialogType(): typeof PTTSDialog;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getService(): string;
        constructor(container: JQuery);
        protected getButtons(): Serenity.ToolButton[];
    }
}
declare namespace webNEOC.LanguageList {
    function getValue(): string[][];
}
declare namespace webNEOC.ScriptInitialization {
}
declare namespace webNEOC.Common {
    class UserPreferenceStorage implements Serenity.SettingStorage {
        getItem(key: string): string;
        setItem(key: string, data: string): void;
    }
}
declare var jsPDF: any;
declare namespace webNEOC.Common {
    interface PdfExportOptions {
        grid: Serenity.DataGrid<any, any>;
        onViewSubmit: () => boolean;
        title?: string;
        hint?: string;
        separator?: boolean;
        reportTitle?: string;
        titleTop?: number;
        titleFontSize?: number;
        fileName?: string;
        pageNumbers?: boolean;
        columnTitles?: {
            [key: string]: string;
        };
        tableOptions?: jsPDF.AutoTableOptions;
        output?: string;
        autoPrint?: boolean;
        printDateTimeHeader?: boolean;
    }
    namespace PdfExportHelper {
        function exportToPdf(options: PdfExportOptions): void;
        function createToolButton(options: PdfExportOptions): Serenity.ToolButton;
    }
}
declare var jsPDF: any;
declare namespace webNEOC.Common {
    class ReportDialog extends Serenity.TemplatedDialog<ReportDialogOptions> {
        private report;
        private propertyGrid;
        constructor(options: ReportDialogOptions);
        protected getDialogButtons(): any;
        protected createPropertyGrid(): void;
        protected loadReport(reportKey: string): void;
        protected updateInterface(): void;
        executeReport(target: string, ext: string, download: boolean): void;
        getToolbarButtons(): {
            title: string;
            cssClass: string;
            onClick: () => void;
        }[];
    }
    interface ReportDialogOptions {
        reportKey: string;
    }
}
declare namespace webNEOC.Common {
    interface ReportExecuteOptions {
        reportKey: string;
        download?: boolean;
        extension?: 'pdf' | 'htm' | 'html' | 'xlsx' | 'docx';
        getParams?: () => any;
        params?: {
            [key: string]: any;
        };
        target?: string;
    }
    interface ReportButtonOptions extends ReportExecuteOptions {
        title?: string;
        cssClass?: string;
        icon?: string;
    }
    namespace ReportHelper {
        function createToolButton(options: ReportButtonOptions): Serenity.ToolButton;
        function execute(options: ReportExecuteOptions): void;
    }
}
declare var jsPDF: any;
declare namespace webNEOC.Common {
    class ReportPage extends Serenity.Widget<any> {
        private reportKey;
        private propertyItems;
        private propertyGrid;
        constructor(element: JQuery);
        protected updateMatchFlags(text: string): void;
        protected categoryClick(e: any): void;
        protected reportLinkClick(e: any): void;
    }
}
declare namespace webNEOC.Common {
    class LanguageSelection extends Serenity.Widget<any> {
        constructor(select: JQuery, currentLanguage: string);
    }
}
declare namespace webNEOC.Common {
    class SidebarSearch extends Serenity.Widget<any> {
        private menuUL;
        constructor(input: JQuery, menuUL: JQuery);
        protected updateMatchFlags(text: string): void;
    }
}
declare namespace webNEOC.Common {
    class ThemeSelection extends Serenity.Widget<any> {
        constructor(select: JQuery);
        protected getCurrentTheme(): string;
    }
}
declare namespace webNEOC.Common {
    class MailDialog extends Serenity.EntityDialog<MailRow, any> {
        protected getFormKey(): string;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getNameProperty(): string;
        protected getService(): string;
        protected form: MailForm;
        constructor();
    }
}
declare namespace webNEOC.Common {
    class MailGrid extends Serenity.EntityGrid<MailRow, any> {
        protected getColumnsKey(): string;
        protected getDialogType(): typeof MailDialog;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getService(): string;
        constructor(container: JQuery);
        protected getButtons(): Serenity.ToolButton[];
    }
}
declare namespace webNEOC {
    class BasicProgressDialog extends Serenity.TemplatedDialog<any> {
        constructor();
        cancelled: boolean;
        max: number;
        value: number;
        title: string;
        cancelTitle: string;
        getDialogOptions(): JQueryUI.DialogOptions;
        initDialog(): void;
        getTemplate(): string;
    }
}
declare namespace webNEOC.Common {
    class BulkServiceAction {
        protected keys: string[];
        protected queue: string[];
        protected queueIndex: number;
        protected progressDialog: BasicProgressDialog;
        protected pendingRequests: number;
        protected completedRequests: number;
        protected errorByKey: Q.Dictionary<Serenity.ServiceError>;
        private successCount;
        private errorCount;
        done: () => void;
        protected createProgressDialog(): void;
        protected getConfirmationFormat(): string;
        protected getConfirmationMessage(targetCount: any): string;
        protected confirm(targetCount: any, action: any): void;
        protected getNothingToProcessMessage(): string;
        protected nothingToProcess(): void;
        protected getParallelRequests(): number;
        protected getBatchSize(): number;
        protected startParallelExecution(): void;
        protected serviceCallCleanup(): void;
        protected executeForBatch(batch: string[]): void;
        protected executeNextBatch(): void;
        protected getAllHadErrorsFormat(): string;
        protected showAllHadErrors(): void;
        protected getSomeHadErrorsFormat(): string;
        protected showSomeHadErrors(): void;
        protected getAllSuccessFormat(): string;
        protected showAllSuccess(): void;
        protected showResults(): void;
        execute(keys: string[]): void;
        get_successCount(): any;
        set_successCount(value: number): void;
        get_errorCount(): any;
        set_errorCount(value: number): void;
    }
}
declare namespace webNEOC.DialogUtils {
    function pendingChangesConfirmation(element: JQuery, hasPendingChanges: () => boolean): void;
}
declare namespace webNEOC.Common {
    class EnumSelectFormatter implements Slick.Formatter {
        constructor();
        format(ctx: Slick.FormatterContext): string;
        enumKey: string;
        allowClear: boolean;
        emptyItemText: string;
    }
}
declare namespace webNEOC.Common {
    interface ExcelExportOptions {
        grid: Serenity.DataGrid<any, any>;
        service: string;
        onViewSubmit: () => boolean;
        title?: string;
        hint?: string;
        separator?: boolean;
    }
    namespace ExcelExportHelper {
        function createToolButton(options: ExcelExportOptions): Serenity.ToolButton;
    }
}
declare namespace webNEOC {
    /**
     * This is an editor widget but it only displays a text, not edits it.
     *
     */
    class StaticTextBlock extends Serenity.Widget<StaticTextBlockOptions> implements Serenity.ISetEditValue {
        private value;
        constructor(container: JQuery, options: StaticTextBlockOptions);
        private updateElementContent();
        /**
         * By implementing ISetEditValue interface, we allow this editor to display its field value.
         * But only do this when our text content is not explicitly set in options
         */
        setEditValue(source: any, property: Serenity.PropertyItem): void;
    }
    interface StaticTextBlockOptions {
        text: string;
        isHtml: boolean;
        isLocalText: boolean;
        hideLabel: boolean;
    }
}
declare namespace webNEOC.Campaign {
    class CampaignDayDialog extends Serenity.EntityDialog<CampaignDayRow, any> {
        protected getFormKey(): string;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getNameProperty(): string;
        protected getService(): string;
        protected form: CampaignDayForm;
        onDialogOpen(): void;
    }
}
declare namespace webNEOC.Campaign {
    class CampaignDayEditor extends Common.GridEditorBase<CampaignDayRow> {
        protected getColumnsKey(): string;
        protected getDialogType(): typeof CampaignDayEditorDialog;
        protected getLocalTextPrefix(): string;
        constructor(container: JQuery);
    }
}
declare namespace webNEOC.Campaign {
    class CampaignDayEditorDialog extends Common.GridEditorDialog<CampaignDayRow> {
        protected getFormKey(): string;
        protected getLocalTextPrefix(): string;
        protected getNameProperty(): string;
        protected form: CampaignDayForm;
        onDialogOpen(): void;
    }
}
declare namespace webNEOC.Campaign {
    class CampaignDayGrid extends Serenity.EntityGrid<CampaignDayRow, any> {
        protected getColumnsKey(): string;
        protected getDialogType(): typeof CampaignDayDialog;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getService(): string;
        constructor(container: JQuery);
        protected getButtons(): Serenity.ToolButton[];
    }
}
declare namespace webNEOC.Campaign {
    class DailyVaccinationsDialog extends Serenity.EntityDialog<DailyVaccinationsRow, any> {
        protected getFormKey(): string;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getService(): string;
        protected form: DailyVaccinationsForm;
        dialogOpen(): void;
    }
}
declare namespace webNEOC.Campaign {
    class DailyVaccinationsEditor extends Common.GridEditorBase<DailyVaccinationsRow> {
        protected getColumnsKey(): string;
        protected getDialogType(): typeof DailyVaccinationsEditorDialog;
        protected getLocalTextPrefix(): string;
        constructor(container: JQuery);
        protected getButtons(): Serenity.ToolButton[];
    }
}
declare namespace webNEOC.Campaign {
    class DailyVaccinationsEditorDialog extends Common.GridEditorDialog<DailyVaccinationsRow> {
        protected getFormKey(): string;
        protected getLocalTextPrefix(): string;
        protected form: DailyVaccinationsForm;
    }
}
declare namespace webNEOC.Campaign {
    class DailyVaccinationsFormatter implements Slick.Formatter {
        format(ctx: Slick.FormatterContext): any;
    }
}
declare namespace webNEOC.Campaign {
    class DailyVaccinationsGrid extends Serenity.EntityGrid<DailyVaccinationsRow, any> {
        protected getColumnsKey(): string;
        protected getDialogType(): typeof DailyVaccinationsDialog;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getService(): string;
        constructor(container: JQuery);
        protected getColumns(): Slick.Column[];
    }
}
declare namespace webNEOC.Campaign {
    class CampaignDialog extends Serenity.EntityDialog<CampaignRow, any> {
        protected getFormKey(): string;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getNameProperty(): string;
        protected getService(): string;
        protected form: CampaignForm;
    }
}
declare namespace webNEOC.Campaign {
    class CampaignEditor extends Common.GridEditorBase<CampaignRow> {
        protected getColumnsKey(): string;
        protected getDialogType(): typeof CampaignEditorDialog;
        protected getLocalTextPrefix(): string;
        constructor(container: JQuery);
    }
}
declare namespace webNEOC.Campaign {
    class CampaignEditorDialog extends Common.GridEditorDialog<CampaignRow> {
        protected getFormKey(): string;
        protected getLocalTextPrefix(): string;
        protected getNameProperty(): string;
        protected form: CampaignForm;
    }
}
declare namespace webNEOC.Campaign {
    class CampaignGrid extends Serenity.EntityGrid<CampaignRow, any> {
        protected getColumnsKey(): string;
        protected getDialogType(): typeof CampaignDialog;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getService(): string;
        constructor(container: JQuery);
    }
}
declare namespace webNEOC.Campaign {
    class AdminDataDialog extends Serenity.EntityDialog<AdminDataRow, any> {
        protected getFormKey(): string;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getNameProperty(): string;
        protected getService(): string;
        protected form: AdminDataForm;
    }
}
declare namespace webNEOC.BasicSamples {
    class WrappedHeadersGrid extends Northwind.OrderGrid {
        constructor(container: JQuery);
    }
}
declare namespace webNEOC.BasicSamples {
    class VSGalleryQAGrid extends Serenity.EntityGrid<BasicSamples.VSGalleryQAThread, any> {
        protected getColumnsKey(): string;
        protected getIdProperty(): string;
        protected getService(): string;
        constructor(container: JQuery);
        protected getButtons(): any[];
        protected getSlickOptions(): Slick.GridOptions;
        protected getColumns(): Slick.Column[];
        protected getInitialTitle(): any;
    }
}
declare namespace webNEOC.BasicSamples {
    class ViewWithoutIDGrid extends Serenity.EntityGrid<Northwind.SalesByCategoryRow, any> {
        protected getColumnsKey(): string;
        protected getIdProperty(): string;
        protected getNameProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getService(): string;
        private nextId;
        constructor(container: JQuery);
        /**
         * This method is called to preprocess data returned from the list service
         */
        protected onViewProcessData(response: Serenity.ListResponse<Northwind.SalesByCategoryRow>): Serenity.ListResponse<Northwind.SalesByCategoryRow>;
        protected getButtons(): any[];
    }
}
declare namespace webNEOC.BasicSamples {
    class TreeGrid extends Northwind.OrderGrid {
        private treeMixin;
        constructor(container: JQuery);
        protected usePager(): boolean;
    }
}
declare namespace webNEOC.BasicSamples {
    class CustomerGrossSalesGrid extends Serenity.EntityGrid<Northwind.CustomerGrossSalesRow, any> {
        protected getColumnsKey(): string;
        protected getIdProperty(): string;
        protected getNameProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getService(): string;
        private nextId;
        constructor(container: JQuery);
        /**
         * This method is called to preprocess data returned from the list service
         */
        protected onViewProcessData(response: Serenity.ListResponse<Northwind.SalesByCategoryRow>): Serenity.ListResponse<Northwind.SalesByCategoryRow>;
        protected getButtons(): any[];
        protected createSlickGrid(): Slick.Grid;
        protected getSlickOptions(): Slick.GridOptions;
        protected usePager(): boolean;
        protected getQuickFilters(): Serenity.QuickFilter<Serenity.Widget<any>, any>[];
    }
}
declare namespace webNEOC.BasicSamples {
    class RemovingAddButton extends Northwind.SupplierGrid {
        constructor(container: JQuery);
        /**
         * This method is called to get list of buttons to be created.
         */
        protected getButtons(): Serenity.ToolButton[];
    }
}
declare namespace webNEOC.BasicSamples {
    class QuickFilterCustomization extends Serenity.EntityGrid<Northwind.OrderRow, any> {
        protected getColumnsKey(): string;
        protected getDialogType(): typeof Northwind.OrderDialog;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getService(): string;
        constructor(container: JQuery);
        /**
         * This method is called to get list of quick filters to be created for this grid.
         * By default, it returns quick filter objects corresponding to properties that
         * have a [QuickFilter] attribute at server side OrderColumns.cs
         */
        protected getQuickFilters(): Serenity.QuickFilter<Serenity.Widget<any>, any>[];
    }
}
declare namespace webNEOC.BasicSamples {
    class ProductExcelImportDialog extends Serenity.PropertyDialog<any, any> {
        private form;
        constructor();
        protected getDialogTitle(): string;
        protected getDialogButtons(): Serenity.DialogButton[];
    }
}
declare namespace webNEOC.BasicSamples {
    class ProductExcelImportGrid extends Northwind.ProductGrid {
        constructor(container: JQuery);
        /**
         * This method is called to get list of buttons to be created.
         */
        protected getButtons(): Serenity.ToolButton[];
    }
}
declare namespace webNEOC.BasicSamples {
    class InlineImageFormatter implements Slick.Formatter, Serenity.IInitializeColumn {
        format(ctx: Slick.FormatterContext): string;
        initializeColumn(column: Slick.Column): void;
        fileProperty: string;
        thumb: boolean;
    }
}
declare namespace webNEOC.BasicSamples {
    class InlineImageInGrid extends Serenity.EntityGrid<Northwind.ProductRow, any> {
        protected getColumnsKey(): string;
        protected getDialogType(): any;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getService(): string;
        constructor(container: JQuery);
        protected getSlickOptions(): Slick.GridOptions;
    }
}
declare namespace webNEOC.BasicSamples {
    class InlineActionGrid extends Northwind.CustomerGrid {
        constructor(container: JQuery);
        protected getColumns(): Slick.Column[];
        protected onClick(e: JQueryEventObject, row: number, cell: number): void;
    }
}
declare namespace webNEOC.BasicSamples {
    class InitialValuesForQuickFilters extends Northwind.OrderGrid {
        constructor(container: JQuery);
        /**
         * This method is called to get list of quick filters to be created for this grid.
         * By default, it returns quick filter objects corresponding to properties that
         * have a [QuickFilter] attribute at server side OrderColumns.cs
         */
        protected getQuickFilters(): Serenity.QuickFilter<Serenity.Widget<any>, any>[];
        /**
         * This method is another possible place to modify quick filter widgets.
         * It is where the quick filter widgets are actually created.
         *
         * By default, it calls getQuickFilters() then renders UI for these
         * quick filters.
         *
         * We could use getQuickFilters() method for ShipVia too,
         * but this is for demonstration purposes
         */
        protected createQuickFilters(): void;
    }
}
declare namespace webNEOC.BasicSamples {
    class GroupingAndSummariesInGrid extends Northwind.ProductGrid {
        constructor(container: JQuery);
        protected createSlickGrid(): Slick.Grid;
        protected getColumns(): Slick.Column[];
        protected getSlickOptions(): Slick.GridOptions;
        protected usePager(): boolean;
        protected getButtons(): {
            title: string;
            cssClass: string;
            onClick: () => void;
        }[];
    }
}
declare namespace webNEOC.BasicSamples {
    class GridFilteredByCriteria extends Northwind.ProductGrid {
        constructor(container: JQuery);
        protected onViewSubmit(): boolean;
    }
}
declare namespace webNEOC {
    class SelectableEntityGrid<TItem, TOptions> extends Serenity.EntityGrid<TItem, TOptions> {
        protected getSlickOptions(): Slick.GridOptions;
        protected createSlickGrid(): Slick.Grid;
    }
}
declare namespace webNEOC.BasicSamples {
    class RowSelectionGrid extends SelectableEntityGrid<Northwind.SupplierRow, any> {
        protected getColumnsKey(): string;
        protected getDialogType(): any;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getService(): string;
        constructor(container: JQuery);
    }
}
declare namespace webNEOC.BasicSamples {
    class DragDropSampleDialog extends Serenity.EntityDialog<DragDropSampleRow, any> {
        protected getFormKey(): string;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getNameProperty(): string;
        protected getService(): string;
        protected form: DragDropSampleForm;
    }
}
declare namespace webNEOC.BasicSamples {
    class DragDropSampleGrid extends Serenity.EntityGrid<DragDropSampleRow, any> {
        protected getColumnsKey(): string;
        protected getDialogType(): typeof DragDropSampleDialog;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getService(): string;
        private dragging;
        constructor(container: JQuery);
        /**
         * This method will determine if item can be moved under a given target
         * An item can't be moved under itself, under one of its children
         */
        private canMoveUnder(item, target);
        /**
         * Gets children list of an item
         */
        private getChildren(item);
        /**
         * Gets all parents of an item
         */
        private getParents(item);
        protected getButtons(): any[];
        protected usePager(): boolean;
    }
}
declare namespace webNEOC.BasicSamples {
    class CustomLinksInGrid extends Northwind.OrderGrid {
        constructor(container: JQuery);
        /**
         * We override getColumns() to change format functions for some columns.
         * You could also write them as formatter classes, and use them at server side
         */
        protected getColumns(): Slick.Column[];
        protected onClick(e: JQueryEventObject, row: number, cell: number): void;
        /**
         * This method is called for columns with [EditLink] attribute,
         * but only for edit links of this grid's own item type.
         * It is also called by Add Product button with a NULL entityOrId
         * parameter so we should check that entityOrId is a string
         * to be sure it is originating from a link.
         *
         * As we changed format for other columns, this will only be called
         * for links in remaining OrderID column
         */
        protected editItem(entityOrId: any): void;
    }
}
declare namespace webNEOC.BasicSamples {
    class ConditionalFormattingGrid extends Serenity.EntityGrid<Northwind.ProductRow, any> {
        protected getColumnsKey(): string;
        protected getDialogType(): any;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getService(): string;
        constructor(container: JQuery);
        /**
         * We override getColumns() to be able to add a custom CSS class to UnitPrice
         * We could also add this class in ProductColumns.cs but didn't want to modify
         * it solely for this sample.
         */
        protected getColumns(): Slick.Column[];
        /**
         * This method is called for all rows
         * @param item Data item for current row
         * @param index Index of the row in grid
         */
        protected getItemCssClass(item: Northwind.ProductRow, index: number): string;
    }
}
declare namespace webNEOC.BasicSamples {
    class OrderBulkAction extends Common.BulkServiceAction {
        /**
         * This controls how many service requests will be used in parallel.
         * Determine this number based on how many requests your server
         * might be able to handle, and amount of wait on external resources.
         */
        protected getParallelRequests(): number;
        /**
         * These number of records IDs will be sent to your service in one
         * service call. If your service is designed to handle one record only,
         * set it to 1. But note that, if you have 5000 records, this will
         * result in 5000 service calls / requests.
         */
        protected getBatchSize(): number;
        /**
         * This is where you should call your service.
         * Batch parameter contains the selected order IDs
         * that should be processed in this service call.
         */
        protected executeForBatch(batch: any): void;
    }
}
declare namespace webNEOC.BasicSamples {
    class CancellableBulkActionGrid extends Northwind.OrderGrid {
        private rowSelection;
        constructor(container: JQuery);
        protected createToolbarExtensions(): void;
        protected getButtons(): {
            title: string;
            cssClass: string;
            onClick: () => void;
        }[];
        protected getColumns(): Slick.Column[];
        protected getViewOptions(): Slick.RemoteViewOptions;
    }
}
declare namespace webNEOC.BasicSamples {
    class StaticTextBlockDialog extends Serenity.PropertyDialog<any, any> {
        protected getFormKey(): string;
        protected form: StaticTextBlockForm;
        constructor();
        /**
         * Here we override loadInitialEntity method to set value for "DisplayFieldValue" field.
         * If this was an EntityDialog, your field value would be originating from server side entity.
         */
        protected loadInitialEntity(): void;
        protected getDialogOptions(): JQueryUI.DialogOptions;
    }
}
declare namespace webNEOC.BasicSamples {
    class HardcodedValuesDialog extends Serenity.PropertyDialog<any, any> {
        protected getFormKey(): string;
        protected form: HardcodedValuesForm;
        constructor();
    }
}
declare namespace webNEOC.BasicSamples {
    /**
     * Our select editor with hardcoded values.
     *
     * When you define a new editor type, make sure you build
     * and transform templates for it to be available
     * in server side forms, e.g. [HardCodedValuesEditor]
     */
    class HardcodedValuesEditor extends Serenity.Select2Editor<any, any> {
        constructor(container: JQuery);
    }
}
declare namespace webNEOC.BasicSamples {
    /**
     * This is our custom product dialog that uses a different product form
     * (LookupFilterByMultipleForm) with our special category editor.
     */
    class LookupFilterByMultipleDialog extends Northwind.ProductDialog {
        protected getFormKey(): string;
    }
}
declare namespace webNEOC.BasicSamples {
    /**
     * Subclass of ProductGrid to override dialog type to CloneableEntityDialog
     */
    class LookupFilterByMultipleGrid extends Northwind.ProductGrid {
        protected getDialogType(): typeof LookupFilterByMultipleDialog;
        constructor(container: JQuery);
        /**
         * This method is called just before List request is sent to service.
         * You have an opportunity here to cancel request or modify it.
         * Here we'll add a custom criteria to list request.
         */
        protected onViewSubmit(): boolean;
    }
}
declare namespace webNEOC.BasicSamples {
    /**
     * This is our category editor that will show only categories of Produce and
     * Seafood. We are subclassing LookupEditorBase which also LookupEditor
     * derives from.
     *
     * After compiling and transforming templates, this editor type will be
     * available in server side to use in our LookupFilterByMultipleForm,
     * which is a version of ProductForm that uses our custom editor.
     */
    class ProduceSeafoodCategoryEditor extends Serenity.LookupEditorBase<Serenity.LookupEditorOptions, Northwind.CategoryRow> {
        constructor(container: JQuery, opt: Serenity.LookupEditorOptions);
        /**
         * Normally LookupEditor requires a lookup key to determine which set of
         * lookup data to show in editor. As our editor will only show category
         * data, we lock it to category lookup key.
         */
        protected getLookupKey(): string;
        /**
         * Here we are filtering by category name but you could filter by any field.
         * Just make sure the fields you filter on has [LookupInclude] attribute on them,
         * otherwise their value will be null in client side as they are not sent back
         * from server in lookup script.
         */
        protected getItems(lookup: Q.Lookup<Northwind.CategoryRow>): Northwind.CategoryRow[];
    }
}
declare namespace webNEOC.BasicSamples {
    /**
     * Our subclass of order detail dialog with a CategoryID property
     * that will be used to set CascadeValue of product editor
     */
    class FilteredLookupOrderDetailDialog extends Northwind.OrderDetailDialog {
        constructor();
        /**
         * This method is called just before an entity is loaded to dialog
         * This is also called for new record mode with an empty entity
         */
        protected beforeLoadEntity(entity: any): void;
        categoryID: number;
    }
}
declare namespace webNEOC.BasicSamples {
    /**
     * Our subclass of Order Details editor with a CategoryID property
     */
    class FilteredLookupDetailEditor extends Northwind.OrderDetailsEditor {
        protected getDialogType(): typeof FilteredLookupOrderDetailDialog;
        constructor(container: JQuery);
        categoryID: number;
        /**
         * This method is called to initialize an edit dialog created by
         * grid editor when Add button or an edit link is clicked
         * We have an opportunity here to pass CategoryID to edit dialog
         */
        protected initEntityDialog(itemType: string, dialog: Serenity.Widget<any>): void;
    }
}
declare namespace webNEOC.BasicSamples {
    /**
     * Basic order dialog with a category selection
     */
    class FilteredLookupInDetailDialog extends Serenity.EntityDialog<Northwind.OrderRow, any> {
        protected getFormKey(): string;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getNameProperty(): string;
        protected getService(): string;
        private form;
        constructor();
    }
}
declare namespace webNEOC.BasicSamples {
    /**
     * Subclass of OrderGrid to override dialog type to FilteredLookupInDetailDialog
     */
    class FilteredLookupInDetailGrid extends Northwind.OrderGrid {
        protected getDialogType(): typeof FilteredLookupInDetailDialog;
        constructor(container: JQuery);
    }
}
declare namespace webNEOC.BasicSamples {
    class ChangingLookupTextDialog extends Common.GridEditorDialog<Northwind.OrderDetailRow> {
        protected getFormKey(): string;
        protected getLocalTextPrefix(): string;
        protected form: ChangingLookupTextForm;
        constructor();
        protected updateInterface(): void;
    }
}
declare namespace webNEOC.BasicSamples {
    /**
     * Our custom product editor type
     */
    class ChangingLookupTextEditor extends Serenity.LookupEditorBase<Serenity.LookupEditorOptions, Northwind.ProductRow> {
        constructor(container: JQuery, options: Serenity.LookupEditorOptions);
        protected getLookupKey(): string;
        protected getItemText(item: Northwind.ProductRow, lookup: Q.Lookup<Northwind.ProductRow>): string;
    }
}
declare namespace webNEOC.BasicSamples {
    class SerialAutoNumberDialog extends Northwind.CustomerDialog {
        constructor();
        protected afterLoadEntity(): void;
        private getNextNumber();
    }
}
declare namespace webNEOC.BasicSamples {
    /**
     * Subclass of CustomerGrid to override dialog type to SerialAutoNumberDialog
     */
    class SerialAutoNumberGrid extends Northwind.CustomerGrid {
        protected getDialogType(): typeof SerialAutoNumberDialog;
        constructor(container: JQuery);
    }
}
declare namespace webNEOC.BasicSamples {
    /**
     * Adding Responsive attribute makes this dialog use full screen in mobile devices.
     */
    class ResponsiveDialog extends Serenity.EntityDialog<Northwind.OrderRow, any> {
        protected getFormKey(): string;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getNameProperty(): string;
        protected getService(): string;
        constructor();
    }
}
declare namespace webNEOC.BasicSamples {
    /**
     * Subclass of OrderGrid to override dialog type to ResponsiveDialog
     */
    class ResponsiveGrid extends Northwind.OrderGrid {
        protected getDialogType(): typeof ResponsiveDialog;
        constructor(container: JQuery);
    }
}
declare namespace webNEOC.BasicSamples {
    class ReadOnlyDialog extends Northwind.SupplierDialog {
        /**
         * This is the method that gets list of tool
         * buttons to be created in a dialog.
         *
         * Here we'll remove save and close button, and
         * apply changes buttons.
         */
        protected getToolbarButtons(): Serenity.ToolButton[];
        /**
         * This method is a good place to update states of
         * interface elements. It is called after dialog
         * is initialized and an entity is loaded into dialog.
         * This is also called in new item mode.
         */
        protected updateInterface(): void;
        /**
         * This method is called when dialog title needs to be updated.
         * Base class returns something like 'Edit xyz' for edit mode,
         * and 'New xyz' for new record mode.
         *
         * But our dialog is readonly, so we should change it to 'View xyz'
         */
        protected getEntityTitle(): string;
        /**
         * This method is actually the one that calls getEntityTitle()
         * and updates the dialog title. We could do it here too...
         */
        protected updateTitle(): void;
    }
}
declare namespace webNEOC.BasicSamples {
    /**
     * A readonly grid that launches ReadOnlyDialog
     */
    class ReadOnlyGrid extends Northwind.SupplierGrid {
        protected getDialogType(): typeof ReadOnlyDialog;
        constructor(container: JQuery);
        /**
         * Removing add button from grid using its css class
         */
        protected getButtons(): Serenity.ToolButton[];
    }
}
declare namespace webNEOC.BasicSamples {
    class PopulateLinkedDataDialog extends Serenity.EntityDialog<Northwind.OrderRow, any> {
        protected getFormKey(): string;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getNameProperty(): string;
        protected getService(): string;
        protected form: PopulateLinkedDataForm;
        constructor();
        private setCustomerDetails(details);
        /**
         * This dialog will have CSS class "s-PopulateLinkedDataDialog"
         * We are changing it here to "s-OrderDialog", to make it use default OrderDialog styles
         * This has no effect other than looks on populate linked data demonstration
         */
        protected getCssClass(): string;
    }
}
declare namespace webNEOC.BasicSamples {
    /**
     * A subclass of OrderGrid that launches PopulateLinkedDataDialog
     */
    class PopulateLinkedDataGrid extends Northwind.OrderGrid {
        protected getDialogType(): typeof PopulateLinkedDataDialog;
        constructor(container: JQuery);
    }
}
declare namespace webNEOC.BasicSamples {
    /**
     * Our custom order dialog subclass that will have a tab to display and edit selected customer details.
     * With single toolbar for all forms
     */
    class OtherFormOneBarDialog extends Northwind.OrderDialog {
        private customerPropertyGrid;
        private customerForm;
        private customerValidator;
        private selfChange;
        constructor();
        getCustomerID(): number;
        loadEntity(entity: Northwind.OrderRow): void;
        protected saveCustomer(callback: (response: Serenity.SaveResponse) => void, onSuccess?: (response: Serenity.SaveResponse) => void): boolean;
        protected saveOrder(callback: (response: Serenity.SaveResponse) => void): void;
        protected saveAll(callback: (response: Serenity.SaveResponse) => void): void;
        protected save(callback: (response: Serenity.SaveResponse) => void): void;
    }
}
declare namespace webNEOC.BasicSamples {
    /**
     * Subclass of OrderGrid to override dialog type to OtherFormInTabOneBarDialog
     */
    class OtherFormInTabOneBarGrid extends Northwind.OrderGrid {
        protected getDialogType(): typeof OtherFormOneBarDialog;
        constructor(container: JQuery);
    }
}
declare namespace webNEOC.BasicSamples {
    /**
     * Our custom order dialog subclass that will have a tab to display and edit selected customer details.
     */
    class OtherFormInTabDialog extends Northwind.OrderDialog {
        private customerPropertyGrid;
        private customerForm;
        private customerValidator;
        constructor();
        getCustomerID(): number;
        loadEntity(entity: Northwind.OrderRow): void;
    }
}
declare namespace webNEOC.BasicSamples {
    /**
     * Subclass of OrderGrid to override dialog type to OtherFormInTabDialog
     */
    class OtherFormInTabGrid extends Northwind.OrderGrid {
        protected getDialogType(): typeof OtherFormInTabDialog;
        constructor(container: JQuery);
    }
}
declare namespace webNEOC.BasicSamples {
    /**
     * Styling for columns is done with CSS in site.basicsamples.less file.
     * When comparing this to MultiColumnDialog sample, you may notice that
     * this version requires much less JS and CSS code.
     */
    class MultiColumnResponsiveDialog extends Northwind.OrderDialog {
        constructor();
    }
}
declare namespace webNEOC.BasicSamples {
    /**
     * Subclass of OrderGrid to override dialog type to MultiColumnResponsiveDialog
     */
    class MultiColumnResponsiveGrid extends Northwind.OrderGrid {
        protected getDialogType(): typeof MultiColumnResponsiveDialog;
        constructor(container: JQuery);
    }
}
declare namespace webNEOC.BasicSamples {
    class GetInsertedRecordIdDialog extends Northwind.CategoryDialog {
        /**
         * This method is called after the save request to service
         * is completed succesfully. This can be an insert or update.
         *
         * @param response Response that is returned from server
         */
        protected onSaveSuccess(response: Serenity.SaveResponse): void;
    }
}
declare namespace webNEOC.BasicSamples {
    /**
     * Subclass of CategoryGrid to override dialog type to GetInsertedRecordIdDialog
     */
    class GetInsertedRecordIdGrid extends Northwind.CategoryGrid {
        protected getDialogType(): typeof GetInsertedRecordIdDialog;
        constructor(container: JQuery);
    }
}
declare namespace webNEOC.BasicSamples {
    /**
     * A version of order dialog converted to a panel by adding Serenity.Decorators.panel decorator.
     */
    class EntityDialogAsPanel extends Northwind.OrderDialog {
        constructor();
        protected updateInterface(): void;
        protected onSaveSuccess(response: any): void;
    }
}
declare namespace webNEOC.BasicSamples.DialogBoxes {
    function initializePage(): void;
}
declare namespace webNEOC.BasicSamples {
    class DefaultValuesInNewGrid extends Northwind.OrderGrid {
        constructor(container: JQuery);
        /**
         * This method is called when New Item button is clicked.
         * By default, it calls EditItem with an empty entity.
         * This is a good place to fill in default values for New Item button.
         */
        protected addButtonClick(): void;
        protected getButtons(): Serenity.ToolButton[];
    }
}
declare namespace webNEOC.BasicSamples {
    class CloneableEntityDialog extends Northwind.ProductDialog {
        protected updateInterface(): void;
        /**
         * Overriding this method is optional to customize cloned entity
         */
        protected getCloningEntity(): Northwind.ProductRow;
    }
}
declare namespace webNEOC.BasicSamples {
    /**
     * Subclass of ProductGrid to override dialog type to CloneableEntityDialog
     */
    class CloneableEntityGrid extends Northwind.ProductGrid {
        protected getDialogType(): typeof CloneableEntityDialog;
        constructor(container: JQuery);
    }
}
declare var Morris: any;
declare namespace webNEOC.BasicSamples {
    class ChartInDialog extends Serenity.TemplatedDialog<any> {
        private areaChart;
        static initializePage(): void;
        protected onDialogOpen(): void;
        protected arrange(): void;
        protected getTemplate(): string;
        protected getDialogOptions(): JQueryUI.DialogOptions;
    }
}
declare namespace webNEOC.Administration {
    class RoleCheckEditor extends Serenity.CheckTreeEditor<Serenity.CheckTreeItem<any>, any> {
        private searchText;
        constructor(div: JQuery);
        protected createToolbarExtensions(): void;
        protected getButtons(): any[];
        protected getTreeItems(): Serenity.CheckTreeItem<any>[];
        protected onViewFilter(item: any): boolean;
    }
}
declare namespace webNEOC.Administration {
    class UserRoleDialog extends Serenity.TemplatedDialog<UserRoleDialogOptions> {
        private permissions;
        constructor(opt: UserRoleDialogOptions);
        protected getDialogOptions(): JQueryUI.DialogOptions;
        protected getTemplate(): string;
    }
    interface UserRoleDialogOptions {
        userID: number;
        username: string;
    }
}
declare namespace webNEOC.Administration {
    class PermissionCheckEditor extends Serenity.DataGrid<PermissionCheckItem, PermissionCheckEditorOptions> {
        protected getIdProperty(): string;
        private searchText;
        private byParentKey;
        constructor(container: JQuery, opt: PermissionCheckEditorOptions);
        private getItemGrantRevokeClass(item, grant);
        private roleOrImplicit(key);
        private getItemEffectiveClass(item);
        protected getColumns(): Slick.Column[];
        setItems(items: PermissionCheckItem[]): void;
        protected onViewSubmit(): boolean;
        protected onViewFilter(item: PermissionCheckItem): boolean;
        private matchContains(item);
        private getDescendants(item, excludeGroups);
        protected onClick(e: any, row: any, cell: any): void;
        private getParentKey(key);
        protected getButtons(): Serenity.ToolButton[];
        protected createToolbarExtensions(): void;
        private getSortedGroupAndPermissionKeys(titleByKey);
        value: UserPermissionRow[];
        private _rolePermissions;
        rolePermissions: string[];
        private _implicitPermissions;
        implicitPermissions: Q.Dictionary<string[]>;
    }
    interface PermissionCheckEditorOptions {
        showRevoke?: boolean;
    }
    interface PermissionCheckItem {
        ParentKey?: string;
        Key?: string;
        Title?: string;
        IsGroup?: boolean;
        GrantRevoke?: boolean;
    }
}
declare namespace webNEOC.Administration {
    class UserPermissionDialog extends Serenity.TemplatedDialog<UserPermissionDialogOptions> {
        private permissions;
        constructor(opt: UserPermissionDialogOptions);
        protected getDialogOptions(): JQueryUI.DialogOptions;
        protected getTemplate(): string;
    }
    interface UserPermissionDialogOptions {
        userID?: number;
        username?: string;
    }
}
declare namespace webNEOC.Administration {
    class UserDialog extends Serenity.EntityDialog<UserRow, any> {
        protected getFormKey(): string;
        protected getIdProperty(): string;
        protected getIsActiveProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getNameProperty(): string;
        protected getService(): string;
        protected form: UserForm;
        constructor();
        protected getToolbarButtons(): Serenity.ToolButton[];
        protected updateInterface(): void;
        protected afterLoadEntity(): void;
        protected getPropertyItems(): Serenity.PropertyItem[];
    }
}
declare namespace webNEOC.Administration {
    class UserGrid extends Serenity.EntityGrid<UserRow, any> {
        protected getColumnsKey(): string;
        protected getDialogType(): typeof UserDialog;
        protected getIdProperty(): string;
        protected getIsActiveProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getService(): string;
        constructor(container: JQuery);
        protected getDefaultSortBy(): string[];
    }
}
declare namespace webNEOC.Authorization {
    let userDefinition: ScriptUserDefinition;
    function hasPermission(permissionKey: string): boolean;
}
declare namespace webNEOC.Administration {
    class TranslationGrid extends Serenity.EntityGrid<TranslationItem, any> {
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getService(): string;
        private hasChanges;
        private searchText;
        private sourceLanguage;
        private targetLanguage;
        private targetLanguageKey;
        constructor(container: JQuery);
        protected onClick(e: JQueryEventObject, row: number, cell: number): any;
        protected getColumns(): Slick.Column[];
        protected createToolbarExtensions(): void;
        protected saveChanges(language: string): PromiseLike<any>;
        protected onViewSubmit(): boolean;
        protected getButtons(): Serenity.ToolButton[];
        protected createQuickSearchInput(): void;
        protected onViewFilter(item: TranslationItem): boolean;
        protected usePager(): boolean;
    }
}
declare namespace MultiTenancy.Administration {
    class TenantDialog extends Serenity.EntityDialog<TenantRow, any> {
        protected getFormKey(): string;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getNameProperty(): string;
        protected getService(): string;
        protected form: TenantForm;
    }
}
declare namespace MultiTenancy.Administration {
    class TenantGrid extends Serenity.EntityGrid<TenantRow, any> {
        protected getColumnsKey(): string;
        protected getDialogType(): typeof TenantDialog;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getService(): string;
        constructor(container: JQuery);
    }
}
declare namespace webNEOC.Administration {
    class RolePermissionDialog extends Serenity.TemplatedDialog<RolePermissionDialogOptions> {
        private permissions;
        constructor(opt: RolePermissionDialogOptions);
        protected getDialogOptions(): JQueryUI.DialogOptions;
        protected getTemplate(): string;
    }
    interface RolePermissionDialogOptions {
        roleID?: number;
        title?: string;
    }
}
declare namespace webNEOC.Administration {
    class RoleDialog extends Serenity.EntityDialog<RoleRow, any> {
        protected getFormKey(): string;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getNameProperty(): string;
        protected getService(): string;
        protected form: RoleForm;
        protected getToolbarButtons(): Serenity.ToolButton[];
        protected updateInterface(): void;
    }
}
declare namespace webNEOC.Administration {
    class RoleGrid extends Serenity.EntityGrid<RoleRow, any> {
        protected getColumnsKey(): string;
        protected getDialogType(): typeof RoleDialog;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getService(): string;
        constructor(container: JQuery);
        protected getDefaultSortBy(): string[];
    }
}
declare namespace webNEOC.Administration {
    class LanguageDialog extends Serenity.EntityDialog<LanguageRow, any> {
        protected getFormKey(): string;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getNameProperty(): string;
        protected getService(): string;
        protected form: LanguageForm;
    }
}
declare namespace webNEOC.Administration {
    class LanguageGrid extends Serenity.EntityGrid<LanguageRow, any> {
        protected getColumnsKey(): string;
        protected getDialogType(): typeof LanguageDialog;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getService(): string;
        constructor(container: JQuery);
        protected getDefaultSortBy(): string[];
    }
}
declare namespace webNEOC.Administration {
}
declare namespace webNEOC.Administration {
    class LanguageForm extends Serenity.PrefixedContext {
        static formKey: string;
    }
    interface LanguageForm {
        LanguageId: Serenity.StringEditor;
        LanguageName: Serenity.StringEditor;
    }
}
declare namespace webNEOC.Administration {
    interface LanguageRow {
        Id?: number;
        LanguageId?: string;
        LanguageName?: string;
    }
    namespace LanguageRow {
        const idProperty = "Id";
        const nameProperty = "LanguageName";
        const localTextPrefix = "Administration.Language";
        const lookupKey = "Administration.Language";
        function getLookup(): Q.Lookup<LanguageRow>;
        namespace Fields {
            const Id: string;
            const LanguageId: string;
            const LanguageName: string;
        }
    }
}
declare namespace webNEOC.Administration {
    namespace LanguageService {
        const baseUrl = "Administration/Language";
        function Create(request: Serenity.SaveRequest<LanguageRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<LanguageRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<LanguageRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<LanguageRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        namespace Methods {
            const Create: string;
            const Update: string;
            const Delete: string;
            const Retrieve: string;
            const List: string;
        }
    }
}
declare namespace webNEOC.Administration {
}
declare namespace webNEOC.Administration {
    class RoleForm extends Serenity.PrefixedContext {
        static formKey: string;
    }
    interface RoleForm {
        RoleName: Serenity.StringEditor;
    }
}
declare namespace webNEOC.Administration {
    interface RolePermissionListRequest extends Serenity.ServiceRequest {
        RoleID?: number;
        Module?: string;
        Submodule?: string;
    }
}
declare namespace webNEOC.Administration {
    interface RolePermissionListResponse extends Serenity.ListResponse<string> {
    }
}
declare namespace webNEOC.Administration {
    interface RolePermissionRow {
        RolePermissionId?: number;
        RoleId?: number;
        PermissionKey?: string;
        RoleRoleName?: string;
    }
    namespace RolePermissionRow {
        const idProperty = "RolePermissionId";
        const nameProperty = "PermissionKey";
        const localTextPrefix = "Administration.RolePermission";
        namespace Fields {
            const RolePermissionId: string;
            const RoleId: string;
            const PermissionKey: string;
            const RoleRoleName: string;
        }
    }
}
declare namespace webNEOC.Administration {
    namespace RolePermissionService {
        const baseUrl = "Administration/RolePermission";
        function Update(request: RolePermissionUpdateRequest, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: RolePermissionListRequest, onSuccess?: (response: RolePermissionListResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        namespace Methods {
            const Update: string;
            const List: string;
        }
    }
}
declare namespace webNEOC.Administration {
    interface RolePermissionUpdateRequest extends Serenity.ServiceRequest {
        RoleID?: number;
        Module?: string;
        Submodule?: string;
        Permissions?: string[];
    }
}
declare namespace webNEOC.Administration {
    interface RoleRow {
        RoleId?: number;
        RoleName?: string;
        TenantId?: number;
    }
    namespace RoleRow {
        const idProperty = "RoleId";
        const nameProperty = "RoleName";
        const localTextPrefix = "Administration.Role";
        const lookupKey = "Administration.Role";
        function getLookup(): Q.Lookup<RoleRow>;
        namespace Fields {
            const RoleId: string;
            const RoleName: string;
            const TenantId: string;
        }
    }
}
declare namespace webNEOC.Administration {
    namespace RoleService {
        const baseUrl = "Administration/Role";
        function Create(request: Serenity.SaveRequest<RoleRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<RoleRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<RoleRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<RoleRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        namespace Methods {
            const Create: string;
            const Update: string;
            const Delete: string;
            const Retrieve: string;
            const List: string;
        }
    }
}
declare namespace webNEOC.Administration {
    class TenantsForm extends Serenity.PrefixedContext {
        static formKey: string;
    }
    interface TenantsForm {
        TenantName: Serenity.StringEditor;
    }
}
declare namespace webNEOC.Administration {
    interface TenantsRow {
        TenantId?: number;
        TenantName?: string;
    }
    namespace TenantsRow {
        const idProperty = "TenantId";
        const nameProperty = "TenantName";
        const localTextPrefix = "Administration.Tenants";
        namespace Fields {
            const TenantId: any;
            const TenantName: any;
        }
    }
}
declare namespace webNEOC.Administration {
    namespace TenantsService {
        const baseUrl = "Administration/Tenants";
        function Create(request: Serenity.SaveRequest<TenantsRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Serenity.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<TenantsRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Serenity.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Serenity.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<TenantsRow>) => void, opt?: Serenity.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<TenantsRow>) => void, opt?: Serenity.ServiceOptions<any>): JQueryXHR;
        namespace Methods {
            const Create: string;
            const Update: string;
            const Delete: string;
            const Retrieve: string;
            const List: string;
        }
    }
}
declare namespace webNEOC.Administration {
    interface TranslationItem {
        Key?: string;
        SourceText?: string;
        TargetText?: string;
        CustomText?: string;
    }
}
declare namespace webNEOC.Administration {
    interface TranslationListRequest extends Serenity.ListRequest {
        SourceLanguageID?: string;
        TargetLanguageID?: string;
    }
}
declare namespace webNEOC.Administration {
    namespace TranslationService {
        const baseUrl = "Administration/Translation";
        function List(request: TranslationListRequest, onSuccess?: (response: Serenity.ListResponse<TranslationItem>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: TranslationUpdateRequest, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        namespace Methods {
            const List: string;
            const Update: string;
        }
    }
}
declare namespace webNEOC.Administration {
    interface TranslationUpdateRequest extends Serenity.ServiceRequest {
        TargetLanguageID?: string;
        Translations?: {
            [key: string]: string;
        };
    }
}
declare namespace webNEOC.Administration {
}
declare namespace webNEOC.Administration {
    class UserForm extends Serenity.PrefixedContext {
        static formKey: string;
    }
    interface UserForm {
        Username: Serenity.StringEditor;
        DisplayName: Serenity.StringEditor;
        Email: Serenity.EmailEditor;
        UserImage: Serenity.ImageUploadEditor;
        Password: Serenity.PasswordEditor;
        PasswordConfirm: Serenity.PasswordEditor;
        Source: Serenity.StringEditor;
        TenantId: Serenity.LookupEditor;
    }
}
declare namespace webNEOC.Administration {
    interface UserPermissionListRequest extends Serenity.ServiceRequest {
        UserID?: number;
        Module?: string;
        Submodule?: string;
    }
}
declare namespace webNEOC.Administration {
    interface UserPermissionRow {
        UserPermissionId?: number;
        UserId?: number;
        PermissionKey?: string;
        Granted?: boolean;
        Username?: string;
        User?: string;
    }
    namespace UserPermissionRow {
        const idProperty = "UserPermissionId";
        const nameProperty = "PermissionKey";
        const localTextPrefix = "Administration.UserPermission";
        namespace Fields {
            const UserPermissionId: string;
            const UserId: string;
            const PermissionKey: string;
            const Granted: string;
            const Username: string;
            const User: string;
        }
    }
}
declare namespace webNEOC.Administration {
    namespace UserPermissionService {
        const baseUrl = "Administration/UserPermission";
        function Update(request: UserPermissionUpdateRequest, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: UserPermissionListRequest, onSuccess?: (response: Serenity.ListResponse<UserPermissionRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function ListRolePermissions(request: UserPermissionListRequest, onSuccess?: (response: Serenity.ListResponse<string>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function ListPermissionKeys(request: Serenity.ServiceRequest, onSuccess?: (response: Serenity.ListResponse<string>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        namespace Methods {
            const Update: string;
            const List: string;
            const ListRolePermissions: string;
            const ListPermissionKeys: string;
        }
    }
}
declare namespace webNEOC.Administration {
    interface UserPermissionUpdateRequest extends Serenity.ServiceRequest {
        UserID?: number;
        Module?: string;
        Submodule?: string;
        Permissions?: UserPermissionRow[];
    }
}
declare namespace webNEOC.Administration {
    interface UserRoleListRequest extends Serenity.ServiceRequest {
        UserID?: number;
    }
}
declare namespace webNEOC.Administration {
    interface UserRoleListResponse extends Serenity.ListResponse<number> {
    }
}
declare namespace webNEOC.Administration {
    interface UserRoleRow {
        UserRoleId?: number;
        UserId?: number;
        RoleId?: number;
        Username?: string;
        User?: string;
    }
    namespace UserRoleRow {
        const idProperty = "UserRoleId";
        const localTextPrefix = "Administration.UserRole";
        namespace Fields {
            const UserRoleId: string;
            const UserId: string;
            const RoleId: string;
            const Username: string;
            const User: string;
        }
    }
}
declare namespace webNEOC.Administration {
    namespace UserRoleService {
        const baseUrl = "Administration/UserRole";
        function Update(request: UserRoleUpdateRequest, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: UserRoleListRequest, onSuccess?: (response: UserRoleListResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        namespace Methods {
            const Update: string;
            const List: string;
        }
    }
}
declare namespace webNEOC.Administration {
    interface UserRoleUpdateRequest extends Serenity.ServiceRequest {
        UserID?: number;
        Roles?: number[];
    }
}
declare namespace webNEOC.Administration {
    interface UserRow {
        UserId?: number;
        Username?: string;
        Source?: string;
        PasswordHash?: string;
        PasswordSalt?: string;
        DisplayName?: string;
        Email?: string;
        UserImage?: string;
        LastDirectoryUpdate?: string;
        IsActive?: number;
        Password?: string;
        PasswordConfirm?: string;
        TenantId?: number;
        TenantName?: string;
        InsertUserId?: number;
        InsertDate?: string;
        UpdateUserId?: number;
        UpdateDate?: string;
    }
    namespace UserRow {
        const idProperty = "UserId";
        const isActiveProperty = "IsActive";
        const nameProperty = "Username";
        const localTextPrefix = "Administration.User";
        const lookupKey = "Administration.User";
        function getLookup(): Q.Lookup<UserRow>;
        namespace Fields {
            const UserId: string;
            const Username: string;
            const Source: string;
            const PasswordHash: string;
            const PasswordSalt: string;
            const DisplayName: string;
            const Email: string;
            const UserImage: string;
            const LastDirectoryUpdate: string;
            const IsActive: string;
            const Password: string;
            const PasswordConfirm: string;
            const TenantId: string;
            const TenantName: string;
            const InsertUserId: string;
            const InsertDate: string;
            const UpdateUserId: string;
            const UpdateDate: string;
        }
    }
}
declare namespace webNEOC.Administration {
    namespace UserService {
        const baseUrl = "Administration/User";
        function Create(request: Serenity.SaveRequest<UserRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<UserRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Undelete(request: Serenity.UndeleteRequest, onSuccess?: (response: Serenity.UndeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<UserRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<UserRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        namespace Methods {
            const Create: string;
            const Update: string;
            const Delete: string;
            const Undelete: string;
            const Retrieve: string;
            const List: string;
        }
    }
}
declare namespace webNEOC.BasicSamples {
    namespace BasicSamplesService {
        const baseUrl = "BasicSamples/BasicSamples";
        function OrdersByShipper(request: OrdersByShipperRequest, onSuccess?: (response: OrdersByShipperResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function OrderBulkAction(request: OrderBulkActionRequest, onSuccess?: (response: Serenity.ServiceResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        namespace Methods {
            const OrdersByShipper: string;
            const OrderBulkAction: string;
        }
    }
}
declare namespace webNEOC.BasicSamples {
    class ChangingLookupTextForm extends Serenity.PrefixedContext {
        static formKey: string;
    }
    interface ChangingLookupTextForm {
        ProductID: ChangingLookupTextEditor;
        UnitPrice: Serenity.DecimalEditor;
        Quantity: Serenity.IntegerEditor;
        Discount: Serenity.DecimalEditor;
    }
}
declare namespace webNEOC.BasicSamples {
}
declare namespace webNEOC.BasicSamples {
    interface CustomerGrossSalesListRequest extends Serenity.ListRequest {
        StartDate?: string;
        EndDate?: string;
    }
}
declare namespace webNEOC.BasicSamples {
    namespace CustomerGrossSalesService {
        const baseUrl = "BasicSamples/CustomerGrossSales";
        function List(request: CustomerGrossSalesListRequest, onSuccess?: (response: Serenity.ListResponse<Northwind.CustomerGrossSalesRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        namespace Methods {
            const List: string;
        }
    }
}
declare namespace webNEOC.BasicSamples {
}
declare namespace webNEOC.BasicSamples {
    class DragDropSampleForm extends Serenity.PrefixedContext {
        static formKey: string;
    }
    interface DragDropSampleForm {
        Title: Serenity.StringEditor;
    }
}
declare namespace webNEOC.BasicSamples {
    interface DragDropSampleRow {
        Id?: number;
        ParentId?: number;
        Title?: string;
    }
    namespace DragDropSampleRow {
        const idProperty = "Id";
        const nameProperty = "Title";
        const localTextPrefix = "BasicSamples.DragDropSample";
        namespace Fields {
            const Id: string;
            const ParentId: string;
            const Title: string;
        }
    }
}
declare namespace webNEOC.BasicSamples {
    namespace DragDropSampleService {
        const baseUrl = "BasicSamples/DragDropSample";
        function Create(request: Serenity.SaveRequest<DragDropSampleRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<DragDropSampleRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<DragDropSampleRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<DragDropSampleRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        namespace Methods {
            const Create: string;
            const Update: string;
            const Delete: string;
            const Retrieve: string;
            const List: string;
        }
    }
}
declare namespace webNEOC.BasicSamples {
    class FilteredLookupInDetailForm extends Serenity.PrefixedContext {
        static formKey: string;
    }
    interface FilteredLookupInDetailForm {
        CustomerID: Northwind.CustomerEditor;
        OrderDate: Serenity.DateEditor;
        CategoryID: Serenity.LookupEditor;
        DetailList: FilteredLookupDetailEditor;
    }
}
declare namespace webNEOC.BasicSamples {
    class HardcodedValuesForm extends Serenity.PrefixedContext {
        static formKey: string;
    }
    interface HardcodedValuesForm {
        SomeValue: HardcodedValuesEditor;
    }
}
declare namespace webNEOC.BasicSamples {
}
declare namespace webNEOC.BasicSamples {
    class LookupFilterByMultipleForm extends Serenity.PrefixedContext {
        static formKey: string;
    }
    interface LookupFilterByMultipleForm {
        ProductName: Serenity.StringEditor;
        ProductImage: Serenity.ImageUploadEditor;
        Discontinued: Serenity.BooleanEditor;
        SupplierID: Serenity.LookupEditor;
        CategoryID: ProduceSeafoodCategoryEditor;
        QuantityPerUnit: Serenity.StringEditor;
        UnitPrice: Serenity.DecimalEditor;
        UnitsInStock: Serenity.IntegerEditor;
        UnitsOnOrder: Serenity.IntegerEditor;
        ReorderLevel: Serenity.IntegerEditor;
    }
}
declare namespace webNEOC.BasicSamples {
    interface OrderBulkActionRequest extends Serenity.ServiceRequest {
        OrderIDs?: number[];
    }
}
declare namespace webNEOC.BasicSamples {
    interface OrdersByShipperRequest extends Serenity.ServiceRequest {
    }
}
declare namespace webNEOC.BasicSamples {
    interface OrdersByShipperResponse extends Serenity.ServiceResponse {
        Values?: {
            [key: string]: any;
        }[];
        ShipperKeys?: string[];
        ShipperLabels?: string[];
    }
}
declare namespace webNEOC.BasicSamples {
    class PopulateLinkedDataForm extends Serenity.PrefixedContext {
        static formKey: string;
    }
    interface PopulateLinkedDataForm {
        CustomerID: Northwind.CustomerEditor;
        CustomerContactName: Serenity.StringEditor;
        CustomerContactTitle: Serenity.StringEditor;
        CustomerCity: Serenity.StringEditor;
        CustomerRegion: Serenity.StringEditor;
        CustomerCountry: Serenity.StringEditor;
        CustomerPhone: Serenity.StringEditor;
        CustomerFax: Serenity.StringEditor;
        OrderDate: Serenity.DateEditor;
        RequiredDate: Serenity.DateEditor;
        EmployeeID: Serenity.LookupEditor;
        DetailList: Northwind.OrderDetailsEditor;
    }
}
declare namespace webNEOC.BasicSamples {
    class ProductExcelImportForm extends Serenity.PrefixedContext {
        static formKey: string;
    }
    interface ProductExcelImportForm {
        FileName: Serenity.ImageUploadEditor;
    }
}
declare namespace webNEOC.BasicSamples {
    namespace ProductExcelImportService {
        const baseUrl = "BasicSamples/ProductExcelImport";
        function ExcelImport(request: ExcelImportRequest, onSuccess?: (response: ExcelImportResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        namespace Methods {
            const ExcelImport: string;
        }
    }
}
declare namespace webNEOC.BasicSamples {
    class StaticTextBlockForm extends Serenity.PrefixedContext {
        static formKey: string;
    }
    interface StaticTextBlockForm {
        StaticText: StaticTextBlock;
        SomeInput: Serenity.StringEditor;
        HtmlList: StaticTextBlock;
        FromLocalText: StaticTextBlock;
        DisplayFieldValue: StaticTextBlock;
    }
}
declare namespace webNEOC.BasicSamples {
}
declare namespace webNEOC.BasicSamples {
    interface VSGalleryQAPost {
        PostId?: number;
        PostedOn?: string;
        PostedByName?: string;
        PostedByUserId?: string;
        Message?: string;
    }
}
declare namespace webNEOC.BasicSamples {
    namespace VSGalleryQAService {
        const baseUrl = "BasicSamples/VSGalleryQA";
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<VSGalleryQAThread>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        namespace Methods {
            const List: string;
        }
    }
}
declare namespace webNEOC.BasicSamples {
    interface VSGalleryQAThread {
        ThreadId?: number;
        Title?: string;
        StartedOn?: string;
        StartedByName?: string;
        StartedByUserId?: string;
        LastPostOn?: string;
        PostCount?: number;
        Posts?: VSGalleryQAPost[];
    }
}
declare namespace webNEOC.Campaign {
}
declare namespace webNEOC.Campaign {
    class AdminDataForm extends Serenity.PrefixedContext {
        static formKey: string;
    }
    interface AdminDataForm {
        RoundId: Serenity.IntegerEditor;
        DistrictId: Serenity.IntegerEditor;
        ClusterId: Serenity.StringEditor;
        DateOfCampaign: Serenity.DateEditor;
        PemtremtManager: Serenity.StringEditor;
        TeamNo: Serenity.StringEditor;
        D1VialsRecieved: Serenity.IntegerEditor;
        D1VialsReturned: Serenity.IntegerEditor;
        D1VaccByTransit: Serenity.IntegerEditor;
        D1NoOfHhsVisited: Serenity.IntegerEditor;
        D1Ch05resident: Serenity.IntegerEditor;
        D1Ch05guest: Serenity.IntegerEditor;
        D1Ch05VaccInHouse: Serenity.IntegerEditor;
        D1Ch05VaccOutHouse: Serenity.IntegerEditor;
        D1Ch05NomadVacc: Serenity.IntegerEditor;
        D1AbsentRecordDuring: Serenity.IntegerEditor;
        D1AbsentFoundVaccDuring: Serenity.IntegerEditor;
        D1AbsentVaccDuring: Serenity.IntegerEditor;
        D1AbsentRemainDuring: Serenity.IntegerEditor;
        D1AbsentRecordAfter: Serenity.IntegerEditor;
        D1AbsentFoundVaccAfter: Serenity.IntegerEditor;
        D1AbsentVaccAfter: Serenity.IntegerEditor;
        D1AbsentRemainAfter: Serenity.IntegerEditor;
        D1NssRecord: Serenity.IntegerEditor;
        D1NssFoundVacc: Serenity.IntegerEditor;
        D1NssVaccinated: Serenity.IntegerEditor;
        D1NssReamining: Serenity.IntegerEditor;
        D1RefusalRecord: Serenity.IntegerEditor;
        D1RefusalFoundVacc: Serenity.IntegerEditor;
        D1RefusalVacc: Serenity.IntegerEditor;
        D1RefusalRemaining: Serenity.IntegerEditor;
        D2VialsRecieved: Serenity.IntegerEditor;
        D2VialsReturned: Serenity.IntegerEditor;
        D2VaccByTransit: Serenity.IntegerEditor;
        D2NoOfHhsVisited: Serenity.IntegerEditor;
        D2Ch05resident: Serenity.IntegerEditor;
        D2Ch05guest: Serenity.IntegerEditor;
        D2Ch05VaccInHouse: Serenity.IntegerEditor;
        D2Ch05VaccOutHouse: Serenity.IntegerEditor;
        D2Ch05NomadVacc: Serenity.IntegerEditor;
        D2AbsentRecordDuring: Serenity.IntegerEditor;
        D2AbsentFoundVaccDuring: Serenity.IntegerEditor;
        D2AbsentVaccDuring: Serenity.IntegerEditor;
        D2AbsentRemainDuring: Serenity.IntegerEditor;
        D2AbsentRecordAfter: Serenity.IntegerEditor;
        D2AbsentFoundVaccAfter: Serenity.IntegerEditor;
        D2AbsentVaccAfter: Serenity.IntegerEditor;
        D2AbsentRemainAfter: Serenity.IntegerEditor;
        D2NssRecord: Serenity.IntegerEditor;
        D2NssFoundVacc: Serenity.IntegerEditor;
        D2NssVaccinated: Serenity.IntegerEditor;
        D2NssReamining: Serenity.IntegerEditor;
        D2RefusalRecord: Serenity.IntegerEditor;
        D2RefusalFoundVacc: Serenity.IntegerEditor;
        D2RefusalVacc: Serenity.IntegerEditor;
        D2RefusalRemaining: Serenity.IntegerEditor;
        D3VialsRecieved: Serenity.IntegerEditor;
        D3VialsReturned: Serenity.IntegerEditor;
        D3VaccByTransit: Serenity.IntegerEditor;
        D3NoOfHhsVisited: Serenity.IntegerEditor;
        D3Ch05resident: Serenity.IntegerEditor;
        D3Ch05guest: Serenity.IntegerEditor;
        D3Ch05VaccInHouse: Serenity.IntegerEditor;
        D3Ch05VaccOutHouse: Serenity.IntegerEditor;
        D3Ch05NomadVacc: Serenity.IntegerEditor;
        D3AbsentRecordDuring: Serenity.IntegerEditor;
        D3AbsentFoundVaccDuring: Serenity.IntegerEditor;
        D3AbsentVaccDuring: Serenity.IntegerEditor;
        D3AbsentRemainDuring: Serenity.IntegerEditor;
        D3AbsentRecordAfter: Serenity.IntegerEditor;
        D3AbsentFoundVaccAfter: Serenity.IntegerEditor;
        D3AbsentVaccAfter: Serenity.IntegerEditor;
        D3AbsentRemainAfter: Serenity.IntegerEditor;
        D3NssRecord: Serenity.IntegerEditor;
        D3NssFoundVacc: Serenity.IntegerEditor;
        D3NssVaccinated: Serenity.IntegerEditor;
        D3NssReamining: Serenity.IntegerEditor;
        D3RefusalRecord: Serenity.IntegerEditor;
        D3RefusalFoundVacc: Serenity.IntegerEditor;
        D3RefusalVacc: Serenity.IntegerEditor;
        D3RefusalRemaining: Serenity.IntegerEditor;
        D5VialsRecieved: Serenity.IntegerEditor;
        D5VialsReturned: Serenity.IntegerEditor;
        D5RemainAbsentDuring: Serenity.IntegerEditor;
        D5AbsentFoundVaccDuring5: Serenity.IntegerEditor;
        D5AbsentVaccDuring5: Serenity.IntegerEditor;
        D5AbsentRemainDuring5: Serenity.IntegerEditor;
        D5RemainAbsentAfter: Serenity.IntegerEditor;
        D5AbsentFoundVaccAfter5: Serenity.IntegerEditor;
        D5AbsentVaccAfter5: Serenity.IntegerEditor;
        D5AbsentRemainAfter5: Serenity.IntegerEditor;
        D5RemainNss: Serenity.IntegerEditor;
        D5FoundVaccNss5: Serenity.IntegerEditor;
        D5VaccNss5: Serenity.IntegerEditor;
        D5RemainNss5: Serenity.IntegerEditor;
        D5RemainRefusal: Serenity.IntegerEditor;
        D5FoundVaccRefusal5: Serenity.IntegerEditor;
        D5VaccRefusal5: Serenity.IntegerEditor;
        D5RemainRefusal5: Serenity.IntegerEditor;
        D5VaccOutofHouse: Serenity.IntegerEditor;
    }
}
declare namespace webNEOC.Campaign {
    interface AdminDataRow {
        AdminDataId?: number;
        RoundId?: number;
        DistrictId?: number;
        ClusterId?: number;
        DateOfCampaign?: string;
        PemtremtManager?: string;
        TeamNo?: string;
        D1VialsRecieved?: number;
        D1VialsReturned?: number;
        D1VaccByTransit?: number;
        D1NoOfHhsVisited?: number;
        D1Ch05resident?: number;
        D1Ch05guest?: number;
        D1Ch05VaccInHouse?: number;
        D1Ch05VaccOutHouse?: number;
        D1Ch05NomadVacc?: number;
        D1AbsentRecordDuring?: number;
        D1AbsentFoundVaccDuring?: number;
        D1AbsentVaccDuring?: number;
        D1AbsentRemainDuring?: number;
        D1AbsentRecordAfter?: number;
        D1AbsentFoundVaccAfter?: number;
        D1AbsentVaccAfter?: number;
        D1AbsentRemainAfter?: number;
        D1NssRecord?: number;
        D1NssFoundVacc?: number;
        D1NssVaccinated?: number;
        D1NssReamining?: number;
        D1RefusalRecord?: number;
        D1RefusalFoundVacc?: number;
        D1RefusalVacc?: number;
        D1RefusalRemaining?: number;
        D2VialsRecieved?: number;
        D2VialsReturned?: number;
        D2VaccByTransit?: number;
        D2NoOfHhsVisited?: number;
        D2Ch05resident?: number;
        D2Ch05guest?: number;
        D2Ch05VaccInHouse?: number;
        D2Ch05VaccOutHouse?: number;
        D2Ch05NomadVacc?: number;
        D2AbsentRecordDuring?: number;
        D2AbsentFoundVaccDuring?: number;
        D2AbsentVaccDuring?: number;
        D2AbsentRemainDuring?: number;
        D2AbsentRecordAfter?: number;
        D2AbsentFoundVaccAfter?: number;
        D2AbsentVaccAfter?: number;
        D2AbsentRemainAfter?: number;
        D2NssRecord?: number;
        D2NssFoundVacc?: number;
        D2NssVaccinated?: number;
        D2NssReamining?: number;
        D2RefusalRecord?: number;
        D2RefusalFoundVacc?: number;
        D2RefusalVacc?: number;
        D2RefusalRemaining?: number;
        D3VialsRecieved?: number;
        D3VialsReturned?: number;
        D3VaccByTransit?: number;
        D3NoOfHhsVisited?: number;
        D3Ch05resident?: number;
        D3Ch05guest?: number;
        D3Ch05VaccInHouse?: number;
        D3Ch05VaccOutHouse?: number;
        D3Ch05NomadVacc?: number;
        D3AbsentRecordDuring?: number;
        D3AbsentFoundVaccDuring?: number;
        D3AbsentVaccDuring?: number;
        D3AbsentRemainDuring?: number;
        D3AbsentRecordAfter?: number;
        D3AbsentFoundVaccAfter?: number;
        D3AbsentVaccAfter?: number;
        D3AbsentRemainAfter?: number;
        D3NssRecord?: number;
        D3NssFoundVacc?: number;
        D3NssVaccinated?: number;
        D3NssReamining?: number;
        D3RefusalRecord?: number;
        D3RefusalFoundVacc?: number;
        D3RefusalVacc?: number;
        D3RefusalRemaining?: number;
        D5VialsRecieved?: number;
        D5VialsReturned?: number;
        D5RemainAbsentDuring?: number;
        D5AbsentFoundVaccDuring5?: number;
        D5AbsentVaccDuring5?: number;
        D5AbsentRemainDuring5?: number;
        D5RemainAbsentAfter?: number;
        D5AbsentFoundVaccAfter5?: number;
        D5AbsentVaccAfter5?: number;
        D5AbsentRemainAfter5?: number;
        D5RemainNss?: number;
        D5FoundVaccNss5?: number;
        D5VaccNss5?: number;
        D5RemainNss5?: number;
        D5RemainRefusal?: number;
        D5FoundVaccRefusal5?: number;
        D5VaccRefusal5?: number;
        D5RemainRefusal5?: number;
        D5VaccOutofHouse?: number;
        DistrictDcode?: string;
        DistrictProvinceId?: number;
        DistrictDname?: string;
        Round?: string;
        Cluster?: string;
        Province?: string;
        TenantId?: number;
        UniqueId?: string;
    }
    namespace AdminDataRow {
        const idProperty = "AdminDataId";
        const nameProperty = "UniqueId";
        const localTextPrefix = "Campaign.AdminData";
        namespace Fields {
            const AdminDataId: string;
            const RoundId: string;
            const DistrictId: string;
            const ClusterId: string;
            const DateOfCampaign: string;
            const PemtremtManager: string;
            const TeamNo: string;
            const D1VialsRecieved: string;
            const D1VialsReturned: string;
            const D1VaccByTransit: string;
            const D1NoOfHhsVisited: string;
            const D1Ch05resident: string;
            const D1Ch05guest: string;
            const D1Ch05VaccInHouse: string;
            const D1Ch05VaccOutHouse: string;
            const D1Ch05NomadVacc: string;
            const D1AbsentRecordDuring: string;
            const D1AbsentFoundVaccDuring: string;
            const D1AbsentVaccDuring: string;
            const D1AbsentRemainDuring: string;
            const D1AbsentRecordAfter: string;
            const D1AbsentFoundVaccAfter: string;
            const D1AbsentVaccAfter: string;
            const D1AbsentRemainAfter: string;
            const D1NssRecord: string;
            const D1NssFoundVacc: string;
            const D1NssVaccinated: string;
            const D1NssReamining: string;
            const D1RefusalRecord: string;
            const D1RefusalFoundVacc: string;
            const D1RefusalVacc: string;
            const D1RefusalRemaining: string;
            const D2VialsRecieved: string;
            const D2VialsReturned: string;
            const D2VaccByTransit: string;
            const D2NoOfHhsVisited: string;
            const D2Ch05resident: string;
            const D2Ch05guest: string;
            const D2Ch05VaccInHouse: string;
            const D2Ch05VaccOutHouse: string;
            const D2Ch05NomadVacc: string;
            const D2AbsentRecordDuring: string;
            const D2AbsentFoundVaccDuring: string;
            const D2AbsentVaccDuring: string;
            const D2AbsentRemainDuring: string;
            const D2AbsentRecordAfter: string;
            const D2AbsentFoundVaccAfter: string;
            const D2AbsentVaccAfter: string;
            const D2AbsentRemainAfter: string;
            const D2NssRecord: string;
            const D2NssFoundVacc: string;
            const D2NssVaccinated: string;
            const D2NssReamining: string;
            const D2RefusalRecord: string;
            const D2RefusalFoundVacc: string;
            const D2RefusalVacc: string;
            const D2RefusalRemaining: string;
            const D3VialsRecieved: string;
            const D3VialsReturned: string;
            const D3VaccByTransit: string;
            const D3NoOfHhsVisited: string;
            const D3Ch05resident: string;
            const D3Ch05guest: string;
            const D3Ch05VaccInHouse: string;
            const D3Ch05VaccOutHouse: string;
            const D3Ch05NomadVacc: string;
            const D3AbsentRecordDuring: string;
            const D3AbsentFoundVaccDuring: string;
            const D3AbsentVaccDuring: string;
            const D3AbsentRemainDuring: string;
            const D3AbsentRecordAfter: string;
            const D3AbsentFoundVaccAfter: string;
            const D3AbsentVaccAfter: string;
            const D3AbsentRemainAfter: string;
            const D3NssRecord: string;
            const D3NssFoundVacc: string;
            const D3NssVaccinated: string;
            const D3NssReamining: string;
            const D3RefusalRecord: string;
            const D3RefusalFoundVacc: string;
            const D3RefusalVacc: string;
            const D3RefusalRemaining: string;
            const D5VialsRecieved: string;
            const D5VialsReturned: string;
            const D5RemainAbsentDuring: string;
            const D5AbsentFoundVaccDuring5: string;
            const D5AbsentVaccDuring5: string;
            const D5AbsentRemainDuring5: string;
            const D5RemainAbsentAfter: string;
            const D5AbsentFoundVaccAfter5: string;
            const D5AbsentVaccAfter5: string;
            const D5AbsentRemainAfter5: string;
            const D5RemainNss: string;
            const D5FoundVaccNss5: string;
            const D5VaccNss5: string;
            const D5RemainNss5: string;
            const D5RemainRefusal: string;
            const D5FoundVaccRefusal5: string;
            const D5VaccRefusal5: string;
            const D5RemainRefusal5: string;
            const D5VaccOutofHouse: string;
            const DistrictDcode: string;
            const DistrictProvinceId: string;
            const DistrictDname: string;
            const Round: string;
            const Cluster: string;
            const Province: string;
            const TenantId: string;
            const UniqueId: string;
        }
    }
}
declare namespace webNEOC.Campaign {
    namespace AdminDataService {
        const baseUrl = "Campaign/AdminData";
        function Create(request: Serenity.SaveRequest<AdminDataRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<AdminDataRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<AdminDataRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<AdminDataRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        namespace Methods {
            const Create: string;
            const Update: string;
            const Delete: string;
            const Retrieve: string;
            const List: string;
        }
    }
}
declare namespace webNEOC.Campaign {
}
declare namespace webNEOC.Campaign {
}
declare namespace webNEOC.Campaign {
    class CampaignDayForm extends Serenity.PrefixedContext {
        static formKey: string;
    }
    interface CampaignDayForm {
        RoundId: Serenity.LookupEditor;
        ProvinceId: Serenity.LookupEditor;
        DistrictId: Serenity.LookupEditor;
        DateOfCampaign: Serenity.DateEditor;
        PemtremtManager: Serenity.StringEditor;
        VaccinationList: DailyVaccinationsEditor;
    }
}
declare namespace webNEOC.Campaign {
    interface CampaignDayRow {
        CampaignDayId?: number;
        RoundId?: number;
        ProvinceId?: number;
        DistrictId?: number;
        DateOfCampaign?: string;
        PemtremtManager?: string;
        ProvincePcode?: string;
        ProvinceRegionId?: number;
        ProvincePname?: string;
        ProvincePAbrv?: string;
        ProvincePcenter?: string;
        ProvinceAreaKmSqr?: number;
        ProvinceNoOfDistricts?: number;
        DistrictDcode?: string;
        DistrictProvinceId?: number;
        DistrictDname?: string;
        DistrictTotalPop?: number;
        DistrictTargetPop?: number;
        DistrictType?: string;
        DistrictPriority?: number;
        DistrictPopYear?: number;
        TenantId?: number;
        RoundName?: string;
        VaccinationList?: DailyVaccinationsRow[];
    }
    namespace CampaignDayRow {
        const idProperty = "CampaignDayId";
        const nameProperty = "RoundName";
        const localTextPrefix = "Campaign.CampaignDay";
        const lookupKey = "Campaign.CampaignDay";
        function getLookup(): Q.Lookup<CampaignDayRow>;
        namespace Fields {
            const CampaignDayId: string;
            const RoundId: string;
            const ProvinceId: string;
            const DistrictId: string;
            const DateOfCampaign: string;
            const PemtremtManager: string;
            const ProvincePcode: string;
            const ProvinceRegionId: string;
            const ProvincePname: string;
            const ProvincePAbrv: string;
            const ProvincePcenter: string;
            const ProvinceAreaKmSqr: string;
            const ProvinceNoOfDistricts: string;
            const DistrictDcode: string;
            const DistrictProvinceId: string;
            const DistrictDname: string;
            const DistrictTotalPop: string;
            const DistrictTargetPop: string;
            const DistrictType: string;
            const DistrictPriority: string;
            const DistrictPopYear: string;
            const TenantId: string;
            const RoundName: string;
            const VaccinationList: string;
        }
    }
}
declare namespace webNEOC.Campaign {
    namespace CampaignDayService {
        const baseUrl = "Campaign/CampaignDay";
        function Create(request: Serenity.SaveRequest<CampaignDayRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<CampaignDayRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<CampaignDayRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<CampaignDayRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        namespace Methods {
            const Create: string;
            const Update: string;
            const Delete: string;
            const Retrieve: string;
            const List: string;
        }
    }
}
declare namespace webNEOC.Campaign {
    class CampaignForm extends Serenity.PrefixedContext {
        static formKey: string;
    }
    interface CampaignForm {
        CampgaignName: Serenity.StringEditor;
        DateFrom: Serenity.DateEditor;
        DateTo: Serenity.DateEditor;
        RoundId: Serenity.IntegerEditor;
        DateCreated: Serenity.DateEditor;
        Comment: Serenity.StringEditor;
        Status: Serenity.BooleanEditor;
    }
}
declare namespace webNEOC.Campaign {
    interface CampaignRow {
        CampaignId?: number;
        CampgaignName?: string;
        DateFrom?: string;
        DateTo?: string;
        RoundId?: number;
        DateCreated?: string;
        Comment?: string;
        Status?: boolean;
    }
    namespace CampaignRow {
        const idProperty = "CampaignId";
        const nameProperty = "CampgaignName";
        const localTextPrefix = "Campaign.Campaign";
        const lookupKey = "Campaign.Campaign";
        function getLookup(): Q.Lookup<CampaignRow>;
        namespace Fields {
            const CampaignId: string;
            const CampgaignName: string;
            const DateFrom: string;
            const DateTo: string;
            const RoundId: string;
            const DateCreated: string;
            const Comment: string;
            const Status: string;
        }
    }
}
declare namespace webNEOC.Campaign {
    namespace CampaignService {
        const baseUrl = "Campaign/Campaign";
        function Create(request: Serenity.SaveRequest<CampaignRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<CampaignRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<CampaignRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<CampaignRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        namespace Methods {
            const Create: string;
            const Update: string;
            const Delete: string;
            const Retrieve: string;
            const List: string;
        }
    }
}
declare namespace webNEOC.Campaign {
}
declare namespace webNEOC.Campaign {
    class DailyVaccinationsForm extends Serenity.PrefixedContext {
        static formKey: string;
    }
    interface DailyVaccinationsForm {
        ClusterId: Serenity.LookupEditor;
        LDPTypes: Serenity.StringEditor;
        TargetU5Case: Serenity.IntegerEditor;
        D1VialDist: Serenity.IntegerEditor;
        D1VialUse: Serenity.IntegerEditor;
        D1Vac011Months: Serenity.IntegerEditor;
        D1Vac1259months: Serenity.IntegerEditor;
        D1RecAbsChildren: Serenity.IntegerEditor;
        D1VacAbsChildren: Serenity.IntegerEditor;
        D1RecNewbornSsc: Serenity.IntegerEditor;
        D1VacNewbornSsc: Serenity.IntegerEditor;
        D1RecRefusedChildren: Serenity.IntegerEditor;
        D1RevacRefusedChildren: Serenity.IntegerEditor;
        D1AfpCase: Serenity.IntegerEditor;
        D2VialDist: Serenity.IntegerEditor;
        D2VialUse: Serenity.IntegerEditor;
        D2Vac011Months: Serenity.IntegerEditor;
        D2Vac1259months: Serenity.IntegerEditor;
        D2RecAbsChildren: Serenity.IntegerEditor;
        D2VacAbsChildren: Serenity.IntegerEditor;
        D2RecNewbornSsc: Serenity.IntegerEditor;
        D2VacNewbornSsc: Serenity.IntegerEditor;
        D2RecRefusedChildren: Serenity.IntegerEditor;
        D2RevacRefusedChildren: Serenity.IntegerEditor;
        D2AfpCase: Serenity.IntegerEditor;
        D3VialDist: Serenity.IntegerEditor;
        D3VialUse: Serenity.IntegerEditor;
        D3Vac011Months: Serenity.IntegerEditor;
        D3Vac1259months: Serenity.IntegerEditor;
        D3RecAbsChildren: Serenity.IntegerEditor;
        D3VacAbsChildren: Serenity.IntegerEditor;
        D3RecNewbornSsc: Serenity.IntegerEditor;
        D3VacNewbornSsc: Serenity.IntegerEditor;
        D3RecRefusedChildren: Serenity.IntegerEditor;
        D3RevacRefusedChildren: Serenity.IntegerEditor;
        D3AfpCase: Serenity.IntegerEditor;
        D5VialDist: Serenity.IntegerEditor;
        D5VialUse: Serenity.IntegerEditor;
        D5Vac011Months: Serenity.IntegerEditor;
        D5Vac1259months: Serenity.IntegerEditor;
        D5RecAbsChildren: Serenity.IntegerEditor;
        D5VacAbsChildren: Serenity.IntegerEditor;
        D5RecNewbornSsc: Serenity.IntegerEditor;
        D5VacNewbornSsc: Serenity.IntegerEditor;
        D5RecRefusedChildren: Serenity.IntegerEditor;
        D5RevacRefusedChildren: Serenity.IntegerEditor;
        D5AfpCase: Serenity.IntegerEditor;
    }
}
declare namespace webNEOC.Campaign {
    interface DailyVaccinationsRow {
        DailyVaccinationsId?: number;
        CampaignDayId?: number;
        ClusterId?: number;
        TargetU5Case?: number;
        D1VialDist?: number;
        D1VialUse?: number;
        D1Vac011Months?: number;
        D1Vac1259months?: number;
        D1RecAbsChildren?: number;
        D1VacAbsChildren?: number;
        D1RecNewbornSsc?: number;
        D1VacNewbornSsc?: number;
        D1RecRefusedChildren?: number;
        D1RevacRefusedChildren?: number;
        D1AfpCase?: number;
        D2VialDist?: number;
        D2VialUse?: number;
        D2Vac011Months?: number;
        D2Vac1259months?: number;
        D2RecAbsChildren?: number;
        D2VacAbsChildren?: number;
        D2RecNewbornSsc?: number;
        D2VacNewbornSsc?: number;
        D2RecRefusedChildren?: number;
        D2RevacRefusedChildren?: number;
        D2AfpCase?: number;
        D3VialDist?: number;
        D3VialUse?: number;
        D3Vac011Months?: number;
        D3Vac1259months?: number;
        D3RecAbsChildren?: number;
        D3VacAbsChildren?: number;
        D3RecNewbornSsc?: number;
        D3VacNewbornSsc?: number;
        D3RecRefusedChildren?: number;
        D3RevacRefusedChildren?: number;
        D3AfpCase?: number;
        D5VialDist?: number;
        D5VialUse?: number;
        D5Vac011Months?: number;
        D5Vac1259months?: number;
        D5RecAbsChildren?: number;
        D5VacAbsChildren?: number;
        D5RecNewbornSsc?: number;
        D5VacNewbornSsc?: number;
        D5RecRefusedChildren?: number;
        D5RevacRefusedChildren?: number;
        D5AfpCase?: number;
        DistrictId?: number;
        Cname?: string;
        TenantId?: number;
        LDPTypes?: string;
    }
    namespace DailyVaccinationsRow {
        const idProperty = "DailyVaccinationsId";
        const localTextPrefix = "Campaign.DailyVaccinations";
        const lookupKey = "Campaign.DailyVaccinations";
        function getLookup(): Q.Lookup<DailyVaccinationsRow>;
        namespace Fields {
            const DailyVaccinationsId: string;
            const CampaignDayId: string;
            const ClusterId: string;
            const TargetU5Case: string;
            const D1VialDist: string;
            const D1VialUse: string;
            const D1Vac011Months: string;
            const D1Vac1259months: string;
            const D1RecAbsChildren: string;
            const D1VacAbsChildren: string;
            const D1RecNewbornSsc: string;
            const D1VacNewbornSsc: string;
            const D1RecRefusedChildren: string;
            const D1RevacRefusedChildren: string;
            const D1AfpCase: string;
            const D2VialDist: string;
            const D2VialUse: string;
            const D2Vac011Months: string;
            const D2Vac1259months: string;
            const D2RecAbsChildren: string;
            const D2VacAbsChildren: string;
            const D2RecNewbornSsc: string;
            const D2VacNewbornSsc: string;
            const D2RecRefusedChildren: string;
            const D2RevacRefusedChildren: string;
            const D2AfpCase: string;
            const D3VialDist: string;
            const D3VialUse: string;
            const D3Vac011Months: string;
            const D3Vac1259months: string;
            const D3RecAbsChildren: string;
            const D3VacAbsChildren: string;
            const D3RecNewbornSsc: string;
            const D3VacNewbornSsc: string;
            const D3RecRefusedChildren: string;
            const D3RevacRefusedChildren: string;
            const D3AfpCase: string;
            const D5VialDist: string;
            const D5VialUse: string;
            const D5Vac011Months: string;
            const D5Vac1259months: string;
            const D5RecAbsChildren: string;
            const D5VacAbsChildren: string;
            const D5RecNewbornSsc: string;
            const D5VacNewbornSsc: string;
            const D5RecRefusedChildren: string;
            const D5RevacRefusedChildren: string;
            const D5AfpCase: string;
            const DistrictId: string;
            const Cname: string;
            const TenantId: string;
            const LDPTypes: string;
        }
    }
}
declare namespace webNEOC.Campaign {
    namespace DailyVaccinationsService {
        const baseUrl = "Campaign/DailyVaccinations";
        function Create(request: Serenity.SaveRequest<DailyVaccinationsRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<DailyVaccinationsRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<DailyVaccinationsRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<DailyVaccinationsRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        namespace Methods {
            const Create: string;
            const Update: string;
            const Delete: string;
            const Retrieve: string;
            const List: string;
        }
    }
}
declare namespace webNEOC.Common {
    interface BackgroundTaskLogRow {
        LogId?: number;
        TaskKey?: string;
        RunAt?: string;
        Status?: number;
        Server?: string;
        Message?: string;
    }
    namespace BackgroundTaskLogRow {
        const idProperty = "LogId";
        const nameProperty = "TaskKey";
        const localTextPrefix = "Common.BackgroundTask";
        namespace Fields {
            const LogId: string;
            const TaskKey: string;
            const RunAt: string;
            const Status: string;
            const Server: string;
            const Message: string;
        }
    }
}
declare namespace webNEOC.Common {
}
declare namespace webNEOC.Common {
    class MailForm extends Serenity.PrefixedContext {
        static formKey: string;
    }
    interface MailForm {
        Uid: Serenity.StringEditor;
        Subject: Serenity.StringEditor;
        Body: Serenity.HtmlNoteContentEditor;
        MailFrom: Serenity.StringEditor;
        MailTo: Serenity.StringEditor;
        ReplyTo: Serenity.StringEditor;
        Cc: Serenity.StringEditor;
        Bcc: Serenity.StringEditor;
        Priority: Serenity.EnumEditor;
        Status: Serenity.EnumEditor;
        RetryCount: Serenity.IntegerEditor;
        LockExpiration: Serenity.DateTimeEditor;
        ErrorMessage: Serenity.StringEditor;
        SentDate: Serenity.DateTimeEditor;
        InsertUser: Serenity.IntegerEditor;
        InsertDate: Serenity.DateTimeEditor;
    }
}
declare namespace webNEOC.Common {
    enum MailQueuePriority {
        High = 1,
        Medium = 2,
        Low = 3,
    }
}
declare namespace webNEOC.Common {
    interface MailRow {
        MailId?: number;
        Uid?: string;
        Subject?: string;
        Body?: string;
        MailFrom?: string;
        MailTo?: string;
        ReplyTo?: string;
        Cc?: string;
        Bcc?: string;
        Priority?: MailQueuePriority;
        Status?: MailStatus;
        RetryCount?: number;
        ErrorMessage?: string;
        LockExpiration?: string;
        SentDate?: string;
        InsertUserId?: number;
        InsertDate?: string;
        InsertUser?: string;
    }
    namespace MailRow {
        const idProperty = "MailId";
        const nameProperty = "Subject";
        const localTextPrefix = "Common.Mail";
        namespace Fields {
            const MailId: string;
            const Uid: string;
            const Subject: string;
            const Body: string;
            const MailFrom: string;
            const MailTo: string;
            const ReplyTo: string;
            const Cc: string;
            const Bcc: string;
            const Priority: string;
            const Status: string;
            const RetryCount: string;
            const ErrorMessage: string;
            const LockExpiration: string;
            const SentDate: string;
            const InsertUserId: string;
            const InsertDate: string;
            const InsertUser: string;
        }
    }
}
declare namespace webNEOC.Common {
    namespace MailService {
        const baseUrl = "Common/Mail";
        function Create(request: Serenity.SaveRequest<MailRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<MailRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<MailRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<MailRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        namespace Methods {
            const Create: string;
            const Update: string;
            const Delete: string;
            const Retrieve: string;
            const List: string;
        }
    }
}
declare namespace webNEOC.Common {
    enum MailStatus {
        InQueue = 0,
        Sent = 1,
        Failed = -1,
    }
}
declare namespace webNEOC.Common.Pages {
    interface UploadResponse extends Serenity.ServiceResponse {
        TemporaryFile?: string;
        Size?: number;
        IsImage?: boolean;
        Width?: number;
        Height?: number;
    }
}
declare namespace webNEOC.Common {
    interface UserPreferenceRetrieveRequest extends Serenity.ServiceRequest {
        PreferenceType?: string;
        Name?: string;
    }
}
declare namespace webNEOC.Common {
    interface UserPreferenceRetrieveResponse extends Serenity.ServiceResponse {
        Value?: string;
    }
}
declare namespace webNEOC.Common {
    interface UserPreferenceRow {
        UserPreferenceId?: number;
        UserId?: number;
        PreferenceType?: string;
        Name?: string;
        Value?: string;
    }
    namespace UserPreferenceRow {
        const idProperty = "UserPreferenceId";
        const nameProperty = "Name";
        const localTextPrefix = "Common.UserPreference";
        namespace Fields {
            const UserPreferenceId: string;
            const UserId: string;
            const PreferenceType: string;
            const Name: string;
            const Value: string;
        }
    }
}
declare namespace webNEOC.Common {
    namespace UserPreferenceService {
        const baseUrl = "Common/UserPreference";
        function Update(request: UserPreferenceUpdateRequest, onSuccess?: (response: Serenity.ServiceResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: UserPreferenceRetrieveRequest, onSuccess?: (response: UserPreferenceRetrieveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        namespace Methods {
            const Update: string;
            const Retrieve: string;
        }
    }
}
declare namespace webNEOC.Common {
    interface UserPreferenceUpdateRequest extends Serenity.ServiceRequest {
        PreferenceType?: string;
        Name?: string;
        Value?: string;
    }
}
declare namespace webNEOC.CVA {
}
declare namespace webNEOC.CVA {
    class PTTSForm extends Serenity.PrefixedContext {
        static formKey: string;
    }
    interface PTTSForm {
        ProvinceId: Serenity.LookupEditor;
        DistrictId: Serenity.LookupEditor;
        Year: Serenity.IntegerEditor;
        MonthId: Serenity.LookupEditor;
        Type: Serenity.StringEditor;
        Subtype: Serenity.StringEditor;
        NoOfTeam: Serenity.IntegerEditor;
        TeamName: Serenity.StringEditor;
        Boys011: Serenity.IntegerEditor;
        Girls011: Serenity.IntegerEditor;
        Boys1259: Serenity.IntegerEditor;
        Girls1259: Serenity.IntegerEditor;
        Remarks: Serenity.TextAreaEditor;
        TenantId: Serenity.IntegerEditor;
    }
}
declare namespace webNEOC.CVA {
    interface PTTSRow {
        PttsId?: number;
        DistrictId?: number;
        Year?: number;
        MonthId?: number;
        Type?: string;
        Subtype?: string;
        NoOfTeam?: number;
        TeamName?: string;
        Boys011?: number;
        Girls011?: number;
        Boys1259?: number;
        Girls1259?: number;
        Remarks?: string;
        DistrictDcode?: string;
        ProvinceId?: number;
        DistrictDname?: string;
        DistrictTotalPop?: number;
        DistrictTargetPop?: number;
        DistrictType?: string;
        DistrictPriority?: number;
        DistrictPopYear?: number;
        DistrictLat?: number;
        DistrictLon?: number;
        ProvName?: string;
        MonthName?: string;
        TenantId?: number;
    }
    namespace PTTSRow {
        const idProperty = "PttsId";
        const nameProperty = "TeamName";
        const localTextPrefix = "CVA.PTTS";
        namespace Fields {
            const PttsId: string;
            const DistrictId: string;
            const Year: string;
            const MonthId: string;
            const Type: string;
            const Subtype: string;
            const NoOfTeam: string;
            const TeamName: string;
            const Boys011: string;
            const Girls011: string;
            const Boys1259: string;
            const Girls1259: string;
            const Remarks: string;
            const DistrictDcode: string;
            const ProvinceId: string;
            const DistrictDname: string;
            const DistrictTotalPop: string;
            const DistrictTargetPop: string;
            const DistrictType: string;
            const DistrictPriority: string;
            const DistrictPopYear: string;
            const DistrictLat: string;
            const DistrictLon: string;
            const ProvName: string;
            const MonthName: string;
            const TenantId: string;
        }
    }
}
declare namespace webNEOC.CVA {
    namespace PTTSService {
        const baseUrl = "CVA/PTTS";
        function Create(request: Serenity.SaveRequest<PTTSRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<PTTSRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<PTTSRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<PTTSRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        namespace Methods {
            const Create: string;
            const Update: string;
            const Delete: string;
            const Retrieve: string;
            const List: string;
        }
    }
}
declare namespace webNEOC.Default {
    class FormsbsForm extends Serenity.PrefixedContext {
        static formKey: string;
    }
    interface FormsbsForm {
        Form: Serenity.StringEditor;
        TotalRecorded: Serenity.IntegerEditor;
        TotalUnapproved: Serenity.IntegerEditor;
        Url: Serenity.StringEditor;
        Active: Serenity.BooleanEditor;
    }
}
declare namespace webNEOC.Default {
    interface FormsbsRow {
        FormsbsId?: number;
        Form?: string;
        TotalRecorded?: number;
        TotalUnapproved?: number;
        Url?: string;
        Active?: boolean;
    }
    namespace FormsbsRow {
        const idProperty = "FormsbsId";
        const nameProperty = "Form";
        const localTextPrefix = "Default.Formsbs";
        namespace Fields {
            const FormsbsId: any;
            const Form: any;
            const TotalRecorded: any;
            const TotalUnapproved: any;
            const Url: any;
            const Active: any;
        }
    }
}
declare namespace webNEOC.Default {
    namespace FormsbsService {
        const baseUrl = "Default/Formsbs";
        function Create(request: Serenity.SaveRequest<FormsbsRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<FormsbsRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<FormsbsRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<FormsbsRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        namespace Methods {
            const Create: string;
            const Update: string;
            const Delete: string;
            const Retrieve: string;
            const List: string;
        }
    }
}
declare namespace webNEOC {
    interface ExcelImportRequest extends Serenity.ServiceRequest {
        FileName?: string;
    }
}
declare namespace webNEOC {
    interface ExcelImportResponse extends Serenity.ServiceResponse {
        Inserted?: number;
        Updated?: number;
        ErrorList?: string[];
    }
}
declare namespace webNEOC {
    interface GetNextNumberRequest extends Serenity.ServiceRequest {
        Prefix?: string;
        Length?: number;
    }
}
declare namespace webNEOC {
    interface GetNextNumberResponse extends Serenity.ServiceResponse {
        Number?: number;
        Serial?: string;
    }
}
declare namespace webNEOC.Implementation {
}
declare namespace webNEOC.Implementation {
    class CommunicationForm extends Serenity.PrefixedContext {
        static formKey: string;
    }
    interface CommunicationForm {
        LanguageId: Serenity.IntegerEditor;
        MediaTypeId: Serenity.IntegerEditor;
        Duration: Serenity.IntegerEditor;
        MediaId: Serenity.IntegerEditor;
        BroadCastDate: Serenity.DateEditor;
        DaypartId: Serenity.IntegerEditor;
        Source: Serenity.StringEditor;
        TenantId: Serenity.IntegerEditor;
    }
}
declare namespace webNEOC.Implementation {
    interface CommunicationRow {
        CommunicationId?: number;
        LanguageId?: number;
        MediaTypeId?: number;
        Duration?: number;
        MediaId?: number;
        BroadCastDate?: string;
        DaypartId?: number;
        Daypart?: string;
        Source?: string;
        TenantId?: number;
        LanguageLanguageName?: string;
        MediaTypeMediaTypeName?: string;
        MediaMediaName?: string;
        BroadCastTime?: string;
        CommunId?: string;
    }
    namespace CommunicationRow {
        const idProperty = "CommunicationId";
        const nameProperty = "CommunId";
        const localTextPrefix = "Implementation.Communication";
        namespace Fields {
            const CommunicationId: string;
            const LanguageId: string;
            const MediaTypeId: string;
            const Duration: string;
            const MediaId: string;
            const BroadCastDate: string;
            const DaypartId: number;
            const Daypart: string;
            const Source: string;
            const TenantId: string;
            const LanguageLanguageName: string;
            const MediaTypeMediaTypeName: string;
            const MediaMediaName: string;
            const BroadCastTime: string;
            const CommunId: string;
        }
    }
}
declare namespace webNEOC.Implementation {
    namespace CommunicationService {
        const baseUrl = "Implementation/Communication";
        function Create(request: Serenity.SaveRequest<CommunicationRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<CommunicationRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<CommunicationRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<CommunicationRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        namespace Methods {
            const Create: string;
            const Update: string;
            const Delete: string;
            const Retrieve: string;
            const List: string;
        }
    }
}
declare namespace webNEOC.Implementation {
}
declare namespace webNEOC.Implementation {
    class IcmHouseholdForm extends Serenity.PrefixedContext {
        static formKey: string;
    }
    interface IcmHouseholdForm {
        RoundId: Serenity.LookupEditor;
        DateFrom: Serenity.DateEditor;
        DateTo: Serenity.DateEditor;
        ProvinceId: Serenity.LookupEditor;
        DistrictId: Serenity.LookupEditor;
        PartId: Serenity.LookupEditor;
        ClusterId: Serenity.LookupEditor;
        ReportDate: Serenity.DateEditor;
        Village: Serenity.StringEditor;
        Supervisor: Serenity.StringEditor;
        NoHhVisited: Serenity.IntegerEditor;
        NoChildrenInVisitedHh: Serenity.IntegerEditor;
        NoVaccInRecall: Serenity.IntegerEditor;
        MissedChildren: Serenity.IntegerEditor;
        TeamNotCome: Serenity.IntegerEditor;
        ChildrenAbsent: Serenity.IntegerEditor;
        NewbornSsChildren: Serenity.IntegerEditor;
        NoRefused: Serenity.IntegerEditor;
        NoIgnoredbyTeam: Serenity.IntegerEditor;
        TotUn5SeenByMonit: Serenity.IntegerEditor;
        NoSeenWithFingerMark: Serenity.IntegerEditor;
        NoCorrect: Serenity.IntegerEditor;
        NoIncorrect: Serenity.IntegerEditor;
        NoNotMarked: Serenity.IntegerEditor;
        NoChildFoundMissedRecall: Serenity.IntegerEditor;
        NoChildRecBackOfTally: Serenity.IntegerEditor;
    }
}
declare namespace webNEOC.Implementation {
    interface IcmHouseholdRow {
        IcmHouseholdId?: number;
        RoundId?: number;
        DistrictId?: number;
        PartId?: number;
        ClusterId?: number;
        ReportDate?: string;
        Village?: string;
        Supervisor?: string;
        NoHhVisited?: number;
        NoChildrenInVisitedHh?: number;
        NoVaccInRecall?: number;
        MissedChildren?: number;
        TeamNotCome?: number;
        ChildrenAbsent?: number;
        NewbornSsChildren?: number;
        NoRefused?: number;
        NoIgnoredbyTeam?: number;
        TotUn5SeenByMonit?: number;
        NoSeenWithFingerMark?: number;
        NoCorrect?: number;
        NoIncorrect?: number;
        NoNotMarked?: number;
        NoChildFoundMissedRecall?: number;
        NoChildRecBackOfTally?: number;
        RoundName?: string;
        DateFrom?: string;
        DateTo?: string;
        TenantId?: number;
        Cname?: string;
        DistrictDcode?: string;
        ProvinceId?: number;
        Province?: string;
        DistrictDname?: string;
        DistrictTotalPop?: number;
        DistrictTargetPop?: number;
        DistrictType?: string;
        DistrictPriority?: number;
        DistrictPopYear?: number;
        PartPartName?: string;
    }
    namespace IcmHouseholdRow {
        const idProperty = "IcmHouseholdId";
        const nameProperty = "Village";
        const localTextPrefix = "Implementation.IcmHousehold";
        namespace Fields {
            const IcmHouseholdId: string;
            const RoundId: string;
            const DistrictId: string;
            const PartId: string;
            const ClusterId: string;
            const ReportDate: string;
            const Village: string;
            const Supervisor: string;
            const NoHhVisited: string;
            const NoChildrenInVisitedHh: string;
            const NoVaccInRecall: string;
            const MissedChildren: string;
            const TeamNotCome: string;
            const ChildrenAbsent: string;
            const NewbornSsChildren: string;
            const NoRefused: string;
            const NoIgnoredbyTeam: string;
            const TotUn5SeenByMonit: string;
            const NoSeenWithFingerMark: string;
            const NoCorrect: string;
            const NoIncorrect: string;
            const NoNotMarked: string;
            const NoChildFoundMissedRecall: string;
            const NoChildRecBackOfTally: string;
            const RoundName: string;
            const DateFrom: string;
            const DateTo: string;
            const TenantId: string;
            const Cname: string;
            const DistrictDcode: string;
            const ProvinceId: string;
            const Province: string;
            const DistrictDname: string;
            const DistrictTotalPop: string;
            const DistrictTargetPop: string;
            const DistrictType: string;
            const DistrictPriority: string;
            const DistrictPopYear: string;
            const PartPartName: string;
        }
    }
}
declare namespace webNEOC.Implementation {
    namespace IcmHouseholdService {
        const baseUrl = "Implementation/IcmHousehold";
        function Create(request: Serenity.SaveRequest<IcmHouseholdRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<IcmHouseholdRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<IcmHouseholdRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<IcmHouseholdRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        namespace Methods {
            const Create: string;
            const Update: string;
            const Delete: string;
            const Retrieve: string;
            const List: string;
        }
    }
}
declare namespace webNEOC.Implementation {
}
declare namespace webNEOC.Implementation {
    class IcmSupervisorForm extends Serenity.PrefixedContext {
        static formKey: string;
    }
    interface IcmSupervisorForm {
        RoundId: Serenity.LookupEditor;
        DateFrom: Serenity.DateEditor;
        DateTo: Serenity.DateEditor;
        ProvinceId: Serenity.LookupEditor;
        DistrictId: Serenity.LookupEditor;
        PartId: Serenity.LookupEditor;
        ClusterId: Serenity.LookupEditor;
        ReportDate: Serenity.DateEditor;
        Supervisor: Serenity.StringEditor;
        MonitorName: Serenity.StringEditor;
        IsSuperResidentOfArea: Serenity.BooleanEditor;
        IsSuperTrained: Serenity.BooleanEditor;
        IsSuperCarryOpv: Serenity.BooleanEditor;
        IsSuperHasClearMap: Serenity.BooleanEditor;
        IsSuperFillingHhChecklist: Serenity.BooleanEditor;
        IsTransProviddToSuper: Serenity.BooleanEditor;
        VehicletypeId: Serenity.LookupEditor;
    }
}
declare namespace webNEOC.Implementation {
    interface IcmSupervisorRow {
        IcmSupervisorId?: number;
        RoundId?: number;
        DistrictId?: number;
        PartId?: number;
        ClusterId?: number;
        ReportDate?: string;
        Supervisor?: string;
        MonitorName?: string;
        IsSuperResidentOfArea?: boolean;
        IsSuperTrained?: boolean;
        IsSuperCarryOpv?: boolean;
        IsSuperHasClearMap?: boolean;
        IsSuperFillingHhChecklist?: boolean;
        IsTransProviddToSuper?: boolean;
        VehicletypeId?: number;
        RoundName?: string;
        DateFrom?: string;
        DateTo?: string;
        TenantId?: number;
        Cname?: string;
        DistrictDcode?: string;
        ProvinceId?: number;
        Province?: string;
        DistrictDname?: string;
        DistrictTotalPop?: number;
        DistrictTargetPop?: number;
        DistrictType?: string;
        DistrictPriority?: number;
        DistrictPopYear?: number;
        VehicletypeTypename?: string;
        PartPartName?: string;
    }
    namespace IcmSupervisorRow {
        const idProperty = "IcmSupervisorId";
        const nameProperty = "Supervisor";
        const localTextPrefix = "Implementation.IcmSupervisor";
        namespace Fields {
            const IcmSupervisorId: string;
            const RoundId: string;
            const DistrictId: string;
            const PartId: string;
            const ClusterId: string;
            const ReportDate: string;
            const Supervisor: string;
            const MonitorName: string;
            const IsSuperResidentOfArea: string;
            const IsSuperTrained: string;
            const IsSuperCarryOpv: string;
            const IsSuperHasClearMap: string;
            const IsSuperFillingHhChecklist: string;
            const IsTransProviddToSuper: string;
            const VehicletypeId: string;
            const RoundName: string;
            const DateFrom: string;
            const DateTo: string;
            const TenantId: string;
            const Cname: string;
            const DistrictDcode: string;
            const ProvinceId: string;
            const Province: string;
            const DistrictDname: string;
            const DistrictTotalPop: string;
            const DistrictTargetPop: string;
            const DistrictType: string;
            const DistrictPriority: string;
            const DistrictPopYear: string;
            const VehicletypeTypename: string;
            const PartPartName: string;
        }
    }
}
declare namespace webNEOC.Implementation {
    namespace IcmSupervisorService {
        const baseUrl = "Implementation/IcmSupervisor";
        function Create(request: Serenity.SaveRequest<IcmSupervisorRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<IcmSupervisorRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<IcmSupervisorRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<IcmSupervisorRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        namespace Methods {
            const Create: string;
            const Update: string;
            const Delete: string;
            const Retrieve: string;
            const List: string;
        }
    }
}
declare namespace webNEOC.Implementation {
}
declare namespace webNEOC.Implementation {
    class IcmTeamForm extends Serenity.PrefixedContext {
        static formKey: string;
    }
    interface IcmTeamForm {
        RoundId: Serenity.LookupEditor;
        DateFrom: Serenity.DateEditor;
        DateTo: Serenity.DateEditor;
        ProvinceId: Serenity.LookupEditor;
        DistrictId: Serenity.LookupEditor;
        PartId: Serenity.LookupEditor;
        ClusterId: Serenity.LookupEditor;
        MonitorName: Serenity.StringEditor;
        TeamMemberName: Serenity.StringEditor;
        TeamNo: Serenity.StringEditor;
        ReportDate: Serenity.DateEditor;
        MonitVisitTime: Serenity.StringEditor;
        IsTeamResident: Serenity.BooleanEditor;
        BothTrained: Serenity.BooleanEditor;
        HaveClearMap: Serenity.BooleanEditor;
        AbleKnowArea: Serenity.BooleanEditor;
        TeamGHtoH: Serenity.BooleanEditor;
        OpvVialsKeptDry: Serenity.BooleanEditor;
        UsingOpvStage3or4: Serenity.BooleanEditor;
        AskingAbout011C: Serenity.BooleanEditor;
        AskingforGnssc: Serenity.BooleanEditor;
        RecNameOfAbsentRefC: Serenity.BooleanEditor;
        AskingAfpCases: Serenity.BooleanEditor;
        VistedBySupervisor: Serenity.BooleanEditor;
        TeamHasAchw: Serenity.BooleanEditor;
        TeamHasFemale: Serenity.BooleanEditor;
        SocMobAccompanyTeam: Serenity.BooleanEditor;
    }
}
declare namespace webNEOC.Implementation {
    interface IcmTeamRow {
        IcmTeamId?: number;
        RoundId?: number;
        DistrictId?: number;
        PartId?: number;
        ClusterId?: number;
        TeamMemberName?: string;
        TeamNo?: string;
        ReportDate?: string;
        MonitorName?: string;
        MonitVisitTime?: string;
        IsTeamResident?: boolean;
        BothTrained?: boolean;
        HaveClearMap?: boolean;
        AbleKnowArea?: boolean;
        TeamGHtoH?: boolean;
        OpvVialsKeptDry?: boolean;
        UsingOpvStage3or4?: boolean;
        AskingAbout011C?: boolean;
        AskingforGnssc?: boolean;
        RecNameOfAbsentRefC?: boolean;
        AskingAfpCases?: boolean;
        VistedBySupervisor?: boolean;
        TeamHasAchw?: boolean;
        TeamHasFemale?: boolean;
        SocMobAccompanyTeam?: boolean;
        RoundName?: string;
        DateFrom?: string;
        DateTo?: string;
        TenantId?: number;
        PartName?: string;
        Cname?: string;
        DistrictDcode?: string;
        ProvinceId?: number;
        Province?: string;
        DistrictDname?: string;
        DistrictTotalPop?: number;
        DistrictTargetPop?: number;
        DistrictType?: string;
        DistrictPriority?: number;
        DistrictPopYear?: number;
    }
    namespace IcmTeamRow {
        const idProperty = "IcmTeamId";
        const nameProperty = "TeamMemberName";
        const localTextPrefix = "Implementation.IcmTeam";
        namespace Fields {
            const IcmTeamId: string;
            const RoundId: string;
            const DistrictId: string;
            const PartId: string;
            const ClusterId: string;
            const TeamMemberName: string;
            const TeamNo: string;
            const ReportDate: string;
            const MonitorName: string;
            const MonitVisitTime: string;
            const IsTeamResident: string;
            const BothTrained: string;
            const HaveClearMap: string;
            const AbleKnowArea: string;
            const TeamGHtoH: string;
            const OpvVialsKeptDry: string;
            const UsingOpvStage3or4: string;
            const AskingAbout011C: string;
            const AskingforGnssc: string;
            const RecNameOfAbsentRefC: string;
            const AskingAfpCases: string;
            const VistedBySupervisor: string;
            const TeamHasAchw: string;
            const TeamHasFemale: string;
            const SocMobAccompanyTeam: string;
            const RoundName: string;
            const DateFrom: string;
            const DateTo: string;
            const TenantId: string;
            const PartName: string;
            const Cname: string;
            const DistrictDcode: string;
            const ProvinceId: string;
            const Province: string;
            const DistrictDname: string;
            const DistrictTotalPop: string;
            const DistrictTargetPop: string;
            const DistrictType: string;
            const DistrictPriority: string;
            const DistrictPopYear: string;
        }
    }
}
declare namespace webNEOC.Implementation {
    namespace IcmTeamService {
        const baseUrl = "Implementation/IcmTeam";
        function Create(request: Serenity.SaveRequest<IcmTeamRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<IcmTeamRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<IcmTeamRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<IcmTeamRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        namespace Methods {
            const Create: string;
            const Update: string;
            const Delete: string;
            const Retrieve: string;
            const List: string;
        }
    }
}
declare namespace webNEOC.Implementation {
}
declare namespace webNEOC.Implementation {
}
declare namespace webNEOC.Implementation {
    class IcnDeploymentForm extends Serenity.PrefixedContext {
        static formKey: string;
    }
    interface IcnDeploymentForm {
        DistrictId: Serenity.IntegerEditor;
        PlannedIcn: Serenity.IntegerEditor;
        RecruitedIcn: Serenity.IntegerEditor;
        RecruitedMale: Serenity.IntegerEditor;
        RecruitedFemale: Serenity.IntegerEditor;
        IcnTypeId: Serenity.IntegerEditor;
        RecruitmentTypeId: Serenity.IntegerEditor;
        MonthId: Serenity.IntegerEditor;
        Year: Serenity.IntegerEditor;
        TenantId: Serenity.IntegerEditor;
    }
}
declare namespace webNEOC.Implementation {
    interface IcnDeploymentRow {
        IcnDeploymentId?: number;
        DistrictId?: number;
        PlannedIcn?: number;
        RecruitedIcn?: number;
        RecruitedMale?: number;
        RecruitedFemale?: number;
        IcnTypeId?: number;
        RecruitmentTypeId?: number;
        MonthId?: number;
        Year?: number;
        TenantId?: number;
        DistrictDcode?: string;
        DistrictProvinceId?: number;
        DistrictDname?: string;
        DistrictTotalPop?: number;
        DistrictTargetPop?: number;
        DistrictType?: string;
        DistrictPriority?: number;
        DistrictPopYear?: number;
        DistrictLat?: number;
        DistrictLon?: number;
        DistrictBackupName?: string;
        DistrictMapName?: string;
        DistrictLdPs?: string;
        IcnType?: string;
        RecruitmentType?: string;
        MonthMonthshort?: string;
        MonthMonthlong?: string;
    }
    namespace IcnDeploymentRow {
        const idProperty = "IcnDeploymentId";
        const localTextPrefix = "Implementation.IcnDeployment";
        namespace Fields {
            const IcnDeploymentId: string;
            const DistrictId: string;
            const PlannedIcn: string;
            const RecruitedIcn: string;
            const RecruitedMale: string;
            const RecruitedFemale: string;
            const IcnTypeId: string;
            const RecruitmentTypeId: string;
            const MonthId: string;
            const Year: string;
            const TenantId: string;
            const DistrictDcode: string;
            const DistrictProvinceId: string;
            const DistrictDname: string;
            const DistrictTotalPop: string;
            const DistrictTargetPop: string;
            const DistrictType: string;
            const DistrictPriority: string;
            const DistrictPopYear: string;
            const DistrictLat: string;
            const DistrictLon: string;
            const DistrictBackupName: string;
            const DistrictMapName: string;
            const DistrictLdPs: string;
            const IcnType: string;
            const RecruitmentType: string;
            const MonthMonthshort: string;
            const MonthMonthlong: string;
        }
    }
}
declare namespace webNEOC.Implementation {
    namespace IcnDeploymentService {
        const baseUrl = "Implementation/IcnDeployment";
        function Create(request: Serenity.SaveRequest<IcnDeploymentRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<IcnDeploymentRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<IcnDeploymentRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<IcnDeploymentRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        namespace Methods {
            const Create: string;
            const Update: string;
            const Delete: string;
            const Retrieve: string;
            const List: string;
        }
    }
}
declare namespace webNEOC.Implementation {
    class IcnForm extends Serenity.PrefixedContext {
        static formKey: string;
    }
    interface IcnForm {
        RoundId: Serenity.LookupEditor;
        DateFrom: Serenity.DateEditor;
        DateTo: Serenity.DateEditor;
        ProvinceId: Serenity.LookupEditor;
        DistrictId: Serenity.LookupEditor;
        ClusterId: Serenity.LookupEditor;
        Area: Serenity.StringEditor;
        RegAbsent: Serenity.IntegerEditor;
        VacAbsent: Serenity.IntegerEditor;
        RegNss: Serenity.IntegerEditor;
        VacNss: Serenity.IntegerEditor;
        RegRefusal: Serenity.IntegerEditor;
        VacRefusal: Serenity.IntegerEditor;
        RegUnrecorded: Serenity.IntegerEditor;
        VacUnrecorded: Serenity.IntegerEditor;
    }
}
declare namespace webNEOC.Implementation {
    interface IcnRow {
        IcnId?: string;
        RoundId?: number;
        DistrictId?: number;
        ClusterId?: number;
        Area?: string;
        RegAbsent?: number;
        VacAbsent?: number;
        RegNss?: number;
        VacNss?: number;
        RegRefusal?: number;
        VacRefusal?: number;
        RegUnrecorded?: number;
        VacUnrecorded?: number;
        TenantId?: number;
        DistrictDcode?: string;
        DistrictProvinceId?: number;
        DistrictDname?: string;
        DistrictTotalPop?: number;
        DistrictTargetPop?: number;
        DistrictType?: string;
        DistrictPriority?: number;
        DistrictPopYear?: number;
        ProvinceId?: number;
        Province?: string;
        RoundName?: string;
        DateFrom?: string;
        DateTo?: string;
        Cname?: string;
    }
    namespace IcnRow {
        const idProperty = "IcnId";
        const nameProperty = "Area";
        const localTextPrefix = "Implementation.Icn";
        namespace Fields {
            const IcnId: string;
            const RoundId: string;
            const DistrictId: string;
            const ClusterId: string;
            const Area: string;
            const RegAbsent: string;
            const VacAbsent: string;
            const RegNss: string;
            const VacNss: string;
            const RegRefusal: string;
            const VacRefusal: string;
            const RegUnrecorded: string;
            const VacUnrecorded: string;
            const TenantId: string;
            const DistrictDcode: string;
            const DistrictProvinceId: string;
            const DistrictDname: string;
            const DistrictTotalPop: string;
            const DistrictTargetPop: string;
            const DistrictType: string;
            const DistrictPriority: string;
            const DistrictPopYear: string;
            const ProvinceId: string;
            const Province: string;
            const RoundName: string;
            const DateFrom: string;
            const DateTo: string;
            const Cname: string;
        }
    }
}
declare namespace webNEOC.Implementation {
    namespace IcnService {
        const baseUrl = "Implementation/Icn";
        function Create(request: Serenity.SaveRequest<IcnRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<IcnRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<IcnRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<IcnRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        namespace Methods {
            const Create: string;
            const Update: string;
            const Delete: string;
            const Retrieve: string;
            const List: string;
        }
    }
}
declare namespace webNEOC.Implementation {
}
declare namespace webNEOC.Implementation {
    class MobileTeamForm extends Serenity.PrefixedContext {
        static formKey: string;
    }
    interface MobileTeamForm {
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
}
declare namespace webNEOC.Implementation {
    interface MobileTeamRow {
        MobileTeamId?: number;
        RoundId?: number;
        DistrictId?: number;
        Nomads?: number;
        Gypsis?: number;
        BlueMosque?: number;
        BusStation?: number;
        CheckPost?: number;
        IDPs?: number;
        Madrasa?: number;
        School?: number;
        Kindergarden?: number;
        Prison?: number;
        Daramsal?: number;
        Crosborder?: number;
        Returnees?: number;
        EPICenters?: number;
        MobileTeams?: number;
        PrivateClinics?: number;
        HotelGuestHouses?: number;
        Others?: number;
        RoundName?: string;
        DateFrom?: string;
        DateTo?: string;
        TenantId?: number;
        DistrictDcode?: string;
        ProvinceId?: number;
        Province?: string;
        DistrictDname?: string;
        DistrictTotalPop?: number;
        DistrictTargetPop?: number;
        DistrictType?: string;
        DistrictPriority?: number;
        DistrictPopYear?: number;
    }
    namespace MobileTeamRow {
        const idProperty = "MobileTeamId";
        const localTextPrefix = "Implementation.MobileTeam";
        namespace Fields {
            const MobileTeamId: string;
            const RoundId: string;
            const DistrictId: string;
            const Nomads: string;
            const Gypsis: string;
            const BlueMosque: string;
            const BusStation: string;
            const CheckPost: string;
            const IDPs: string;
            const Madrasa: string;
            const School: string;
            const Kindergarden: string;
            const Prison: string;
            const Daramsal: string;
            const Crosborder: string;
            const Returnees: string;
            const EPICenters: string;
            const MobileTeams: string;
            const PrivateClinics: string;
            const HotelGuestHouses: string;
            const Others: string;
            const RoundName: string;
            const DateFrom: string;
            const DateTo: string;
            const TenantId: string;
            const DistrictDcode: string;
            const ProvinceId: string;
            const Province: string;
            const DistrictDname: string;
            const DistrictTotalPop: string;
            const DistrictTargetPop: string;
            const DistrictType: string;
            const DistrictPriority: string;
            const DistrictPopYear: string;
        }
    }
}
declare namespace webNEOC.Implementation {
    namespace MobileTeamService {
        const baseUrl = "Implementation/MobileTeam";
        function Create(request: Serenity.SaveRequest<MobileTeamRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<MobileTeamRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<MobileTeamRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<MobileTeamRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function ApproveMobileTeam(request: Serenity.ServiceRequest, onSuccess?: (response: System.Int32) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        namespace Methods {
            const Create: string;
            const Update: string;
            const Delete: string;
            const Retrieve: string;
            const List: string;
            const ApproveMobileTeam: string;
        }
    }
}
declare namespace webNEOC.Implementation {
}
declare namespace webNEOC.Implementation {
    class VitaminAForm extends Serenity.PrefixedContext {
        static formKey: string;
    }
    interface VitaminAForm {
        RoundId: Serenity.LookupEditor;
        DateFrom: Serenity.DateEditor;
        DateTo: Serenity.DateEditor;
        ProvinceId: Serenity.LookupEditor;
        DistrictId: Serenity.LookupEditor;
        PemtremtManager: Serenity.StringEditor;
        VitaminAVaccinations: VitaminAVaccinationsEditor;
    }
}
declare namespace webNEOC.Implementation {
    interface VitaminARow {
        VitaminADayId?: number;
        RoundId?: number;
        ProvinceId?: number;
        DistrictId?: number;
        PemtremtManager?: string;
        RoundName?: string;
        DateFrom?: string;
        DateTo?: string;
        TenantId?: number;
        ProvincePcode?: string;
        ProvinceRegionId?: number;
        ProvincePname?: string;
        ProvincePAbrv?: string;
        ProvincePcenter?: string;
        ProvinceAreaKmSqr?: number;
        ProvinceNoOfDistricts?: number;
        DistrictDcode?: string;
        DistrictProvinceId?: number;
        DistrictDname?: string;
        DistrictTotalPop?: number;
        DistrictTargetPop?: number;
        DistrictType?: string;
        DistrictPriority?: number;
        DistrictPopYear?: number;
        VitaminAVaccinations?: VitaminAVaccinationsRow[];
    }
    namespace VitaminARow {
        const idProperty = "VitaminADayId";
        const nameProperty = "PemtremtManager";
        const localTextPrefix = "Implementation.VitaminA";
        namespace Fields {
            const VitaminADayId: string;
            const RoundId: string;
            const ProvinceId: string;
            const DistrictId: string;
            const PemtremtManager: string;
            const RoundName: string;
            const DateFrom: string;
            const DateTo: string;
            const TenantId: string;
            const ProvincePcode: string;
            const ProvinceRegionId: string;
            const ProvincePname: string;
            const ProvincePAbrv: string;
            const ProvincePcenter: string;
            const ProvinceAreaKmSqr: string;
            const ProvinceNoOfDistricts: string;
            const DistrictDcode: string;
            const DistrictProvinceId: string;
            const DistrictDname: string;
            const DistrictTotalPop: string;
            const DistrictTargetPop: string;
            const DistrictType: string;
            const DistrictPriority: string;
            const DistrictPopYear: string;
            const VitaminAVaccinations: string;
        }
    }
}
declare namespace webNEOC.Implementation {
    namespace VitaminAService {
        const baseUrl = "Implementation/VitaminA";
        function Create(request: Serenity.SaveRequest<VitaminARow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<VitaminARow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<VitaminARow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<VitaminARow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        namespace Methods {
            const Create: string;
            const Update: string;
            const Delete: string;
            const Retrieve: string;
            const List: string;
        }
    }
}
declare namespace webNEOC.Implementation {
}
declare namespace webNEOC.Implementation {
    class VitaminAVaccinationsForm extends Serenity.PrefixedContext {
        static formKey: string;
    }
    interface VitaminAVaccinationsForm {
        ClusterId: Serenity.LookupEditor;
        TargetU5Cases: Serenity.IntegerEditor;
        d1VitADist: Serenity.IntegerEditor;
        d1VitAUse: Serenity.IntegerEditor;
        d1C611Months: Serenity.IntegerEditor;
        d1C1259Months: Serenity.IntegerEditor;
        d2VitADist: Serenity.IntegerEditor;
        d2VitAUse: Serenity.IntegerEditor;
        d2C611Months: Serenity.IntegerEditor;
        d2C1259Months: Serenity.IntegerEditor;
        d3VitADist: Serenity.IntegerEditor;
        d3VitAUse: Serenity.IntegerEditor;
        d3C611Months: Serenity.IntegerEditor;
        d3C1259Months: Serenity.IntegerEditor;
        d5VitADist: Serenity.IntegerEditor;
        d5VitAUse: Serenity.IntegerEditor;
        d5C611Months: Serenity.IntegerEditor;
        d5C1259Months: Serenity.IntegerEditor;
    }
}
declare namespace webNEOC.Implementation {
    interface VitaminAVaccinationsRow {
        VitaminAVaccinationsId?: number;
        VitaminADayId?: number;
        ClusterId?: number;
        TargetU5Cases?: number;
        d1VitADist?: number;
        d1VitAUse?: number;
        d1C611Months?: number;
        d1C1259Months?: number;
        d2VitADist?: number;
        d2VitAUse?: number;
        d2C611Months?: number;
        d2C1259Months?: number;
        d3VitADist?: number;
        d3VitAUse?: number;
        d3C611Months?: number;
        d3C1259Months?: number;
        d5VitADist?: number;
        d5VitAUse?: number;
        d5C611Months?: number;
        d5C1259Months?: number;
        VitaminADayCampaignId?: number;
        VitaminADayProvinceId?: number;
        VitaminADayDistrictId?: number;
        VitaminADayDayNumber?: number;
        VitaminADayDateOfCampaign?: string;
        VitaminADayPemtremtManager?: string;
        ClusterName?: string;
        TenantId?: number;
    }
    namespace VitaminAVaccinationsRow {
        const idProperty = "VitaminAVaccinationsId";
        const localTextPrefix = "Implementation.VitaminAVaccinations";
        namespace Fields {
            const VitaminAVaccinationsId: string;
            const VitaminADayId: string;
            const ClusterId: string;
            const TargetU5Cases: string;
            const d1VitADist: string;
            const d1VitAUse: string;
            const d1C611Months: string;
            const d1C1259Months: string;
            const d2VitADist: string;
            const d2VitAUse: string;
            const d2C611Months: string;
            const d2C1259Months: string;
            const d3VitADist: string;
            const d3VitAUse: string;
            const d3C611Months: string;
            const d3C1259Months: string;
            const d5VitADist: string;
            const d5VitAUse: string;
            const d5C611Months: string;
            const d5C1259Months: string;
            const VitaminADayCampaignId: string;
            const VitaminADayProvinceId: string;
            const VitaminADayDistrictId: string;
            const VitaminADayDayNumber: string;
            const VitaminADayDateOfCampaign: string;
            const VitaminADayPemtremtManager: string;
            const ClusterName: string;
            const TenantId: string;
        }
    }
}
declare namespace webNEOC.Implementation {
    namespace VitaminAVaccinationsService {
        const baseUrl = "Implementation/VitaminAVaccinations";
        function Create(request: Serenity.SaveRequest<VitaminAVaccinationsRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<VitaminAVaccinationsRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<VitaminAVaccinationsRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<VitaminAVaccinationsRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        namespace Methods {
            const Create: string;
            const Update: string;
            const Delete: string;
            const Retrieve: string;
            const List: string;
        }
    }
}
declare namespace webNEOC.ImportGate {
}
declare namespace webNEOC.ImportGate {
    class TempCampaignForm extends Serenity.PrefixedContext {
        static formKey: string;
    }
    interface TempCampaignForm {
        RoundId: Serenity.LookupEditor;
        ProvinceId: Serenity.LookupEditor;
        DistrictId: Serenity.LookupEditor;
        ClusterId: Serenity.LookupEditor;
        LDPTypes: Serenity.StringEditor;
        PemtremtManager: Serenity.StringEditor;
        DateOfCampaign: Serenity.DateEditor;
        TargetU5Case: Serenity.IntegerEditor;
        TeamNo: Serenity.StringEditor;
        HhNo: Serenity.IntegerEditor;
        D1VialDist: Serenity.IntegerEditor;
        D1VialUse: Serenity.IntegerEditor;
        D1Vac011Months: Serenity.IntegerEditor;
        D1Vac1259months: Serenity.IntegerEditor;
        D1RecAbsChildren: Serenity.IntegerEditor;
        D1VacAbsChildren: Serenity.IntegerEditor;
        D1RecNewbornSsc: Serenity.IntegerEditor;
        D1VacNewbornSsc: Serenity.IntegerEditor;
        D1RecRefusedChildren: Serenity.IntegerEditor;
        D1RevacRefusedChildren: Serenity.IntegerEditor;
        D1AfpCase: Serenity.IntegerEditor;
        D2VialDist: Serenity.IntegerEditor;
        D2VialUse: Serenity.IntegerEditor;
        D2Vac011Months: Serenity.IntegerEditor;
        D2Vac1259months: Serenity.IntegerEditor;
        D2RecAbsChildren: Serenity.IntegerEditor;
        D2VacAbsChildren: Serenity.IntegerEditor;
        D2RecNewbornSsc: Serenity.IntegerEditor;
        D2VacNewbornSsc: Serenity.IntegerEditor;
        D2RecRefusedChildren: Serenity.IntegerEditor;
        D2RevacRefusedChildren: Serenity.IntegerEditor;
        D2AfpCase: Serenity.IntegerEditor;
        D3VialDist: Serenity.IntegerEditor;
        D3VialUse: Serenity.IntegerEditor;
        D3Vac011Months: Serenity.IntegerEditor;
        D3Vac1259months: Serenity.IntegerEditor;
        D3RecAbsChildren: Serenity.IntegerEditor;
        D3VacAbsChildren: Serenity.IntegerEditor;
        D3RecNewbornSsc: Serenity.IntegerEditor;
        D3VacNewbornSsc: Serenity.IntegerEditor;
        D3RecRefusedChildren: Serenity.IntegerEditor;
        D3RevacRefusedChildren: Serenity.IntegerEditor;
        D3AfpCase: Serenity.IntegerEditor;
        D5VialDist: Serenity.IntegerEditor;
        D5VialUse: Serenity.IntegerEditor;
        D5Vac011Months: Serenity.IntegerEditor;
        D5Vac1259months: Serenity.IntegerEditor;
        D5RecAbsChildren: Serenity.IntegerEditor;
        D5VacAbsChildren: Serenity.IntegerEditor;
        D5RecNewbornSsc: Serenity.IntegerEditor;
        D5VacNewbornSsc: Serenity.IntegerEditor;
        D5RecRefusedChildren: Serenity.IntegerEditor;
        D5RevacRefusedChildren: Serenity.IntegerEditor;
        D5AfpCase: Serenity.IntegerEditor;
        TenantId: Serenity.IntegerEditor;
    }
}
declare namespace webNEOC.ImportGate {
    interface TempCampaignRow {
        TempCampaignId?: number;
        RoundId?: number;
        ProvinceId?: number;
        DistrictId?: number;
        DateOfCampaign?: string;
        PemtremtManager?: string;
        ClusterId?: number;
        TargetU5Case?: number;
        TeamNo?: string;
        HhNo?: number;
        D1VialDist?: number;
        D1VialUse?: number;
        D1Vac011Months?: number;
        D1Vac1259months?: number;
        D1RecAbsChildren?: number;
        D1VacAbsChildren?: number;
        D1RecNewbornSsc?: number;
        D1VacNewbornSsc?: number;
        D1RecRefusedChildren?: number;
        D1RevacRefusedChildren?: number;
        D1AfpCase?: number;
        D2VialDist?: number;
        D2VialUse?: number;
        D2Vac011Months?: number;
        D2Vac1259months?: number;
        D2RecAbsChildren?: number;
        D2VacAbsChildren?: number;
        D2RecNewbornSsc?: number;
        D2VacNewbornSsc?: number;
        D2RecRefusedChildren?: number;
        D2RevacRefusedChildren?: number;
        D2AfpCase?: number;
        D3VialDist?: number;
        D3VialUse?: number;
        D3Vac011Months?: number;
        D3Vac1259months?: number;
        D3RecAbsChildren?: number;
        D3VacAbsChildren?: number;
        D3RecNewbornSsc?: number;
        D3VacNewbornSsc?: number;
        D3RecRefusedChildren?: number;
        D3RevacRefusedChildren?: number;
        D3AfpCase?: number;
        D5VialDist?: number;
        D5VialUse?: number;
        D5Vac011Months?: number;
        D5Vac1259months?: number;
        D5RecAbsChildren?: number;
        D5VacAbsChildren?: number;
        D5RecNewbornSsc?: number;
        D5VacNewbornSsc?: number;
        D5RecRefusedChildren?: number;
        D5RevacRefusedChildren?: number;
        D5AfpCase?: number;
        TenantId?: number;
        RoundName?: string;
        ProvinceName?: string;
        DistrictName?: string;
        ClusterName?: string;
        LDPTypes?: string;
    }
    namespace TempCampaignRow {
        const idProperty = "TempCampaignId";
        const nameProperty = "PemtremtManager";
        const localTextPrefix = "ImportGate.TempCampaign";
        namespace Fields {
            const TempCampaignId: string;
            const RoundId: string;
            const ProvinceId: string;
            const DistrictId: string;
            const DateOfCampaign: string;
            const PemtremtManager: string;
            const ClusterId: string;
            const TargetU5Case: string;
            const TeamNo: string;
            const HhNo: string;
            const D1VialDist: string;
            const D1VialUse: string;
            const D1Vac011Months: string;
            const D1Vac1259months: string;
            const D1RecAbsChildren: string;
            const D1VacAbsChildren: string;
            const D1RecNewbornSsc: string;
            const D1VacNewbornSsc: string;
            const D1RecRefusedChildren: string;
            const D1RevacRefusedChildren: string;
            const D1AfpCase: string;
            const D2VialDist: string;
            const D2VialUse: string;
            const D2Vac011Months: string;
            const D2Vac1259months: string;
            const D2RecAbsChildren: string;
            const D2VacAbsChildren: string;
            const D2RecNewbornSsc: string;
            const D2VacNewbornSsc: string;
            const D2RecRefusedChildren: string;
            const D2RevacRefusedChildren: string;
            const D2AfpCase: string;
            const D3VialDist: string;
            const D3VialUse: string;
            const D3Vac011Months: string;
            const D3Vac1259months: string;
            const D3RecAbsChildren: string;
            const D3VacAbsChildren: string;
            const D3RecNewbornSsc: string;
            const D3VacNewbornSsc: string;
            const D3RecRefusedChildren: string;
            const D3RevacRefusedChildren: string;
            const D3AfpCase: string;
            const D5VialDist: string;
            const D5VialUse: string;
            const D5Vac011Months: string;
            const D5Vac1259months: string;
            const D5RecAbsChildren: string;
            const D5VacAbsChildren: string;
            const D5RecNewbornSsc: string;
            const D5VacNewbornSsc: string;
            const D5RecRefusedChildren: string;
            const D5RevacRefusedChildren: string;
            const D5AfpCase: string;
            const TenantId: string;
            const RoundName: string;
            const ProvinceName: string;
            const DistrictName: string;
            const ClusterName: string;
            const LDPTypes: string;
        }
    }
}
declare namespace webNEOC.ImportGate {
    namespace TempCampaignService {
        const baseUrl = "ImportGate/TempCampaign";
        function Create(request: Serenity.SaveRequest<TempCampaignRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<TempCampaignRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<TempCampaignRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<TempCampaignRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function ExecProcedure(request: Serenity.ServiceRequest, onSuccess?: (response: System.Int32) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        namespace Methods {
            const Create: string;
            const Update: string;
            const Delete: string;
            const Retrieve: string;
            const List: string;
            const ExecProcedure: string;
        }
    }
}
declare namespace webNEOC.ImportGate {
}
declare namespace webNEOC.ImportGate {
    class TempVitaminAForm extends Serenity.PrefixedContext {
        static formKey: string;
    }
    interface TempVitaminAForm {
        RoundId: Serenity.LookupEditor;
        ProvinceId: Serenity.LookupEditor;
        DistrictId: Serenity.LookupEditor;
        ClusterId: Serenity.LookupEditor;
        PemtremtManager: Serenity.StringEditor;
        TargetU5Cases: Serenity.IntegerEditor;
        D1VitADist: Serenity.IntegerEditor;
        D1VitAUse: Serenity.IntegerEditor;
        D1C611Months: Serenity.IntegerEditor;
        D1C1259Months: Serenity.IntegerEditor;
        D2VitADist: Serenity.IntegerEditor;
        D2VitAUse: Serenity.IntegerEditor;
        D2C611Months: Serenity.IntegerEditor;
        D2C1259Months: Serenity.IntegerEditor;
        D3VitADist: Serenity.IntegerEditor;
        D3VitAUse: Serenity.IntegerEditor;
        D3C611Months: Serenity.IntegerEditor;
        D3C1259Months: Serenity.IntegerEditor;
        D5VitADist: Serenity.IntegerEditor;
        D5VitAUse: Serenity.IntegerEditor;
        D5C611Months: Serenity.IntegerEditor;
        D5C1259Months: Serenity.IntegerEditor;
        TenantId: Serenity.IntegerEditor;
    }
}
declare namespace webNEOC.ImportGate {
    interface TempVitaminARow {
        TempVitaminAId?: number;
        RoundId?: number;
        ProvinceId?: number;
        DistrictId?: number;
        PemtremtManager?: string;
        ClusterId?: number;
        TargetU5Cases?: number;
        D1VitADist?: number;
        D1VitAUse?: number;
        D1C611Months?: number;
        D1C1259Months?: number;
        D2VitADist?: number;
        D2VitAUse?: number;
        D2C611Months?: number;
        D2C1259Months?: number;
        D3VitADist?: number;
        D3VitAUse?: number;
        D3C611Months?: number;
        D3C1259Months?: number;
        D5VitADist?: number;
        D5VitAUse?: number;
        D5C611Months?: number;
        D5C1259Months?: number;
        TenantId?: number;
        RoundName?: string;
        ProvinceName?: string;
        DistrictName?: string;
        ClusterName?: string;
    }
    namespace TempVitaminARow {
        const idProperty = "TempVitaminAId";
        const nameProperty = "PemtremtManager";
        const localTextPrefix = "ImportGate.TempVitaminA";
        namespace Fields {
            const TempVitaminAId: string;
            const RoundId: string;
            const ProvinceId: string;
            const DistrictId: string;
            const PemtremtManager: string;
            const ClusterId: string;
            const TargetU5Cases: string;
            const D1VitADist: string;
            const D1VitAUse: string;
            const D1C611Months: string;
            const D1C1259Months: string;
            const D2VitADist: string;
            const D2VitAUse: string;
            const D2C611Months: string;
            const D2C1259Months: string;
            const D3VitADist: string;
            const D3VitAUse: string;
            const D3C611Months: string;
            const D3C1259Months: string;
            const D5VitADist: string;
            const D5VitAUse: string;
            const D5C611Months: string;
            const D5C1259Months: string;
            const TenantId: string;
            const RoundName: string;
            const ProvinceName: string;
            const DistrictName: string;
            const ClusterName: string;
        }
    }
}
declare namespace webNEOC.ImportGate {
    namespace TempVitaminAService {
        const baseUrl = "ImportGate/TempVitaminA";
        function Create(request: Serenity.SaveRequest<TempVitaminARow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<TempVitaminARow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<TempVitaminARow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<TempVitaminARow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function ExecProcedure(request: Serenity.ServiceRequest, onSuccess?: (response: System.Int32) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        namespace Methods {
            const Create: string;
            const Update: string;
            const Delete: string;
            const Retrieve: string;
            const List: string;
            const ExecProcedure: string;
        }
    }
}
declare namespace webNEOC.ImportHelper {
    class AdminDataImportForm extends Serenity.PrefixedContext {
        static formKey: string;
    }
    interface AdminDataImportForm {
        FileName: Serenity.ImageUploadEditor;
    }
}
declare namespace webNEOC.ImportHelper {
    namespace AdminDataImportService {
        const baseUrl = "ImportHelper/AdminDataImport";
        function ExcelImport(request: ExcelImportRequest, onSuccess?: (response: ExcelImportResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        namespace Methods {
            const ExcelImport: string;
        }
    }
}
declare namespace webNEOC.ImportHelper {
    class CampaignImportForm extends Serenity.PrefixedContext {
        static formKey: string;
    }
    interface CampaignImportForm {
        FileName: Serenity.ImageUploadEditor;
    }
}
declare namespace webNEOC.ImportHelper {
    namespace CampaignImportService {
        const baseUrl = "ImportHelper/CampaignImport";
        function ExcelImport(request: ExcelImportRequest, onSuccess?: (response: ExcelImportResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        namespace Methods {
            const ExcelImport: string;
        }
    }
}
declare namespace webNEOC.ImportHelper {
    class CommunicationImportForm extends Serenity.PrefixedContext {
        static formKey: string;
    }
    interface CommunicationImportForm {
        FileName: Serenity.ImageUploadEditor;
    }
}
declare namespace webNEOC.ImportHelper {
    namespace CommunicationImportService {
        const baseUrl = "ImportHelper/CommunicationImport";
        function ExcelImport(request: ExcelImportRequest, onSuccess?: (response: ExcelImportResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        namespace Methods {
            const ExcelImport: string;
        }
    }
}
declare namespace webNEOC.ImportHelper {
    class ICMHouseholdImportForm extends Serenity.PrefixedContext {
        static formKey: string;
    }
    interface ICMHouseholdImportForm {
        FileName: Serenity.ImageUploadEditor;
    }
}
declare namespace webNEOC.ImportHelper {
    namespace ICMHouseholdImportService {
        const baseUrl = "ImportHelper/ICMHouseholdImport";
        function ExcelImport(request: ExcelImportRequest, onSuccess?: (response: ExcelImportResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        namespace Methods {
            const ExcelImport: string;
        }
    }
}
declare namespace webNEOC.ImportHelper {
    class ICMSupervisorImportForm extends Serenity.PrefixedContext {
        static formKey: string;
    }
    interface ICMSupervisorImportForm {
        FileName: Serenity.ImageUploadEditor;
    }
}
declare namespace webNEOC.ImportHelper {
    namespace ICMSupervisorImportService {
        const baseUrl = "ImportHelper/ICMSupervisorImport";
        function ExcelImport(request: ExcelImportRequest, onSuccess?: (response: ExcelImportResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        namespace Methods {
            const ExcelImport: string;
        }
    }
}
declare namespace webNEOC.ImportHelper {
    class ICMTeamImportForm extends Serenity.PrefixedContext {
        static formKey: string;
    }
    interface ICMTeamImportForm {
        FileName: Serenity.ImageUploadEditor;
    }
}
declare namespace webNEOC.ImportHelper {
    namespace ICMTeamImportService {
        const baseUrl = "ImportHelper/ICMTeamImport";
        function ExcelImport(request: ExcelImportRequest, onSuccess?: (response: ExcelImportResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        namespace Methods {
            const ExcelImport: string;
        }
    }
}
declare namespace webNEOC.ImportHelper {
    class ICNImportForm extends Serenity.PrefixedContext {
        static formKey: string;
    }
    interface ICNImportForm {
        FileName: Serenity.ImageUploadEditor;
    }
}
declare namespace webNEOC.ImportHelper {
    namespace ICNImportService {
        const baseUrl = "ImportHelper/ICNImport";
        function ExcelImport(request: ExcelImportRequest, onSuccess?: (response: ExcelImportResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        namespace Methods {
            const ExcelImport: string;
        }
    }
}
declare namespace webNEOC.ImportHelper {
    class InAccessibleImportForm extends Serenity.PrefixedContext {
        static formKey: string;
    }
    interface InAccessibleImportForm {
        FileName: Serenity.ImageUploadEditor;
    }
}
declare namespace webNEOC.ImportHelper {
    namespace InAccessibleImportService {
        const baseUrl = "ImportHelper/InAccessibleImport";
        function ExcelImport(request: ExcelImportRequest, onSuccess?: (response: ExcelImportResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        namespace Methods {
            const ExcelImport: string;
        }
    }
}
declare namespace webNEOC.ImportHelper {
    class LQASImportForm extends Serenity.PrefixedContext {
        static formKey: string;
    }
    interface LQASImportForm {
        FileName: Serenity.ImageUploadEditor;
    }
}
declare namespace webNEOC.ImportHelper {
    namespace LQASImportService {
        const baseUrl = "ImportHelper/LQASImport";
        function ExcelImport(request: ExcelImportRequest, onSuccess?: (response: ExcelImportResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        namespace Methods {
            const ExcelImport: string;
        }
    }
}
declare namespace webNEOC.ImportHelper {
    class MobileTeamImportForm extends Serenity.PrefixedContext {
        static formKey: string;
    }
    interface MobileTeamImportForm {
        FileName: Serenity.ImageUploadEditor;
    }
}
declare namespace webNEOC.ImportHelper {
    namespace MobileTeamImportService {
        const baseUrl = "ImportHelper/MobileTeamImport";
        function ExcelImport(request: ExcelImportRequest, onSuccess?: (response: ExcelImportResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        namespace Methods {
            const ExcelImport: string;
        }
    }
}
declare namespace webNEOC.ImportHelper {
    class OutHouseImportForm extends Serenity.PrefixedContext {
        static formKey: string;
    }
    interface OutHouseImportForm {
        FileName: Serenity.ImageUploadEditor;
    }
}
declare namespace webNEOC.ImportHelper {
    namespace OutHouseImportService {
        const baseUrl = "ImportHelper/OutHouseImport";
        function ExcelImport(request: ExcelImportRequest, onSuccess?: (response: ExcelImportResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        namespace Methods {
            const ExcelImport: string;
        }
    }
}
declare namespace webNEOC.ImportHelper {
    class PcmImportForm extends Serenity.PrefixedContext {
        static formKey: string;
    }
    interface PcmImportForm {
        FileName: Serenity.ImageUploadEditor;
    }
}
declare namespace webNEOC.ImportHelper {
    namespace PcmImportService {
        const baseUrl = "ImportHelper/PcmImport";
        function ExcelImport(request: ExcelImportRequest, onSuccess?: (response: ExcelImportResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        namespace Methods {
            const ExcelImport: string;
        }
    }
}
declare namespace webNEOC.ImportHelper {
    class TargetImportForm extends Serenity.PrefixedContext {
        static formKey: string;
    }
    interface TargetImportForm {
        FileName: Serenity.ImageUploadEditor;
    }
}
declare namespace webNEOC.ImportHelper {
    namespace TargetImportService {
        const baseUrl = "ImportHelper/TargetImport";
        function ExcelImport(request: ExcelImportRequest, onSuccess?: (response: ExcelImportResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        namespace Methods {
            const ExcelImport: string;
        }
    }
}
declare namespace webNEOC.ImportHelper {
    class VitaminAImportForm extends Serenity.PrefixedContext {
        static formKey: string;
    }
    interface VitaminAImportForm {
        FileName: Serenity.ImageUploadEditor;
    }
}
declare namespace webNEOC.ImportHelper {
    namespace VitaminAImportService {
        const baseUrl = "ImportHelper/VitaminAImport";
        function ExcelImport(request: ExcelImportRequest, onSuccess?: (response: ExcelImportResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        namespace Methods {
            const ExcelImport: string;
        }
    }
}
declare namespace webNEOC.Locations {
}
declare namespace webNEOC.Locations {
    class ClusterForm extends Serenity.PrefixedContext {
        static formKey: string;
    }
    interface ClusterForm {
        ProvinceId: Serenity.LookupEditor;
        DistrictId: Serenity.LookupEditor;
        Ccode: Serenity.StringEditor;
        Cname: Serenity.StringEditor;
        Targetpop: Serenity.IntegerEditor;
    }
}
declare namespace webNEOC.Locations {
    interface ClusterRow {
        ClusterId?: number;
        DistrictId?: number;
        Ccode?: string;
        Cname?: string;
        Targetpop?: number;
        DistrictDcode?: string;
        ProvinceId?: number;
        Dname?: string;
        DistrictTotalPop?: number;
        DistrictTargetPop?: number;
        DistrictType?: string;
        DistrictPriority?: number;
        DistrictPopYear?: number;
        Province?: string;
    }
    namespace ClusterRow {
        const idProperty = "ClusterId";
        const nameProperty = "Cname";
        const localTextPrefix = "Locations.Cluster";
        const lookupKey = "Locations.Cluster";
        function getLookup(): Q.Lookup<ClusterRow>;
        namespace Fields {
            const ClusterId: string;
            const DistrictId: string;
            const Ccode: string;
            const Cname: string;
            const Targetpop: string;
            const DistrictDcode: string;
            const ProvinceId: string;
            const Dname: string;
            const DistrictTotalPop: string;
            const DistrictTargetPop: string;
            const DistrictType: string;
            const DistrictPriority: string;
            const DistrictPopYear: string;
            const Province: string;
        }
    }
}
declare namespace webNEOC.Locations {
    namespace ClusterService {
        const baseUrl = "Locations/Cluster";
        function Create(request: Serenity.SaveRequest<ClusterRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<ClusterRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<ClusterRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<ClusterRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        namespace Methods {
            const Create: string;
            const Update: string;
            const Delete: string;
            const Retrieve: string;
            const List: string;
        }
    }
}
declare namespace webNEOC.Locations {
}
declare namespace webNEOC.Locations {
    class DistrictForm extends Serenity.PrefixedContext {
        static formKey: string;
    }
    interface DistrictForm {
        Dcode: Serenity.StringEditor;
        ProvinceId: Serenity.LookupEditor;
        Dname: Serenity.StringEditor;
        TotalPop: Serenity.IntegerEditor;
        TargetPop: Serenity.IntegerEditor;
        Type: Serenity.StringEditor;
        Priority: Serenity.IntegerEditor;
        PopYear: Serenity.IntegerEditor;
    }
}
declare namespace webNEOC.Locations {
    interface DistrictRow {
        DistrictId?: number;
        Dcode?: string;
        ProvinceId?: number;
        Dname?: string;
        TotalPop?: number;
        TargetPop?: number;
        Type?: string;
        Priority?: number;
        PopYear?: number;
        ProvincePcode?: string;
        ProvinceRegionId?: number;
        Pname?: string;
        ProvincePAbrv?: string;
        ProvincePcenter?: string;
        ProvinceAreaKmSqr?: number;
        ProvinceNoOfDistricts?: number;
    }
    namespace DistrictRow {
        const idProperty = "DistrictId";
        const nameProperty = "Dname";
        const localTextPrefix = "Locations.District";
        const lookupKey = "Locations.District";
        function getLookup(): Q.Lookup<DistrictRow>;
        namespace Fields {
            const DistrictId: string;
            const Dcode: string;
            const ProvinceId: string;
            const Dname: string;
            const TotalPop: string;
            const TargetPop: string;
            const Type: string;
            const Priority: string;
            const PopYear: string;
            const ProvincePcode: string;
            const ProvinceRegionId: string;
            const Pname: string;
            const ProvincePAbrv: string;
            const ProvincePcenter: string;
            const ProvinceAreaKmSqr: string;
            const ProvinceNoOfDistricts: string;
        }
    }
}
declare namespace webNEOC.Locations {
    namespace DistrictService {
        const baseUrl = "Locations/District";
        function Create(request: Serenity.SaveRequest<DistrictRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<DistrictRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<DistrictRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<DistrictRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        namespace Methods {
            const Create: string;
            const Update: string;
            const Delete: string;
            const Retrieve: string;
            const List: string;
        }
    }
}
declare namespace webNEOC.Locations {
}
declare namespace webNEOC.Locations {
    class ProvinceForm extends Serenity.PrefixedContext {
        static formKey: string;
    }
    interface ProvinceForm {
        Pcode: Serenity.StringEditor;
        RegionId: Serenity.LookupEditor;
        Pname: Serenity.StringEditor;
        PAbrv: Serenity.StringEditor;
        Pcenter: Serenity.StringEditor;
        AreaKmSqr: Serenity.IntegerEditor;
        NoOfDistricts: Serenity.IntegerEditor;
    }
}
declare namespace webNEOC.Locations {
    interface ProvinceRow {
        ProvinceId?: number;
        Pcode?: string;
        RegionId?: number;
        Pname?: string;
        PAbrv?: string;
        Pcenter?: string;
        AreaKmSqr?: number;
        NoOfDistricts?: number;
        Rname?: string;
        RegionRAbrv?: string;
    }
    namespace ProvinceRow {
        const idProperty = "ProvinceId";
        const nameProperty = "Pname";
        const localTextPrefix = "Locations.Province";
        const lookupKey = "Locations.Province";
        function getLookup(): Q.Lookup<ProvinceRow>;
        namespace Fields {
            const ProvinceId: string;
            const Pcode: string;
            const RegionId: string;
            const Pname: string;
            const PAbrv: string;
            const Pcenter: string;
            const AreaKmSqr: string;
            const NoOfDistricts: string;
            const Rname: string;
            const RegionRAbrv: string;
        }
    }
}
declare namespace webNEOC.Locations {
    namespace ProvinceService {
        const baseUrl = "Locations/Province";
        function Create(request: Serenity.SaveRequest<ProvinceRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<ProvinceRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<ProvinceRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<ProvinceRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        namespace Methods {
            const Create: string;
            const Update: string;
            const Delete: string;
            const Retrieve: string;
            const List: string;
        }
    }
}
declare namespace webNEOC.Locations {
}
declare namespace webNEOC.Locations {
    class RegionForm extends Serenity.PrefixedContext {
        static formKey: string;
    }
    interface RegionForm {
        Rname: Serenity.StringEditor;
        RAbrv: Serenity.StringEditor;
    }
}
declare namespace webNEOC.Locations {
    interface RegionRow {
        RegionId?: number;
        Rname?: string;
        RAbrv?: string;
    }
    namespace RegionRow {
        const idProperty = "RegionId";
        const nameProperty = "Rname";
        const localTextPrefix = "Locations.Region";
        const lookupKey = "Locations.Region";
        function getLookup(): Q.Lookup<RegionRow>;
        namespace Fields {
            const RegionId: string;
            const Rname: string;
            const RAbrv: string;
        }
    }
}
declare namespace webNEOC.Locations {
    namespace RegionService {
        const baseUrl = "Locations/Region";
        function Create(request: Serenity.SaveRequest<RegionRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<RegionRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<RegionRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<RegionRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        namespace Methods {
            const Create: string;
            const Update: string;
            const Delete: string;
            const Retrieve: string;
            const List: string;
        }
    }
}
declare namespace webNEOC.Lookup {
}
declare namespace webNEOC.Lookup {
    class CampaignTypeForm extends Serenity.PrefixedContext {
        static formKey: string;
    }
    interface CampaignTypeForm {
        CampaignName: Serenity.StringEditor;
    }
}
declare namespace webNEOC.Lookup {
    interface CampaignTypeRow {
        CampaignTypeId?: number;
        CampaignName?: string;
    }
    namespace CampaignTypeRow {
        const idProperty = "CampaignTypeId";
        const nameProperty = "CampaignName";
        const localTextPrefix = "Lookup.CampaignType";
        const lookupKey = "Lookup.CampaignType";
        function getLookup(): Q.Lookup<CampaignTypeRow>;
        namespace Fields {
            const CampaignTypeId: string;
            const CampaignName: string;
        }
    }
}
declare namespace webNEOC.Lookup {
    namespace CampaignTypeService {
        const baseUrl = "Lookup/CampaignType";
        function Create(request: Serenity.SaveRequest<CampaignTypeRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<CampaignTypeRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<CampaignTypeRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<CampaignTypeRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        namespace Methods {
            const Create: string;
            const Update: string;
            const Delete: string;
            const Retrieve: string;
            const List: string;
        }
    }
}
declare namespace webNEOC.Lookup {
}
declare namespace webNEOC.Lookup {
    class ClusterLevelForm extends Serenity.PrefixedContext {
        static formKey: string;
    }
    interface ClusterLevelForm {
        ClusterName: Serenity.StringEditor;
    }
}
declare namespace webNEOC.Lookup {
    interface ClusterLevelRow {
        ClusterLevelId?: number;
        ClusterName?: string;
    }
    namespace ClusterLevelRow {
        const idProperty = "ClusterLevelId";
        const nameProperty = "ClusterName";
        const localTextPrefix = "Lookup.ClusterLevel";
        const lookupKey = "Lookup.ClusterLevel";
        function getLookup(): Q.Lookup<ClusterLevelRow>;
        namespace Fields {
            const ClusterLevelId: string;
            const ClusterName: string;
        }
    }
}
declare namespace webNEOC.Lookup {
    namespace ClusterLevelService {
        const baseUrl = "Lookup/ClusterLevel";
        function Create(request: Serenity.SaveRequest<ClusterLevelRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<ClusterLevelRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<ClusterLevelRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<ClusterLevelRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        namespace Methods {
            const Create: string;
            const Update: string;
            const Delete: string;
            const Retrieve: string;
            const List: string;
        }
    }
}
declare namespace webNEOC.Lookup {
    class DayPartForm extends Serenity.PrefixedContext {
        static formKey: string;
    }
    interface DayPartForm {
        Daypart: Serenity.StringEditor;
    }
}
declare namespace webNEOC.Lookup {
    interface DayPartRow {
        DaypartId?: number;
        Daypart?: string;
    }
    namespace DayPartRow {
        const idProperty = "DaypartId";
        const nameProperty = "Daypart";
        const localTextPrefix = "Lookup.DayPart";
        namespace Fields {
            const DaypartId: string;
            const Daypart: string;
        }
    }
}
declare namespace webNEOC.Lookup {
    namespace DayPartService {
        const baseUrl = "Lookup/DayPart";
        function Create(request: Serenity.SaveRequest<DaysRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<DaysRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<DaysRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<DaysRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        namespace Methods {
            const Create: string;
            const Update: string;
            const Delete: string;
            const Retrieve: string;
            const List: string;
        }
    }
}
declare namespace webNEOC.Lookup {
}
declare namespace webNEOC.Lookup {
    class DaysForm extends Serenity.PrefixedContext {
        static formKey: string;
    }
    interface DaysForm {
        DayName: Serenity.StringEditor;
    }
}
declare namespace webNEOC.Lookup {
    interface DaysRow {
        DayId?: number;
        DayName?: string;
    }
    namespace DaysRow {
        const idProperty = "DayId";
        const nameProperty = "DayName";
        const localTextPrefix = "Lookup.Days";
        namespace Fields {
            const DayId: string;
            const DayName: string;
        }
    }
}
declare namespace webNEOC.Lookup {
    namespace DaysService {
        const baseUrl = "Lookup/Days";
        function Create(request: Serenity.SaveRequest<DaysRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<DaysRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<DaysRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<DaysRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        namespace Methods {
            const Create: string;
            const Update: string;
            const Delete: string;
            const Retrieve: string;
            const List: string;
        }
    }
}
declare namespace webNEOC.Lookup {
}
declare namespace webNEOC.Lookup {
    class IcnTypeForm extends Serenity.PrefixedContext {
        static formKey: string;
    }
    interface IcnTypeForm {
        IcnType: Serenity.StringEditor;
    }
}
declare namespace webNEOC.Lookup {
    interface IcnTypeRow {
        IcnTypeId?: number;
        IcnType?: string;
    }
    namespace IcnTypeRow {
        const idProperty = "IcnTypeId";
        const nameProperty = "IcnType";
        const localTextPrefix = "Lookup.IcnType";
        namespace Fields {
            const IcnTypeId: string;
            const IcnType: string;
        }
    }
}
declare namespace webNEOC.Lookup {
    namespace IcnTypeService {
        const baseUrl = "Lookup/IcnType";
        function Create(request: Serenity.SaveRequest<IcnTypeRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<IcnTypeRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<IcnTypeRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<IcnTypeRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        namespace Methods {
            const Create: string;
            const Update: string;
            const Delete: string;
            const Retrieve: string;
            const List: string;
        }
    }
}
declare namespace webNEOC.Lookup {
}
declare namespace webNEOC.Lookup {
    class InAcsCategoryForm extends Serenity.PrefixedContext {
        static formKey: string;
    }
    interface InAcsCategoryForm {
        CategoryCode: Serenity.StringEditor;
        Description: Serenity.StringEditor;
    }
}
declare namespace webNEOC.Lookup {
    interface InAcsCategoryRow {
        InAcsCategoryId?: number;
        CategoryCode?: string;
        Description?: string;
    }
    namespace InAcsCategoryRow {
        const idProperty = "InAcsCategoryId";
        const nameProperty = "Description";
        const localTextPrefix = "Lookup.InAcsCategory";
        const lookupKey = "Lookup.InAcsCategory";
        function getLookup(): Q.Lookup<InAcsCategoryRow>;
        namespace Fields {
            const InAcsCategoryId: string;
            const CategoryCode: string;
            const Description: string;
        }
    }
}
declare namespace webNEOC.Lookup {
    namespace InAcsCategoryService {
        const baseUrl = "Lookup/InAcsCategory";
        function Create(request: Serenity.SaveRequest<InAcsCategoryRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<InAcsCategoryRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<InAcsCategoryRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<InAcsCategoryRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        namespace Methods {
            const Create: string;
            const Update: string;
            const Delete: string;
            const Retrieve: string;
            const List: string;
        }
    }
}
declare namespace webNEOC.Lookup {
    class LangForm extends Serenity.PrefixedContext {
        static formKey: string;
    }
    interface LangForm {
        LanguageName: Serenity.StringEditor;
    }
}
declare namespace webNEOC.Lookup {
    interface LangRow {
        LanguageId?: number;
        LanguageName?: string;
    }
    namespace LangRow {
        const idProperty = "LanguageId";
        const nameProperty = "LanguageName";
        const localTextPrefix = "Lookup.Lang";
        namespace Fields {
            const LanguageId: any;
            const LanguageName: any;
        }
    }
}
declare namespace webNEOC.Lookup {
    namespace LangService {
        const baseUrl = "Lookup/Lang";
        function Create(request: Serenity.SaveRequest<DaysRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<DaysRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<DaysRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<DaysRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        namespace Methods {
            const Create: string;
            const Update: string;
            const Delete: string;
            const Retrieve: string;
            const List: string;
        }
    }
}
declare namespace webNEOC.Lookup {
}
declare namespace webNEOC.Lookup {
    class MediaForm extends Serenity.PrefixedContext {
        static formKey: string;
    }
    interface MediaForm {
        MediaName: Serenity.StringEditor;
    }
}
declare namespace webNEOC.Lookup {
    interface MediaRow {
        MediaId?: number;
        MediaName?: string;
    }
    namespace MediaRow {
        const idProperty = "MediaId";
        const nameProperty = "MediaName";
        const localTextPrefix = "Lookup.Media";
        namespace Fields {
            const MediaId: string;
            const MediaName: string;
        }
    }
}
declare namespace webNEOC.Lookup {
    namespace MediaService {
        const baseUrl = "Lookup/Media";
        function Create(request: Serenity.SaveRequest<MediaRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<MediaRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<MediaRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<MediaRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        namespace Methods {
            const Create: string;
            const Update: string;
            const Delete: string;
            const Retrieve: string;
            const List: string;
        }
    }
}
declare namespace webNEOC.Lookup {
}
declare namespace webNEOC.Lookup {
    class MediaTypeForm extends Serenity.PrefixedContext {
        static formKey: string;
    }
    interface MediaTypeForm {
        MediaTypeName: Serenity.StringEditor;
    }
}
declare namespace webNEOC.Lookup {
    interface MediaTypeRow {
        MediaTypeId?: number;
        MediaTypeName?: string;
    }
    namespace MediaTypeRow {
        const idProperty = "MediaTypeId";
        const nameProperty = "MediaTypeName";
        const localTextPrefix = "Lookup.MediaType";
        namespace Fields {
            const MediaTypeId: string;
            const MediaTypeName: string;
        }
    }
}
declare namespace webNEOC.Lookup {
    namespace MediaTypeService {
        const baseUrl = "Lookup/MediaType";
        function Create(request: Serenity.SaveRequest<MediaTypeRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<MediaTypeRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<MediaTypeRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<MediaTypeRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        namespace Methods {
            const Create: string;
            const Update: string;
            const Delete: string;
            const Retrieve: string;
            const List: string;
        }
    }
}
declare namespace webNEOC.Lookup {
}
declare namespace webNEOC.Lookup {
    class MonthsForm extends Serenity.PrefixedContext {
        static formKey: string;
    }
    interface MonthsForm {
        Monthshort: Serenity.StringEditor;
        Monthlong: Serenity.StringEditor;
    }
}
declare namespace webNEOC.Lookup {
    interface MonthsRow {
        MonthId?: number;
        Monthshort?: string;
        Monthlong?: string;
    }
    namespace MonthsRow {
        const idProperty = "MonthId";
        const nameProperty = "Monthlong";
        const localTextPrefix = "Lookup.Months";
        const lookupKey = "Lookup.Months";
        function getLookup(): Q.Lookup<MonthsRow>;
        namespace Fields {
            const MonthId: string;
            const Monthshort: string;
            const Monthlong: string;
        }
    }
}
declare namespace webNEOC.Lookup {
    namespace MonthsService {
        const baseUrl = "Lookup/Months";
        function Create(request: Serenity.SaveRequest<MonthsRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<MonthsRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<MonthsRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<MonthsRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        namespace Methods {
            const Create: string;
            const Update: string;
            const Delete: string;
            const Retrieve: string;
            const List: string;
        }
    }
}
declare namespace webNEOC.Lookup {
}
declare namespace webNEOC.Lookup {
    class PartForm extends Serenity.PrefixedContext {
        static formKey: string;
    }
    interface PartForm {
        PartName: Serenity.StringEditor;
    }
}
declare namespace webNEOC.Lookup {
    interface PartRow {
        PartId?: number;
        PartName?: string;
    }
    namespace PartRow {
        const idProperty = "PartId";
        const nameProperty = "PartName";
        const localTextPrefix = "Lookup.Part";
        const lookupKey = "Lookup.Part";
        function getLookup(): Q.Lookup<PartRow>;
        namespace Fields {
            const PartId: string;
            const PartName: string;
        }
    }
}
declare namespace webNEOC.Lookup {
    namespace PartService {
        const baseUrl = "Lookup/Part";
        function Create(request: Serenity.SaveRequest<PartRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<PartRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<PartRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<PartRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        namespace Methods {
            const Create: string;
            const Update: string;
            const Delete: string;
            const Retrieve: string;
            const List: string;
        }
    }
}
declare namespace webNEOC.Lookup {
}
declare namespace webNEOC.Lookup {
    class RecruitmentTypeForm extends Serenity.PrefixedContext {
        static formKey: string;
    }
    interface RecruitmentTypeForm {
        RecruitmentType: Serenity.StringEditor;
    }
}
declare namespace webNEOC.Lookup {
    interface RecruitmentTypeRow {
        RecruitmentTypeId?: number;
        RecruitmentType?: string;
    }
    namespace RecruitmentTypeRow {
        const idProperty = "RecruitmentTypeId";
        const nameProperty = "RecruitmentType";
        const localTextPrefix = "Lookup.RecruitmentType";
        namespace Fields {
            const RecruitmentTypeId: string;
            const RecruitmentType: string;
        }
    }
}
declare namespace webNEOC.Lookup {
    namespace RecruitmentTypeService {
        const baseUrl = "Lookup/RecruitmentType";
        function Create(request: Serenity.SaveRequest<RecruitmentTypeRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<RecruitmentTypeRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<RecruitmentTypeRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<RecruitmentTypeRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        namespace Methods {
            const Create: string;
            const Update: string;
            const Delete: string;
            const Retrieve: string;
            const List: string;
        }
    }
}
declare namespace webNEOC.Lookup {
}
declare namespace webNEOC.Lookup {
    class RoundForm extends Serenity.PrefixedContext {
        static formKey: string;
    }
    interface RoundForm {
        CampaignTypeId: Serenity.LookupEditor;
        DateFrom: Serenity.DateEditor;
        DateTo: Serenity.DateEditor;
        RoundName: Serenity.StringEditor;
    }
}
declare namespace webNEOC.Lookup {
    interface RoundRow {
        RoundId?: number;
        DateFrom?: string;
        DateTo?: string;
        RoundName?: string;
        CampaignTypeId?: number;
        CampaignName?: string;
    }
    namespace RoundRow {
        const idProperty = "RoundId";
        const nameProperty = "RoundName";
        const localTextPrefix = "Lookup.Round";
        const lookupKey = "Lookup.Round";
        function getLookup(): Q.Lookup<RoundRow>;
        namespace Fields {
            const RoundId: string;
            const DateFrom: string;
            const DateTo: string;
            const RoundName: string;
            const CampaignTypeId: string;
            const CampaignName: string;
        }
    }
}
declare namespace webNEOC.Lookup {
    namespace RoundService {
        const baseUrl = "Lookup/Round";
        function Create(request: Serenity.SaveRequest<RoundRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<RoundRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<RoundRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<RoundRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        namespace Methods {
            const Create: string;
            const Update: string;
            const Delete: string;
            const Retrieve: string;
            const List: string;
        }
    }
}
declare namespace webNEOC.Lookup {
}
declare namespace webNEOC.Lookup {
    class StatusForm extends Serenity.PrefixedContext {
        static formKey: string;
    }
    interface StatusForm {
        StatusName: Serenity.StringEditor;
    }
}
declare namespace webNEOC.Lookup {
    interface StatusRow {
        StatusId?: number;
        StatusName?: string;
    }
    namespace StatusRow {
        const idProperty = "StatusId";
        const nameProperty = "StatusName";
        const localTextPrefix = "Lookup.Status";
        const lookupKey = "Lookup.Status";
        function getLookup(): Q.Lookup<StatusRow>;
        namespace Fields {
            const StatusId: string;
            const StatusName: string;
        }
    }
}
declare namespace webNEOC.Lookup {
    namespace StatusService {
        const baseUrl = "Lookup/Status";
        function Create(request: Serenity.SaveRequest<StatusRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<StatusRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<StatusRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<StatusRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        namespace Methods {
            const Create: string;
            const Update: string;
            const Delete: string;
            const Retrieve: string;
            const List: string;
        }
    }
}
declare namespace webNEOC.Lookup {
}
declare namespace webNEOC.Lookup {
    class TargetPopForm extends Serenity.PrefixedContext {
        static formKey: string;
    }
    interface TargetPopForm {
        ProvinceId: Serenity.LookupEditor;
        DistrictId: Serenity.LookupEditor;
        YearId: Serenity.IntegerEditor;
        Population: Serenity.StringEditor;
        Target: Serenity.IntegerEditor;
        LpDs: Serenity.StringEditor;
        Comment: Serenity.StringEditor;
    }
}
declare namespace webNEOC.Lookup {
    interface TargetPopRow {
        TargetId?: number;
        DistrictId?: number;
        YearId?: number;
        Population?: number;
        Target?: number;
        LpDs?: string;
        Comment?: string;
        DistrictDcode?: string;
        DistrictProvinceId?: number;
        DistrictDname?: string;
        DistrictTotalPop?: number;
        DistrictTargetPop?: number;
        DistrictType?: string;
        DistrictPriority?: number;
        DistrictPopYear?: number;
        ProvinceId?: number;
        Province?: string;
    }
    namespace TargetPopRow {
        const idProperty = "TargetId";
        const nameProperty = "LpDs";
        const localTextPrefix = "Lookup.TargetPop";
        namespace Fields {
            const TargetId: string;
            const DistrictId: string;
            const YearId: string;
            const Population: string;
            const Target: string;
            const LpDs: string;
            const Comment: string;
            const DistrictDcode: string;
            const DistrictProvinceId: string;
            const DistrictDname: string;
            const DistrictTotalPop: string;
            const DistrictTargetPop: string;
            const DistrictType: string;
            const DistrictPriority: string;
            const DistrictPopYear: string;
            const ProvinceId: string;
            const Province: string;
        }
    }
}
declare namespace webNEOC.Lookup {
    namespace TargetPopService {
        const baseUrl = "Lookup/TargetPop";
        function Create(request: Serenity.SaveRequest<TargetPopRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<TargetPopRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<TargetPopRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<TargetPopRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        namespace Methods {
            const Create: string;
            const Update: string;
            const Delete: string;
            const Retrieve: string;
            const List: string;
        }
    }
}
declare namespace webNEOC.Lookup {
}
declare namespace webNEOC.Lookup {
    class VehicletypeForm extends Serenity.PrefixedContext {
        static formKey: string;
    }
    interface VehicletypeForm {
        Typename: Serenity.StringEditor;
    }
}
declare namespace webNEOC.Lookup {
    interface VehicletypeRow {
        VehicletypeId?: number;
        Typename?: string;
    }
    namespace VehicletypeRow {
        const idProperty = "VehicletypeId";
        const nameProperty = "Typename";
        const localTextPrefix = "Lookup.Vehicletype";
        const lookupKey = "Lookup.Vehicletype";
        function getLookup(): Q.Lookup<VehicletypeRow>;
        namespace Fields {
            const VehicletypeId: string;
            const Typename: string;
        }
    }
}
declare namespace webNEOC.Lookup {
    namespace VehicletypeService {
        const baseUrl = "Lookup/Vehicletype";
        function Create(request: Serenity.SaveRequest<VehicletypeRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<VehicletypeRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<VehicletypeRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<VehicletypeRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        namespace Methods {
            const Create: string;
            const Update: string;
            const Delete: string;
            const Retrieve: string;
            const List: string;
        }
    }
}
declare namespace webNEOC.Meeting {
}
declare namespace webNEOC.Meeting {
    class MeetingAgendaForm extends Serenity.PrefixedContext {
        static formKey: string;
    }
    interface MeetingAgendaForm {
        MeetingId: Serenity.IntegerEditor;
        AgendaNumber: Serenity.IntegerEditor;
        Title: Serenity.StringEditor;
        Description: Serenity.StringEditor;
        AgendaTypeId: Serenity.IntegerEditor;
        RequestedByContactId: Serenity.IntegerEditor;
        Images: Serenity.MultipleImageUploadEditor;
        Attachments: Serenity.MultipleImageUploadEditor;
    }
}
declare namespace webNEOC.Meeting {
}
declare namespace webNEOC.Meeting {
    class MeetingAgendaRelevantForm extends Serenity.PrefixedContext {
        static formKey: string;
    }
    interface MeetingAgendaRelevantForm {
        AgendaId: Serenity.IntegerEditor;
        ContactId: Serenity.IntegerEditor;
    }
}
declare namespace webNEOC.Meeting {
    interface MeetingAgendaRelevantRow {
        AgendaRelevantId?: number;
        AgendaId?: number;
        ContactId?: number;
        AgendaMeetingId?: number;
        AgendaAgendaNumber?: number;
        AgendaTitle?: string;
        AgendaDescription?: string;
        AgendaAgendaTypeId?: number;
        AgendaRequestedByContactId?: number;
        AgendaImages?: string;
        AgendaAttachments?: string;
        ContactTitle?: string;
        ContactFirstName?: string;
        ContactLastName?: string;
        ContactEmail?: string;
        ContactIdentityNo?: string;
        ContactUserId?: number;
    }
    namespace MeetingAgendaRelevantRow {
        const idProperty = "AgendaRelevantId";
        const localTextPrefix = "Meeting.MeetingAgendaRelevant";
        namespace Fields {
            const AgendaRelevantId: string;
            const AgendaId: string;
            const ContactId: string;
            const AgendaMeetingId: string;
            const AgendaAgendaNumber: string;
            const AgendaTitle: string;
            const AgendaDescription: string;
            const AgendaAgendaTypeId: string;
            const AgendaRequestedByContactId: string;
            const AgendaImages: string;
            const AgendaAttachments: string;
            const ContactTitle: string;
            const ContactFirstName: string;
            const ContactLastName: string;
            const ContactEmail: string;
            const ContactIdentityNo: string;
            const ContactUserId: string;
        }
    }
}
declare namespace webNEOC.Meeting {
    namespace MeetingAgendaRelevantService {
        const baseUrl = "Meeting/MeetingAgendaRelevant";
        function Create(request: Serenity.SaveRequest<MeetingAgendaRelevantRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<MeetingAgendaRelevantRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<MeetingAgendaRelevantRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<MeetingAgendaRelevantRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        namespace Methods {
            const Create: string;
            const Update: string;
            const Delete: string;
            const Retrieve: string;
            const List: string;
        }
    }
}
declare namespace webNEOC.Meeting {
    interface MeetingAgendaRow {
        AgendaId?: number;
        MeetingId?: number;
        AgendaNumber?: number;
        Title?: string;
        Description?: string;
        AgendaTypeId?: number;
        RequestedByContactId?: number;
        Images?: string;
        Attachments?: string;
        MeetingMeetingName?: string;
        MeetingMeetingNumber?: string;
        MeetingMeetingGuid?: string;
        MeetingMeetingTypeId?: number;
        MeetingStartDate?: string;
        MeetingEndDate?: string;
        MeetingLocationId?: number;
        MeetingUnitId?: number;
        MeetingOrganizerContactId?: number;
        MeetingReporterContactId?: number;
        MeetingInsertUserId?: number;
        MeetingInsertDate?: string;
        MeetingUpdateUserId?: number;
        MeetingUpdateDate?: string;
        AgendaTypeName?: string;
        RequestedByContactTitle?: string;
        RequestedByContactFirstName?: string;
        RequestedByContactLastName?: string;
        RequestedByContactFullName?: string;
        RequestedByContactEmail?: string;
        RequestedByContactIdentityNo?: string;
        RequestedByContactUserId?: number;
    }
    namespace MeetingAgendaRow {
        const idProperty = "AgendaId";
        const nameProperty = "Title";
        const localTextPrefix = "Meeting.MeetingAgenda";
        namespace Fields {
            const AgendaId: string;
            const MeetingId: string;
            const AgendaNumber: string;
            const Title: string;
            const Description: string;
            const AgendaTypeId: string;
            const RequestedByContactId: string;
            const Images: string;
            const Attachments: string;
            const MeetingMeetingName: string;
            const MeetingMeetingNumber: string;
            const MeetingMeetingGuid: string;
            const MeetingMeetingTypeId: string;
            const MeetingStartDate: string;
            const MeetingEndDate: string;
            const MeetingLocationId: string;
            const MeetingUnitId: string;
            const MeetingOrganizerContactId: string;
            const MeetingReporterContactId: string;
            const MeetingInsertUserId: string;
            const MeetingInsertDate: string;
            const MeetingUpdateUserId: string;
            const MeetingUpdateDate: string;
            const AgendaTypeName: string;
            const RequestedByContactTitle: string;
            const RequestedByContactFirstName: string;
            const RequestedByContactLastName: string;
            const RequestedByContactFullName: string;
            const RequestedByContactEmail: string;
            const RequestedByContactIdentityNo: string;
            const RequestedByContactUserId: string;
        }
    }
}
declare namespace webNEOC.Meeting {
    namespace MeetingAgendaService {
        const baseUrl = "Meeting/MeetingAgenda";
        function Create(request: Serenity.SaveRequest<MeetingAgendaRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<MeetingAgendaRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<MeetingAgendaRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<MeetingAgendaRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        namespace Methods {
            const Create: string;
            const Update: string;
            const Delete: string;
            const Retrieve: string;
            const List: string;
        }
    }
}
declare namespace webNEOC.Meeting {
}
declare namespace webNEOC.Meeting {
    class MeetingAgendaTypeForm extends Serenity.PrefixedContext {
        static formKey: string;
    }
    interface MeetingAgendaTypeForm {
        Name: Serenity.StringEditor;
    }
}
declare namespace webNEOC.Meeting {
    interface MeetingAgendaTypeRow {
        AgendaTypeId?: number;
        Name?: string;
    }
    namespace MeetingAgendaTypeRow {
        const idProperty = "AgendaTypeId";
        const nameProperty = "Name";
        const localTextPrefix = "Meeting.MeetingAgendaType";
        const lookupKey = "Meeting.MeetingAgendaType";
        function getLookup(): Q.Lookup<MeetingAgendaTypeRow>;
        namespace Fields {
            const AgendaTypeId: string;
            const Name: string;
        }
    }
}
declare namespace webNEOC.Meeting {
    namespace MeetingAgendaTypeService {
        const baseUrl = "Meeting/MeetingAgendaType";
        function Create(request: Serenity.SaveRequest<MeetingAgendaTypeRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<MeetingAgendaTypeRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<MeetingAgendaTypeRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<MeetingAgendaTypeRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        namespace Methods {
            const Create: string;
            const Update: string;
            const Delete: string;
            const Retrieve: string;
            const List: string;
        }
    }
}
declare namespace webNEOC.Meeting {
    enum MeetingAttendanceStatus {
        NotSet = 0,
        Attended = 1,
        Absent = 2,
        AbsentWithPermission = 3,
    }
}
declare namespace webNEOC.Meeting {
}
declare namespace webNEOC.Meeting {
    class MeetingAttendeeForm extends Serenity.PrefixedContext {
        static formKey: string;
    }
    interface MeetingAttendeeForm {
        MeetingId: Serenity.IntegerEditor;
        ContactId: Serenity.IntegerEditor;
        AttendeeType: Serenity.EnumEditor;
        AttendanceStatus: Serenity.EnumEditor;
    }
}
declare namespace webNEOC.Meeting {
    interface MeetingAttendeeRow {
        AttendeeId?: number;
        MeetingId?: number;
        ContactId?: number;
        AttendeeType?: MeetingAttendeeType;
        AttendanceStatus?: MeetingAttendanceStatus;
        MeetingMeetingName?: string;
        MeetingMeetingNumber?: string;
        MeetingMeetingGuid?: string;
        MeetingMeetingTypeId?: number;
        MeetingStartDate?: string;
        MeetingEndDate?: string;
        MeetingLocationId?: number;
        MeetingUnitId?: number;
        MeetingOrganizerContactId?: number;
        MeetingReporterContactId?: number;
        MeetingInsertUserId?: number;
        MeetingInsertDate?: string;
        MeetingUpdateUserId?: number;
        MeetingUpdateDate?: string;
        ContactTitle?: string;
        ContactFirstName?: string;
        ContactLastName?: string;
        ContactFullName?: string;
        ContactEmail?: string;
        ContactIdentityNo?: string;
        ContactUserId?: number;
    }
    namespace MeetingAttendeeRow {
        const idProperty = "AttendeeId";
        const localTextPrefix = "Meeting.MeetingAttendee";
        namespace Fields {
            const AttendeeId: string;
            const MeetingId: string;
            const ContactId: string;
            const AttendeeType: string;
            const AttendanceStatus: string;
            const MeetingMeetingName: string;
            const MeetingMeetingNumber: string;
            const MeetingMeetingGuid: string;
            const MeetingMeetingTypeId: string;
            const MeetingStartDate: string;
            const MeetingEndDate: string;
            const MeetingLocationId: string;
            const MeetingUnitId: string;
            const MeetingOrganizerContactId: string;
            const MeetingReporterContactId: string;
            const MeetingInsertUserId: string;
            const MeetingInsertDate: string;
            const MeetingUpdateUserId: string;
            const MeetingUpdateDate: string;
            const ContactTitle: string;
            const ContactFirstName: string;
            const ContactLastName: string;
            const ContactFullName: string;
            const ContactEmail: string;
            const ContactIdentityNo: string;
            const ContactUserId: string;
        }
    }
}
declare namespace webNEOC.Meeting {
    enum MeetingAttendeeType {
        Attendee = 1,
        Guest = 2,
    }
}
declare namespace webNEOC.Meeting {
}
declare namespace webNEOC.Meeting {
}
declare namespace webNEOC.Meeting {
    class MeetingDecisionForm extends Serenity.PrefixedContext {
        static formKey: string;
    }
    interface MeetingDecisionForm {
        MeetingId: Serenity.IntegerEditor;
        AgendaId: Serenity.IntegerEditor;
        Description: Serenity.StringEditor;
        DecisionNumber: Serenity.IntegerEditor;
        ResponsibleContactId: Serenity.IntegerEditor;
        DueDate: Serenity.DateEditor;
        ResolutionStatus: Serenity.IntegerEditor;
        Images: Serenity.StringEditor;
        Attachments: Serenity.StringEditor;
    }
}
declare namespace webNEOC.Meeting {
}
declare namespace webNEOC.Meeting {
    class MeetingDecisionRelevantForm extends Serenity.PrefixedContext {
        static formKey: string;
    }
    interface MeetingDecisionRelevantForm {
        DecisionId: Serenity.IntegerEditor;
        ContactId: Serenity.IntegerEditor;
    }
}
declare namespace webNEOC.Meeting {
    interface MeetingDecisionRelevantRow {
        DecisionRelevantId?: number;
        DecisionId?: number;
        ContactId?: number;
        DecisionMeetingId?: number;
        DecisionAgendaId?: number;
        DecisionDescription?: string;
        DecisionDecisionNumber?: number;
        DecisionResponsibleContactId?: number;
        DecisionDueDate?: string;
        DecisionResolutionStatus?: number;
        DecisionImages?: string;
        DecisionAttachments?: string;
        ContactTitle?: string;
        ContactFirstName?: string;
        ContactLastName?: string;
        ContactEmail?: string;
        ContactIdentityNo?: string;
        ContactUserId?: number;
    }
    namespace MeetingDecisionRelevantRow {
        const idProperty = "DecisionRelevantId";
        const localTextPrefix = "Meeting.MeetingDecisionRelevant";
        namespace Fields {
            const DecisionRelevantId: string;
            const DecisionId: string;
            const ContactId: string;
            const DecisionMeetingId: string;
            const DecisionAgendaId: string;
            const DecisionDescription: string;
            const DecisionDecisionNumber: string;
            const DecisionResponsibleContactId: string;
            const DecisionDueDate: string;
            const DecisionResolutionStatus: string;
            const DecisionImages: string;
            const DecisionAttachments: string;
            const ContactTitle: string;
            const ContactFirstName: string;
            const ContactLastName: string;
            const ContactEmail: string;
            const ContactIdentityNo: string;
            const ContactUserId: string;
        }
    }
}
declare namespace webNEOC.Meeting {
    namespace MeetingDecisionRelevantService {
        const baseUrl = "Meeting/MeetingDecisionRelevant";
        function Create(request: Serenity.SaveRequest<MeetingDecisionRelevantRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<MeetingDecisionRelevantRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<MeetingDecisionRelevantRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<MeetingDecisionRelevantRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        namespace Methods {
            const Create: string;
            const Update: string;
            const Delete: string;
            const Retrieve: string;
            const List: string;
        }
    }
}
declare namespace webNEOC.Meeting {
    interface MeetingDecisionRow {
        DecisionId?: number;
        MeetingId?: number;
        AgendaId?: number;
        Description?: string;
        DecisionNumber?: number;
        ResponsibleContactId?: number;
        DueDate?: string;
        ResolutionStatus?: number;
        Images?: string;
        Attachments?: string;
        MeetingMeetingName?: string;
        MeetingMeetingNumber?: string;
        MeetingMeetingGuid?: string;
        MeetingMeetingTypeId?: number;
        MeetingStartDate?: string;
        MeetingEndDate?: string;
        MeetingLocationId?: number;
        MeetingUnitId?: number;
        MeetingOrganizerContactId?: number;
        MeetingReporterContactId?: number;
        MeetingInsertUserId?: number;
        MeetingInsertDate?: string;
        MeetingUpdateUserId?: number;
        MeetingUpdateDate?: string;
        AgendaMeetingId?: number;
        AgendaNumber?: number;
        AgendaTitle?: string;
        AgendaDescription?: string;
        AgendaAgendaTypeId?: number;
        AgendaRequestedByContactId?: number;
        AgendaImages?: string;
        AgendaAttachments?: string;
        DecisionNumberName?: string;
        ResponsibleContactTitle?: string;
        ResponsibleContactFirstName?: string;
        ResponsibleContactLastName?: string;
        ResponsibleContactFullName?: string;
        ResponsibleContactEmail?: string;
        ResponsibleContactIdentityNo?: string;
        ResponsibleContactUserId?: number;
    }
    namespace MeetingDecisionRow {
        const idProperty = "DecisionId";
        const nameProperty = "Description";
        const localTextPrefix = "Meeting.MeetingDecision";
        namespace Fields {
            const DecisionId: string;
            const MeetingId: string;
            const AgendaId: string;
            const Description: string;
            const DecisionNumber: string;
            const ResponsibleContactId: string;
            const DueDate: string;
            const ResolutionStatus: string;
            const Images: string;
            const Attachments: string;
            const MeetingMeetingName: string;
            const MeetingMeetingNumber: string;
            const MeetingMeetingGuid: string;
            const MeetingMeetingTypeId: string;
            const MeetingStartDate: string;
            const MeetingEndDate: string;
            const MeetingLocationId: string;
            const MeetingUnitId: string;
            const MeetingOrganizerContactId: string;
            const MeetingReporterContactId: string;
            const MeetingInsertUserId: string;
            const MeetingInsertDate: string;
            const MeetingUpdateUserId: string;
            const MeetingUpdateDate: string;
            const AgendaMeetingId: string;
            const AgendaNumber: string;
            const AgendaTitle: string;
            const AgendaDescription: string;
            const AgendaAgendaTypeId: string;
            const AgendaRequestedByContactId: string;
            const AgendaImages: string;
            const AgendaAttachments: string;
            const DecisionNumberName: string;
            const ResponsibleContactTitle: string;
            const ResponsibleContactFirstName: string;
            const ResponsibleContactLastName: string;
            const ResponsibleContactFullName: string;
            const ResponsibleContactEmail: string;
            const ResponsibleContactIdentityNo: string;
            const ResponsibleContactUserId: string;
        }
    }
}
declare namespace webNEOC.Meeting {
    namespace MeetingDecisionService {
        const baseUrl = "Meeting/MeetingDecision";
        function Create(request: Serenity.SaveRequest<MeetingDecisionRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<MeetingDecisionRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<MeetingDecisionRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<MeetingDecisionRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        namespace Methods {
            const Create: string;
            const Update: string;
            const Delete: string;
            const Retrieve: string;
            const List: string;
        }
    }
}
declare namespace webNEOC.Meeting {
    class MeetingForm extends Serenity.PrefixedContext {
        static formKey: string;
    }
    interface MeetingForm {
        MeetingName: Serenity.StringEditor;
        MeetingTypeId: Serenity.LookupEditor;
        MeetingNumber: Serenity.StringEditor;
        StartDate: Serenity.DateTimeEditor;
        EndDate: Serenity.DateTimeEditor;
        LocationId: Serenity.LookupEditor;
        UnitId: Organization.BusinessUnitEditor;
        OrganizerContactId: Serenity.LookupEditor;
        ReporterContactId: Serenity.LookupEditor;
        AttendeeList: MeetingAttendeeEditor;
    }
}
declare namespace webNEOC.Meeting {
}
declare namespace webNEOC.Meeting {
    class MeetingLocationForm extends Serenity.PrefixedContext {
        static formKey: string;
    }
    interface MeetingLocationForm {
        Name: Serenity.StringEditor;
        Address: Serenity.StringEditor;
        Latitude: Serenity.DecimalEditor;
        Longitude: Serenity.DecimalEditor;
    }
}
declare namespace webNEOC.Meeting {
    interface MeetingLocationRow {
        LocationId?: number;
        Name?: string;
        Address?: string;
        Latitude?: number;
        Longitude?: number;
    }
    namespace MeetingLocationRow {
        const idProperty = "LocationId";
        const nameProperty = "Name";
        const localTextPrefix = "Meeting.MeetingLocation";
        const lookupKey = "Meeting.MeetingLocation";
        function getLookup(): Q.Lookup<MeetingLocationRow>;
        namespace Fields {
            const LocationId: string;
            const Name: string;
            const Address: string;
            const Latitude: string;
            const Longitude: string;
        }
    }
}
declare namespace webNEOC.Meeting {
    namespace MeetingLocationService {
        const baseUrl = "Meeting/MeetingLocation";
        function Create(request: Serenity.SaveRequest<MeetingLocationRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<MeetingLocationRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<MeetingLocationRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<MeetingLocationRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        namespace Methods {
            const Create: string;
            const Update: string;
            const Delete: string;
            const Retrieve: string;
            const List: string;
        }
    }
}
declare namespace webNEOC.Meeting {
    interface MeetingRow {
        MeetingId?: number;
        MeetingName?: string;
        MeetingNumber?: string;
        MeetingGuid?: string;
        MeetingTypeId?: number;
        StartDate?: string;
        EndDate?: string;
        LocationId?: number;
        UnitId?: number;
        OrganizerContactId?: number;
        ReporterContactId?: number;
        MeetingTypeName?: string;
        LocationName?: string;
        UnitName?: string;
        UnitParentUnitId?: number;
        OrganizerContactTitle?: string;
        OrganizerContactFirstName?: string;
        OrganizerContactLastName?: string;
        OrganizerContactFullName?: string;
        OrganizerContactEmail?: string;
        OrganizerContactIdentityNo?: string;
        OrganizerContactUserId?: number;
        ReporterContactTitle?: string;
        ReporterContactFirstName?: string;
        ReporterContactLastName?: string;
        ReporterContactFullName?: string;
        ReporterContactEmail?: string;
        ReporterContactIdentityNo?: string;
        ReporterContactUserId?: number;
        AttendeeList?: MeetingAttendeeRow[];
        InsertUserId?: number;
        InsertDate?: string;
        UpdateUserId?: number;
        UpdateDate?: string;
    }
    namespace MeetingRow {
        const idProperty = "MeetingId";
        const nameProperty = "MeetingName";
        const localTextPrefix = "Meeting.Meeting";
        namespace Fields {
            const MeetingId: string;
            const MeetingName: string;
            const MeetingNumber: string;
            const MeetingGuid: string;
            const MeetingTypeId: string;
            const StartDate: string;
            const EndDate: string;
            const LocationId: string;
            const UnitId: string;
            const OrganizerContactId: string;
            const ReporterContactId: string;
            const MeetingTypeName: string;
            const LocationName: string;
            const UnitName: string;
            const UnitParentUnitId: string;
            const OrganizerContactTitle: string;
            const OrganizerContactFirstName: string;
            const OrganizerContactLastName: string;
            const OrganizerContactFullName: string;
            const OrganizerContactEmail: string;
            const OrganizerContactIdentityNo: string;
            const OrganizerContactUserId: string;
            const ReporterContactTitle: string;
            const ReporterContactFirstName: string;
            const ReporterContactLastName: string;
            const ReporterContactFullName: string;
            const ReporterContactEmail: string;
            const ReporterContactIdentityNo: string;
            const ReporterContactUserId: string;
            const AttendeeList: string;
            const InsertUserId: string;
            const InsertDate: string;
            const UpdateUserId: string;
            const UpdateDate: string;
        }
    }
}
declare namespace webNEOC.Meeting {
    namespace MeetingService {
        const baseUrl = "Meeting/Meeting";
        function Create(request: Serenity.SaveRequest<MeetingRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<MeetingRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<MeetingRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<MeetingRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        namespace Methods {
            const Create: string;
            const Update: string;
            const Delete: string;
            const Retrieve: string;
            const List: string;
        }
    }
}
declare namespace webNEOC.Meeting {
}
declare namespace webNEOC.Meeting {
    class MeetingTypeForm extends Serenity.PrefixedContext {
        static formKey: string;
    }
    interface MeetingTypeForm {
        Name: Serenity.StringEditor;
    }
}
declare namespace webNEOC.Meeting {
    interface MeetingTypeRow {
        MeetingTypeId?: number;
        Name?: string;
    }
    namespace MeetingTypeRow {
        const idProperty = "MeetingTypeId";
        const nameProperty = "Name";
        const localTextPrefix = "Meeting.MeetingType";
        const lookupKey = "Meeting.MeetingType";
        function getLookup(): Q.Lookup<MeetingTypeRow>;
        namespace Fields {
            const MeetingTypeId: string;
            const Name: string;
        }
    }
}
declare namespace webNEOC.Meeting {
    namespace MeetingTypeService {
        const baseUrl = "Meeting/MeetingType";
        function Create(request: Serenity.SaveRequest<MeetingTypeRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<MeetingTypeRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<MeetingTypeRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<MeetingTypeRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        namespace Methods {
            const Create: string;
            const Update: string;
            const Delete: string;
            const Retrieve: string;
            const List: string;
        }
    }
}
declare namespace webNEOC.Membership {
    class ChangePasswordForm extends Serenity.PrefixedContext {
        static formKey: string;
    }
    interface ChangePasswordForm {
        OldPassword: Serenity.PasswordEditor;
        NewPassword: Serenity.PasswordEditor;
        ConfirmPassword: Serenity.PasswordEditor;
    }
}
declare namespace webNEOC.Membership {
    interface ChangePasswordRequest extends Serenity.ServiceRequest {
        OldPassword?: string;
        NewPassword?: string;
        ConfirmPassword?: string;
    }
}
declare namespace webNEOC.Membership {
    class ForgotPasswordForm extends Serenity.PrefixedContext {
        static formKey: string;
    }
    interface ForgotPasswordForm {
        Email: Serenity.EmailEditor;
    }
}
declare namespace webNEOC.Membership {
    interface ForgotPasswordRequest extends Serenity.ServiceRequest {
        Email?: string;
    }
}
declare namespace webNEOC.Membership {
    class LoginForm extends Serenity.PrefixedContext {
        static formKey: string;
    }
    interface LoginForm {
        Username: Serenity.StringEditor;
        Password: Serenity.PasswordEditor;
    }
}
declare namespace webNEOC.Membership {
    interface LoginRequest extends Serenity.ServiceRequest {
        Username?: string;
        Password?: string;
    }
}
declare namespace webNEOC.Membership {
    class ResetPasswordForm extends Serenity.PrefixedContext {
        static formKey: string;
    }
    interface ResetPasswordForm {
        NewPassword: Serenity.PasswordEditor;
        ConfirmPassword: Serenity.PasswordEditor;
    }
}
declare namespace webNEOC.Membership {
    interface ResetPasswordRequest extends Serenity.ServiceRequest {
        Token?: string;
        NewPassword?: string;
        ConfirmPassword?: string;
    }
}
declare namespace webNEOC.Membership {
    class SignUpForm extends Serenity.PrefixedContext {
        static formKey: string;
    }
    interface SignUpForm {
        DisplayName: Serenity.StringEditor;
        Email: Serenity.EmailEditor;
        ConfirmEmail: Serenity.EmailEditor;
        Password: Serenity.PasswordEditor;
        ConfirmPassword: Serenity.PasswordEditor;
    }
}
declare namespace webNEOC.Membership {
    interface SignUpRequest extends Serenity.ServiceRequest {
        DisplayName?: string;
        Email?: string;
        Password?: string;
    }
}
declare namespace MultiTenancy.Administration {
}
declare namespace MultiTenancy.Administration {
    class TenantForm extends Serenity.PrefixedContext {
        static formKey: string;
    }
    interface TenantForm {
        TenantName: Serenity.StringEditor;
    }
}
declare namespace MultiTenancy.Administration {
    interface TenantRow {
        TenantId?: number;
        TenantName?: string;
    }
    namespace TenantRow {
        const idProperty = "TenantId";
        const nameProperty = "TenantName";
        const localTextPrefix = "Administration.Tenant";
        const lookupKey = "Administration.Tenant";
        function getLookup(): Q.Lookup<TenantRow>;
        namespace Fields {
            const TenantId: string;
            const TenantName: string;
        }
    }
}
declare namespace MultiTenancy.Administration {
    namespace TenantService {
        const baseUrl = "Administration/Tenant";
        function Create(request: Serenity.SaveRequest<TenantRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<TenantRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<TenantRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<TenantRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        namespace Methods {
            const Create: string;
            const Update: string;
            const Delete: string;
            const Retrieve: string;
            const List: string;
        }
    }
}
declare namespace webNEOC.Northwind {
}
declare namespace webNEOC.Northwind {
    class CategoryForm extends Serenity.PrefixedContext {
        static formKey: string;
    }
    interface CategoryForm {
        CategoryName: Serenity.StringEditor;
        Description: Serenity.StringEditor;
    }
}
declare namespace webNEOC.Northwind {
    interface CategoryLangRow {
        Id?: number;
        CategoryId?: number;
        LanguageId?: number;
        CategoryName?: string;
        Description?: string;
    }
    namespace CategoryLangRow {
        const idProperty = "Id";
        const nameProperty = "CategoryName";
        const localTextPrefix = "Northwind.CategoryLang";
        namespace Fields {
            const Id: string;
            const CategoryId: string;
            const LanguageId: string;
            const CategoryName: string;
            const Description: string;
        }
    }
}
declare namespace webNEOC.Northwind {
    namespace CategoryLangService {
        const baseUrl = "Northwind/CategoryLang";
        function Create(request: Serenity.SaveRequest<CategoryLangRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<CategoryLangRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<CategoryLangRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<CategoryLangRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        namespace Methods {
            const Create: string;
            const Update: string;
            const Delete: string;
            const Retrieve: string;
            const List: string;
        }
    }
}
declare namespace webNEOC.Northwind {
    interface CategoryRow {
        CategoryID?: number;
        CategoryName?: string;
        Description?: string;
        Picture?: number[];
    }
    namespace CategoryRow {
        const idProperty = "CategoryID";
        const nameProperty = "CategoryName";
        const localTextPrefix = "Northwind.Category";
        const lookupKey = "Northwind.Category";
        function getLookup(): Q.Lookup<CategoryRow>;
        namespace Fields {
            const CategoryID: string;
            const CategoryName: string;
            const Description: string;
            const Picture: string;
        }
    }
}
declare namespace webNEOC.Northwind {
    namespace CategoryService {
        const baseUrl = "Northwind/Category";
        function Create(request: Serenity.SaveRequest<CategoryRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<CategoryRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<CategoryRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<CategoryRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        namespace Methods {
            const Create: string;
            const Update: string;
            const Delete: string;
            const Retrieve: string;
            const List: string;
        }
    }
}
declare namespace webNEOC.Northwind {
}
declare namespace webNEOC.Northwind {
    interface CustomerCustomerDemoRow {
        ID?: number;
        CustomerID?: string;
        CustomerTypeID?: string;
        CustomerCompanyName?: string;
        CustomerContactName?: string;
        CustomerContactTitle?: string;
        CustomerAddress?: string;
        CustomerCity?: string;
        CustomerRegion?: string;
        CustomerPostalCode?: string;
        CustomerCountry?: string;
        CustomerPhone?: string;
        CustomerFax?: string;
        CustomerTypeCustomerDesc?: string;
    }
    namespace CustomerCustomerDemoRow {
        const idProperty = "ID";
        const nameProperty = "CustomerID";
        const localTextPrefix = "Northwind.CustomerCustomerDemo";
        namespace Fields {
            const ID: string;
            const CustomerID: string;
            const CustomerTypeID: string;
            const CustomerCompanyName: string;
            const CustomerContactName: string;
            const CustomerContactTitle: string;
            const CustomerAddress: string;
            const CustomerCity: string;
            const CustomerRegion: string;
            const CustomerPostalCode: string;
            const CustomerCountry: string;
            const CustomerPhone: string;
            const CustomerFax: string;
            const CustomerTypeCustomerDesc: string;
        }
    }
}
declare namespace webNEOC.Northwind {
    interface CustomerDemographicRow {
        ID?: number;
        CustomerTypeID?: string;
        CustomerDesc?: string;
    }
    namespace CustomerDemographicRow {
        const idProperty = "ID";
        const nameProperty = "CustomerTypeID";
        const localTextPrefix = "Northwind.CustomerDemographic";
        namespace Fields {
            const ID: string;
            const CustomerTypeID: string;
            const CustomerDesc: string;
        }
    }
}
declare namespace webNEOC.Northwind {
    interface CustomerDetailsRow {
        Id?: number;
        LastContactDate?: string;
        LastContactedBy?: number;
        Email?: string;
        SendBulletin?: boolean;
        LastContactedByLastName?: string;
        LastContactedByFirstName?: string;
        LastContactedByTitle?: string;
        LastContactedByTitleOfCourtesy?: string;
        LastContactedByBirthDate?: string;
        LastContactedByHireDate?: string;
        LastContactedByAddress?: string;
        LastContactedByCity?: string;
        LastContactedByRegion?: string;
        LastContactedByPostalCode?: string;
        LastContactedByCountry?: string;
        LastContactedByHomePhone?: string;
        LastContactedByExtension?: string;
        LastContactedByPhoto?: number[];
        LastContactedByNotes?: string;
        LastContactedByReportsTo?: number;
        LastContactedByPhotoPath?: string;
    }
    namespace CustomerDetailsRow {
        const idProperty = "Id";
        const nameProperty = "Email";
        const localTextPrefix = "Northwind.CustomerDetails";
        namespace Fields {
            const Id: string;
            const LastContactDate: string;
            const LastContactedBy: string;
            const Email: string;
            const SendBulletin: string;
            const LastContactedByLastName: string;
            const LastContactedByFirstName: string;
            const LastContactedByTitle: string;
            const LastContactedByTitleOfCourtesy: string;
            const LastContactedByBirthDate: string;
            const LastContactedByHireDate: string;
            const LastContactedByAddress: string;
            const LastContactedByCity: string;
            const LastContactedByRegion: string;
            const LastContactedByPostalCode: string;
            const LastContactedByCountry: string;
            const LastContactedByHomePhone: string;
            const LastContactedByExtension: string;
            const LastContactedByPhoto: string;
            const LastContactedByNotes: string;
            const LastContactedByReportsTo: string;
            const LastContactedByPhotoPath: string;
        }
    }
}
declare namespace webNEOC.Northwind {
    class CustomerForm extends Serenity.PrefixedContext {
        static formKey: string;
    }
    interface CustomerForm {
        CustomerID: Serenity.StringEditor;
        CompanyName: Serenity.StringEditor;
        ContactName: Serenity.StringEditor;
        ContactTitle: Serenity.StringEditor;
        Representatives: Serenity.LookupEditor;
        Address: Serenity.StringEditor;
        Country: Serenity.LookupEditor;
        City: Serenity.LookupEditor;
        Region: Serenity.StringEditor;
        PostalCode: Serenity.StringEditor;
        Phone: Serenity.StringEditor;
        Fax: Serenity.StringEditor;
        NoteList: NotesEditor;
        LastContactDate: Serenity.DateEditor;
        LastContactedBy: Serenity.LookupEditor;
        Email: Serenity.EmailEditor;
        SendBulletin: Serenity.BooleanEditor;
    }
}
declare namespace webNEOC.Northwind {
    interface CustomerGrossSalesRow {
        CustomerId?: string;
        ContactName?: string;
        ProductId?: number;
        ProductName?: string;
        GrossAmount?: number;
    }
    namespace CustomerGrossSalesRow {
        const nameProperty = "ContactName";
        const localTextPrefix = "BasicSamples.GrossSales";
        namespace Fields {
            const CustomerId: string;
            const ContactName: string;
            const ProductId: string;
            const ProductName: string;
            const GrossAmount: string;
        }
    }
}
declare namespace webNEOC.Northwind {
    interface CustomerRepresentativesRow {
        RepresentativeId?: number;
        CustomerId?: number;
        EmployeeId?: number;
    }
    namespace CustomerRepresentativesRow {
        const idProperty = "RepresentativeId";
        const localTextPrefix = "CustomerRepresentatives";
        namespace Fields {
            const RepresentativeId: string;
            const CustomerId: string;
            const EmployeeId: string;
        }
    }
}
declare namespace webNEOC.Northwind {
    interface CustomerRow {
        ID?: number;
        CustomerID?: string;
        CompanyName?: string;
        ContactName?: string;
        ContactTitle?: string;
        Address?: string;
        City?: string;
        Region?: string;
        PostalCode?: string;
        Country?: string;
        Phone?: string;
        Fax?: string;
        NoteList?: NoteRow[];
        Representatives?: number[];
        LastContactDate?: string;
        LastContactedBy?: number;
        Email?: string;
        SendBulletin?: boolean;
    }
    namespace CustomerRow {
        const idProperty = "ID";
        const nameProperty = "CompanyName";
        const localTextPrefix = "Northwind.Customer";
        const lookupKey = "Northwind.Customer";
        function getLookup(): Q.Lookup<CustomerRow>;
        namespace Fields {
            const ID: string;
            const CustomerID: string;
            const CompanyName: string;
            const ContactName: string;
            const ContactTitle: string;
            const Address: string;
            const City: string;
            const Region: string;
            const PostalCode: string;
            const Country: string;
            const Phone: string;
            const Fax: string;
            const NoteList: string;
            const Representatives: string;
            const LastContactDate: string;
            const LastContactedBy: string;
            const Email: string;
            const SendBulletin: string;
        }
    }
}
declare namespace webNEOC.Northwind {
    namespace CustomerService {
        const baseUrl = "Northwind/Customer";
        function Create(request: Serenity.SaveRequest<CustomerRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<CustomerRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function GetNextNumber(request: GetNextNumberRequest, onSuccess?: (response: GetNextNumberResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<CustomerRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<CustomerRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        namespace Methods {
            const Create: string;
            const Update: string;
            const Delete: string;
            const GetNextNumber: string;
            const Retrieve: string;
            const List: string;
        }
    }
}
declare namespace webNEOC.Northwind {
    interface EmployeeRow {
        EmployeeID?: number;
        LastName?: string;
        FirstName?: string;
        FullName?: string;
        Title?: string;
        TitleOfCourtesy?: string;
        BirthDate?: string;
        HireDate?: string;
        Address?: string;
        City?: string;
        Region?: string;
        PostalCode?: string;
        Country?: string;
        HomePhone?: string;
        Extension?: string;
        Photo?: number[];
        Notes?: string;
        ReportsTo?: number;
        PhotoPath?: string;
        ReportsToFullName?: string;
        ReportsToLastName?: string;
        ReportsToFirstName?: string;
        ReportsToTitle?: string;
        ReportsToTitleOfCourtesy?: string;
        ReportsToBirthDate?: string;
        ReportsToHireDate?: string;
        ReportsToAddress?: string;
        ReportsToCity?: string;
        ReportsToRegion?: string;
        ReportsToPostalCode?: string;
        ReportsToCountry?: string;
        ReportsToHomePhone?: string;
        ReportsToExtension?: string;
        ReportsToPhoto?: number[];
        ReportsToNotes?: string;
        ReportsToReportsTo?: number;
        ReportsToPhotoPath?: string;
        Gender?: Gender;
    }
    namespace EmployeeRow {
        const idProperty = "EmployeeID";
        const nameProperty = "FullName";
        const localTextPrefix = "Northwind.Employee";
        const lookupKey = "Northwind.Employee";
        function getLookup(): Q.Lookup<EmployeeRow>;
        namespace Fields {
            const EmployeeID: string;
            const LastName: string;
            const FirstName: string;
            const FullName: string;
            const Title: string;
            const TitleOfCourtesy: string;
            const BirthDate: string;
            const HireDate: string;
            const Address: string;
            const City: string;
            const Region: string;
            const PostalCode: string;
            const Country: string;
            const HomePhone: string;
            const Extension: string;
            const Photo: string;
            const Notes: string;
            const ReportsTo: string;
            const PhotoPath: string;
            const ReportsToFullName: string;
            const ReportsToLastName: string;
            const ReportsToFirstName: string;
            const ReportsToTitle: string;
            const ReportsToTitleOfCourtesy: string;
            const ReportsToBirthDate: string;
            const ReportsToHireDate: string;
            const ReportsToAddress: string;
            const ReportsToCity: string;
            const ReportsToRegion: string;
            const ReportsToPostalCode: string;
            const ReportsToCountry: string;
            const ReportsToHomePhone: string;
            const ReportsToExtension: string;
            const ReportsToPhoto: string;
            const ReportsToNotes: string;
            const ReportsToReportsTo: string;
            const ReportsToPhotoPath: string;
            const Gender: string;
        }
    }
}
declare namespace webNEOC.Northwind {
    interface EmployeeTerritoryRow {
        EmployeeID?: number;
        TerritoryID?: string;
        EmployeeLastName?: string;
        EmployeeFirstName?: string;
        EmployeeTitle?: string;
        EmployeeTitleOfCourtesy?: string;
        EmployeeBirthDate?: string;
        EmployeeHireDate?: string;
        EmployeeAddress?: string;
        EmployeeCity?: string;
        EmployeeRegion?: string;
        EmployeePostalCode?: string;
        EmployeeCountry?: string;
        EmployeeHomePhone?: string;
        EmployeeExtension?: string;
        EmployeePhoto?: number[];
        EmployeeNotes?: string;
        EmployeeReportsTo?: number;
        EmployeePhotoPath?: string;
        TerritoryTerritoryDescription?: string;
        TerritoryRegionID?: number;
    }
    namespace EmployeeTerritoryRow {
        const idProperty = "EmployeeID";
        const nameProperty = "TerritoryID";
        const localTextPrefix = "Northwind.EmployeeTerritory";
        namespace Fields {
            const EmployeeID: string;
            const TerritoryID: string;
            const EmployeeLastName: string;
            const EmployeeFirstName: string;
            const EmployeeTitle: string;
            const EmployeeTitleOfCourtesy: string;
            const EmployeeBirthDate: string;
            const EmployeeHireDate: string;
            const EmployeeAddress: string;
            const EmployeeCity: string;
            const EmployeeRegion: string;
            const EmployeePostalCode: string;
            const EmployeeCountry: string;
            const EmployeeHomePhone: string;
            const EmployeeExtension: string;
            const EmployeePhoto: string;
            const EmployeeNotes: string;
            const EmployeeReportsTo: string;
            const EmployeePhotoPath: string;
            const TerritoryTerritoryDescription: string;
            const TerritoryRegionID: string;
        }
    }
}
declare namespace webNEOC.Northwind {
    enum Gender {
        Male = 1,
        Female = 2,
    }
}
declare namespace webNEOC.Northwind {
    interface NoteRow {
        NoteId?: number;
        EntityType?: string;
        EntityId?: number;
        Text?: string;
        InsertUserId?: number;
        InsertDate?: string;
        InsertUserDisplayName?: string;
    }
    namespace NoteRow {
        const idProperty = "NoteId";
        const nameProperty = "EntityType";
        const localTextPrefix = "Northwind.Note";
        namespace Fields {
            const NoteId: string;
            const EntityType: string;
            const EntityId: string;
            const Text: string;
            const InsertUserId: string;
            const InsertDate: string;
            const InsertUserDisplayName: string;
        }
    }
}
declare namespace webNEOC.Northwind {
}
declare namespace webNEOC.Northwind {
}
declare namespace webNEOC.Northwind {
    class OrderDetailForm extends Serenity.PrefixedContext {
        static formKey: string;
    }
    interface OrderDetailForm {
        ProductID: Serenity.LookupEditor;
        UnitPrice: Serenity.DecimalEditor;
        Quantity: Serenity.IntegerEditor;
        Discount: Serenity.DecimalEditor;
    }
}
declare namespace webNEOC.Northwind {
    interface OrderDetailRow {
        DetailID?: number;
        OrderID?: number;
        ProductID?: number;
        UnitPrice?: number;
        Quantity?: number;
        Discount?: number;
        OrderCustomerID?: string;
        OrderEmployeeID?: number;
        OrderDate?: string;
        OrderShippedDate?: string;
        OrderShipVia?: number;
        OrderShipCity?: string;
        OrderShipCountry?: string;
        ProductName?: string;
        ProductDiscontinued?: boolean;
        ProductSupplierID?: number;
        ProductQuantityPerUnit?: string;
        ProductUnitPrice?: number;
        LineTotal?: number;
    }
    namespace OrderDetailRow {
        const idProperty = "DetailID";
        const localTextPrefix = "Northwind.OrderDetail";
        namespace Fields {
            const DetailID: string;
            const OrderID: string;
            const ProductID: string;
            const UnitPrice: string;
            const Quantity: string;
            const Discount: string;
            const OrderCustomerID: string;
            const OrderEmployeeID: string;
            const OrderDate: string;
            const OrderShippedDate: string;
            const OrderShipVia: string;
            const OrderShipCity: string;
            const OrderShipCountry: string;
            const ProductName: string;
            const ProductDiscontinued: string;
            const ProductSupplierID: string;
            const ProductQuantityPerUnit: string;
            const ProductUnitPrice: string;
            const LineTotal: string;
        }
    }
}
declare namespace webNEOC.Northwind {
    namespace OrderDetailService {
        const baseUrl = "Northwind/OrderDetail";
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<OrderDetailRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<OrderDetailRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        namespace Methods {
            const Retrieve: string;
            const List: string;
        }
    }
}
declare namespace webNEOC.Northwind {
    class OrderForm extends Serenity.PrefixedContext {
        static formKey: string;
    }
    interface OrderForm {
        CustomerID: CustomerEditor;
        OrderDate: Serenity.DateEditor;
        RequiredDate: Serenity.DateEditor;
        EmployeeID: Serenity.LookupEditor;
        DetailList: OrderDetailsEditor;
        ShippedDate: Serenity.DateEditor;
        ShipVia: Serenity.LookupEditor;
        Freight: Serenity.DecimalEditor;
        ShipName: Serenity.StringEditor;
        ShipAddress: Serenity.StringEditor;
        ShipCity: Serenity.StringEditor;
        ShipRegion: Serenity.StringEditor;
        ShipPostalCode: Serenity.StringEditor;
        ShipCountry: Serenity.StringEditor;
    }
}
declare namespace webNEOC.Northwind {
    interface OrderListRequest extends Serenity.ListRequest {
        ProductID?: number;
    }
}
declare namespace webNEOC.Northwind {
    interface OrderRow {
        OrderID?: number;
        CustomerID?: string;
        EmployeeID?: number;
        OrderDate?: string;
        RequiredDate?: string;
        ShippedDate?: string;
        ShipVia?: number;
        Freight?: number;
        ShipName?: string;
        ShipAddress?: string;
        ShipCity?: string;
        ShipRegion?: string;
        ShipPostalCode?: string;
        ShipCountry?: string;
        CustomerCompanyName?: string;
        CustomerContactName?: string;
        CustomerContactTitle?: string;
        CustomerCity?: string;
        CustomerRegion?: string;
        CustomerCountry?: string;
        CustomerPhone?: string;
        CustomerFax?: string;
        EmployeeFullName?: string;
        EmployeeGender?: Gender;
        EmployeeReportsToFullName?: string;
        ShipViaCompanyName?: string;
        ShipViaPhone?: string;
        ShippingState?: OrderShippingState;
        DetailList?: OrderDetailRow[];
    }
    namespace OrderRow {
        const idProperty = "OrderID";
        const nameProperty = "CustomerID";
        const localTextPrefix = "Northwind.Order";
        const lookupKey = "Northwind.OrderShipCity";
        function getLookup(): Q.Lookup<OrderRow>;
        namespace Fields {
            const OrderID: string;
            const CustomerID: string;
            const EmployeeID: string;
            const OrderDate: string;
            const RequiredDate: string;
            const ShippedDate: string;
            const ShipVia: string;
            const Freight: string;
            const ShipName: string;
            const ShipAddress: string;
            const ShipCity: string;
            const ShipRegion: string;
            const ShipPostalCode: string;
            const ShipCountry: string;
            const CustomerCompanyName: string;
            const CustomerContactName: string;
            const CustomerContactTitle: string;
            const CustomerCity: string;
            const CustomerRegion: string;
            const CustomerCountry: string;
            const CustomerPhone: string;
            const CustomerFax: string;
            const EmployeeFullName: string;
            const EmployeeGender: string;
            const EmployeeReportsToFullName: string;
            const ShipViaCompanyName: string;
            const ShipViaPhone: string;
            const ShippingState: string;
            const DetailList: string;
        }
    }
}
declare namespace webNEOC.Northwind {
    namespace OrderService {
        const baseUrl = "Northwind/Order";
        function Create(request: Serenity.SaveRequest<OrderRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<OrderRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<OrderRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: OrderListRequest, onSuccess?: (response: Serenity.ListResponse<OrderRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        namespace Methods {
            const Create: string;
            const Update: string;
            const Delete: string;
            const Retrieve: string;
            const List: string;
        }
    }
}
declare namespace webNEOC.Northwind {
    enum OrderShippingState {
        NotShipped = 0,
        Shipped = 1,
    }
}
declare namespace webNEOC.Northwind {
}
declare namespace webNEOC.Northwind {
    class ProductForm extends Serenity.PrefixedContext {
        static formKey: string;
    }
    interface ProductForm {
        ProductName: Serenity.StringEditor;
        ProductImage: Serenity.ImageUploadEditor;
        Discontinued: Serenity.BooleanEditor;
        SupplierID: Serenity.LookupEditor;
        CategoryID: Serenity.LookupEditor;
        QuantityPerUnit: Serenity.StringEditor;
        UnitPrice: Serenity.DecimalEditor;
        UnitsInStock: Serenity.IntegerEditor;
        UnitsOnOrder: Serenity.IntegerEditor;
        ReorderLevel: Serenity.IntegerEditor;
    }
}
declare namespace webNEOC.Northwind {
    interface ProductLangRow {
        Id?: number;
        ProductId?: number;
        LanguageId?: number;
        ProductName?: string;
    }
    namespace ProductLangRow {
        const idProperty = "Id";
        const nameProperty = "ProductName";
        const localTextPrefix = "Northwind.ProductLang";
        namespace Fields {
            const Id: string;
            const ProductId: string;
            const LanguageId: string;
            const ProductName: string;
        }
    }
}
declare namespace webNEOC.Northwind {
    namespace ProductLangService {
        const baseUrl = "Northwind/ProductLang";
        function Create(request: Serenity.SaveRequest<ProductLangRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<ProductLangRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<ProductLangRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<ProductLangRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        namespace Methods {
            const Create: string;
            const Update: string;
            const Delete: string;
            const Retrieve: string;
            const List: string;
        }
    }
}
declare namespace webNEOC.Northwind {
    interface ProductLogRow {
        ProductLogID?: number;
        OperationType?: Serenity.CaptureOperationType;
        ChangingUserId?: number;
        ValidFrom?: string;
        ValidUntil?: string;
        ProductID?: number;
        ProductName?: string;
        ProductImage?: string;
        Discontinued?: boolean;
        SupplierID?: number;
        CategoryID?: number;
        QuantityPerUnit?: string;
        UnitPrice?: number;
        UnitsInStock?: number;
        UnitsOnOrder?: number;
        ReorderLevel?: number;
    }
    namespace ProductLogRow {
        const idProperty = "ProductLogID";
        const localTextPrefix = "Northwind.ProductLog";
        namespace Fields {
            const ProductLogID: string;
            const OperationType: string;
            const ChangingUserId: string;
            const ValidFrom: string;
            const ValidUntil: string;
            const ProductID: string;
            const ProductName: string;
            const ProductImage: string;
            const Discontinued: string;
            const SupplierID: string;
            const CategoryID: string;
            const QuantityPerUnit: string;
            const UnitPrice: string;
            const UnitsInStock: string;
            const UnitsOnOrder: string;
            const ReorderLevel: string;
        }
    }
}
declare namespace webNEOC.Northwind {
    interface ProductRow {
        ProductID?: number;
        ProductName?: string;
        ProductImage?: string;
        Discontinued?: boolean;
        SupplierID?: number;
        CategoryID?: number;
        QuantityPerUnit?: string;
        UnitPrice?: number;
        UnitsInStock?: number;
        UnitsOnOrder?: number;
        ReorderLevel?: number;
        SupplierCompanyName?: string;
        SupplierContactName?: string;
        SupplierContactTitle?: string;
        SupplierAddress?: string;
        SupplierCity?: string;
        SupplierRegion?: string;
        SupplierPostalCode?: string;
        SupplierCountry?: string;
        SupplierPhone?: string;
        SupplierFax?: string;
        SupplierHomePage?: string;
        CategoryName?: string;
        CategoryDescription?: string;
        CategoryPicture?: number[];
    }
    namespace ProductRow {
        const idProperty = "ProductID";
        const nameProperty = "ProductName";
        const localTextPrefix = "Northwind.Product";
        const lookupKey = "Northwind.Product";
        function getLookup(): Q.Lookup<ProductRow>;
        namespace Fields {
            const ProductID: string;
            const ProductName: string;
            const ProductImage: string;
            const Discontinued: string;
            const SupplierID: string;
            const CategoryID: string;
            const QuantityPerUnit: string;
            const UnitPrice: string;
            const UnitsInStock: string;
            const UnitsOnOrder: string;
            const ReorderLevel: string;
            const SupplierCompanyName: string;
            const SupplierContactName: string;
            const SupplierContactTitle: string;
            const SupplierAddress: string;
            const SupplierCity: string;
            const SupplierRegion: string;
            const SupplierPostalCode: string;
            const SupplierCountry: string;
            const SupplierPhone: string;
            const SupplierFax: string;
            const SupplierHomePage: string;
            const CategoryName: string;
            const CategoryDescription: string;
            const CategoryPicture: string;
        }
    }
}
declare namespace webNEOC.Northwind {
    namespace ProductService {
        const baseUrl = "Northwind/Product";
        function Create(request: Serenity.SaveRequest<ProductRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<ProductRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<ProductRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<ProductRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        namespace Methods {
            const Create: string;
            const Update: string;
            const Delete: string;
            const Retrieve: string;
            const List: string;
        }
    }
}
declare namespace webNEOC.Northwind {
}
declare namespace webNEOC.Northwind {
    class RegionForm extends Serenity.PrefixedContext {
        static formKey: string;
    }
    interface RegionForm {
        RegionID: Serenity.IntegerEditor;
        RegionDescription: Serenity.StringEditor;
    }
}
declare namespace webNEOC.Northwind {
    interface RegionRow {
        RegionID?: number;
        RegionDescription?: string;
    }
    namespace RegionRow {
        const idProperty = "RegionID";
        const nameProperty = "RegionDescription";
        const localTextPrefix = "Northwind.Region";
        const lookupKey = "Northwind.Region";
        function getLookup(): Q.Lookup<RegionRow>;
        namespace Fields {
            const RegionID: string;
            const RegionDescription: string;
        }
    }
}
declare namespace webNEOC.Northwind {
    namespace RegionService {
        const baseUrl = "Northwind/Region";
        function Create(request: Serenity.SaveRequest<RegionRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<RegionRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<RegionRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<RegionRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        namespace Methods {
            const Create: string;
            const Update: string;
            const Delete: string;
            const Retrieve: string;
            const List: string;
        }
    }
}
declare namespace webNEOC.Northwind {
}
declare namespace webNEOC.Northwind {
    interface SalesByCategoryRow {
        CategoryId?: number;
        CategoryName?: string;
        ProductName?: string;
        ProductSales?: number;
    }
    namespace SalesByCategoryRow {
        const nameProperty = "CategoryName";
        const localTextPrefix = "Northwind.SalesByCategory";
        namespace Fields {
            const CategoryId: string;
            const CategoryName: string;
            const ProductName: string;
            const ProductSales: string;
        }
    }
}
declare namespace webNEOC.Northwind {
    namespace SalesByCategoryService {
        const baseUrl = "Northwind/SalesByCategory";
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<SalesByCategoryRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        namespace Methods {
            const List: string;
        }
    }
}
declare namespace webNEOC.Northwind {
}
declare namespace webNEOC.Northwind {
    class ShipperForm extends Serenity.PrefixedContext {
        static formKey: string;
    }
    interface ShipperForm {
        CompanyName: Serenity.StringEditor;
        Phone: PhoneEditor;
    }
}
declare namespace webNEOC.Northwind {
    interface ShipperRow {
        ShipperID?: number;
        CompanyName?: string;
        Phone?: string;
    }
    namespace ShipperRow {
        const idProperty = "ShipperID";
        const nameProperty = "CompanyName";
        const localTextPrefix = "Northwind.Shipper";
        const lookupKey = "Northwind.Shipper";
        function getLookup(): Q.Lookup<ShipperRow>;
        namespace Fields {
            const ShipperID: string;
            const CompanyName: string;
            const Phone: string;
        }
    }
}
declare namespace webNEOC.Northwind {
    namespace ShipperService {
        const baseUrl = "Northwind/Shipper";
        function Create(request: Serenity.SaveRequest<ShipperRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<ShipperRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<ShipperRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<ShipperRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        namespace Methods {
            const Create: string;
            const Update: string;
            const Delete: string;
            const Retrieve: string;
            const List: string;
        }
    }
}
declare namespace webNEOC.Northwind {
}
declare namespace webNEOC.Northwind {
    class SupplierForm extends Serenity.PrefixedContext {
        static formKey: string;
    }
    interface SupplierForm {
        CompanyName: Serenity.StringEditor;
        ContactName: Serenity.StringEditor;
        ContactTitle: Serenity.StringEditor;
        Address: Serenity.StringEditor;
        Region: Serenity.StringEditor;
        PostalCode: Serenity.StringEditor;
        Country: Serenity.StringEditor;
        City: Serenity.StringEditor;
        Phone: Serenity.StringEditor;
        Fax: Serenity.StringEditor;
        HomePage: Serenity.StringEditor;
    }
}
declare namespace webNEOC.Northwind {
    interface SupplierRow {
        SupplierID?: number;
        CompanyName?: string;
        ContactName?: string;
        ContactTitle?: string;
        Address?: string;
        City?: string;
        Region?: string;
        PostalCode?: string;
        Country?: string;
        Phone?: string;
        Fax?: string;
        HomePage?: string;
    }
    namespace SupplierRow {
        const idProperty = "SupplierID";
        const nameProperty = "CompanyName";
        const localTextPrefix = "Northwind.Supplier";
        const lookupKey = "Northwind.Supplier";
        function getLookup(): Q.Lookup<SupplierRow>;
        namespace Fields {
            const SupplierID: string;
            const CompanyName: string;
            const ContactName: string;
            const ContactTitle: string;
            const Address: string;
            const City: string;
            const Region: string;
            const PostalCode: string;
            const Country: string;
            const Phone: string;
            const Fax: string;
            const HomePage: string;
        }
    }
}
declare namespace webNEOC.Northwind {
    namespace SupplierService {
        const baseUrl = "Northwind/Supplier";
        function Create(request: Serenity.SaveRequest<SupplierRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<SupplierRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<SupplierRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<SupplierRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        namespace Methods {
            const Create: string;
            const Update: string;
            const Delete: string;
            const Retrieve: string;
            const List: string;
        }
    }
}
declare namespace webNEOC.Northwind {
}
declare namespace webNEOC.Northwind {
    class TerritoryForm extends Serenity.PrefixedContext {
        static formKey: string;
    }
    interface TerritoryForm {
        TerritoryID: Serenity.StringEditor;
        TerritoryDescription: Serenity.StringEditor;
        RegionID: Serenity.LookupEditor;
    }
}
declare namespace webNEOC.Northwind {
    interface TerritoryRow {
        ID?: number;
        TerritoryID?: string;
        TerritoryDescription?: string;
        RegionID?: number;
        RegionDescription?: string;
    }
    namespace TerritoryRow {
        const idProperty = "ID";
        const nameProperty = "TerritoryID";
        const localTextPrefix = "Northwind.Territory";
        const lookupKey = "Northwind.Territory";
        function getLookup(): Q.Lookup<TerritoryRow>;
        namespace Fields {
            const ID: string;
            const TerritoryID: string;
            const TerritoryDescription: string;
            const RegionID: string;
            const RegionDescription: string;
        }
    }
}
declare namespace webNEOC.Northwind {
    namespace TerritoryService {
        const baseUrl = "Northwind/Territory";
        function Create(request: Serenity.SaveRequest<TerritoryRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<TerritoryRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<TerritoryRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<TerritoryRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        namespace Methods {
            const Create: string;
            const Update: string;
            const Delete: string;
            const Retrieve: string;
            const List: string;
        }
    }
}
declare namespace webNEOC.Organization {
}
declare namespace webNEOC.Organization {
    class BusinessUnitForm extends Serenity.PrefixedContext {
        static formKey: string;
    }
    interface BusinessUnitForm {
        Name: Serenity.StringEditor;
        ParentUnitId: BusinessUnitEditor;
    }
}
declare namespace webNEOC.Organization {
    interface BusinessUnitRow {
        UnitId?: number;
        Name?: string;
        ParentUnitId?: number;
        ParentUnitName?: string;
        ParentUnitParentUnitId?: number;
    }
    namespace BusinessUnitRow {
        const idProperty = "UnitId";
        const nameProperty = "Name";
        const localTextPrefix = "Organization.BusinessUnit";
        const lookupKey = "Organization.BusinessUnit";
        function getLookup(): Q.Lookup<BusinessUnitRow>;
        namespace Fields {
            const UnitId: string;
            const Name: string;
            const ParentUnitId: string;
            const ParentUnitName: string;
            const ParentUnitParentUnitId: string;
        }
    }
}
declare namespace webNEOC.Organization {
    namespace BusinessUnitService {
        const baseUrl = "Organization/BusinessUnit";
        function Create(request: Serenity.SaveRequest<BusinessUnitRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<BusinessUnitRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<BusinessUnitRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<BusinessUnitRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        namespace Methods {
            const Create: string;
            const Update: string;
            const Delete: string;
            const Retrieve: string;
            const List: string;
        }
    }
}
declare namespace webNEOC.Organization {
}
declare namespace webNEOC.Organization {
    class ContactForm extends Serenity.PrefixedContext {
        static formKey: string;
    }
    interface ContactForm {
        Title: Serenity.StringEditor;
        FirstName: Serenity.StringEditor;
        LastName: Serenity.StringEditor;
        Email: Serenity.EmailEditor;
        IdentityNo: Serenity.StringEditor;
        UserId: Serenity.LookupEditor;
    }
}
declare namespace webNEOC.Organization {
    interface ContactRow {
        ContactId?: number;
        Title?: string;
        FirstName?: string;
        LastName?: string;
        FullName?: string;
        Email?: string;
        IdentityNo?: string;
        UserId?: number;
        Username?: string;
        UserDisplayName?: string;
        UserEmail?: string;
        UserSource?: string;
        UserPasswordHash?: string;
        UserPasswordSalt?: string;
        UserLastDirectoryUpdate?: string;
        UserUserImage?: string;
        UserInsertDate?: string;
        UserInsertUserId?: number;
        UserUpdateDate?: string;
        UserUpdateUserId?: number;
        UserIsActive?: number;
    }
    namespace ContactRow {
        const idProperty = "ContactId";
        const nameProperty = "FullName";
        const localTextPrefix = "Organization.Contact";
        const lookupKey = "Organization.Contact";
        function getLookup(): Q.Lookup<ContactRow>;
        namespace Fields {
            const ContactId: string;
            const Title: string;
            const FirstName: string;
            const LastName: string;
            const FullName: string;
            const Email: string;
            const IdentityNo: string;
            const UserId: string;
            const Username: string;
            const UserDisplayName: string;
            const UserEmail: string;
            const UserSource: string;
            const UserPasswordHash: string;
            const UserPasswordSalt: string;
            const UserLastDirectoryUpdate: string;
            const UserUserImage: string;
            const UserInsertDate: string;
            const UserInsertUserId: string;
            const UserUpdateDate: string;
            const UserUpdateUserId: string;
            const UserIsActive: string;
        }
    }
}
declare namespace webNEOC.Organization {
    namespace ContactService {
        const baseUrl = "Organization/Contact";
        function Create(request: Serenity.SaveRequest<ContactRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<ContactRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<ContactRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<ContactRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        namespace Methods {
            const Create: string;
            const Update: string;
            const Delete: string;
            const Retrieve: string;
            const List: string;
        }
    }
}
declare namespace webNEOC.PostCampaign {
}
declare namespace webNEOC.PostCampaign {
    class LQASForm extends Serenity.PrefixedContext {
        static formKey: string;
    }
    interface LQASForm {
        RoundId: Serenity.LookupEditor;
        DateFrom: Serenity.DateEditor;
        DateTo: Serenity.DateEditor;
        ProvinceId: Serenity.LookupEditor;
        DistrictId: Serenity.LookupEditor;
        LotNo: Serenity.IntegerEditor;
        NoVaccChildren: Serenity.IntegerEditor;
        Comments: Serenity.TextAreaEditor;
    }
}
declare namespace webNEOC.PostCampaign {
    interface LQASRow {
        LqasId?: number;
        DistrictId?: number;
        LotNo?: number;
        NoVaccChildren?: number;
        RoundId?: number;
        Comments?: string;
        RoundName?: string;
        DateFrom?: string;
        DateTo?: string;
        TenantId?: number;
        DistrictDcode?: string;
        ProvinceId?: number;
        DistrictDname?: string;
        Province?: string;
        DistrictTotalPop?: number;
        DistrictTargetPop?: number;
        DistrictPriority?: number;
        DistrictPopYear?: number;
    }
    namespace LQASRow {
        const idProperty = "LqasId";
        const nameProperty = "Comments";
        const localTextPrefix = "PostCampaign.LQAS";
        namespace Fields {
            const LqasId: string;
            const DistrictId: string;
            const LotNo: string;
            const NoVaccChildren: string;
            const RoundId: string;
            const Comments: string;
            const RoundName: string;
            const DateFrom: string;
            const DateTo: string;
            const TenantId: string;
            const DistrictDcode: string;
            const ProvinceId: string;
            const DistrictDname: string;
            const Province: string;
            const DistrictTotalPop: string;
            const DistrictTargetPop: string;
            const DistrictPriority: string;
            const DistrictPopYear: string;
        }
    }
}
declare namespace webNEOC.PostCampaign {
    namespace LQASService {
        const baseUrl = "PostCampaign/LQAS";
        function Create(request: Serenity.SaveRequest<LQASRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<LQASRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<LQASRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<LQASRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        namespace Methods {
            const Create: string;
            const Update: string;
            const Delete: string;
            const Retrieve: string;
            const List: string;
        }
    }
}
declare namespace webNEOC.PostCampaign {
}
declare namespace webNEOC.PostCampaign {
    class OutOfHouseSurveyForm extends Serenity.PrefixedContext {
        static formKey: string;
    }
    interface OutOfHouseSurveyForm {
        RoundId: Serenity.LookupEditor;
        DateFrom: Serenity.DateEditor;
        DateTo: Serenity.DateEditor;
        ProvinceId: Serenity.LookupEditor;
        DistrictId: Serenity.LookupEditor;
        ReportDate: Serenity.DateEditor;
        T059m: Serenity.IntegerEditor;
        Vac059m: Serenity.IntegerEditor;
        FM059m: Serenity.IntegerEditor;
        T059f: Serenity.IntegerEditor;
        Vac059f: Serenity.IntegerEditor;
        FM059f: Serenity.IntegerEditor;
        MissTmNotCome: Serenity.IntegerEditor;
        MissAbsent: Serenity.IntegerEditor;
        MissRefused: Serenity.IntegerEditor;
        MissNewBornSick: Serenity.IntegerEditor;
    }
}
declare namespace webNEOC.PostCampaign {
    interface OutOfHouseSurveyRow {
        OutOfHouseSurveyId?: number;
        RoundId?: number;
        DistrictId?: number;
        ReportDate?: string;
        T059m?: number;
        Vac059m?: number;
        FM059m?: number;
        T059f?: number;
        Vac059f?: number;
        FM059f?: number;
        MissTmNotCome?: number;
        MissAbsent?: number;
        MissRefused?: number;
        MissNewBornSick?: number;
        RoundName?: string;
        DateFrom?: string;
        DateTo?: string;
        TenantId?: number;
        DistrictDcode?: string;
        ProvinceId?: number;
        Province?: string;
        DistrictDname?: string;
        DistrictTotalPop?: number;
        DistrictTargetPop?: number;
        DistrictType?: string;
        DistrictPriority?: number;
        DistrictPopYear?: number;
    }
    namespace OutOfHouseSurveyRow {
        const idProperty = "OutOfHouseSurveyId";
        const localTextPrefix = "PostCampaign.OutOfHouseSurvey";
        namespace Fields {
            const OutOfHouseSurveyId: string;
            const RoundId: string;
            const DistrictId: string;
            const ReportDate: string;
            const T059m: string;
            const Vac059m: string;
            const FM059m: string;
            const T059f: string;
            const Vac059f: string;
            const FM059f: string;
            const MissTmNotCome: string;
            const MissAbsent: string;
            const MissRefused: string;
            const MissNewBornSick: string;
            const RoundName: string;
            const DateFrom: string;
            const DateTo: string;
            const TenantId: string;
            const DistrictDcode: string;
            const ProvinceId: string;
            const Province: string;
            const DistrictDname: string;
            const DistrictTotalPop: string;
            const DistrictTargetPop: string;
            const DistrictType: string;
            const DistrictPriority: string;
            const DistrictPopYear: string;
        }
    }
}
declare namespace webNEOC.PostCampaign {
    namespace OutOfHouseSurveyService {
        const baseUrl = "PostCampaign/OutOfHouseSurvey";
        function Create(request: Serenity.SaveRequest<OutOfHouseSurveyRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<OutOfHouseSurveyRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<OutOfHouseSurveyRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<OutOfHouseSurveyRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        namespace Methods {
            const Create: string;
            const Update: string;
            const Delete: string;
            const Retrieve: string;
            const List: string;
        }
    }
}
declare namespace webNEOC.PostCampaign {
}
declare namespace webNEOC.PostCampaign {
    class PcmForm extends Serenity.PrefixedContext {
        static formKey: string;
    }
    interface PcmForm {
        RoundId: Serenity.LookupEditor;
        DateFrom: Serenity.DateEditor;
        DateTo: Serenity.DateEditor;
        ProvinceId: Serenity.LookupEditor;
        DistrictId: Serenity.LookupEditor;
        ClusterId: Serenity.LookupEditor;
        ClusterLevelId: Serenity.LookupEditor;
        CampaignTypeId: Serenity.LookupEditor;
        ClusterCode: Serenity.StringEditor;
        Village: Serenity.StringEditor;
        VistedHouses: Serenity.IntegerEditor;
        T059m: Serenity.IntegerEditor;
        V059m: Serenity.IntegerEditor;
        T011Seen: Serenity.IntegerEditor;
        Fm011HvFm: Serenity.IntegerEditor;
        T1259Seen: Serenity.IntegerEditor;
        Fm1259HvFm: Serenity.IntegerEditor;
        TChildrenNoFm: Serenity.IntegerEditor;
        R1TeamNoVisit: Serenity.IntegerEditor;
        R21: Serenity.IntegerEditor;
        R22: Serenity.IntegerEditor;
        R23: Serenity.IntegerEditor;
        R24: Serenity.IntegerEditor;
        R31: Serenity.IntegerEditor;
        R32: Serenity.IntegerEditor;
        R33: Serenity.IntegerEditor;
        R4NewBorn: Serenity.IntegerEditor;
        R5Sleep: Serenity.IntegerEditor;
        R6Sick: Serenity.IntegerEditor;
        R7Other: Serenity.IntegerEditor;
        DmCorrect: Serenity.IntegerEditor;
        DmIncorrect: Serenity.IntegerEditor;
        NoDm: Serenity.IntegerEditor;
        FmHeard: Serenity.IntegerEditor;
        FmNotHeard: Serenity.IntegerEditor;
        Radio: Serenity.IntegerEditor;
        Tv: Serenity.IntegerEditor;
        MullahElders: Serenity.IntegerEditor;
        Teacher: Serenity.IntegerEditor;
        Chw: Serenity.IntegerEditor;
        CElders: Serenity.IntegerEditor;
        PbLeaflet: Serenity.IntegerEditor;
        Sm: Serenity.IntegerEditor;
        Other: Serenity.IntegerEditor;
        ChVacByMonitor: Serenity.IntegerEditor;
        RCallCoverage: Serenity.IntegerEditor;
        Fm059Coverage: Serenity.IntegerEditor;
        Fm011Coverage: Serenity.IntegerEditor;
        InAcesChildren: Serenity.IntegerEditor;
    }
}
declare namespace webNEOC.PostCampaign {
    interface PcmRow {
        PcmId?: number;
        RoundId?: number;
        DistrictId?: number;
        ClusterLevelId?: number;
        ClusterId?: number;
        CampaignTypeId?: number;
        ClusterCode?: string;
        Village?: string;
        VistedHouses?: number;
        T059m?: number;
        V059m?: number;
        T011Seen?: number;
        Fm011HvFm?: number;
        T1259Seen?: number;
        Fm1259HvFm?: number;
        TChildrenNoFm?: number;
        R1TeamNoVisit?: number;
        R21?: number;
        R22?: number;
        R23?: number;
        R24?: number;
        R31?: number;
        R32?: number;
        R33?: number;
        R4NewBorn?: number;
        R5Sleep?: number;
        R6Sick?: number;
        R7Other?: number;
        DmCorrect?: number;
        DmIncorrect?: number;
        NoDm?: number;
        FmHeard?: number;
        FmNotHeard?: number;
        Radio?: number;
        Tv?: number;
        MullahElders?: number;
        Teacher?: number;
        Chw?: number;
        CElders?: number;
        PbLeaflet?: number;
        Sm?: number;
        Other?: number;
        ChVacByMonitor?: number;
        RCallCoverage?: number;
        Fm059Coverage?: number;
        Fm011Coverage?: number;
        InAcesChildren?: number;
        DateFrom?: string;
        DateTo?: string;
        RoundName?: string;
        ClusterName?: string;
        LevelName?: string;
        CampaignTypeName?: string;
        TenantId?: number;
        DistrictDcode?: string;
        ProvinceId?: number;
        DistrictDname?: string;
        Province?: string;
        DistrictTotalPop?: number;
        DistrictTargetPop?: number;
        DistrictType?: string;
        DistrictPriority?: number;
        DistrictPopYear?: number;
    }
    namespace PcmRow {
        const idProperty = "PcmId";
        const nameProperty = "Village";
        const localTextPrefix = "PostCampaign.Pcm";
        namespace Fields {
            const PcmId: string;
            const RoundId: string;
            const DistrictId: string;
            const ClusterLevelId: string;
            const ClusterId: string;
            const CampaignTypeId: string;
            const ClusterCode: string;
            const Village: string;
            const VistedHouses: string;
            const T059m: string;
            const V059m: string;
            const T011Seen: string;
            const Fm011HvFm: string;
            const T1259Seen: string;
            const Fm1259HvFm: string;
            const TChildrenNoFm: string;
            const R1TeamNoVisit: string;
            const R21: string;
            const R22: string;
            const R23: string;
            const R24: string;
            const R31: string;
            const R32: string;
            const R33: string;
            const R4NewBorn: string;
            const R5Sleep: string;
            const R6Sick: string;
            const R7Other: string;
            const DmCorrect: string;
            const DmIncorrect: string;
            const NoDm: string;
            const FmHeard: string;
            const FmNotHeard: string;
            const Radio: string;
            const Tv: string;
            const MullahElders: string;
            const Teacher: string;
            const Chw: string;
            const CElders: string;
            const PbLeaflet: string;
            const Sm: string;
            const Other: string;
            const ChVacByMonitor: string;
            const RCallCoverage: string;
            const Fm059Coverage: string;
            const Fm011Coverage: string;
            const InAcesChildren: string;
            const DateFrom: string;
            const DateTo: string;
            const RoundName: string;
            const ClusterName: string;
            const LevelName: string;
            const CampaignTypeName: string;
            const TenantId: string;
            const DistrictDcode: string;
            const ProvinceId: string;
            const DistrictDname: string;
            const Province: string;
            const DistrictTotalPop: string;
            const DistrictTargetPop: string;
            const DistrictType: string;
            const DistrictPriority: string;
            const DistrictPopYear: string;
        }
    }
}
declare namespace webNEOC.PostCampaign {
    namespace PcmService {
        const baseUrl = "PostCampaign/Pcm";
        function Create(request: Serenity.SaveRequest<PcmRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<PcmRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<PcmRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<PcmRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        namespace Methods {
            const Create: string;
            const Update: string;
            const Delete: string;
            const Retrieve: string;
            const List: string;
        }
    }
}
declare namespace webNEOC.Preparation {
}
declare namespace webNEOC.Preparation {
    class InAccessibleForm extends Serenity.PrefixedContext {
        static formKey: string;
    }
    interface InAccessibleForm {
        RoundId: Serenity.LookupEditor;
        DateFrom: Serenity.DateEditor;
        DateTo: Serenity.DateEditor;
        ProvinceId: Serenity.LookupEditor;
        DistrictId: Serenity.LookupEditor;
        ReportDate: Serenity.DateEditor;
        Target: Serenity.IntegerEditor;
        MissedClusters: Serenity.IntegerEditor;
        MissedChildren: Serenity.IntegerEditor;
        PartiallyMissed: Serenity.IntegerEditor;
        PartiallyMissedName: Serenity.TextAreaEditor;
        FullyMissed: Serenity.IntegerEditor;
        FullyMissedName: Serenity.TextAreaEditor;
        InAcsCategoryId: Serenity.LookupEditor;
        PlanToReduce: Serenity.TextAreaEditor;
        Remarks: Serenity.TextAreaEditor;
    }
}
declare namespace webNEOC.Preparation {
    interface InAccessibleRow {
        InAccessibleId?: number;
        RoundId?: number;
        DistrictId?: number;
        ReportDate?: string;
        Target?: number;
        MissedClusters?: number;
        MissedChildren?: number;
        PartiallyMissed?: number;
        PartiallyMissedName?: string;
        FullyMissed?: number;
        FullyMissedName?: string;
        InAcsCategoryId?: number;
        PlanToReduce?: string;
        Remarks?: string;
        RoundName?: string;
        DateFrom?: string;
        DateTo?: string;
        TenantId?: number;
        DistrictDcode?: string;
        ProvinceId?: number;
        Province?: string;
        DistrictDname?: string;
        DistrictTotalPop?: number;
        DistrictTargetPop?: number;
        DistrictType?: string;
        DistrictPriority?: number;
        DistrictPopYear?: number;
        Description?: string;
    }
    namespace InAccessibleRow {
        const idProperty = "InAccessibleId";
        const nameProperty = "PartiallyMissedName";
        const localTextPrefix = "Preparation.InAccessible";
        namespace Fields {
            const InAccessibleId: string;
            const RoundId: string;
            const DistrictId: string;
            const ReportDate: string;
            const Target: string;
            const MissedClusters: string;
            const MissedChildren: string;
            const PartiallyMissed: string;
            const PartiallyMissedName: string;
            const FullyMissed: string;
            const FullyMissedName: string;
            const InAcsCategoryId: string;
            const PlanToReduce: string;
            const Remarks: string;
            const RoundName: string;
            const DateFrom: string;
            const DateTo: string;
            const TenantId: string;
            const DistrictDcode: string;
            const ProvinceId: string;
            const Province: string;
            const DistrictDname: string;
            const DistrictTotalPop: string;
            const DistrictTargetPop: string;
            const DistrictType: string;
            const DistrictPriority: string;
            const DistrictPopYear: string;
            const Description: string;
        }
    }
}
declare namespace webNEOC.Preparation {
    namespace InAccessibleService {
        const baseUrl = "Preparation/InAccessible";
        function Create(request: Serenity.SaveRequest<InAccessibleRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<InAccessibleRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<InAccessibleRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<InAccessibleRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        namespace Methods {
            const Create: string;
            const Update: string;
            const Delete: string;
            const Retrieve: string;
            const List: string;
        }
    }
}
declare namespace webNEOC.Preparation {
}
declare namespace webNEOC.Preparation {
    class MicroplanForm extends Serenity.PrefixedContext {
        static formKey: string;
    }
    interface MicroplanForm {
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
}
declare namespace webNEOC.Preparation {
    interface MicroplanRow {
        MicroplanId?: number;
        RoundId?: number;
        DistrictId?: number;
        ReportDate?: string;
        Sno?: number;
        TotalPop?: number;
        OpvTarget?: number;
        MissedTarget?: number;
        VitATarget?: number;
        Teams?: number;
        NomadTeams?: number;
        FixVacTeams?: number;
        RemtpemTstaff?: number;
        Coordinators?: number;
        Pco?: number;
        Dpodco?: number;
        CcSs?: number;
        SMs?: number;
        Sup?: number;
        NoOfTeams?: number;
        Volunteers?: number;
        IntraNiDsMonitors?: number;
        PcAmonotors?: number;
        OpvDoses?: number;
        OpvVials?: number;
        AlbendazTablet?: number;
        VitACapsules?: number;
        ColdBoxes?: number;
        Thermos?: number;
        IcePacks?: number;
        Banner?: number;
        Vehicle?: number;
        MotorBikes4Monitors?: number;
        MotorBikes4Nomads?: number;
        Leflet?: number;
        Scissors?: number;
        FingerMarkers?: number;
        PlasticBagNo?: number;
        PenNo?: number;
        ChalkNo?: number;
        AlbenVitSheetCoordinator?: number;
        AlbenVitSheetSupvervisor?: number;
        RoundName?: string;
        DateFrom?: string;
        DateTo?: string;
        TenantId?: number;
        DistrictDcode?: string;
        ProvinceId?: number;
        Province?: string;
        DistrictDname?: string;
        DistrictTotalPop?: number;
        DistrictTargetPop?: number;
        DistrictType?: string;
        DistrictPriority?: number;
        DistrictPopYear?: number;
    }
    namespace MicroplanRow {
        const idProperty = "MicroplanId";
        const localTextPrefix = "Preparation.Microplan";
        namespace Fields {
            const MicroplanId: string;
            const RoundId: string;
            const DistrictId: string;
            const ReportDate: string;
            const Sno: string;
            const TotalPop: string;
            const OpvTarget: string;
            const MissedTarget: string;
            const VitATarget: string;
            const Teams: string;
            const NomadTeams: string;
            const FixVacTeams: string;
            const RemtpemTstaff: string;
            const Coordinators: string;
            const Pco: string;
            const Dpodco: string;
            const CcSs: string;
            const SMs: string;
            const Sup: string;
            const NoOfTeams: string;
            const Volunteers: string;
            const IntraNiDsMonitors: string;
            const PcAmonotors: string;
            const OpvDoses: string;
            const OpvVials: string;
            const AlbendazTablet: string;
            const VitACapsules: string;
            const ColdBoxes: string;
            const Thermos: string;
            const IcePacks: string;
            const Banner: string;
            const Vehicle: string;
            const MotorBikes4Monitors: string;
            const MotorBikes4Nomads: string;
            const Leflet: string;
            const Scissors: string;
            const FingerMarkers: string;
            const PlasticBagNo: string;
            const PenNo: string;
            const ChalkNo: string;
            const AlbenVitSheetCoordinator: string;
            const AlbenVitSheetSupvervisor: string;
            const RoundName: string;
            const DateFrom: string;
            const DateTo: string;
            const TenantId: string;
            const DistrictDcode: string;
            const ProvinceId: string;
            const Province: string;
            const DistrictDname: string;
            const DistrictTotalPop: string;
            const DistrictTargetPop: string;
            const DistrictType: string;
            const DistrictPriority: string;
            const DistrictPopYear: string;
        }
    }
}
declare namespace webNEOC.Preparation {
    namespace MicroplanService {
        const baseUrl = "Preparation/Microplan";
        function Create(request: Serenity.SaveRequest<MicroplanRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<MicroplanRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<MicroplanRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<MicroplanRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        namespace Methods {
            const Create: string;
            const Update: string;
            const Delete: string;
            const Retrieve: string;
            const List: string;
        }
    }
}
declare namespace webNEOC {
    interface ScriptUserDefinition {
        Username?: string;
        DisplayName?: string;
        IsAdmin?: boolean;
        Permissions?: {
            [key: string]: boolean;
        };
    }
}
