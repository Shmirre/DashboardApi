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

        // GET: api/Observation/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Observation
        public void Post([FromBody]string value)
        {
        }

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
