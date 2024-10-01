using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Data;
using WMSCOREAPI.Utility.V1;
using static WMSCOREAPI.Model.V1.Request.RfidTagging;

namespace WMSCOREAPI.Controllers.V1
{
    [Route("api/[controller]")]
    [ApiController]
    public class RfidTaggingController : ControllerBase
    {
        [HttpPost]
        //[Route("api/rfid/GetRfidTagging")]
        [Route("GetRfidTagging")]
        public GetRfidTaggingResponse GetRfidTagging(GetRfidTaggingRequest req)
        {
            DataSet ds = new DataSet();
            DataSet dslist = new DataSet();

            long CurrentPage = req.CurrentPage;
            long RecordLimit = req.RecordLimit;
            long CustomerId = req.CustomerId;
            long WarehouseId = req.WarehouseId;
            long UserId = req.UserId;
            String SearchKey = req.SearchKey;
            String ListType = req.ListType;
            String activetab = req.ActiveTab;

            long dsTotalRecord = 0, dsUnassigned = 0, dsAssigned = 0;

            GetRfidTaggingResponse rfidTaggingRes = new GetRfidTaggingResponse();
            try
            {

                String jsonString = "";
                ds = RfidTaggingUtility.GetRfidDashboard(CurrentPage, RecordLimit, CustomerId, WarehouseId, UserId, SearchKey, ListType, activetab);
                dsTotalRecord = Convert.ToInt32(ds.Tables[0].Rows[0]["TotalRecords"]);
                dsUnassigned = Convert.ToInt32(ds.Tables[0].Rows[0]["TotalUnassigned"]);
                dsAssigned = Convert.ToInt32(ds.Tables[0].Rows[0]["TotalAssigned"]);

                jsonString = "{\"RfidList\":[{";
                jsonString = jsonString + "\"CurrentPage\":\"" + CurrentPage + "\",";
                jsonString = jsonString + "\"TotalRecords\":\"" + dsTotalRecord + "\",";
                jsonString = jsonString + "\"Unassigned\":\"" + dsUnassigned + "\",";
                jsonString = jsonString + "\"Assigned\":\"" + dsAssigned + "\",";

                dslist = RfidTaggingUtility.GetRfidList(CurrentPage, RecordLimit, CustomerId, WarehouseId, UserId, SearchKey, ListType, activetab);
                jsonString = jsonString + JsonConvert.SerializeObject(dslist).TrimStart('{').TrimEnd('}');

                jsonString = jsonString + "}]}";
                rfidTaggingRes.Status = "Success";
                rfidTaggingRes.StatusCode = "200";
                rfidTaggingRes.Result = jsonString;
            }
            catch (Exception ex)
            {
                rfidTaggingRes.Status = "failed";
                rfidTaggingRes.StatusCode = "400";
                rfidTaggingRes.Result = "Server Error";
                throw ex;
            }
            return rfidTaggingRes;
        }

        // GET: UpdateRfid
        [HttpPost]
        [Route("api/rfid/UpdateRfid")]
        
        public UpdateRfidResponse UpdateRfid(UpdateRfidRequest req)
        {
            DataSet ds = new DataSet();
            DataSet dslist = new DataSet();
            UpdateRfidResponse rfidUpdateRes = new UpdateRfidResponse();
            try
            {

                String jsonString = "";
                string getRfidCode = req.RfidLabel;
                if (getRfidCode == "-")
                {
                    getRfidCode = "";
                }
                ds = RfidTaggingUtility.UpdateRfid(getRfidCode, req.RecordId, req.Code, req.CodeId);

                rfidUpdateRes.Status = "Success";
                rfidUpdateRes.StatusCode = "200";
                rfidUpdateRes.Result = "Record Updated";
            }
            catch (Exception ex)
            {
                rfidUpdateRes.Status = "failed";
                rfidUpdateRes.StatusCode = "400";
                rfidUpdateRes.Result = "Server Error";
                throw ex;
            }
            return rfidUpdateRes;
        }

        // GET: MultipleRfidUnassign
        [HttpPost]
        [Route("api/rfid/MultipleRfidUnassign")]
       
        public MultipleRfidUnassignResponse MultipleRfidUnassign(MultipleRfidUnassignRequest req)
        {
            DataSet ds = new DataSet();
            DataSet dslist = new DataSet();
            MultipleRfidUnassignResponse multipleRfidUnassignRes = new MultipleRfidUnassignResponse();
            try
            {

                string getRfidCode = req.RecordId;
                if (getRfidCode == "-")
                {
                    getRfidCode = "";
                }
                ds = RfidTaggingUtility.UnassignMultipleRfid(req.RecordId);

                multipleRfidUnassignRes.Status = "Success";
                multipleRfidUnassignRes.StatusCode = "200";
                multipleRfidUnassignRes.Result = "Record Updated";
            }
            catch (Exception ex)
            {
                multipleRfidUnassignRes.Status = "failed";
                multipleRfidUnassignRes.StatusCode = "400";
                multipleRfidUnassignRes.Result = "Server Error";
                throw ex;
            }
            return multipleRfidUnassignRes;
        }

        // GET: InsertRfid
        [HttpPost]
        [Route("api/rfid/InsertRfid")]
       
        public InsertRfidResponse InsertRfid(InsertRfidRequest req)
        {
            DataSet ds = new DataSet();
            DataSet dslist = new DataSet();
            InsertRfidResponse rfidInsertRes = new InsertRfidResponse();
            try
            {

                String jsonString = "";
                ds = RfidTaggingUtility.InsertRfid(req.RfidLabel, req.RfidType, req.Code, req.CodeId, req.Description, req.UserId);

                rfidInsertRes.Status = "Success";
                rfidInsertRes.StatusCode = "200";
                rfidInsertRes.Result = "Record Added";
            }
            catch (Exception ex)
            {
                rfidInsertRes.Status = "failed";
                rfidInsertRes.StatusCode = "400";
                rfidInsertRes.Result = "Server Error";
                throw ex;
            }
            return rfidInsertRes;
        }
    }
}
