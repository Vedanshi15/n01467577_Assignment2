using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01467577_Assignment2.Controllers
{
    public class J2Controller : ApiController
    {
        // <summary> There are two dice. One dice has m sides labelled 1, 2, 3 ..., m. The other dice has n sides labelled 1, 2, 3, …, n
        // This code will determines how many ways she can roll the value of 10. </summary>
        // <param name="Die1/Die2">Input of Two integer number. The first input representing the number of sides on the first die
        // and the second input representing the number of sides on the second die.</param>
        // <returns>It will display one number which shows total ways she can roll the value of 10.</returns>
        // <example>
        // Get api/J2/DiceGame/6/8 -> There are 5 total ways to get the sum 10.
        // Get api/J2/DiceGame/12/4 -> There are 4 total ways to get the sum 10.
        // Get api/J2/DiceGame/3/3 -> There are 0  total ways to get the sum 10.
        // Get api/J2/DiceGame/5/5 -> There are 1 total ways to get the sum 10.
        // </example>

        [Route("api/J2/DiceGame/{Die1}/{Die2}")]
        [HttpGet]
        public string DiceGame(int Die1, int Die2)
        {
            // This code will find out how many ways she can roll the value of 10. 
            int total = 0;
            if (Die1 > 0 && Die1 <= Die1 && Die2 > 0 && Die2 <= Die2)
            {
                for (int i = 1; i <= Die1; i++)
                {
                    for (int j = 1; j<=Die2; j++)
                    {
                        if((i+j)==10)
                        {
                            total = total + 1;
                        }
                    }
                }
                string msg1 = "There are ";
                string msg2 = " total ways to get the sum 10.";
                return msg1 + total + msg2;
            }
            else
            {
                return "Enter Positive Integer Number.";
            }

        }
    }
}
