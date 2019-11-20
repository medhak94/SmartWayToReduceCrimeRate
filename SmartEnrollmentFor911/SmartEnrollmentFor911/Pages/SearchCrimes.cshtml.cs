using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CrimeIncident;
using Smart911Enrollments;

namespace SmartEnrollmentFor911.Pages
{
    public class SearchCrimesModel : PageModel
    {
        public bool searchFinished { get; set; }
        [BindProperty]
        public long zipSearch { get; set; }
        public CrimeIncident.CrimeIncidents[] crimes;
        public Smart911Enrollments.Smart911Enrollment[] enrollments;
        public CrimeIncident.CrimeIncidents[] crimesFiltered;
        public Smart911Enrollments.Smart911Enrollment[] enrollmentsFiltered;
        public string crimeJsonEndPoint = "https://data.cincinnati-oh.gov/resource/k59e-2pvf.json";
        public string smart911EnrollmentJsonEndPoint = "https://data.cincinnati-oh.gov/resource/rtu7-isj6.json";

        //Reusable method to het the input Json Streams
        public string GetDataFromJson(string endpoint)
        {
            using (WebClient webClient = new WebClient())
            {
                return webClient.DownloadString(endpoint);
            }
        }
        public void OnGet()
        {
           
            {
                //Getting Crime incidents data
                String crimeIncidentJSON = GetDataFromJson(crimeJsonEndPoint);
                crimes = CrimeIncidents.FromJson(crimeIncidentJSON);

                //Getting Smart 911 data
                String smart911EnrollmentJSON = GetDataFromJson(smart911EnrollmentJsonEndPoint);
                enrollments = Smart911Enrollment.FromJson(smart911EnrollmentJSON);

                crimesFiltered = crimes.Where(x => x.Zip == zipSearch).ToArray();
                enrollmentsFiltered = enrollments.Where(x => x.ZipCode == zipSearch).ToArray();

                ViewData["CrimeIncidents"] = crimesFiltered;
                ViewData["Smart911Enrollments"] = enrollmentsFiltered;
            }
            searchFinished = true;
        }
        public void OnPost()
        {
            

             
        }
    }
}