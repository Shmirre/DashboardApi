using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DashboardApi.Models
{
    public class PatientInfo
    {
        [Key]
        public long PatientId { get; set; }

        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public string PrimaryDoctor { get; set; }

        public string SecondaryDoctor { get; set; }

        public string PhoneNumber { get; set; }

        public string Street { get; set; }

        public string Number { get; set; }

        public string PostalCode { get; set; }
        public string City { get; set; }

        public string EmergencyContact { get; set; }

        public string EmergencyContactPhone { get; set; }

        public string Sex { get; set; }

        public string Weight { get; set; }

        public string Height { get; set; }
        public string Afdeling { get; set; }

    }
}