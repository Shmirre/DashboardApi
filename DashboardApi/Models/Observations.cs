using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DashboardApi.Models
{
    public class Observations
    {
        [Key]
        public long Id { get; set; }

        public string Afdeling { get; set; }

        //[ForeignKey("PatientId")]
        public long PatientId { get; set; }

        public DateTime Observationdate { get; set; }

        public string Ewsprocedure { get; set; }

        public int Ews_total { get; set; }

        public float Sbp { get; set; }

        public int Sbp_score { get; set; }

        public string Loc { get; set; }

        public int Loc_score { get; set; }

        public float Spo2 { get; set; }

        public int Spo2_score { get; set; }

        public string Add_o2 { get; set; }

        public int Add_o2_score { get; set; }

        public int Hr { get; set; }

        public int Hr_score { get; set; }

        public int Rr { get; set; }

        public int Rr_score { get; set; }

        public float Temp { get; set; }

        public int Temp_score { get; set; }
    }
}