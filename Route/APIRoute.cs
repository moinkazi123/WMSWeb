using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WMSCOREAPI.Route
{
    public class APIRoute
    {
        public const string Root = "api";
        public const string Environment = "staging";
        public const string Version = "v1";
        public const string Base = Root + "/" + Environment + "/" + Version;
        public static class GRN
        {
            //public const string GetSKUList = Base + "/GRN/getGRNList";
            //public const string GetDropDownOption = Base + "/GRN/GetDropDownOption";
            //public const string MobSaveGateDetails = Base + "/GRN/MobSaveGateDetails";
            //public const string ScanPalletandSKUUDetails = Base + "/GRN/ScanPalletandSKUUDetails";
            //public const string GetGRNRecevingSKUScan = Base + "/GRN/GetGRNRecevingSKUScan";
            //public const string GetReceivingHistory = Base + "/GRN/GetReceivingHistory";
            //public const string UpdateReceivingProdQuantity = Base + "/GRN/UpdateReceivingProdQuantity";
            //public const string SaveGRN = Base + "/GRN/SaveGRN";

            public const string GetSKUList = Base + "/GRN/GetGRNList";
            public const string SaveSKUDetails = Base + "/GRN/SaveGRNDetails";
            public const string RemoveSKU = Base + "/GRN/RemoveSKU";
            public const string GetTransportList = Base + "/GRN/GetTransportList";
            public const string SaveGRNTransport = Base + "/GRN/SaveGRNTransport";
            public const string GetGRNTransportDetail = Base + "/GRN/GetGRNTransportDetail";
            public const string GetGRNHead = Base + "/GRN/GetGRNHead";
            public const string GetGRNDetail = Base + "/GRN/GetGRNDetail";
            public const string getGRNID = Base + "/GRN/getGRNID";
            public const string SaveGRNSKUDetail = Base + "/GRN/SaveGRNSKUDetail";
            public const string UpdateGrnStatus = Base + "/GRN/UpdateGrnStatus";
            public const string GetGatePassDetail = Base + "/GRN/GetGatePassDetail";
            public const string SaveGatePass = Base + "/GRN/SaveGatePass";
            //public const string SkuGrnHistory = Base + "/GRN/SkuGrnHistory";

            //FOR MOBILE API ROUTE
            public const string GetGRNListDetails = Base + "/MobileApi/GetGRNListDetails";
            public const string GetDropDownOption = Base + "/MobileApi/GetDropDownOption";
            public const string MobSaveGateDetails = Base + "/MobileApi/MobSaveGateDetails";
            public const string ScanPalletandSKUUDetails = Base + "/MobileApi/ScanPalletandSKUUDetails";
            public const string GetGRNRecevingSKUScan = Base + "/MobileApi/GetGRNRecevingSKUScan";
            public const string GetGRNScanLog = Base + "/MobileApi/GetGRNScanLog";
            // public const string GetReceivingHistory = Base + "/GRN/mob/GetReceivingHistory";
            public const string GetReceivingHistory = Base + "/MobileApi/GetReceivingHistory";
            public const string UpdateReceivingProdQuantity = Base + "/MobileApi/UpdateReceivingProdQuantity";
            public const string SaveGRN = Base + "/MobileApi/SaveGRN";
            public const string BlanRecevingPO = Base + "/MobileApi/BlanRecevingPO";
            public const string BlanRecevingScnaPallet = Base + "/MobileApi/BlanRecevingScnaPallet";
            public const string UpdateRecProdQtyBlank = Base + "/MobileApi/UpdateRecProdQtyBlank";

            public const string BarcodeScanLott = Base + "/MobileApi/BarcodeScanLott";
            public const string UpdateSkuandpalletLott = Base + "/MobileApi/UpdateSkuandpalletLott";
            public const string UpdateGrnMobLott = Base + "/MobileApi/UpdateGrnMobLott";
            public const string forceUpdateGrnQuantity = Base + "/MobileApi/forceUpdateGrnQuantity";

            public const string UpdateGrnLottable = Base + "/MobileApi/UpdateGrnLottable";
            public const string SkuGrnHistory = Base + "/MobileApi/SkuGrnHistory";
            public const string CheckGrnID = Base + "/MobileApi/CheckGrnID";
            public const string UpdateQtyGrnHistory = Base + "/MobileApi/UpdateQtyGrnHistory";

        }
        public static class PutIn
        {
            public const string getmobPutinlist = Base + "/MobileApi/getmobPutinlist"; // not use
            public const string getmobPalletAndLoctionDetails = Base + "/MobileApi/getmobPalletAndLoctionDetails"; //getbarcode tye & Details
            public const string getPutAwayHistory = Base + "/MobileApi/getPutAwayHistory"; //history


            public const string getmobilePutinList = Base + "/MobileApi/getmobilePutinList";
            public const string getSuggestedLocationBySKU = Base + "/MobileApi/getSuggestedLocationBySKU";
            public const string getPutInScan = Base + "/MobileApi/getPutInScan";
            public const string getmobSKUAndLoctionDetails = Base + "/MobileApi/getmobSKUAndLoctionDetails"; // for getBarcodeTypeAndDetails ispallet-NO & isQC-YES

            public const string ScanMobileBarcodeNOQC = Base + "/MobileApi/ScanMobileBarcodeNOQC";
            public const string ScanLogMobileNOQC = Base + "/MobileApi/ScanLogMobileNOQC";
            public const string GetLocListNoQc = Base + "/MobileApi/GetLocListNoQc";
            public const string PutInScanNoQcNoPallet = Base + "/MobileApi/PutInScanNoQcNoPallet";
            public const string ScanMobBarcodeNoQcNoPallet = Base + "/MobileApi/ScanMobBarcodeNoQcNoPallet";

            public const string getPutInScanYes = Base + "/MobileApi/getPutInScanYes";
            public const string UpdateQtyPutinNoQC = Base + "/MobileApi/UpdateQtyPutinNoQC";
            public const string HistoryPutinNoQC = Base + "/MobileApi/HistoryPutinNoQC";

            public const string UpdateQtyPutinWithQC = Base + "/MobileApi/UpdateQtyPutinWithQC";
            public const string HistoryPutinWithQC = Base + "/MobileApi/HistoryPutinWithQC";

            public const string PutAwayHistoryWithOutQcWithPlt = Base + "/MobileApi/PutAwayHistoryWithOutQcWithPlt";

            public const string MobGetPutAwaySKUHistory = Base + "/MobileApi/MobGetPutAwaySKUHistory";
            public const string SKUHistoryNoQCYesPlt = Base + "/MobileApi/SKUHistoryNoQCYesPlt";
            public const string SKUHistoryWithQCNoPlt = Base + "/MobileApi/SKUHistoryWithQCNoPlt";
            public const string MobPutAwayHistoryNoQCNoPlt = Base + "/MobileApi/MobPutAwayHistoryNoQCNoPlt";
            public const string SKUHistoryNoQCNoPlt = Base + "/MobileApi/SKUHistoryNoQCNoPlt";

            public const string ScanputinMobile = Base + "/MobileApi/ScanputinMobile";
        }
        public static class InboundQC
        {
            public const string UpdateQCStatus = Base + "/MobileApi/UpdateQCStatus";
            public const string MobQCList = Base + "/MobileApi/QCList";
            public const string MobgetQCID = Base + "/MobileApi/MobgetQCID";
            public const string MobGetQCHistory = Base + "/MobileApi/MobGetQCHistory";
            public const string MobDeleteQCRecord = Base + "/MobileApi/MobDeleteQCRecord";
            public const string InboundGetBarcodeScan = Base + "/MobileApi/InboundGetBarcodeScan";
            public const string MobQCScanLog = Base + "/MobileApi/MobQCScanLog";
            public const string GetQCReasoncode = Base + "/MobileApi/GetQCReasoncode";
            public const string InboundSaveMobQCDetail = Base + "/MobileApi/InboundSaveMobQCDetail";
            public const string GetQCsaveDetailScan = Base + "/MobileApi/GetQCsaveDetailScan";
            public const string SavefinalQCDetail = Base + "/MobileApi/SavefinalQCDetail";
            public const string InboundQCBarcodeScan = Base + "/MobileApi/InboundQCBarcodeScan";

            public const string MobGetQCSKUHistory = Base + "/MobileApi/MobGetQCSKUHistory";

        }
        public static class CommFunAPI
        {
            public const string loginprocess = Base + "/MobileApi/LoginProcess";
            public const string ScanMobileBarcode = Base + "/MobileApi/ScanMobileBarcode";
            public const string ScanMobileSerialBarcode = Base + "/MobileApi/ScanMobileSerialBarcode";
        }
        public static class OutboundQC
        {

            public const string OutbondQCList = Base + "/OutboundQC/QCList";
            public const string OutbondMobQCHistory = Base + "/OutboundQC/QCHistory";
            public const string OutbondMobQCSaveScanLog = Base + "/OutboundQC/QCScanLog";
            public const string OutbondMobQCScanLog = Base + "/OutboundQC/QCSKUScanLog";
            public const string OutbondGetBarcodeScan = Base + "/OutboundQC/BarcodeScan";
            public const string OutbondMobQCSaveDetails = Base + "/OutboundQC/QCSaveDetails";
            public const string OutbondMobQCUpdateStatus = Base + "/OutboundQC/QCUpdateStatus";
            public const string GetQCSOList = Base + "/OutboundQC/qcSOList";
            public const string OutbondGetQCLottableList = Base + "/OutboundQC/OutbondGetQCLottableList";
            public const string SkuwiseOutbondMobQCHistory = Base + "/Packing/SkuwiseOutbondMobQCHistory";
        }
        public static class InternalTransfer
        {
            public const string UOMLottable = Base + "/InternalTransfer/UOMLottable";
            public const string ScanBarcode = Base + "/InternalTransfer/ScanBarcode";
            public const string SaveInternalTransfer = Base + "/InternalTransfer/SaveInternalTransfer";
            public const string PalletTransfer = Base + "/InternalTransfer/PalletTransfer";
            public const string CheckIsPallet = Base + "/InternalTransfer/CheckIsPallet";
        }
        public static class CycleCount
        {
            public const string lottablelist = Base + "/MobileApi/CycleCount/lottablelist";
            public const string PalletCheck = Base + "/MobileApi/CycleCount/PalletCheck";

            public const string CycleCountPlanlist = Base + "/MobileApi/CycleCount/CycleCountPlanlist";
            // public const string CycleCountPlanSkulist = Base + "/MobileApi/CycleCount/CycleCountPlanDetaillist";
            public const string CycleCountPlanSkuScanDetail = Base + "/MobileApi/CycleCount/CycleCountGetBarcodeScan";
            public const string CycleCountSearchSkuCode = Base + "/MobileApi/CycleCount/CycleCountSKUSearch";
            public const string CycleCountPlanGetReasonCode = Base + "/MobileApi/CycleCount/CycleCountGetReasonCode";
            public const string CycleCountCheckUpDateQty = Base + "/MobileApi/CycleCount/CycleCountUpdateQTYCheck";
            public const string CycleCountUpDateQty = Base + "/MobileApi/CycleCount/CycleCountUpdateQTY";
            public const string CycleCountPlanDetaillist = Base + "/MobileApi/CycleCount/CycleCountPlanDetaillist";
            public const string CycleCountUpdateplan = Base + "/MobileApi/CycleCount/CycleCountUpdateplan";
            public const string CycleCountScanBarcode = Base + "/MobileApi/CycleCount/CycleCountScanBarcode";
            public const string SearchLottList = Base + "/MobileApi/CycleCount/SearchLottList";
        }

        public static class loginpage
        {
            public const string GetLogin = Base + "/loginpage/GetLogin";
            public const string LogInWithToken = Base + "/loginpage/LogInWithToken";
            public const string ResetPassword = Base + "/loginpage/ResetPassword";
            public const string ForgetPassword = Base + "/loginpage/ForgetPassword";

            public const string GetCompanyLogo = Base + "/loginpage/GetCompanyLogo";
            public const string GetCustLott = Base + "/loginpage/GetCustLott";
        }
        public static class PickUp
        {
            public const string GetPickUpList = Base + "/PickUp/PickUpList";
            public const string GetPickUpListVwOrder = Base + "/PickUp/GetPickUpListVwOrder";
            public const string GetPickUpSKUList = Base + "/PickUp/GetPickUpSkuList";
            public const string GetPickUpScanLog = Base + "/PickUp/GetPickUpScanLog";
            public const string BarcodeScan = Base + "/PickUp/BarcodeScan";
            public const string LottableList = Base + "/PickUp/lottableList";
            public const string SaveSKU = Base + "/PickUp/saveSKU";
            public const string FinalSave = Base + "/PickUp/finalSave";
            public const string UpdatePickUp = Base + "/PickUp/updatePickup";
            public const string GetPickUpEditList = Base + "/PickUp/PickUpEditList";
            public const string SkuWisePickUpSKUList = Base + "/PickUp/SkuWisePickUpSKUList";
            public const string PickEditScanLog = Base + "/PickUp/PickEditScanLog";
            public const string PickEditScanBarcode = Base + "/PickUp/PickEditScanBarcode";
            public const string PickEditLottableList = Base + "/PickUp/PickEditLottableList";
            public const string SavePickUpEditDetails = Base + "/PickUp/SavePickUpEditDetails";
            public const string PickEditCompletedScanLog = Base + "/PickUp/PickEditCompletedScanLog";

        }
        public static class Packing
        {
            public const string GetPackingList = Base + "/Packing/PackingList";
            public const string GetPackingSOList = Base + "/Packing/packingSOList";
            public const string GetPackingSKUList = Base + "/Packing/packingSKUList";
            public const string GetPackingSKULog = Base + "/Packing/packingSKULog";
            public const string GetPackingScan = Base + "/Packing/packingbarcodescan";
            public const string GetPackingSKUDetail = Base + "/Packing/packingskuDetail";
            public const string SavePackingSKUDetail = Base + "/Packing/saveskuDetail";
            public const string SavePackingDetail = Base + "/Packing/saveDetail";
            public const string SkuwisePackingSKUList = Base + "/Packing/SkuwisePackingSKUList";
            public const string MobUpdateQtyPacking = Base + "/Packing/MobUpdateQtyPacking";


        }
        public static class Dispatch
        {
            public const string GetDispatchList = Base + "/Dispatch/GetDispatchList";
            public const string GetDispatchVwOrder = Base + "/Dispatch/GetDispatchVwOrder";
            public const string GetDispatDetail = Base + "/Dispatch/dispatchDetail";
            public const string CarrierList = Base + "/Dispatch/getCarrierList";
            public const string saveDispatchbyso = Base + "/Dispatch/saveDispatchbyso";
            public const string UpdateQty = Base + "/Dispatch/updateQuantity";
            public const string GetDispatchmobScan = Base + "/Dispatch/GetDispatchmobScan";
            public const string Dispatchmobvalidate = Base + "/Dispatch/Dispatchmobvalidate";
            public const string GetDispatchmobSkuScan = Base + "/Dispatch/GetDispatchmobSkuScan";
            public const string GetDispatchmobSkuSave = Base + "/Dispatch/GetDispatchmobSkuSave";
        }
        public static class Replishment
        {
            public const string GetRepListDetails = Base + "/Replishment/GetRepListDetails";
            public const string GetRepscanlog = Base + "/Replishment/GetRepscanlog";
            public const string GetRepscan = Base + "/Replishment/GetRepscan";
            public const string SaveRepSku = Base + "/Replishment/SaveRepSku";
            public const string UpdateStatusRep = Base + "/Replishment/UpdateStatusRep";
        }

        public static class TimeTracker
        {
            public const string BarcodeScanLabour = Base + "/TimeTracker/BarcodeScanLabour";
            public const string LabourHistory = Base + "/TimeTracker/LabourHistory";
            public const string SaveLabour = Base + "/TimeTracker/SaveLabour";
            public const string ScanLogLabour = Base + "/TimeTracker/ScanLogLabour";
            public const string FinalSaveLabour = Base + "/TimeTracker/FinalSaveLabour";

        }
        public static class MobileProdIssue
        {
            public const string GetMobileProdIssuelist = Base + "/MobileProdIssue/GetMobileProdIssuelist";
            public const string GetMobProdIssuelottablelist = Base + "/MobileProdIssue/GetMobProdIssuelottablelist";
            public const string MobilePrdIssueSave = Base + "/MobileProdIssue/MobilePrdIssueSave";
            public const string MobilePrdIssueScanBarcode = Base + "/MobileProdIssue/MobilePrdIssueScanBarcode";
        }
        public static class Search
        {

            public const string GetSearchDropDownValues = Base + "/Search/GetSearchDropDownValues";
            public const string GetSearchBarcodeScan = Base + "/Search/GetSearchBarcodeScan";
            public const string GetSearchScanLog = Base + "/Search/GetSearchScanLog";
        }

        public static class Transload
        {
            public const string RecevingListMobile = Base + "/Transload/RecevingListMobile";
            public const string TransportList = Base + "/Transload/TransportList";
            public const string DockList = Base + "/Transload/DockList";
            public const string OrderTypeList = Base + "/Transload/OrderTypeList";
            public const string TransportDetail = Base + "/Transload/TransportDetail";
            public const string ScanLogForStaging = Base + "/Transload/ScanLogForStaging";
            public const string Mob_ScanData = Base + "/Transload/Mob_ScanData";
            public const string ScanHistory = Base + "/Transload/ScanHistory";
            public const string SaveScanLogRecDT = Base + "/Transload/SaveScanLogRecDT";
            public const string StagingListMobile = Base + "/Transload/StagingListMobile";
            public const string MobDockIdStatus = Base + "/Transload/MobDockIdStatus";
            public const string Get_Staging_scanAPI = Base + "/Transload/Get_Staging_scanAPI";
            public const string GetDispatchDetails = Base + "/Transload/ GetDispatchDetails";

        }
    }
}

