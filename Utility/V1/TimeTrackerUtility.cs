using Newtonsoft.Json.Linq;
using System.Data.SqlClient;
using System.Text.Json;
using static WMSCOREAPI.Model.V1.Request.TimeTracker;

namespace WMSCOREAPI.Utility.V1
{
    public class TimeTrackerUtility
    {
        SqlParameter[] param;
        DBActivity obj;
        public TimeTrackerUtility()
        {
            obj = new DBActivity();
        }

        public async Task<JsonElement> BarcodeScanLabour(BarcodeScanLabour req)
        {
            param = new SqlParameter[]
                    {
                        new SqlParameter("@Barcode", req.Barcode),
                        new SqlParameter("@zoneID", req.zoneID),
                        new SqlParameter("@actid", req.actid),
                        new SqlParameter("@compid", req.compid),
                        new SqlParameter("@custid", req.custid),
                        new SqlParameter("@userid", req.userid),
                        new SqlParameter("@orderGroupName", req.orderGroupName),
                        new SqlParameter("@orderid", req.orderid)
                    };
            return await obj.ConvertDataSetToJObject(obj.Return_DataSet("BarcodeScanLabour", param));
        }

        public async Task<JsonElement> LabourHistory(LabourHistory req)
        {
            param = new SqlParameter[]
                    {
                        new SqlParameter("@uid", req.uid),
                        new SqlParameter("@wrid", req.wrid),
                        new SqlParameter("@custid", req.custid),

                    };
            return await obj.ConvertDataSetToJObject(obj.Return_DataSet("SP_GetLobourList", param));
        }

        public async Task<JsonElement> SaveLabour(SaveLabour req)
        {
            param = new SqlParameter[]
                    {
                        new SqlParameter("@labourId", req.labourId),
                        new SqlParameter("@zoneId", req.zoneId),
                        new SqlParameter("@orderGroupName", req.orderGroupName),
                        new SqlParameter("@popupflag", req.popupflag),
                        new SqlParameter("@warehouseId", req.warehouseId),
                        new SqlParameter("@createdby", req.createdby),
                        new SqlParameter("@activityId", req.activityId),
                        new SqlParameter("@compid", req.compid),
                        new SqlParameter("@custid", req.custid),

                    };
            return await obj.ConvertDataSetToJObject(obj.Return_DataSet("sp_insertTimeTracker", param));
        }
        public async Task<JsonElement> ScanLogLabour(ScanLogLabour req)
        {
            param = new SqlParameter[]
                    {
                        new SqlParameter("@order", req.order),
                        new SqlParameter("@zoneID", req.zoneID),
                        new SqlParameter("@userid", req.userid),
                         new SqlParameter("@custid", req.custid)

                    };
            return await obj.ConvertDataSetToJObject(obj.Return_DataSet("sp_Mob_Lobourscanlog", param));
        }
        public async Task<JsonElement> FinalSaveLabour(FinalSaveLabour req)
        {
            param = new SqlParameter[]
                    {
                        new SqlParameter("@zoneID", req.zoneID),
                        new SqlParameter("@activityid", req.activityid),
                        new SqlParameter("@orderno", req.orderno),
                         new SqlParameter("@custid", req.custid),

                    };
            return await obj.ConvertDataSetToJObject(obj.Return_DataSet("SP_Mob_CloseOrder", param));
        }
    }
}
