using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VMS.Models
{
    public class Opportunity
    {
            public Int32 OpportunityID { get; set; }
            public string Center { get; set; }
            public string Description { get; set; }
            public DateTime DateEntered { get; set; }
            public DateTime DateExpired { get; set; }
            public string ContactName { get; set; }
            public string OpportunityStatus { get; set; }
            public bool IsDeleted { get; set; }
    }
    public class DeleteOpportunity
    {

    }
}