using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System.Data;
using System.Text.Json;
using WMSCOREAPI.Models.V1.Request;
using WMSCOREAPI.Models.V1.Responce;
using WMSCOREAPI.Route;
using WMSCOREAPI.Utility.V1;
using static WMSCOREAPI.Model.V1.Request.Packing;

namespace WMSCOREAPI.Controllers.V1
{
    [Route("api/[controller]")]
    [ApiController]
    public class PackingController : ControllerBase
    {
        SysException exe = new SysException();
        PackingUtility obj = new PackingUtility();

        [HttpPost]
        [Route(APIRoute.Packing.GetPackingList)]
        public async Task<ResponceList> GetPackingList(GetPackingListRequest ReqPara)
        {
            ResponceList Response = new ResponceList();
            try
            {
                if (ReqPara != null)
                {
                    JsonElement result = await obj.GetPackingList(ReqPara);

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
                exe.ErrorLog(ex.Message.ToString(), APIRoute.Packing.GetPackingList, ReqPara.uid);
            }
            return Response;
        }

        [HttpPost]
        [Route(APIRoute.Packing.GetPackingSOList)]
        public async Task<ResponceList> GetPackingSOList(GetPackingSOListRequest ReqPara)
        {
            ResponceList Response = new ResponceList();
            try
            {
                if (ReqPara != null)
                {
                    JsonElement result = await obj.GetPackingSOList(ReqPara);

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
                exe.ErrorLog(ex.Message.ToString(), APIRoute.Packing.GetPackingSOList, 0);
            }
            return Response;
        }

        [HttpPost]
        [Route(APIRoute.Packing.GetPackingSKUList)]
        public async Task<ResponceList> GetPackingSKUList(GetSOSKUListRequest ReqPara)
        {
            ResponceList Response = new ResponceList();
            try
            {
                if (ReqPara != null)
                {
                    JsonElement result = await obj.GetSOSKUList(ReqPara);

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
                exe.ErrorLog(ex.Message.ToString(), APIRoute.Packing.GetPackingSKUList, ReqPara.UserId);
            }
            return Response;
        }

        [HttpPost]
        [Route(APIRoute.Packing.GetPackingSKULog)]
        public async Task<ResponceList> GetPackingSKULog(GetSOSKULogRequest ReqPara)
        {
            ResponceList Response = new ResponceList();
            try
            {
                if (ReqPara != null)
                {
                    JsonElement result = await obj.GetSOSKULog(ReqPara);

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
                exe.ErrorLog(ex.Message.ToString(), APIRoute.Packing.GetPackingSKULog, ReqPara.UserId);
            }
            return Response;
        }

        [HttpPost]
        [Route(APIRoute.Packing.GetPackingScan)]
        public async Task<BarcodeScan> ScanBarcode(PackingBarcodeScanRequest ReqPara)
        {
            BarcodeScan Response = new BarcodeScan();
            string type = "", id = "", code = "", result = "", dimension = "";
            try
            {
                if (ReqPara != null)
                {
                    DataSet ds = obj.ScanBarcode(ReqPara);
                    type = ds.Tables[0].Rows[0]["scanType"].ToString();
                    id = ds.Tables[0].Rows[0]["ID"].ToString();
                    code = ds.Tables[0].Rows[0]["Value"].ToString();
                    result = ds.Tables[0].Rows[0]["Result"].ToString();
                    dimension = ds.Tables[0].Rows[0]["Dimension"].ToString();
                    if (result == "success")
                    {
                        Response = ResponceResult.BarcodeScanPacking(type, id, code, dimension);
                    }
                    else
                    {
                        Response = ResponceResult.BarcodeScanFailed(type, id, code, result);
                    }
                }
                else
                {
                    Response = ResponceResult.BarcodeScanFailed(type, id, code, "Scan Fail!");
                }
            }
            catch (System.Exception ex)
            {
                Response = ResponceResult.BarcodeScanFailed(type, id, code, ex.Message.ToString());
                exe.ErrorLog(ex.Message.ToString(), APIRoute.Packing.GetPackingScan, ReqPara.UserId);
            }
            return Response;
        }

        [HttpPost]
        [Route(APIRoute.Packing.GetPackingSKUDetail)]
        public async Task<ResponceList> GetPackingSKUDetail(PackingSKUDetailRequest ReqPara)
        {
            ResponceList Response = new ResponceList();
            try
            {
                if (ReqPara != null)
                {
                    JsonElement result = await obj.GetSKUDetail(ReqPara);

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
                exe.ErrorLog(ex.Message.ToString(), APIRoute.Packing.GetPackingSKUDetail, 0
);
            }
            return Response;
        }

        [HttpPost]
        [Route(APIRoute.Packing.SavePackingSKUDetail)]
        public async Task<Responce> SaveSKUDetails(SaveSKUDetailRequest req)
        {
            Responce Response = new Responce();
            try
            {
                if (req != null)
                {
                    string result = obj.SaveSKUDetails(req);
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
                    return Response;
                }
            }
            catch (Exception ex)
            {
                Response = ResponceResult.ErrorResponse(ex.Message.ToString());
                exe.ErrorLog(ex.Message.ToString(), APIRoute.Packing.SavePackingSKUDetail, req.UserId);
            }
            return Response;
        }

        [HttpPost]
        [Route(APIRoute.Packing.SavePackingDetail)]
        public Responce SaveDetails(PackingSaveRequest req)
        {
            Responce Response = new Responce();
            try
            {
                if (req != null)
                {
                    string result = obj.SaveDetails(req);
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
                    return Response;
                }
            }
            catch (Exception ex)
            {
                Response = ResponceResult.ErrorResponse(ex.Message.ToString());
                exe.ErrorLog(ex.Message.ToString(), APIRoute.Packing.SavePackingDetail, req.UserId);
            }
            return Response;
        }

        [HttpPost]
        [Route(APIRoute.Packing.SkuwisePackingSKUList)]
        public async Task<ResponceList> SkuwisePackingSKUList(SkuwisePackingSKUList ReqPara)
        {
            ResponceList Response = new ResponceList();
            try
            {
                if (ReqPara != null)
                {
                    JsonElement result = await obj.SkuwisePackingSKUList(ReqPara);

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
                exe.ErrorLog(ex.Message.ToString(), APIRoute.Packing.SkuwisePackingSKUList, ReqPara.SOID);
            }
            return Response;
        }


        [HttpPost]
        [Route(APIRoute.Packing.MobUpdateQtyPacking)]
        public async Task<ResponceList> MobUpdateQtyPacking(MobUpdateQtyPacking ReqPara)
        {
            ResponceList Response = new ResponceList();
            try
            {
                if (ReqPara != null)
                {
                    JsonElement result = await obj.MobUpdateQtyPacking(ReqPara);

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
                exe.ErrorLog(ex.Message.ToString(), APIRoute.Packing.MobUpdateQtyPacking, ReqPara.Palletid);
            }
            return Response;
        }
    }
}
