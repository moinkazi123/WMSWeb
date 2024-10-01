using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System.Text.Json;
using WMSCOREAPI.Model.V1.Request;
using WMSCOREAPI.Models.V1.Responce;
using WMSCOREAPI.Route;
using WMSCOREAPI.Utility.V1;

namespace WMSCOREAPI.Controllers.V1
{
    [Route("api/[controller]")]
    [ApiController]
    public class MobileProdIssueController : ControllerBase
    {
        MobileProdIssueUtility obj = new MobileProdIssueUtility();
        SysException exe = new SysException();

        [HttpPost]
        [Route(APIRoute.MobileProdIssue.GetMobileProdIssuelist)]
        public async Task<ResponceList> GetMobileProdIssuelist(GetMobileProdIssuelistRequest ReqPara)
        {
            ResponceList Response = new ResponceList();
            try
            {
                if (ReqPara != null)
                {
                    JsonElement result = await obj.MobileProdIssuelist(ReqPara);

                    Response = ResponceResult.SuccessResponseList(result);
                }
                else
                {
                    Response = ResponceResult.ErrorResponseList("No record found..!");
                }
            }
            catch (Exception ex)
            {
                Response = ResponceResult.ErrorResponseList(ex.Message.ToString());
                exe.ErrorLog(ex.Message.ToString(), APIRoute.MobileProdIssue.GetMobileProdIssuelist, 0);
            }
            return Response;
        }

        [HttpPost]
        [Route(APIRoute.MobileProdIssue.GetMobProdIssuelottablelist)]
        public async Task<ResponceList> GetMobProdIssuelottablelist(GetMobProdIssuelottablelistRequest ReqPara)
        {
            ResponceList Response = new ResponceList();
            try
            {
                if (ReqPara != null)
                {
                    JsonElement result = await obj.MobProdIssuelottablelist(ReqPara);

                    Response = ResponceResult.SuccessResponseList(result);
                }
                else
                {
                    Response = ResponceResult.ErrorResponseList("No record found..!");
                }
            }
            catch (Exception ex)
            {
                Response = ResponceResult.ErrorResponseList(ex.Message.ToString());
                exe.ErrorLog(ex.Message.ToString(), APIRoute.MobileProdIssue.GetMobileProdIssuelist, 0);
            }
            return Response;
        }

        [HttpPost]
        [Route(APIRoute.MobileProdIssue.MobilePrdIssueSave)]
        public Responce MobilePrdIssueSave(MobilePrdIssueSaveRequest ReqPara)
        {
            Responce Response = new Responce();
            try
            {
                if (ReqPara != null)
                {
                    string result = obj.MobilePrdIssueSave(ReqPara);
                    if (result == "success")
                    {
                        Response = ResponceResult.SuccessResponse(result);
                    }
                    else
                    {
                        Response = ResponceResult.ValidateResponse(result);
                    }
                }
                else
                {
                    Response = ResponceResult.ErrorResponse("Record Not Save..!");
                }
            }
            catch (Exception ex)
            {
                Response = ResponceResult.ErrorResponse(ex.Message.ToString());
                exe.ErrorLog(ex.Message.ToString(), APIRoute.MobileProdIssue.MobilePrdIssueSave, 0);
            }
            return Response;
        }

        [HttpPost]
        [Route(APIRoute.MobileProdIssue.MobilePrdIssueScanBarcode)]
        public async Task<ResponceList> MobilePrdIssueScanBarcode(MobilePrdIssueScanBarcodeRequest ReqPara)
        {
            ResponceList Response = new ResponceList();
            try
            {
                if (ReqPara != null)
                {
                    JsonElement result =await obj.MobilePrdIssueScanBarcode(ReqPara);

                    Response = ResponceResult.SuccessResponseList(result);
                }
                else
                {
                    Response = ResponceResult.ErrorResponseList("No record found..!");
                }
            }
            catch (Exception ex)
            {
                Response = ResponceResult.ErrorResponseList(ex.Message.ToString());
                exe.ErrorLog(ex.Message.ToString(), APIRoute.MobileProdIssue.MobilePrdIssueScanBarcode, 0);
            }
            return Response;
        }
    }
}
