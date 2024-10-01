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
    public class ReplishmentmobController : ControllerBase
    {
        ReplishmentmobUtility obj = new ReplishmentmobUtility();
        SysException exe = new SysException();

        [HttpPost]
        [Route(APIRoute.Replishment.GetRepListDetails)]
        public async Task<ResponceList> GetRepListDetails(GetRepListDetails ReqPara)
        {
            ResponceList Response = new ResponceList();
            try
            {
                if (ReqPara != null)
                {
                    JsonElement result = await obj.GetRepListDetails(ReqPara);
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
                exe.ErrorLog(ex.Message.ToString(), APIRoute.Replishment.GetRepListDetails, Int64.Parse(ReqPara.userid));
            }
            return Response;
        }
        [HttpPost]
        [Route(APIRoute.Replishment.GetRepscanlog)]
        public async Task<ResponceList> GetRepscanlog(GetRepscanlog ReqPara)
        {
            ResponceList Response = new ResponceList();
            try
            {
                if (ReqPara != null)
                {
                    JsonElement result = await obj.GetRepscanlog(ReqPara);
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
                exe.ErrorLog(ex.Message.ToString(), APIRoute.Replishment.GetRepscanlog, Int64.Parse(ReqPara.userid));
            }
            return Response;
        }

        [HttpPost]
        [Route(APIRoute.Replishment.GetRepscan)]
        public async Task<ResponceList> GetRepscan(GetRepscan ReqPara)
        {
            ResponceList Response = new ResponceList();
            try
            {
                if (ReqPara != null)
                {
                    JsonElement result = await obj.GetRepscan(ReqPara);
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
                exe.ErrorLog(ex.Message.ToString(), APIRoute.Replishment.GetRepscan, Int64.Parse(ReqPara.userid));
            }
            return Response;
        }

        [HttpPost]
        [Route(APIRoute.Replishment.SaveRepSku)]
        public async Task<ResponceList> SaveRepSku(SaveRepSku ReqPara)
        {
            ResponceList Response = new ResponceList();
            try
            {
                if (ReqPara != null)
                {
                    JsonElement result = await obj.SaveRepSku(ReqPara);
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
                exe.ErrorLog(ex.Message.ToString(), APIRoute.Replishment.SaveRepSku, Int64.Parse(ReqPara.UserID));
            }
            return Response;
        }

        [HttpPost]
        [Route(APIRoute.Replishment.UpdateStatusRep)]
        public async Task<ResponceList> UpdateStatusRep(UpdateStatusRep ReqPara)
        {
            ResponceList Response = new ResponceList();
            try
            {
                if (ReqPara != null)
                {
                    JsonElement result = await obj.UpdateStatusRep(ReqPara);
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
                exe.ErrorLog(ex.Message.ToString(), APIRoute.Replishment.UpdateStatusRep, Int64.Parse(ReqPara.UserID));
            }
            return Response;
        }
    }
}
