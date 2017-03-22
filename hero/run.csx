#load "../shared/heroGenerator.csx"
#load "../shared/environment.csx"
#load "../shared/person.csx"

using System.Net;

public static HttpResponseMessage Run(HttpRequestMessage req, TraceWriter log)
{

    string first = req.GetQueryNameValuePairs()
        .FirstOrDefault(q => string.Compare(q.Key, "first", true) == 0)
        .Value;
    
    string last = req.GetQueryNameValuePairs()
        .FirstOrDefault(q => string.Compare(q.Key, "last", true) == 0)
        .Value;

    return first == null || last == null 
        ? req.CreateResponse(HttpStatusCode.BadRequest, "First and/or Last name argument is missing.")
        : req.CreateResponse(HttpStatusCode.OK, GetHeroName(first, last));
    
}