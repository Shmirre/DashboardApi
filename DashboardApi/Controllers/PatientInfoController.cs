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
    [RoutePrefix("api/patients")]
    public class PatientInfoController : ApiController
    {
        // GET: api/patients
        [Route("")]
        [HttpGet]
        public ArrayList Get()
        {
            PatientInfoPersistence pip = new PatientInfoPersistence();

            return pip.GetPatients();
        }

        // GET: api/patients/department/
        [Route("department/{department}")]
        [HttpGet]
        public HttpResponseMessage Getpatientdepartment(string department)
        {
            PatientInfoPersistence pip = new PatientInfoPersistence();
            PatientInfo patientinfo = pip.GetPatientByDepartment(department);

            if (patientinfo == null)
            {
                var message = string.Format("Patient with department = {0} not found", department);
                HttpError err = new HttpError(message);
                return Request.CreateResponse(HttpStatusCode.NotFound, err);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.OK, patientinfo);
            }
        }

        // GET: api/patients/31
        [Route("{id:long}")]
        [HttpGet]
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

        // POST: api/patients/createpatient
        [Route("createpatient")]
        [HttpPost]
        public HttpResponseMessage Post([FromBody]PatientInfo value)
        {
            PatientInfoPersistence pip = new PatientInfoPersistence();
            long id;

            // Save the patient in the db
            id = pip.SavePatientInfo(value);

            // Get the id of the created patient
            value.PatientId = id;

            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created);

            string msg = string.Format("Patient with id: {0} was created.", id);
            response = Request.CreateResponse(HttpStatusCode.OK, msg);

            return response;
        }

        // PUT: api/PatientInfo/5
        [Route("updatepatient/{id}")]
        [HttpPut]
        public HttpResponseMessage Update(long id, [FromBody]PatientInfo value)
        {
            PatientInfoPersistence pip = new PatientInfoPersistence();
            bool recordExisted = false;

            recordExisted = pip.UpdatePatient(id, value);

            HttpResponseMessage response;

            if (recordExisted)
            {
                string msg = string.Format("Patient with id: {0} was found and updated.", id);
                response = Request.CreateResponse(HttpStatusCode.OK, msg);
            }
            else
            {
                var message = string.Format("Patient with id = {0} not found!", id);
                HttpError err = new HttpError(message);
                response = Request.CreateResponse(HttpStatusCode.NotFound, err);
            }

            return response;
        }

        // DELETE: api/PatientInfo/5
        [Route("deletepatient/{id}")]
        [HttpDelete]
        public HttpResponseMessage Delete(long id)
        {
            PatientInfoPersistence pip = new PatientInfoPersistence();
            bool recordExisted = false;
            recordExisted = pip.DeletePatient(id);

            HttpResponseMessage response;

            if (recordExisted)
            {
                string msg = string.Format("Patient with id: {0} was found and deleted.", id);
                response = Request.CreateResponse(HttpStatusCode.OK, msg);
            }
            else
            {
                var message = string.Format("Patient with id = {0} was not found!", id);
                HttpError err = new HttpError(message);
                response = Request.CreateResponse(HttpStatusCode.NotFound, err);
            }

            return response;
        }
    }
}
