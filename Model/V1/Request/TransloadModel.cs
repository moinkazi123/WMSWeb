namespace WMSCOREAPI.Model.V1.Request
{
    public class RecevingListMobile
    {
        public string CustomerId { get; set; }
        public string WarehouseId { get; set; }
        public string UserId { get; set; }
        public string OrderId { get; set; }

    }

    public class TransportList
    {
        public string CompanyId { get; set; }
        public string userId { get; set; }
        public string whId { get; set; }
        public string custId { get; set; }
        public string vendorName { get; set; }

    }

    public class DockList
    {
        public string CompanyId { get; set; }
        public string userId { get; set; }
        public string whId { get; set; }
        public string custId { get; set; }
        public string DockName { get; set; }

    }
    public class OrderTypeList
    {
        public string CompanyId { get; set; }
        public string userId { get; set; }
        public string whId { get; set; }
        public string custId { get; set; }
        public string OrderType { get; set; }

    }
    public class TransportDetail
    {
        public string Id { get; set; }
        public string AirwaybillRT { get; set; }
        public string shippingtypeRT { get; set; }
        public string shippingdateRT { get; set; }
        public string expdeldateRT { get; set; }
        public string TransporterNameRT { get; set; }
        public string TransporterRemarkRT { get; set; }
        public string OutTimeRT { get; set; }
        public string ContainerID { get; set; }
        public string DockNoRT { get; set; }
        public string TruckNo { get; set; }
        public string LRNoRT { get; set; }
        public string InTimeRT { get; set; }
        public string Trailer { get; set; }
        public string Seal { get; set; }
        public string Carrier { get; set; }
        public string OrderType { get; set; }
        public string UserId { get; set; }

    }

    public class ScanLogForStaging
    {
        public string CustomerId { get; set; }
        public string WarehouseId { get; set; }
        public string UserId { get; set; }
        public string OrderId { get; set; }
        public string OrderDTId { get; set; }

    }

    public class Mob_ScanData
    {
        public string companyId { get; set; }
        public string userId { get; set; }
        public string whId { get; set; }
        public string custId { get; set; }
        public string LocationId { get; set; }
        public string PalletId { get; set; }
        public string ScanData { get; set; }
        public string OrderType { get; set; }

    }

    public class ScanHistory
    {
        public string CustomerId { get; set; }
        public string WarehouseId { get; set; }
        public string UserId { get; set; }
        public string ContainerId { get; set; }
        public string OrderDTId { get; set; }

    }
    public class SaveScanLogRecDT
    {
        public string CustomerId { get; set; }
        public string WarehouseId { get; set; }
        public string UserId { get; set; }
        public string OrderId { get; set; }
        public string OrderDTId { get; set; }
        public string StagingId { get; set; }
        public string PalletId { get; set; }
        public string PalletType { get; set; }
        public string PalletTypeId { get; set; }
        public string Noofcarton { get; set; }
        public string Weight { get; set; }
        public string Height { get; set; }
        public string Width { get; set; }
        public string Length { get; set; }
        public string UOMID { get; set; }
        public string PalletImg { get; set; }
        public string Remark { get; set; }
        public string OrderType { get; set; }

    }
    public class StagingListMobile
    {
        public string CustomerId { get; set; }
        public string WarehouseId { get; set; }
        public string UserId { get; set; }
        public string OrderId { get; set; }

    }

    public class MobDockIdStatus
    {
        public string WarehouseId { get; set; }
        public string CustomerId { get; set; }
        public string CompanyID { get; set; }
        public string UserId { get; set; }
        public string TranloadDTId { get; set; }
        public string DockId { get; set; }
        public string PalletId { get; set; }
        public string TranloadId { get; set; }


    }
    public class Get_Staging_scanAPI
    {
        public string companyId { get; set; }
        public string userId { get; set; }
        public string whId { get; set; }
        public string custId { get; set; }
        public string LocationId { get; set; }
        public string PalletId { get; set; }
        public string OrderId { get; set; }
        public string OrderDTId { get; set; }
        public string ScanData { get; set; }


    }
}
