using System.Data.SqlClient;
using System.Data;
using System.Configuration;


namespace WMSCOREAPI.Utility.V1
{
    public class RfidTaggingUtility
    {
        //static string Connstr = ConfigurationManager.AppSettings["ConnStr"].ToString();

        static string Connstr = "server=116.74.138.65,2765;database=BWMSProd_UAT;Uid=sa;Pwd=Password123#";
        public static DataSet GetRfidList(long currentpage, long recordlimit, long customerid, long warehouseid, long userid, string rfidsearch, string listtype, string activetab)
        {
            DataSet ds = new DataSet();
            if (rfidsearch == null)
            {
                rfidsearch = "all";
            }
            SqlConnection strcon = new SqlConnection(Connstr);
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    using (SqlDataAdapter da = new SqlDataAdapter())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "sp_api_getrfidInfo";
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@currentpage", currentpage);
                        cmd.Parameters.AddWithValue("@recordlimit", recordlimit);
                        cmd.Parameters.AddWithValue("@customerid", customerid);
                        cmd.Parameters.AddWithValue("@warehouseid", warehouseid);
                        cmd.Parameters.AddWithValue("@userid", userid);
                        cmd.Parameters.AddWithValue("@SearchKey", rfidsearch);
                        cmd.Parameters.AddWithValue("@listtype", listtype);
                        cmd.Parameters.AddWithValue("@activetab", activetab);
                        cmd.Connection = strcon;
                        cmd.Connection.Open();
                        da.SelectCommand = cmd;
                        da.Fill(ds);
                        cmd.Connection.Close();
                    }
                }
            }
            catch (Exception ex) { }
            finally { }
            return ds;
        }

        //public static DataSet GetRfidDashboard(long customerid, long warehouseid, long userid)
        //{
        //    DataSet ds = new DataSet();

        //    SqlConnection strcon = new SqlConnection(Constr);
        //    try
        //    {
        //        using (SqlCommand cmd = new SqlCommand())
        //        {
        //            using (SqlDataAdapter da = new SqlDataAdapter())
        //            {
        //                cmd.CommandType = CommandType.StoredProcedure;
        //                cmd.CommandText = "sp_api_rfiddashboard";
        //                cmd.Parameters.Clear();
        //                cmd.Parameters.AddWithValue("@customerid", customerid);
        //                cmd.Parameters.AddWithValue("@warehouseid", warehouseid);
        //                cmd.Parameters.AddWithValue("@userid", userid);
        //                cmd.Connection = strcon;
        //                cmd.Connection.Open();
        //                da.SelectCommand = cmd;
        //                da.Fill(ds);
        //                cmd.Connection.Close();
        //            }
        //        }
        //    }
        //    catch (Exception ex) { }
        //    finally { }
        //    return ds;
        //}

        public static DataSet GetRfidDashboard(long currentpage, long recordlimit, long customerid, long warehouseid, long userid, string rfidsearch, string listtype, string activetab)
        {
            DataSet ds = new DataSet();

            SqlConnection strcon = new SqlConnection(Connstr);
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    using (SqlDataAdapter da = new SqlDataAdapter())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "sp_api_rfiddashboardnew";
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@currentpage", currentpage);
                        cmd.Parameters.AddWithValue("@recordlimit", recordlimit);
                        cmd.Parameters.AddWithValue("@customerid", customerid);
                        cmd.Parameters.AddWithValue("@warehouseid", warehouseid);
                        cmd.Parameters.AddWithValue("@userid", userid);
                        cmd.Parameters.AddWithValue("@rfidsearch", rfidsearch);
                        cmd.Parameters.AddWithValue("@listtype", listtype);
                        cmd.Parameters.AddWithValue("@activetab", activetab);
                        cmd.Connection = strcon;
                        cmd.Connection.Open();
                        da.SelectCommand = cmd;
                        da.Fill(ds);
                        cmd.Connection.Close();
                    }
                }
            }
            catch (Exception ex) { }
            finally { }
            return ds;
        }

        public static DataSet UpdateRfid(string rfid, long recId, string code, long codeId)
        {
            DataSet ds = new DataSet();

            SqlConnection strcon = new SqlConnection(Connstr);
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    using (SqlDataAdapter da = new SqlDataAdapter())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "sp_api_rfidupdate";
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@rfid", rfid);
                        cmd.Parameters.AddWithValue("@recId", recId);
                        cmd.Parameters.AddWithValue("@code", code);
                        cmd.Parameters.AddWithValue("@codeId", codeId);
                        cmd.Connection = strcon;
                        cmd.Connection.Open();
                        da.SelectCommand = cmd;
                        da.Fill(ds);
                        cmd.Connection.Close();
                    }
                }
            }
            catch (Exception ex) { }
            finally { }
            return ds;
        }

        public static DataSet UnassignMultipleRfid(string recId)
        {
            DataSet ds = new DataSet();

            SqlConnection strcon = new SqlConnection(Connstr);
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    using (SqlDataAdapter da = new SqlDataAdapter())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "sp_api_rfidMultipleUnassign";
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@recId", recId);
                        cmd.Connection = strcon;
                        cmd.Connection.Open();
                        da.SelectCommand = cmd;
                        da.Fill(ds);
                        cmd.Connection.Close();
                    }
                }
            }
            catch (Exception ex) { }
            finally { }
            return ds;
        }

        public static DataSet InsertRfid(string rfidlabel, string type, string code, long codeId, string description, long userId)
        {
            DataSet ds = new DataSet();

            SqlConnection strcon = new SqlConnection(Connstr);
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    using (SqlDataAdapter da = new SqlDataAdapter())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "sp_api_rfidinsert";
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@rfidlabel", rfidlabel);
                        cmd.Parameters.AddWithValue("@type", type);
                        cmd.Parameters.AddWithValue("@code", code);
                        cmd.Parameters.AddWithValue("@codeId", codeId);
                        cmd.Parameters.AddWithValue("@description", description);
                        cmd.Parameters.AddWithValue("@userId", userId);
                        cmd.Connection = strcon;
                        cmd.Connection.Open();
                        da.SelectCommand = cmd;
                        da.Fill(ds);
                        cmd.Connection.Close();
                    }
                }
            }
            catch (Exception ex) { }
            finally { }
            return ds;
        }
    }
}
