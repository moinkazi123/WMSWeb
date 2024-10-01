using System.Data.SqlClient;
using System.Text.Json;
using WMSCOREAPI.Model.V1.Request;

namespace WMSCOREAPI.Utility.V1
{
    public class TransloadUtility
    {
        SqlParameter[] param;
        DBActivity obj;


        public TransloadUtility()
        {
            obj = new DBActivity();
        }

        public async Task<JsonElement> RecevingListMobile(RecevingListMobile req)
        {
            param = new SqlParameter[]
                    {

                        new SqlParameter("@CustomerId", req.CustomerId),
                        new SqlParameter("@WarehouseId", req.WarehouseId),
                        new SqlParameter("@UserId", req.UserId),
                        new SqlParameter("@OrderId", req.OrderId)

                    };
            return await obj.ConvertDataSetToJObject(obj.Return_DataSet("Get_RecevingListMobile", param));
        }

        public async Task<JsonElement> TransportList(TransportList req)
        {
            param = new SqlParameter[]
                    {

                        new SqlParameter("@companyId", req.CompanyId),
                        new SqlParameter("@userId", req.userId),
                        new SqlParameter("@whId", req.whId),
                        new SqlParameter("@custId", req.custId),
                        new SqlParameter("@vendorName", req.vendorName)

                    };
            return await obj.ConvertDataSetToJObject(obj.Return_DataSet("Get_vendorList", param));
        }

        public async Task<JsonElement> DockList(DockList req)
        {
            param = new SqlParameter[]
                    {


                        new SqlParameter("@companyId", req.CompanyId),
                        new SqlParameter("@userId", req.userId),
                        new SqlParameter("@whId", req.whId),
                        new SqlParameter("@custId", req.custId),
                        new SqlParameter("@DockName", req.DockName)

                    };
            return await obj.ConvertDataSetToJObject(obj.Return_DataSet("Get_DockList", param));
        }

        public async Task<JsonElement> OrderTypeList(OrderTypeList req)
        {
            param = new SqlParameter[]
                    {


                        new SqlParameter("@companyId", req.CompanyId),
                        new SqlParameter("@userId", req.userId),
                        new SqlParameter("@whId", req.whId),
                        new SqlParameter("@custId", req.custId),
                        new SqlParameter("@OrderType", req.OrderType)

                    };
            return await obj.ConvertDataSetToJObject(obj.Return_DataSet("Get_OrderTypeList", param));
        }

        public async Task<JsonElement> TransportDetail(TransportDetail req)
        {
            param = new SqlParameter[]
                    {

                        new SqlParameter("@Id", req.Id),
                        new SqlParameter("@AirwaybillRT", req.AirwaybillRT),
                        new SqlParameter("@shippingtypeRT", req.shippingtypeRT),
                        new SqlParameter("@shippingdateRT", req.shippingdateRT),
                        new SqlParameter("@expdeldateRT", req.expdeldateRT),
                        new SqlParameter("@TransporterNameRT", req.TransporterNameRT),
                        new SqlParameter("@TransporterRemarkRT", req.TransporterRemarkRT),
                        new SqlParameter("@OutTimeRT", req.OutTimeRT),
                        new SqlParameter("@ContainerID", req.ContainerID),
                        new SqlParameter("@DockNoRT", req.DockNoRT),
                        new SqlParameter("@TruckNo", req.TruckNo),
                        new SqlParameter("@LRNoRT", req.LRNoRT),
                        new SqlParameter("@InTimeRT", req.InTimeRT),
                        new SqlParameter("@Trailer", req.Trailer),
                        new SqlParameter("@Seal", req.Seal),
                        new SqlParameter("@Carrier", req.Carrier),
                        new SqlParameter("@OrderType", req.OrderType),
                        new SqlParameter("@UserId", req.UserId)

            };

            return await obj.ConvertDataSetToJObject(obj.Return_DataSet("IU_TransportDetail", param));
        }

        public async Task<JsonElement> ScanLogForStaging(ScanLogForStaging req)
        {
            param = new SqlParameter[]
            {


                        new SqlParameter("@CustomerId", req.CustomerId),
                        new SqlParameter("@WarehouseId", req.WarehouseId),
                        new SqlParameter("@UserId", req.UserId),
                        new SqlParameter("@OrderId", req.OrderId),
                        new SqlParameter("@OrderDTId", req.OrderDTId)

            };
            return await obj.ConvertDataSetToJObject(obj.Return_DataSet("Get_TLScanLog", param));
        }

