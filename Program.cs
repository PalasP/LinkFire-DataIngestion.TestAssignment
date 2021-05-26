using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace DataIngestion.TestAssignment
{
    class Program
    {
        /// <summary>
        /// This is the starting point.
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        static async Task Main(string[] args)
        {            
            using (var client = new HttpClient())
            {
                var result = await client.GetAsync("https://localhost:44381/api/LinkFireReadAllData/ReadDataRange");

            }

        }
    }
}
