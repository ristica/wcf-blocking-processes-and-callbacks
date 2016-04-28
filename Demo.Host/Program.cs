using Demo.Wcf;
using System.ServiceModel;

namespace Demo.Host
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Starting the Long-Running-Service...");
            System.Console.WriteLine("");

            var host = new ServiceHost(typeof(LrpManager));
            host.Open();

            System.Console.WriteLine("Service started!");
            System.Console.WriteLine("");
            System.Console.WriteLine("Pres <Enter> to exit...");
            System.Console.Read();

            // housekeeping
            host.Close();
        }
    }
}
