using System;
using System.Collections.Generic;
using System.Net.Mime;
using System.Text;
using USSD;

namespace USSD_console
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 1)
            {
                Console.WriteLine("No command parameter provided.");
                return ;
            }
            if (Modem_Controller.init_modem() == false)
            {
                Console.WriteLine("Failed to find any modem . Please try again.");
                return;
            }
            string output = Modem_Controller.send_ussd(args[0]);
            Console.WriteLine(Modem_Controller.decode_ussd_message(output));
        }
    }
}
