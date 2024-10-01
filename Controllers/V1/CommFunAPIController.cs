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
    public class CommFunAPIController : ControllerBase
    {
        CommFunAPIUtility obj = new CommFunAPIUtility();
        SysException exe = new SysException();
        // GET api/<controller>

        [HttpPost]
        [Route(APIRoute.CommFunAPI.loginprocess)]
        public async Task<ResponceList> getLoginlist(Login ReqPara)
        {
            ResponceList Response = new ResponceList();
            try
            {
                if (ReqPara != null)
                {
                    JsonElement result = await obj.LoginList(ReqPara);

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
                exe.ErrorLog(ex.Message.ToString(), APIRoute.CommFunAPI.loginprocess, Int64.Parse(ReqPara.Username));
            }
            return Response;
        }

        [HttpPost]
        [Route(APIRoute.CommFunAPI.ScanMobileBarcode)]
        public async Task<ResponceList> ScanMobileBarcode(scanmobilerequest ReqPara)
        {
            ResponceList Response = new ResponceList();
            try
            {
                if (ReqPara != null)
                {
                    JsonElement result = await obj.ScaninboundMobile(ReqPara);

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
                exe.ErrorLog(ex.Message.ToString(), APIRoute.CommFunAPI.ScanMobileBarcode, 0);
            }
            return Response;
        }

        [HttpPost]
        [Route(APIRoute.CommFunAPI.ScanMobileSerialBarcode)]
        public async Task<ResponceList> ScanMobileSerialBarcode(ScanMobileSerialBarcode ReqPara)
        {
            ResponceList Response = new ResponceList();
            try
            {
                if (ReqPara != null)
                {
                    JsonElement result = await obj.ScanMobileSerialBarcode(ReqPara);

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
                exe.ErrorLog(ex.Message.ToString(), APIRoute.CommFunAPI.ScanMobileSerialBarcode, 0);
            }
            return Response;
        }
    }
}
