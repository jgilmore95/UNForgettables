using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Configuration;
using System.Web;

namespace VMS.DAL
{
    public class DALBase
    {
        protected static OleDbCommand Connect()
        {
            String path = ConfigurationManager.ConnectionStrings["VMSDB"].ToString().Replace("[PATH]", HttpContext.Current.Request.PhysicalApplicationPath);

            OleDbConnection cnx = new OleDbConnection(path);

            cnx.Open();

            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = cnx;
            return cmd;
        }

        protected static void CloseConnection(OleDbCommand cmd)
        {
            if (cmd != null)
            {
                if (cmd.Connection.State == System.Data.ConnectionState.Open)
                {
                    cmd.Connection.Close();
                    cmd = null;
                }
            }
        }
    }
}
