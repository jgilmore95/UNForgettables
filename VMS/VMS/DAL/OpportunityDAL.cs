using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.OleDb;
using VMS.Models;

namespace VMS.DAL
{
    public class OpportunityDAL : DALBase
    {
        public void DeleteOpportunity(Int32 opportunityID)
        {
            OleDbCommand cmd = null;

            try
            {
                cmd = Connect();

                cmd.CommandText = "UPDATE Opportunity Set IsDeleted = 1 WHERE OpportunityID = " + opportunityID + ";";
                cmd.CommandType = System.Data.CommandType.Text;

                OleDbDataReader rdr = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);

                while (rdr.Read() == true)
                {
                    System.Diagnostics.Debug.WriteLine(rdr["Description"].ToString());
                }
            }
            catch (Exception e)
            {

            }
            finally
            {
                CloseConnection(cmd);
            }
        }

        public static List<Opportunity> GetAll()
        {
            OleDbCommand cmd = null;

            List<Opportunity> opps = new List<Opportunity>();

            try
            {
                cmd = Connect();

                cmd.CommandText = "SELECT OpportunityID, CenterID, Description, DateEntered, DateExpired, ContactName, OpportunityStatusID, IsDeleted FROM Opportunity ORDER BY Description;";
                cmd.CommandType = System.Data.CommandType.Text;

                OleDbDataReader rdr = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);

                while (rdr.Read() == true)
                {
                    Opportunity opp = new Opportunity();

                    opp.OpportunityID = Convert.ToInt32(rdr["OpportunityID"].ToString());
                    opp.CenterID = Convert.ToInt32(rdr["CenterID"].ToString());
                    opp.Description = rdr["Description"].ToString();                   
                    opp.DateEntered = Convert.ToDateTime(rdr["DateEntered"].ToString());
                    opp.DateExpired = Convert.ToDateTime(rdr["DateExpired"].ToString());
                    opp.ContactName = rdr["ContactName"].ToString();
                    opp.OpportunityStatusID = Convert.ToInt32(rdr["OpportunityStatusID"].ToString());
                    opp.IsDeleted = Convert.ToBoolean(rdr["IsDeleted"].ToString());

                    opps.Add(opp);
                }
            }
            catch (Exception e)
            {
                throw;
                //return null;
            }
            finally
            {
                CloseConnection(cmd);
            }

            return opps;
        }
    }
}
