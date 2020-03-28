using System;
using System.Threading.Tasks;
using System.Threading;


namespace procesamiento_asincrono_jarturogl05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine( EscribirHolaAsync().Status);
        }


        static async Task<Task> EscribirHolaAsync()
        {
          await HacerCosasAsync();

          return Task.CompletedTask;
        }

        static async Task HacerCosasAsync()
        {

            Thread.Sleep(5000);
            Console.WriteLine("Hola");
        }
    }
}