        public async Task<JsonElement> Mob_ScanData(Mob_ScanData req)
        {
            param = new SqlParameter[]
            {
                        new SqlParameter("@companyId", req.companyId),
                        new SqlParameter("@userId", req.userId),
                        new SqlParameter("@whId", req.whId),
                        new SqlParameter("@custId", req.custId),
                        new SqlParameter("@LocationId", req.LocationId),
                        new SqlParameter("@PalletId", req.PalletId),
                        new SqlParameter("@ScanData", req.ScanData),
                        new SqlParameter("@OrderType", req.OrderType)

            };
            return await obj.ConvertDataSetToJObject(obj.Return_DataSet("Get_Comm_scanAPI", param));
        }

        public async Task<JsonElement> ScanHistory(ScanHistory req)
        {
            param = new SqlParameter[]
            {
                        new SqlParameter("@CustomerId", req.CustomerId),
                        new SqlParameter("@WarehouseId", req.WarehouseId),
                        new SqlParameter("@UserId", req.UserId),
                        new SqlParameter("@ContainerId", req.ContainerId),
                        new SqlParameter("@OrderDTId", req.OrderDTId),

            };
            return await obj.ConvertDataSetToJObject(obj.Return_DataSet("Get_TLScanHistory", param));
        }

        public async Task<JsonElement> SaveScanLogRecDT(SaveScanLogRecDT req)
        {
            param = new SqlParameter[]
            {
                        new SqlParameter("@CustomerId", req.CustomerId),
                        new SqlParameter("@WarehouseId", req.WarehouseId),
                        new SqlParameter("@UserId", req.UserId),
                        new SqlParameter("@OrderId", req.OrderId),
                        new SqlParameter("@OrderDTId", req.OrderDTId),
                        new SqlParameter("@StagingId", req.StagingId),
                        new SqlParameter("@PalletId", req.PalletId),
                        new SqlParameter("@PalletType", req.PalletType),
                        new SqlParameter("@PalletTypeId", req.PalletTypeId),
                        new SqlParameter("@Noofcarton", req.Noofcarton),
                        new SqlParameter("@Weight", req.Weight),
                        new SqlParameter("@Height", req.Height),
                        new SqlParameter("@Width", req.Width),
                        new SqlParameter("@Length", req.Length),
                        new SqlParameter("@UOMID", req.UOMID),
                        new SqlParameter("@PalletImg", req.PalletImg),
                        new SqlParameter("@Remark", req.Remark),
                        new SqlParameter("@OrderType", req.OrderType),

            };
            return await obj.ConvertDataSetToJObject(obj.Return_DataSet("IU_scan_logSave", param));
        }

        public async Task<JsonElement> StagingListMobile(StagingListMobile req)
        {
            param = new SqlParameter[]
            {
                        new SqlParameter("@CustomerId", req.CustomerId),
                        new SqlParameter("@WarehouseId", req.WarehouseId),
                        new SqlParameter("@UserId", req.UserId),
                        new SqlParameter("@OrderId", req.OrderId),

            };
            return await obj.ConvertDataSetToJObject(obj.Return_DataSet("Get_StagingListMobile", param));
        }

        public async Task<JsonElement> MobDockIdStatus(MobDockIdStatus req)
        {
            param = new SqlParameter[]
            {
                        new SqlParameter("@WarehouseId", req.WarehouseId),
                        new SqlParameter("@CustomerId", req.CustomerId),
                        new SqlParameter("@CompanyID", req.CompanyID),
                        new SqlParameter("@UserId", req.UserId),
                        new SqlParameter("@TranloadDTId", req.TranloadDTId),
                        new SqlParameter("@DockId", req.DockId),
                        new SqlParameter("@PalletId", req.PalletId),
                        new SqlParameter("@TranloadId", req.TranloadId),

            };
            return await obj.ConvertDataSetToJObject(obj.Return_DataSet("IU_MobileTransloadDispatch", param));
        }
        public async Task<JsonElement> Get_Staging_scanAPI(Get_Staging_scanAPI req)
        {
            param = new SqlParameter[]
            {
                        new SqlParameter("@companyId", req.companyId),
                        new SqlParameter("@userId", req.userId),
                        new SqlParameter("@whId", req.whId),
                        new SqlParameter("@custId", req.custId),
                        new SqlParameter("@LocationId", req.LocationId),
                        new SqlParameter("@PalletId", req.PalletId),
                        new SqlParameter("@OrderId", req.OrderId),
                        new SqlParameter("@OrderDTId", req.OrderDTId),
                        new SqlParameter("@ScanData", req.ScanData),

            };
            return await obj.ConvertDataSetToJObject(obj.Return_DataSet("Get_Staging_scanAPI", param));
        }
    }
}
