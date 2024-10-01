using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using WMSCOREAPI.Model.V1.Request;
using WMSCOREAPI.Models.V1.Responce;
using WMSCOREAPI.Route;
using WMSCOREAPI.Utility.V1;

namespace WMSCOREAPI.Controllers.V1
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransloadController : ControllerBase
    {
        TransloadUtility obj = new TransloadUtility();
        SysException exe = new SysException();

        [HttpPost]
        [Route(APIRoute.Transload.RecevingListMobile)]
        public async Task<ResponceList> RecevingListMobile(RecevingListMobile ReqPara)
        {
            ResponceList Response = new ResponceList();
            try
            {
                if (ReqPara != null)
                {
                    JsonElement result = await obj.RecevingListMobile(ReqPara);

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
        [Route(APIRoute.Transload.TransportList)]
        public async Task<ResponceList> TransportList(TransportList ReqPara)
        {
            ResponceList Response = new ResponceList();
            try
            {
                if (ReqPara != null)
                {
                    JsonElement result = await obj.TransportList(ReqPara);

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
        [Route(APIRoute.Transload.DockList)]
        public async Task<ResponceList> DockList(DockList ReqPara)
        {
            ResponceList Response = new ResponceList();
            try
            {
                if (ReqPara != null)
                {
                    JsonElement result = await obj.DockList(ReqPara);

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
        [Route(APIRoute.Transload.OrderTypeList)]
        public async Task<ResponceList> OrderTypeList(OrderTypeList ReqPara)
        {
            ResponceList Response = new ResponceList();
            try
            {
                if (ReqPara != null)
                {
                    JsonElement result = await obj.OrderTypeList(ReqPara);

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
        [Route(APIRoute.Transload.TransportDetail)]
        public async Task<ResponceList> TransportDetail(TransportDetail ReqPara)
        {
            ResponceList Response = new ResponceList();
            try
            {
                if (ReqPara != null)
                {
                    JsonElement result = await obj.TransportDetail(ReqPara);

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
        [Route(APIRoute.Transload.ScanLogForStaging)]
        public async Task<ResponceList> ScanLogForStaging(ScanLogForStaging ReqPara)
        {
            ResponceList Response = new ResponceList();
            try
            {
                if (ReqPara != null)
                {
                    JsonElement result = await obj.ScanLogForStaging(ReqPara);

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
        [Route(APIRoute.Transload.Mob_ScanData)]
        public async Task<ResponceList> Mob_ScanData(Mob_ScanData ReqPara)
        {
            ResponceList Response = new ResponceList();
            try
            {
                if (ReqPara != null)
                {
                    JsonElement result = await obj.Mob_ScanData(ReqPara);

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
        [Route(APIRoute.Transload.ScanHistory)]
        public async Task<ResponceList> ScanHistory(ScanHistory ReqPara)
        {
            ResponceList Response = new ResponceList();
            try
            {
                if (ReqPara != null)
                {
                    JsonElement result = await obj.ScanHistory(ReqPara);

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
        [Route(APIRoute.Transload.SaveScanLogRecDT)]
        public async Task<ResponceList> SaveScanLogRecDT(SaveScanLogRecDT ReqPara)
        {
            ResponceList Response = new ResponceList();
            try
            {
                if (ReqPara != null)
                {
                    JsonElement result = await obj.SaveScanLogRecDT(ReqPara);

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
        [Route(APIRoute.Transload.StagingListMobile)]
        public async Task<ResponceList> StagingListMobile(StagingListMobile ReqPara)
        {
            ResponceList Response = new ResponceList();
            try
            {
                if (ReqPara != null)
                {
                    JsonElement result = await obj.StagingListMobile(ReqPara);

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
        [Route(APIRoute.Transload.MobDockIdStatus)]
        public async Task<ResponceList> MobDockIdStatus(MobDockIdStatus ReqPara)
        {
            ResponceList Response = new ResponceList();
            try
            {
                if (ReqPara != null) 
                {
                    JsonElement result = await obj.MobDockIdStatus(ReqPara);

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
        [Route(APIRoute.Transload.Get_Staging_scanAPI)]
        public async Task<ResponceList> Get_Staging_scanAPI(Get_Staging_scanAPI ReqPara)
        {
            ResponceList Response = new ResponceList();
            try
            {
                if (ReqPara != null)
                {
                    JsonElement result = await obj.Get_Staging_scanAPI(ReqPara);

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
    }
}
