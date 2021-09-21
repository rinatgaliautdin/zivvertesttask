using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace JsonPlaceholderWpf.TestTask.BLL
{
    /// <summary>
    /// Json Data Retreiver
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class DataRetreiver<T> where T : class
    {
        /// <summary>
        /// GetPosts
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public async Task<T> GetPosts(string url)
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage result = await client.GetAsync(new Uri(url));
                if (result.IsSuccessStatusCode)
                {
                    var responseStr = await result.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<T>(responseStr);
                }

                return null;
            }
        }
    }
}
