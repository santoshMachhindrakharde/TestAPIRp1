using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace simpalapilearn.MLL
{
    public class AccountInfoModel
    {
        public int AccountLedger_ID { get; set; }
        public int AccountLedger_accountGroupId { get; set; }
        public string AccountLedger_ledgerName { get; set; }
        public string AccountLedger_Type { get; set; }
        public int AccountLedger_TypeId { get; set; }
        public string AccountLedger_Code { get; set; }
        public int AccountLedger_VoucherID { get; set; }
        public string AccountLedger_taxtype { get; set; }
        public double AccountLedger_openingBalance { get; set; }
        public int AccountLedger_BranchId { get; set; }
        public int AccountLedger_CompanyId { get; set; }
        public int AccountLedger_PosId { get; set; }
        public DateTime AccountLedger_ExtraDate { get; set; }
        public string AccountLedger_Status { get; set; }
        public bool AccountLedger_IsDelete { get; set; }
        public int AccountLedger_Createdby { get; set; }
        public DateTime AccountLedger_CreatedDate { get; set; }
        public int AccountLedger_ModifiedBy { get; set; }
        public DateTime AccountLedger_ModifiedDate { get; set; }
        public string AccountLedger_ISGLOBAL { get; set; }
        public string AccountLedger_LocationFlg { get; set; }
        public string AccountLedger_TransCategoryFlg { get; set; }
        public int AccountLedger_Expense_Nature { get; set; }
        public int AccountLedger_Deductee_Type { get; set; }
        public int AccountLedger_is_otp { get; set; }
        public int AccountLedger_IS_MOB_FIRST_TRAN { get; set; }
        public bool AccountLedger_smart_collect_lock { get; set; }
        public string AccountLedger_CloudAccessFlg { get; set; }
        public bool AccountLedger_Allow { get; set; }
        public int AccountLedger_Cust_Id { get; set; }
        public int AccountLedger_is_exempted { get; set; }
        public bool? AccountLedger_isDefault { get; set; }
        public string AccountLedger_crOrDr { get; set; }
        public string AccountLedger_narration { get; set; }
        public string AccountLedger_mailingName { get; set; }
        public string AccountLedger_address { get; set; }
        public string AccountLedger_phone { get; set; }
        public string AccountLedger_mobile { get; set; }
        public string AccountLedger_email { get; set; }
        public int? AccountLedger_creditPeriod { get; set; }
        public double? AccountLedger_creditLimit { get; set; }
        public int? AccountLedger_pricinglevelId { get; set; }
        public bool? AccountLedger_billByBill { get; set; }
        public string AccountLedger_tin { get; set; }
        public string AccountLedger_cst { get; set; }
        public string AccountLedger_pan { get; set; }
        public int? AccountLedger_routeId { get; set; }
        public string AccountLedger_bankAccountNumber { get; set; }
        public string AccountLedger_branchName { get; set; }
        public string AccountLedger_branchCode { get; set; }
        public string AccountLedger_Landmark { get; set; }
        public int? AccountLedger_Area { get; set; }
        public int? AccountLedger_City { get; set; }
        public string AccountLedger_Pincode { get; set; }
        public string AccountLedger_Adharcard { get; set; }
        public string AccountLedger_DateOfBirth { get; set; }
        public string AccountLedger_AliasCode { get; set; }
        public string AccountLedger_Address1 { get; set; }
        public string AccountLedger_Address2 { get; set; }
        public string AccountLedger_Address3 { get; set; }
        public string AccountLedger_Address4 { get; set; }
        public string AccountLedger_STNo { get; set; }
        public string AccountLedger_OpeBalType { get; set; }
        public string AccountLedger_LastChequeNo { get; set; }
        public string AccountLedger_Branch { get; set; }
        public string AccountLedger_DaySummary { get; set; }
        public string AccountLedger_AID { get; set; }
        public string AccountLedger_ServTaxNo { get; set; }
        public string AccountLedger_AliasCode1 { get; set; }
        public string AccountLedger_PaymentMode { get; set; }
        public int? AccountLedger_ChqCleardays { get; set; }
        public string AccountLedger_DefLedgercode { get; set; }
        public int? AccountLedger_TDSCode { get; set; }
        public int? AccountLedger_VATCode { get; set; }
        public string AccountLedger_ChequeName { get; set; }
        public double? AccountLedger_Rateofinterest { get; set; }
        public string AccountLedger_MarketBeatCode { get; set; }
        public string AccountLedger_SalesBeatCode { get; set; }
        public string AccountLedger_DeliveryBeatCode { get; set; }
        public string AccountLedger_Bankname { get; set; }
        public int? AccountLedger_Rem_Cus_Id { get; set; }
        public int? AccountLedger_Cheque_Payment_Days { get; set; }
        public int? AccountLedger_AlertBRSDays { get; set; }
        public double? AccountLedger_Repcom { get; set; }
        public int? AccountLedger_Duedays { get; set; }
        public string AccountLedger_PaymentType { get; set; }
        public string AccountLedger_CollectionDay { get; set; }
        public string AccountLedger_Mcode { get; set; }
        public string AccountLedger_gstno { get; set; }
        public string AccountLedger_aadhar_no { get; set; }
        public int? AccountLedger_state_code { get; set; }
        public string AccountLedger_exempted_type { get; set; }
        public string AccountLedger_sac_code { get; set; }
        public int? AccountLedger_gst_code { get; set; }
        public int? AccountLedger_location_type { get; set; }
        public string AccountLedger_DisplayName { get; set; }
        public string AccountLedger_Extra1 { get; set; }
        public int? AccountLedger_financialYearId { get; set; }
    }
}
    