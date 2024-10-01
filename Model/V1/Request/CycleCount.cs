using System.ComponentModel.DataAnnotations;

namespace WMSCOREAPI.Model.V1.Request
{
    public class palletCheckrequest
    {
        public string CustomerId { get; set; }
        public string WarehouseId { get; set; }
        public string CompanyId { get; set; }
        public string UserID { get; set; }

    }
    public class lottablelistrequest
    {
        public string CustomerId { get; set; }
        public string WarehouseId { get; set; }
        public string CompanyId { get; set; }
        public string SkuID { get; set; }
        public string UserID { get; set; }
        public string LocationId { get; set; }
        public string PalletID { get; set; }
        public string PlanId { get; set; }

    }
    public class CycleCountPlanlistRequest
    {
        public string custid { get; set; }
        public string UserID { get; set; }
        public string WarehouseID { get; set; }

        [DisplayFormat(ConvertEmptyStringToNull = false)]
        public string skey { get; set; }
    }
    public class CycleCountPlanSkulist
    {
        public string custid { get; set; }
        public string UserID { get; set; }
        public string WarehouseID { get; set; }
        public string CompanyID { get; set; }
        public string PlanID { get; set; }
        public string Flag { get; set; }
    }
    public class CycleCountScanBarcoderequest
    {
        public string Barcode { get; set; }
        public string Pallet { get; set; }
        public string Location { get; set; }
        public string SkuID { get; set; }
        public string UserID { get; set; }
        public string CustId { get; set; }
        public string pactive { get; set; }
        public string Warehouse { get; set; }
        public string CompanyId { get; set; }
        public string PlanID { get; set; }

    }
    public class CycleCountUpdateqnt
    {
        public string planid { get; set; }
        public string detailid { get; set; }
        public string locid { get; set; }
        public string pltid { get; set; }
        public string prdid { get; set; }
        public string qty { get; set; }
        public string remark { get; set; }
        public string reasonid { get; set; }
        public string custid { get; set; }
        public string compid { get; set; }
        public string uid { get; set; }
        public string batchCode { get; set; }
        public string lottable1 { get; set; }
        public string lottable2 { get; set; }
        public string lottable3 { get; set; }
        public string lottable4 { get; set; }
        public string lottable5 { get; set; }
        public string lottable6 { get; set; }
        public string lottable7 { get; set; }
        public string lottable8 { get; set; }
        public string lottable9 { get; set; }
        public string lottable10 { get; set; }
        public string eLot1 { get; set; }
        public string eLot2 { get; set; }
        public string eLot3 { get; set; }
        public string eLot4 { get; set; }
        public string eLot5 { get; set; }
        public string eLot6 { get; set; }
        public string eLot7 { get; set; }
        public string eLot8 { get; set; }
        public string eLot9 { get; set; }
        public string eLot10 { get; set; }
    }
    public class UpdateQntCheck
    {
        public string planid { get; set; }
        public string detailid { get; set; }
        public string locid { get; set; }
        public string pltid { get; set; }
        public string prdid { get; set; }
        public string qty { get; set; }
        public string uid { get; set; }
    }
    public class Updateplanrequest
    {
        public string planid { get; set; }
        public string custid { get; set; }
        public string UserID { get; set; }
    }

    public class SearchLottList
    {
        public string Pallet { get; set; }
        public string Location { get; set; }
        public string SkuID { get; set; }
        public string UserID { get; set; }
        public string CustId { get; set; }
        public string Warehouse { get; set; }
        public string PlanID { get; set; }

    }
}
