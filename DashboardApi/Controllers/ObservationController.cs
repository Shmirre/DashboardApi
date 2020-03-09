using DashboardApi.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DashboardApi.Controllers
{
    public class ObservationController : ApiController
    {
        // GET: api/Observation
        public ArrayList Get()
        {
            ObservationPersistence obp = new ObservationPersistence();

            return obp.GetObservations();
        }

        // GET: api/Observation/id
        public String Get(long id)
        {
            ObservationPersistence obp = new ObservationPersistence();
            return "id";
        }

        // POST: api/Observation
        /* HttpResponseMessage Post([FromBody]Observations value)
        {
            ObservationPersistence obp = new ObservationPersistence();
            long id;
            id = obp.savePatientInfo(value);
            value.PatientId = id;

            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created);
            response.Headers.Location = new Uri(Request.RequestUri, String.Format("patientinfo/{0}", id));
            return response;
        }*/

        // PUT: api/Observation/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Observation/5
        public void Delete(int id)
        {
        }
    }
}
