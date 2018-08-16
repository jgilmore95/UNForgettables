/**
 * Robert Bolden
 * 
 * This page is used for applying commands to the delete page as well as displaying active opportunity results from the database.
 * It also performs a function to show matches with the opportunity.
 **/
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

                cmd.CommandText = "UPDATE Opportunity Set IsDeleted = 1 WHERE OpportunityID = " + opportunityID.ToString() + ";";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {

            }
            finally
            {
                CloseConnection(cmd);
            }
        }

        public static List<Opportunity> GetAllActive()
        {
            OleDbCommand cmd = null;

            List<Opportunity> opps = new List<Opportunity>();

            try
            {
                cmd = Connect();

                cmd.CommandText = "SELECT [Opportunity].OpportunityID, [Center].Name, [Opportunity].Description, [Opportunity].DateEntered, [Opportunity].DateExpired, [Opportunity].ContactName, [Opportunity].IsDeleted, [OpportunityStatus].OpportunityStatus FROM OpportunityStatus INNER JOIN(Center INNER JOIN Opportunity ON Center.CenterID = Opportunity.CenterID) ON OpportunityStatus.OpportunityStatusID = Opportunity.OpportunityStatusID WHERE [Opportunity].IsDeleted = 0 ORDER BY [Opportunity].Description;";
                cmd.CommandType = System.Data.CommandType.Text;

                OleDbDataReader rdr = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);

                while (rdr.Read() == true)
                {
                    Opportunity opp = new Opportunity();

                    opp.OpportunityID = Convert.ToInt32(rdr["OpportunityID"].ToString());
                    opp.Center = rdr["Name"].ToString();
                    opp.Description = rdr["Description"].ToString();
                    opp.DateEntered = Convert.ToDateTime(rdr["DateEntered"].ToString());
                    opp.DateExpired = Convert.ToDateTime(rdr["DateExpired"].ToString());
                    opp.ContactName = rdr["ContactName"].ToString();
                    opp.OpportunityStatus = rdr["OpportunityStatus"].ToString();
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

        public static List<OpportunityVolunteer> GetAllOppVols()
        {
            OleDbCommand cmd = null;

            List<OpportunityVolunteer> oppsVolunteers = new List<OpportunityVolunteer>();

            try
            {
                cmd = Connect();

                cmd.CommandText = "SELECT Center.Name as CenterName, Opportunity.Description, Volunteer.FName + ' ' + Volunteer.LName as VolunteerName FROM Volunteer INNER JOIN((Center INNER JOIN Opportunity ON Center.CenterID = Opportunity.CenterID) INNER JOIN VolunteerOpportunity ON Opportunity.OpportunityID = VolunteerOpportunity.OpportunityID) ON Volunteer.VolunteerID = VolunteerOpportunity.VolunteerID ORDER BY Center.Name,  Opportunity.Description;";
                cmd.CommandType = System.Data.CommandType.Text;

                OleDbDataReader rdr = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);

                while (rdr.Read() == true)
                {
                    OpportunityVolunteer opp = new OpportunityVolunteer();

                    opp.CenterName = rdr["CenterName"].ToString();
                    opp.Description = rdr["Description"].ToString();
                    opp.VolunteerName = rdr["VolunteerName"].ToString();

                    oppsVolunteers.Add(opp);
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

            return oppsVolunteers;
        }

        public static List<VolunteerOpportunity> GetAllVolsOpps()
        {
            OleDbCommand cmd = null;

            List<VolunteerOpportunity> Volunteersopps = new List<VolunteerOpportunity>();

            try
            {
                cmd = Connect();

                cmd.CommandText = "SELECT Volunteer.FName + ' ' + Volunteer.LName as VolunteerName, Center.Name as CenterName, Opportunity.Description  FROM Volunteer INNER JOIN((Center INNER JOIN Opportunity ON Center.CenterID = Opportunity.CenterID) INNER JOIN VolunteerOpportunity ON Opportunity.OpportunityID = VolunteerOpportunity.OpportunityID) ON Volunteer.VolunteerID = VolunteerOpportunity.VolunteerID ORDER BY LName, FName, Center.Name;";
                cmd.CommandType = System.Data.CommandType.Text;

                OleDbDataReader rdr = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);

                while (rdr.Read() == true)
                {
                    VolunteerOpportunity opp = new VolunteerOpportunity();

                    opp.CenterName = rdr["CenterName"].ToString();
                    opp.Description = rdr["Description"].ToString();
                    opp.VolunteerName = rdr["VolunteerName"].ToString();

                    Volunteersopps.Add(opp);
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

            return Volunteersopps;
        }
    }
}

