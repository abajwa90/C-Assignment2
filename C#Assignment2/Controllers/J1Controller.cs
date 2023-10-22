using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace Assignment2.Controllers
{
    /// <summary>
    /// this controller calculates whether a day is "before", "special", or "after" based
    /// on the input date (day, month) considering February 18 to be a "special" date.
    /// </summary>
    [System.Web.Http.Route("api/J1/Get/{month}/{day}")]
    public class J1Controller : ApiController
    {
        public string Get(int day, int month)
        {
            bool dateBefore;
            bool dateSpecial;

            if (day <= 18 && month < 2)
            {
                dateBefore = true;
                return "Before";
            }

            else if (day == 18 && month == 2)
            {
                dateSpecial = true;
                return "Special";
            }

            else
            {
                return "After";
            }


        }

    }

}