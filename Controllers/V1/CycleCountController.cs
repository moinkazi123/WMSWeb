using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System.Data;
using System.Text.Json;
using WMSCOREAPI.Model.V1.Request;
using WMSCOREAPI.Models.V1.Responce;
using WMSCOREAPI.Route;
using WMSCOREAPI.Utility.V1;

namespace WMSCOREAPI.Controllers.V1
{
    [Route("api/[controller]")]
    [ApiController]
    public class CycleCountController : ControllerBase
    {
        CycleCountUtility obj = new CycleCountUtility();
        SysException exe = new SysException();

        [HttpPost]
        [Route(APIRoute.CycleCount.PalletCheck)]
        public async Task<ResponceList> PalletCheck(palletCheckrequest ReqPara)

        {
            ResponceList Response = new ResponceList();
            try

            {
                if (ReqPara != null)
                {
                    JsonElement result = await obj.palletCheck(ReqPara);

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
                exe.ErrorLog(ex.Message.ToString(), APIRoute.CycleCount.PalletCheck, Int64.Parse(ReqPara.UserID));
            }
            return Response;
        }
        [HttpPost]
        [Route(APIRoute.CycleCount.lottablelist)]
        public async Task<ResponceList> lottablelist(lottablelistrequest ReqPara)

        {
            ResponceList Response = new ResponceList();
            try

            {
                if (ReqPara != null)
                {
                    JsonElement result = await obj.lottablelist(ReqPara);

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
        [Route(APIRoute.CycleCount.CycleCountPlanlist)]
        public async Task<ResponceList> CycleCountPlanlist(CycleCountPlanlistRequest ReqPara)
        {
            ResponceList Response = new ResponceList();
            try

            {
                if (ReqPara != null)
                {
                    JsonElement result = await obj.CycleCountPlanlist(ReqPara);

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
                exe.ErrorLog(ex.Message.ToString(), APIRoute.CycleCount.CycleCountPlanlist, Convert.ToInt64(ReqPara.UserID));
            }
            return Response;
        }

        [HttpPost]
        [Route(APIRoute.CycleCount.CycleCountPlanDetaillist)]
        public async Task<ResponceList> CycleCountPlanDetaillist(CycleCountPlanSkulist ReqPara)
        {
            ResponceList Response = new ResponceList();
            try

            {
                if (ReqPara != null)
                {
                    JsonElement result = await obj.CycleCountPlanDetail(ReqPara);

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
                exe.ErrorLog(ex.Message.ToString(), APIRoute.CycleCount.CycleCountPlanDetaillist, Convert.ToInt64(ReqPara.UserID));
            }
            return Response;
        }

        //[HttpPost]
        //[Route(APIRoute.CycleCount.CycleCountScanBarcode)]
        //public async Task<ResponceList> CycleCountScanBarcode(CycleCountScanBarcoderequest ReqPara)

        //{
        //    BarcodeScan Response = new BarcodeScan();
        //    string type = "";
        //    string id = "";
        //    string trid = "";
        //    string code = "";
        //    string result = "";
        //    try

        //    {
        //        if (ReqPara != null)
        //        {
        //            DataSet result1 =await obj.CycleCountScanBarcode(ReqPara);

        //            type = result1.Tables[0].Rows[0]["scanType"].ToString();
        //            id = result1.Tables[0].Rows[0]["ID"].ToString();
        //            trid = result1.Tables[0].Rows[0]["ID"].ToString();
        //            code = result1.Tables[0].Rows[0]["Value"].ToString();
        //            result = result1.Tables[0].Rows[0]["Result"].ToString();

        //            if (result == "success")
        //            {

        //                Response = ResponceResult.BarcodeScanSuccess(type, id, code);
        //            }
        //            else
        //            {
        //                Response = ResponceResult.BarcodeScanFailed(type, id, code, result);
        //            }

        //        }
        //        else
        //        {
        //            Response = ResponceResult.BarcodeScanFailed(type, id, code, "Scan Fail!");
        //        }
        //    }
        //    catch (System.Exception ex)
        //    {
        //        Response = ResponceResult.BarcodeScanFailed(type, id, code, ex.Message.ToString());
        //        exe.ErrorLog(ex.Message.ToString(), APIRoute.CycleCount.CycleCountScanBarcode, Int64.Parse(ReqPara.UserID));
        //    }
        //    return Response;
        //}

        [HttpPost]
        [Route(APIRoute.CycleCount.CycleCountUpDateQty)]
        public async Task<ResponceList> CycleCountUpdateQty(CycleCountUpdateqnt ReqPara)
        {
            ResponceList Response = new ResponceList();
            try
            {
                if (ReqPara != null)
                {

                    // bool Pallet = obj.PallatOrNot(Convert.ToInt64(ReqPara.compid), Convert.ToInt64(ReqPara.custid));

                    JsonElement result;
                    //if (Pallet) result = obj.CycleCountUpdateQty(ReqPara);
                    //else result = obj.WithOutPallCycleCountUpdateQty(ReqPara);
                    result = await obj.CycleCountUpdateQty(ReqPara);
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
                exe.ErrorLog(ex.Message.ToString(), APIRoute.CycleCount.CycleCountUpDateQty, Convert.ToInt64(ReqPara.uid));
            }
            return Response;
        }

        [HttpPost]
        [Route(APIRoute.CycleCount.CycleCountCheckUpDateQty)]
        public async Task<ResponceList> CycleCountUpdateQntCheck(UpdateQntCheck ReqPara)
        {
            ResponceList Response = new ResponceList();
            try
            {
                if (ReqPara != null)
                {
                    JsonElement result = await obj.UpdateQntCheck(ReqPara);
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
                exe.ErrorLog(ex.Message.ToString(), APIRoute.CycleCount.CycleCountCheckUpDateQty, Convert.ToInt64(ReqPara.uid));
            }
            return Response;
        }

        [HttpPost]
        [Route(APIRoute.CycleCount.CycleCountUpdateplan)]
        public async Task<ResponceList> Updateplan(Updateplanrequest ReqPara)

        {
            ResponceList Response = new ResponceList();
            try

            {
                if (ReqPara != null)
                {
                    JsonElement result = await obj.Updateplan(ReqPara);

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
                exe.ErrorLog(ex.Message.ToString(), APIRoute.CycleCount.CycleCountUpdateplan, Int64.Parse(ReqPara.UserID));
            }
            return Response;
        }

        [HttpPost]
        [Route(APIRoute.CycleCount.SearchLottList)]
        public async Task<ResponceList> SearchLottList(SearchLottList ReqPara)

        {
            ResponceList Response = new ResponceList();
            try

            {
                if (ReqPara != null)
                {
                    JsonElement result = await obj.SearchLottList(ReqPara);

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
