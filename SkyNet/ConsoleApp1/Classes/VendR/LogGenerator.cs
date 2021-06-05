using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SkyNetOS
{
    public class LogGenerator
    {

        public static void Log(string audit)
        {

            try
            {
                using (StreamWriter writer = new StreamWriter(@"C:\Users\Student\Desktop\Sideprojects\SkyNetConsoleApp\SkyNetConsoleAppPreAlpa\SkyNet\ConsoleApp1\VendR Log\Log.txt", true))
                {
                    writer.WriteLine(audit);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }




        }
    }
}
