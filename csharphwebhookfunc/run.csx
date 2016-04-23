#r "Newtonsoft.Json"
#load "models.csx" // loads models.csx - you can put as many csx files you want in the directory and load by using #load "csfilename.csx"

using System;
using System.Net;
using Newtonsoft.Json;

public static async Task<object> Run(HttpRequestMessage req, TraceWriter log)
{
    log.Verbose($"Webhook was triggered!");
    
    string jsonContent = await req.Content.ReadAsStringAsync();
    dynamic data = JsonConvert.DeserializeObject(jsonContent);
    
    return req.CreateResponse(HttpStatusCode.OK, new {
        message = "Hello World"
    });
}