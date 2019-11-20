using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using CrimeIncident;
using Smart911Enrollments;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;

namespace SmartEnrollmentFor911.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }



        public void OnGet()
        {
            using (var webClient = new WebClient())

            {
                string crimeIncidentJSONEndpoint = "https://data.cincinnati-oh.gov/resource/k59e-2pvf.json";
                string smart911EnrollmentJSONEndpoint = "https://data.cincinnati-oh.gov/resource/rtu7-isj6.json";
                string crimeIncidentJSON = GetDataFromEndpoint(crimeIncidentJSONEndpoint);
                string smart911EnrollmentJSON = GetDataFromEndpoint(smart911EnrollmentJSONEndpoint);

                
                var crimeIncidents = CrimeIncidents.FromJson(crimeIncidentJSON);
                ViewData["CrimeIncidents"] = crimeIncidents;


                 var smart911Enrollments = Smart911Enrollment.FromJson(smart911EnrollmentJSON);
                ViewData["Smart911Enrollments"] = smart911Enrollments;

                IDictionary<long, CrimeIncident.CrimeIncidents> incidentsMap = new Dictionary<long, CrimeIncidents>();
                List<Smart911Enrollments.Smart911Enrollment> enrollist = new List<Smart911Enrollment>();
                
                foreach (CrimeIncidents crInc in crimeIncidents)
                {
                    if (!incidentsMap.ContainsKey(crInc.Zip))
                    {
                        incidentsMap.Add(crInc.Zip, crInc);
                    }
                }

                foreach (Smart911Enrollment enroll in smart911Enrollments)
                {
                    if (incidentsMap.ContainsKey(enroll.ZipCode))
                    {
                        enrollist.Add(enroll);
                    }
                }
                ViewData["Enrollist"] = enrollist;

                
            }
        }


        public string GetDataFromEndpoint(string jsonEndpoint)
        {
            string jSonData = "";
            using (WebClient webClient = new WebClient())
            {
                jSonData = webClient.DownloadString(jsonEndpoint);
            }
            return jSonData;
        }

    }
}
