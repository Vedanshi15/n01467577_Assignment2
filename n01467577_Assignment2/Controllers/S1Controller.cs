using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01467577_Assignment2.Controllers
{
    public class S1Controller : ApiController
    {
        // <summary> This Code will find the next year after the given year with distinct digits. </summary>
        // <param name="Year">Input of one integer number which is the Year.</param>
        // <returns>It will display the next year after the given year.</returns>
        // <example>
        // Get api/S1/DistinctDigitsYear/1987 -> The next year after 1987 with distinct digits is 2013
        // Get api/S1/DistinctDigitsYear/999 -> The next year after 999 with distinct digits is 1023
        // Get api/S1/DistinctDigitsYear/-5 -> Enter valid Year between 1 to 10000.
        // </example>
        // Question Link: https://cemc.math.uwaterloo.ca/contests/computing/2013/stage1/seniorEn.pdf
        [Route("api/S1/DistinctDigitsYear/{Year}")]
        [HttpGet]
        public string DistinctDigitsYear(int Year)
        {
            //This Code will find the next year after the given year with distinct digits.
            if (Year > 0 && Year <= 10000)
            {
                int year = Year;
                startFrom:
                Year = Year + 1;
                string str = Convert.ToString(Year);
                for (int i = 0; i < str.Length; i++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        if (str[i] == str[j])
                        {
                            goto startFrom;
                        }
                    }
                }             
                return "The next year after " + year +" with distinct digits is " + Year;
            }
            else
            {
                return "Enter valid Year between 1 to 10000.";
            }

        }
    }
}
