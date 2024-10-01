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
    public class SearchController : ControllerBase
    {
        SearchUtility obj = new SearchUtility();
        SysException exe = new SysException();

        [HttpPost]
        [Route(APIRoute.Search.GetSearchDropDownValues)]
        public async Task<ResponceList> DropDownOption(GetSearchDropDownValues ReqPara)
        {
            ResponceList Response = new ResponceList();
            try
            {
                if (ReqPara != null)
                {
                    JsonElement result = await obj.GetSearchDropDownValues(ReqPara);

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
            }
            return Response;
        }


        [HttpPost]
        [Route(APIRoute.Search.GetSearchBarcodeScan)]
        public async Task<ResponceList> GetSearchBarcodeScan(GetSearchBarcodeScan ReqPara)
        {
            ResponceList Response = new ResponceList();
            try
            {
                if (ReqPara != null)
                {
                    JsonElement result = await obj.GetSearchBarcodeScan(ReqPara);

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

            }
            return Response;
        }

        [HttpPost]
        [Route(APIRoute.Search.GetSearchScanLog)]
        public async Task<ResponceList> GetSearchScanLog(GetSearchScanLog ReqPara)
        {
            ResponceList Response = new ResponceList();
            try
            {
                if (ReqPara != null)
                {
                    JsonElement result = await obj.GetSearchScanLog(ReqPara);

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
            }
            return Response;
        }
    }
}
