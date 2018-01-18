using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BNCSharp_Tests.Async
{
  public static  class AsyncClass
    {
        public async static Task<long?> GetPageLength()
        {
            var client = new HttpClient();
            var httpMessage = await client.GetAsync("www.mapnamd1.com");
            Console.WriteLine("I made a request to the mapnamd1.com. Waiting for Reply...");
            return httpMessage.Content.Headers.ContentLength;
        }
    }
}
