using System;
using System.Text.RegularExpressions;
class DateFormat
{
   public static void Main()
    {
        string input = "Hdjsh asd2324234jghjsd hjsdg sdhk 12212021 idf23432 32423 d34234jlh dfh";
        Regex regex = new Regex(@"\b(0[1-9]|1[0-2])(0[1-9]|[12][0-9]|3[01])\d{4}\b");

        MatchCollection matches = regex.Matches(input);

        foreach (Match match in matches)
        {
            string dateStr = match.Value;
            if (DateTime.TryParseExact(dateStr, "MMddyyyy", null, System.Globalization.DateTimeStyles.None, out DateTime validDate))
            {
                Console.WriteLine("Valid date found: " + validDate.ToString("MM/dd/yyyy"));
            }
        }
    }
}
