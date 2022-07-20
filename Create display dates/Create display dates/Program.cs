/*
 Q2.Create a console app to display dates in as follows
-Add days in given date.
-Add months in given date.
-Add years in given date.

Output(somthing like this but input values can be different):
Enter date:02/07/2022
Enter add days to date:4
Date:06/07/2022
Enter add months to date:2
Date:02/09/2022
Enter add years to date:1
Date:06/07/2023*/


using System;
using System.Collections;
using System.Globalization;

namespace date
{

    class Program
    {
        public static void Main(string[] arg)

        {

            /*Convert The Date Format To dd-MM-yyyy to dd/MM/yyyy*/

            CultureInfo provider = CultureInfo.InvariantCulture;
            Console.WriteLine("Enter Date in this pattern ('dd/mm/yyyy):");
            string mydate = Console.ReadLine();
            DateTime d = Convert.ToDateTime(mydate);
            var r = d.ToString("dd/MM/yyyy").Replace("-", "/");

            /*Enter The Date From The User*/
            Console.WriteLine($"Enter Your Date: {r}");

            /*Add Day Into The Date*/
            Console.WriteLine("you want to add Day: ");
            var day = Console.ReadLine();
            DateTime dayCal = d.AddDays(Convert.ToInt32(day));
            Console.WriteLine($"your add day after result:  {dayCal.ToString("dd/MM/yyyy ").Replace("-","/")} ");

            /*Add Months Into The Date */
            Console.WriteLine("you want to add month:");
            var month = Console.ReadLine();
            Console.WriteLine($"your add month after result: {d.AddMonths(Convert.ToInt32(month))}".Replace("-", "/"));


            /*Add Year Into The Date */
            Console.WriteLine("you want to add year:");
            var year = Console.ReadLine();

            /*Final Result after Adding Day,Month And Year*/
            Console.WriteLine($"your add year after result: {d.AddYears(Convert.ToInt32(year))}".Replace("-", "/"));
            Console.Read();
        }
    }
}



