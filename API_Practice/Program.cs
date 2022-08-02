using Newtonsoft.Json.Linq;
using System;
using System.Linq;
using System.Text;

var client = new HttpClient();


var kanyeURL = "https://api.kanye.rest/";

var kanyeResponse = client.GetStringAsync(kanyeURL).Result;

var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();

var swansonURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";

var swansonResponse = client.GetStringAsync(swansonURL).Result;

var swansonQuote = JArray.Parse(swansonResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim();


Console.WriteLine(kanyeQuote);
Console.WriteLine();
Console.WriteLine(swansonQuote);
Console.WriteLine();
Console.WriteLine(kanyeQuote);
Console.WriteLine();
Console.WriteLine(swansonQuote);
Console.WriteLine();
Console.WriteLine(kanyeQuote);
Console.WriteLine();
Console.WriteLine(swansonQuote);
Console.WriteLine();
Console.WriteLine(kanyeQuote);