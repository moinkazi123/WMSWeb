using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System.Text.Json;
using WMSCOREAPI.Models.V1.Responce;
using WMSCOREAPI.Route;
using WMSCOREAPI.Utility.V1;
using static WMSCOREAPI.Model.V1.Request.TimeTracker;

namespace WMSCOREAPI.Controllers.V1
{
    [Route("api/[controller]")]
    [ApiController]
    public class TimeTrackerController : ControllerBase
    {
        TimeTrackerUtility obj = new TimeTrackerUtility();
        SysException exe = new SysException();

        [HttpPost]
        [Route(APIRoute.TimeTracker.BarcodeScanLabour)]
        public async Task<ResponceList> BarcodeScanLabour(BarcodeScanLabour ReqPara)
        {
            ResponceList Response = new ResponceList();
            try
            {
                if (ReqPara != null)
                {
                    JsonElement result = await obj.BarcodeScanLabour(ReqPara);
                    Response = ResponceResult.SuccessResponseList(result);
                }
                else
                {
                    Response = ResponceResult.ErrorResponseList("No record found..!");
                }
            }
            catch (System.Exception ex)
            {
                Response = ResponceResult.ErrorResponseList(ex.Message.ToString());
                exe.ErrorLog(ex.Message.ToString(), APIRoute.TimeTracker.BarcodeScanLabour, 0);
            }
            return Response;
        }

        [HttpPost]
        [Route(APIRoute.TimeTracker.LabourHistory)]
        public async Task<ResponceList> LabourHistory(LabourHistory ReqPara)
        {
            ResponceList Response = new ResponceList();
            try
            {
                if (ReqPara != null)
                {
                    JsonElement result = await obj.LabourHistory(ReqPara);
                    Response = ResponceResult.SuccessResponseList(result);
                }
                else
                {
                    Response = ResponceResult.ErrorResponseList("No record found..!");
                }
            }
            catch (System.Exception ex)
            {
                Response = ResponceResult.ErrorResponseList(ex.Message.ToString());
                exe.ErrorLog(ex.Message.ToString(), APIRoute.TimeTracker.LabourHistory, 0);
            }
            return Response;
        }

        [HttpPost]
        [Route(APIRoute.TimeTracker.SaveLabour)]
        public async Task<ResponceList> SaveLabour(SaveLabour ReqPara)
        {
            ResponceList Response = new ResponceList();
            try
            {
                if (ReqPara != null)
                {
                    JsonElement result = await obj.SaveLabour(ReqPara);
                    Response = ResponceResult.SuccessResponseList(result);
                }
                else
                {
                    Response = ResponceResult.ErrorResponseList("No record found..!");
                }
            }
            catch (System.Exception ex)
            {
                Response = ResponceResult.ErrorResponseList(ex.Message.ToString());
                exe.ErrorLog(ex.Message.ToString(), APIRoute.TimeTracker.SaveLabour, 0);
            }
            return Response;
        }

        [HttpPost]
        [Route(APIRoute.TimeTracker.ScanLogLabour)]
        public async Task<ResponceList> ScanLogLabour(ScanLogLabour ReqPara)
        {
            ResponceList Response = new ResponceList();
            try
            {
                if (ReqPara != null)
                {
                    JsonElement result = await obj.ScanLogLabour(ReqPara);
                    Response = ResponceResult.SuccessResponseList(result);
                }
                else
                {
                    Response = ResponceResult.ErrorResponseList("No record found..!");
                }
            }
            catch (System.Exception ex)
            {
                Response = ResponceResult.ErrorResponseList(ex.Message.ToString());
                exe.ErrorLog(ex.Message.ToString(), APIRoute.TimeTracker.ScanLogLabour, 0);
            }
            return Response;
        }

        [HttpPost]
        [Route(APIRoute.TimeTracker.FinalSaveLabour)]
        public async Task<ResponceList> FinalSaveLabour(FinalSaveLabour ReqPara)
        {
            ResponceList Response = new ResponceList();
            try
            {
                if (ReqPara != null)
                {
                    JsonElement result = await obj.FinalSaveLabour(ReqPara);
                    Response = ResponceResult.SuccessResponseList(result);
                }
                else
                {
                    Response = ResponceResult.ErrorResponseList("No record found..!");
                }
            }
            catch (System.Exception ex)
            {
                Response = ResponceResult.ErrorResponseList(ex.Message.ToString());
                exe.ErrorLog(ex.Message.ToString(), APIRoute.TimeTracker.FinalSaveLabour, 0);
            }
            return Response;
        }

    }
}
