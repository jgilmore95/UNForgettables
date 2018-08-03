using System.Collections.Generic;
namespace VMS.Models
{
    public static class Repository
    {
        private static List<UserLoginInput> responses2 = new List<UserLoginInput>();
        public static IEnumerable<UserLoginInput> Responses2
        {
            get
            {
                return responses2;
            }
        }
        public static void AddResponse(UserLoginInput response)
        {
            responses2.Add(response);

        }
    }
}