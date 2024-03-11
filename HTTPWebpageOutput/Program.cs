// Michael Banko - CPS3330 Midterm SP24f
using System;
using System.Net.Http;
using System.Threading.Tasks;
class Program {
    static async Task Main(string[] args) {
        using var httpClient = new HttpClient();

        try {
            HttpResponseMessage response = await httpClient.GetAsync("https://www.steamcommunity.com");

            if (response.IsSuccessStatusCode) {
                string content = await response.Content.ReadAsStringAsync();

                long contentLength = content.Length;

                Console.WriteLine($"Page Content:\n{content}\n");
                Console.WriteLine($"Number of Bytes: {contentLength}");
            } else {
                Console.WriteLine($"Request failed with code: {response.StatusCode}");
            }
        }
        catch (HttpRequestException e) {
            Console.WriteLine($"Request errored with message: {e.Message}");
        }
    }
}