using System;
using System.Threading;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Collections.Generic;
using System.Runtime.Serialization.Json;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.IO;
using System.Linq;


namespace WebApiClient
{
    class Program
    {
        private static readonly HttpClient client = new HttpClient();        
  
        static void Main(string[] args)
        {
            CancellationToken tok = new CancellationToken();            
            var WorkItemHistoryList = GetHistoryItems("61346",tok).Result;
        }


        private static T DeserializeJsonFromStream<T>(Stream stream)
        {

            //Open the stream and read it back.

            if (stream == null || stream.CanRead == false)
                return default(T);

            using (var sr = new StreamReader(stream))
            using (var jtr = new JsonTextReader(sr))
            {
                 var js = new JsonSerializer();
                 
                var searchResult = js.Deserialize<T>(jtr);
                return searchResult;
            }
        }

        private static async Task<string> StreamToStringAsync(Stream stream)
        {
            string content = null;

            if (stream != null)
                using (var sr = new StreamReader(stream))
                    content = await sr.ReadToEndAsync();
            return content;
        }

        private static async Task<WorkItemHistoryItems> GetHistoryItems(string ParentItemId, CancellationToken cancellationToken)
        { 
            var personalaccesstoken = "";
            var project = "";
            var account = "";
            var url = $"https://{account}.visualstudio.com/{project}/_apis/wit/workitems/{ParentItemId}/updates?api-version=5.0-preview.3";

            using(var request = new HttpRequestMessage(HttpMethod.Get, url))
            {
                request.Headers.Authorization = new AuthenticationHeaderValue("Basic", personalaccesstoken);
                using(var response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead,cancellationToken))
                {
                    var stream = await response.Content.ReadAsStreamAsync();

                    if (response.IsSuccessStatusCode)
                        return DeserializeJsonFromStream<WorkItemHistoryItems>(stream);

                    var content = await StreamToStringAsync(stream);
                    throw new ApiException
                    {
                        StatusCode = (int)response.StatusCode,
                        Content = content
                    };
                }
            }
        }
    }

    
}


