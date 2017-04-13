#load "../shared/environment.csx"
#load "../shared/person.csx"
#load "../shared/heroGenerator.csx"

using System.Net;


public static HttpResponseMessage Run(Person req, TraceWriter log)
{

    if (req.first == null || req.last == null)
    {
        return new HttpResponseMessage(HttpStatusCode.BadRequest, "First and/or Last name argument is missing.");
    } else {

        Person p = new Person(req.First, req.Last);

        return new HttpResponseMessage(HttpStatusCode.OK, p, "application/json");
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