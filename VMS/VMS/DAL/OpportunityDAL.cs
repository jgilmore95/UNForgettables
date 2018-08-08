using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace VMS.DAL
{
    public class OpportunityDAL : DALBase
    {
        public static void DeleteOpportunity(int opportunityID)
        {
            OleDbCommand cmd = Connect();

            cmd.CommandText = "SELECT * FROM Opportunity;";
            cmd.CommandType = System.Data.CommandType.Text;

            cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
        }
    }
}
