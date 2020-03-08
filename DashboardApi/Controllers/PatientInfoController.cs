using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DashboardApi.Models;

namespace DashboardApi.Controllers
{
    public class PatientInfoController : ApiController
    {
        /// <summary>
        /// Get all the Patients
        /// </summary>
        /// <returns></returns>
        // GET: api/PatientInfo
        // Return a list of all the patientInformation
        public ArrayList Get()
        {
            PatientInfoPersistence pip = new PatientInfoPersistence();

            return pip.GetPatients();
        }

        /// <summary>
        /// Return specific patientinfo based on an ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        // GET: api/PatientInfo/id
        public HttpResponseMessage Get(long id)
        {
            PatientInfoPersistence pip = new PatientInfoPersistence();
            PatientInfo patientinfo = pip.GetPatient(id);

            if (patientinfo == null)
            {
                var message = string.Format("Patient with id = {0} not found", id);
                HttpError err = new HttpError(message);
                return Request.CreateResponse(HttpStatusCode.NotFound, err);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.OK, patientinfo);
            }
        }

        // POST: api/PatientInfo
        public HttpResponseMessage Post([FromBody]PatientInfo value)
        {
            PatientInfoPersistence pip = new PatientInfoPersistence();
            long id;
            id = pip.savePatientInfo(value);
            value.PatientId = id;

            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created);
            response.Headers.Location = new Uri(Request.RequestUri, String.Format("patientinfo/{0}", id));
            return response;
        }

        // PUT: api/PatientInfo/5
        public HttpResponseMessage Put(long id, [FromBody]PatientInfo value)
        {
            PatientInfoPersistence pip = new PatientInfoPersistence();
            bool recordExisted = false;

            recordExisted = pip.updatePatient(id, value);

            HttpResponseMessage response;

            if (recordExisted)
            {
                var message = string.Format("Patient with id = {0} not found", id);
                HttpError err = new HttpError(message);
                return Request.CreateResponse(HttpStatusCode.NoContent, err);
            }
            else
            {
                response = Request.CreateResponse(HttpStatusCode.OK, pip);
            }

            return response;
        }

        // DELETE: api/PatientInfo/5
        public HttpResponseMessage Delete(long id)
        {
            PatientInfoPersistence pip = new PatientInfoPersistence();
            bool recordExisted = false;
            recordExisted = pip.deletePatient(id);

            HttpResponseMessage response;

            if (recordExisted)
            {
                response = Request.CreateResponse(HttpStatusCode.NoContent);
            }
            else
            {
                response = Request.CreateResponse(HttpStatusCode.OK);
            }

            return response;
        }
    }
}
