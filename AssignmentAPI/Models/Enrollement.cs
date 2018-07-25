using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssignmentAPI.Models
{  
    public static class Enrollement
    {
        public static List<EnrollementUser> lstEnrollement = new List<EnrollementUser>();
        static Enrollement()
        {
            EnrollementUser enrollementUser = new EnrollementUser();
            enrollementUser.id = 1;
            enrollementUser.name = "Ankit";
            enrollementUser.email = "a@a.com";
            enrollementUser.phone = "9817231234";
            lstEnrollement.Add(enrollementUser);

        }



    }
}
