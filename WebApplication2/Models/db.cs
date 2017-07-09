using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class db
    { 
        public static Boolean validate(string name, string pass)
        {
            if (name == "admin" && pass == "admin")
            {
                return true;
            }
            else
                return false;
        }
    }
}