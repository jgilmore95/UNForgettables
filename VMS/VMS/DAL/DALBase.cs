using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Configuration;

namespace VMS.DAL
{
    public class DALBase
    {
        protected static OleDbCommand Connect()
        {
            OleDbConnection cnx = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=~\\Database\\VMSDB.accdb;Persist Security Info = ");

            cnx.Open();

            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = cnx;
            return cmd;
            
        }
    }
}
