using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01467577_Assignment2.Controllers
{
    public class J1Controller : ApiController
	{
		// <summary> This code will determine whether he is happy or sad at the end of the day depending on the number and size of treats he receives throughout the day.
		// The treats come in three sizes: small,medium, and large.If score is 10 or greater then he is happy Otherwise, he is sad. 
		// </summary>
		// <param name="smallTreats/mediumTreats/largeTreats">Input of Three integer number. The first contains the number of small treats, the second contains the number of medium treats, 
		// and the third contains the number of large treats that dog receives in a day.</param>
		// <returns>It will display the string 'Happy' or 'Sad'.</returns>
		// <example>
		// Get api/J1/FindTreats/3/1/0 -> Sad
		// Get api/J1/FindTreats/3/2/1 -> Happy
		// Get api/J1/FindTreats/3/-1/0 -> Enter number between 0 to 10!!!!
		// </example>
		// Question Link: https://cemc.math.uwaterloo.ca/contests/computing/2020/ccc/juniorEF.pdf

		[Route("api/J1/FindTreats/{smallTreats}/{mediumTreats}/{largeTreats}")]
		[HttpGet]
		public string FindTreats(int smallTreats, int mediumTreats, int largeTreats)
        {
			//This code will determine whether the dog is happy or sad at the end of the day based on the treats he is getting. 
			if (smallTreats >= 0 && smallTreats<= 10 && mediumTreats >=0 && mediumTreats<= 10 && largeTreats >=0 && largeTreats<= 10)
			{
				int count = (1 * smallTreats) + (2 * mediumTreats) + (3 * largeTreats);
				if (count >= 10)
				{
					return " Happy :) ";
				}
				else
				{
					return " Sad :( ";
				}
			}
			else
			{
				return "Enter Treats between 0 to 10!!!!";
			}
		}
    }
}
