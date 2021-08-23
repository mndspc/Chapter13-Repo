using System;


namespace DateTimeAPI
{
    class Program
    {
        //  This program demo. how to use DateTime API
        static void Main(string[] args)
        {
            try
            {
                //  How to construct DateTime object
                DateTime dateTime = new DateTime(2021, 08, 23);
                Console.WriteLine("Day={0} Month={1} Year={2}", dateTime.Day, dateTime.Month, dateTime.Year);
                Console.WriteLine("{0}", dateTime.ToString("dd-MMM-yyyy"));
               
                //  How to Convert String to DateTime
                var dateString = "23/08/2021";
                DateTime dt;
                var isValidDate = DateTime.TryParse(dateString,out dt);
                if (isValidDate)
                {
                    Console.WriteLine("After converting string into a DateTime:{0}",dt);
                }
                else
                {
                    Console.WriteLine("Invalid DateTime");
                }
                DateTime dateTime1 = new DateTime(2021,08,23);
                DateTime dateTime2 = new DateTime(2021,08,23);
                Console.WriteLine("After Sub Date2 from Date1:{0}",dateTime1-dateTime2);
                TimeSpan timeSpan = new TimeSpan(24, 0, 0);
                Console.WriteLine("After Sub Date2 from Date1:{0}", dateTime1+timeSpan);

                //  How to explore System DateTime
                Console.WriteLine("Current DateTime is:{0}",DateTime.Now);
                Console.WriteLine("Current Date is:{0}",DateTime.Now.Date);
                Console.WriteLine("Current Year is:{0} Month:{1} Day:{2}",DateTime.Now.Date.Year,DateTime.Now.Date.Month,DateTime.Now.Date.Day);
                DateTime dateTime3 = DateTime.Now.AddDays(10);
                Console.WriteLine("new Date after adding some days:{0}",dateTime3.Date);
                DateTime dateTime4 = DateTime.Now.AddMonths(2);
                Console.WriteLine("new date after adding some months:{0}",dateTime4.Date);

                int result = dateTime1.CompareTo(dateTime2);
                Console.WriteLine(result == 0 ? "Both Dates are Equal" : "Both Dates are not equal") ;
            }
            catch(ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
