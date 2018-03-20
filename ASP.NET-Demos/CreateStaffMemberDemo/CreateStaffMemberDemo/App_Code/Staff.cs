using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Staff
/// </summary>
namespace CreateStaffMemberDemo
{
    public class Staff : User
    {
        public Role Role { get; set; }
        public bool Volunteer { get; set; }

        public Staff()
        {

        }
    }
}