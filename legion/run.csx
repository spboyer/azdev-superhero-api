#load "../shared/environment.csx"
#load "../shared/person.csx"
#load "../shared/heroGenerator.csx"

using System.Net;


public static HttpResponseMessage Run(HttpRequestMessage req, Person person, TraceWriter log)
{

    if (person.First == null || person.Last == null)
    {
        return req.CreateResponse(HttpStatusCode.BadRequest, "First and/or Last name argument is missing.");
    } else {

        Person p = new Person(person.First, person.Last);

        return req.CreateResponse(HttpStatusCode.OK, p, "application/json");
    }
}

// public static async Task<HttpResponseMessage> Run
//return Request.CreateResponse<T>(HttpStatusCode.OK, Tobject);
//  if (req.orderId == null)
//     {
//         return new HttpResponseMessage(HttpStatusCode.BadRequest);
//     }
//     else
//     {
//         await outputQueueItem.AddAsync(req);
//         return new HttpResponseMessage(HttpStatusCode.OK);
//     }