using Newtonsoft.Json.Linq;
using System.Data.SqlClient;
using System.Text.Json;
using WMSCOREAPI.Model.V1.Request;

namespace WMSCOREAPI.Utility.V1
{
    public class SearchUtility
    {
        SqlParameter[] param;
        DBActivity obj;


        public SearchUtility()
        {
            obj = new DBActivity();
        }

        public async Task<JsonElement> GetSearchDropDownValues(GetSearchDropDownValues req)
        {
            param = new SqlParameter[]
                    {

                          new SqlParameter("@CustomerID", req.CustomerId)

                    };
            return await obj.ConvertDataSetToJObject(obj.Return_DataSet("Sp_getSearchDropDownValues", param));
        }


        public async Task<JsonElement> GetSearchBarcodeScan(GetSearchBarcodeScan req)
        {
            param = new SqlParameter[]
                    {

                         new SqlParameter("@SearchType", req.SearchType),
                         new SqlParameter("@Barcode", req.Barcode),
                         new SqlParameter("@CustomerId", req.CustomerId),
                         new SqlParameter("@WarehouseId", req.WarehouseId),
                         new SqlParameter("@CompanyId", req.CompanyId),


                    };
            return await obj.ConvertDataSetToJObject(obj.Return_DataSet("Sp_getSearchBarcodeScan", param));
        }

        public async Task<JsonElement> GetSearchScanLog(GetSearchScanLog req)
        {
            param = new SqlParameter[]
                    {

                      new SqlParameter("@SearchType", req.SearchType),
                         new SqlParameter("@CustomerId", req.CustomerId),
                         new SqlParameter("@WarehouseId", req.WarehouseId),
                         new SqlParameter("@CompanyId", req.CompanyId),
                         new SqlParameter("@SearchId", req.SearchId),
                    };
            return await obj.ConvertDataSetToJObject(obj.Return_DataSet("Sp_getSearchScanLog", param));
        }
    }
}
