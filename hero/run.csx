#load "../shared/environment.csx"
#load "../shared/person.csx"
#load "../shared/heroGenerator.csx"

using System.Net;

public static HttpResponseMessage Run(HttpRequestMessage req, Person person, TraceWriter log)
{
    return req.CreateResponse(HttpStatusCode.OK, person , "application/json");

    string first = req.GetQueryNameValuePairs()
        .FirstOrDefault(q => string.Compare(q.Key, "first", true) == 0)
        .Value;

    string last = req.GetQueryNameValuePairs()
        .FirstOrDefault(q => string.Compare(q.Key, "last", true) == 0)
        .Value;


    if (first == null || last == null)
    {
        return req.CreateResponse(HttpStatusCode.BadRequest, "First and/or Last name argument is missing.");
    } else {

        Person p = new Person(first, last);

        return req.CreateResponse(HttpStatusCode.OK, p, "application/json");
    }
}

