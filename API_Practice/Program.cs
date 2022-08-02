using Newtonsoft.Json.Linq;
using System;
using System.Linq;
using System.Text;


var client = new HttpClient();
var swansonURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";
var kanyeURL = "https://api.kanye.rest/";


for (int i = 0; i < 6; i++)
{
    var kanyeResponse = client.GetStringAsync(kanyeURL).Result;
    var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();
    var swansonResponse = client.GetStringAsync(swansonURL).Result;
    var swansonQuote = JArray.Parse(swansonResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim();
    Console.WriteLine($"Kanye: {kanyeQuote} \n");
    Console.WriteLine($"Ron: {swansonQuote} \n");
}