using System;
using System.Globalization;
using DockerVolume.Services;


namespace DockerVolume
{
    class Program
    {
        static void Main(string[] args)
        {
            var fileService = new FileService();

            Console.WriteLine(fileService.Read());
            fileService.Write($"{DateTime.Now.ToString(CultureInfo.InvariantCulture)}\n");

            Console.ReadKey();
        }
    }
}
