using Newtonsoft.Json.Linq;
using System.Data.SqlClient;
using System.Text.Json;
using static WMSCOREAPI.Model.V1.Request.Dispatch;

namespace WMSCOREAPI.Utility.V1
{
    public class DispatchUtility
    {
        SqlParameter[] param;
        DBActivity obj;
        public DispatchUtility()
        {
            obj = new DBActivity();
        }
        public async Task<JsonElement> GetDispatchList(GetDispatchListRequest req)
        {
            param = new SqlParameter[]
                    {
                        new SqlParameter("@uid", req.uid),
                        new SqlParameter("@wrid", req.WrId),
                        new SqlParameter("@custid", req.Custid),
                        new SqlParameter("@skey", req.skey)
                    };
            return await obj.ConvertDataSetToJObject(obj.Return_DataSet("sp_Mob_DispatchListV2", param));
        }
        public async Task<JsonElement> GetDispatchVwOrder(GetDispatchOrderViewRequest req)
        {
            param = new SqlParameter[]
                    {
                        new SqlParameter("@DispatchId", req.DispatchId)

                    };
            return await obj.ConvertDataSetToJObject(obj.Return_DataSet("sp_Mob_DispatchOrderViewV2", param));
        }
        public async Task<JsonElement> GetDispatchDetails(GetDispatchDetailRequest req)
        {
            param = new SqlParameter[]
                    {
                        new SqlParameter("@bid", req.BatchId),
                        new SqlParameter("@packingid", req.PackingNo),
                        new SqlParameter("@soid", req.SOID),
                        new SqlParameter("@uid", req.UserId),
                        new SqlParameter("@custid", req.CustomerId),
                        new SqlParameter("@wrid", req.WarehouseId),
                         new SqlParameter("@Tab", req.tab)
                    };
            return await obj.ConvertDataSetToJObject(obj.Return_DataSet("PackingSODetail", param));
        }
        public async Task<JsonElement> CarrierDetail(CarrierListRequest req)
        {
            param = new SqlParameter[]
                    {
                        new SqlParameter("@uid", Convert.ToInt64(req.UserId)),
                        new SqlParameter("@custid", Convert.ToInt64(req.CustomerId)),
                        new SqlParameter("@wrid", Convert.ToInt64(req.WarehouseId)),
                        new SqlParameter("@OrderID", Convert.ToInt64(req.OrderID))
                    };
            return await obj.ConvertDataSetToJObject(obj.Return_DataSet("SP_Mob_DispatchTransport", param));
        }
        public string SaveDispatchBySO(SaveDispatchBySORequest req)
        {
            string result = "";
            param = new SqlParameter[]
                    {
                        new SqlParameter("@bid", Convert.ToInt64(req.BatchID)),
                        new SqlParameter("@soid", Convert.ToInt64(req.SOID)),
                        new SqlParameter("@uid", Convert.ToInt64(req.UserId)),
                        new SqlParameter("@custid", Convert.ToInt64(req.CustomerId)),
                        new SqlParameter("@wrid", Convert.ToInt64(req.WarehouseId)),
                        new SqlParameter("@carierid", Convert.ToInt64(req.CarrierID)),
                        new SqlParameter("@trno", req.TrackingNO),
                        new SqlParameter("@driver", req.DriverName),
                        new SqlParameter("@pickby", req.PickUpBy),
                        new SqlParameter("@schdatetime", req.ScheduleDateTime),
                        new SqlParameter("@actdatetime", req.ActualDateTime),
                        new SqlParameter("@lrno", req.LRNo),
                        new SqlParameter("@vehicleno", req.VehicleNo),
                        new SqlParameter("@transremark", req.TransportRemark),
                        new SqlParameter("@bol", req.BOL),
                        new SqlParameter("@transname", req.TransportName),
                        new SqlParameter("@Disid", req.DispatchHeadId),
                         new SqlParameter("@DocImage", req.DocImage),
                        new SqlParameter("@DocSignature", req.DocSignature)
                    };

            result = obj.Return_ScalerValue("sp_Mob_SaveDispatchBySO", param);
            return result;
        }

        public string UpdateQty(UpdateQtyRequest req)
        {
            param = new SqlParameter[]
                    {
                        new SqlParameter("@did", req.DispatchId),
                        new SqlParameter("@soid", req.Soid),
                        new SqlParameter("@prodid", req.ProdId),
                        new SqlParameter("@cartonid", req.CartonId),
                        new SqlParameter("@lot", req.Lottables),
                        new SqlParameter("@dispqty", req.DispatchQty),
                        new SqlParameter("@qty", req.Qty),
                        new SqlParameter("@uid", req.UserId)
                    };
            return obj.Return_ScalerValue("UpdateDispQty", param);

        }

        public async Task<JsonElement> GetDispatchmobScan(GetDispatchmobScan req)
        {
            param = new SqlParameter[]
                    {
                        new SqlParameter("@bid", req.BatchId),
                        new SqlParameter("@packingid", req.PackingNo),
                        new SqlParameter("@soid", req.SOID),
                        new SqlParameter("@uid", req.UserId),
                        new SqlParameter("@custid", req.CustomerId),
                        new SqlParameter("@wrid", req.WarehouseId),
                        new SqlParameter("@Barcode", req.Barcode)
                    };
            return await obj.ConvertDataSetToJObject(obj.Return_DataSet("MobScanBarcodeDispatch", param));
        }

        public async Task<JsonElement> Dispatchmobvalidate(Dispatchmobvalidate req)
        {
            param = new SqlParameter[]
                    {
                        new SqlParameter("@bid", req.BatchId),
                        new SqlParameter("@packingid", req.PackingNo),
                        new SqlParameter("@soid", req.SOID),
                        new SqlParameter("@uid", req.UserId),
                        new SqlParameter("@custid", req.CustomerId),
                        new SqlParameter("@wrid", req.WarehouseId),

                    };
            return await obj.ConvertDataSetToJObject(obj.Return_DataSet("Mobdisvalidated", param));
        }


        public async Task<JsonElement> GetDispatchmobSkuScan(GetDispatchmobSkuScan req)
        {
            param = new SqlParameter[]
                    {
                        new SqlParameter("@bid", req.BatchId),
                        new SqlParameter("@packingid", req.PackingNo),
                        new SqlParameter("@soid", req.SOID),
                        new SqlParameter("@uid", req.UserId),
                        new SqlParameter("@custid", req.CustomerId),
                        new SqlParameter("@wrid", req.WarehouseId),
                        new SqlParameter("@Barcode", req.Barcode)
                    };
            return await obj.ConvertDataSetToJObject(obj.Return_DataSet("MobScanSKUBarcodeDispatch", param));
        }

        public async Task<JsonElement> GetDispatchmobSkuSave(GetDispatchmobSkuSave req)
        {
            param = new SqlParameter[]
                    {
                        new SqlParameter("@bid", req.BatchId),
                        new SqlParameter("@packingid", req.PackingNo),
                        new SqlParameter("@soid", req.SOID),
                        new SqlParameter("@uid", req.UserId),
                        new SqlParameter("@custid", req.CustomerId),
                        new SqlParameter("@wrid", req.WarehouseId),
                        new SqlParameter("@Skuid", req.Skuid),
                        new SqlParameter("@Lott", req.Lott)

                    };
            return await obj.ConvertDataSetToJObject(obj.Return_DataSet("MobSaveSKUDispatch", param));
        }

    }
}
