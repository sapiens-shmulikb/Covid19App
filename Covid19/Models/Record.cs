using Newtonsoft.Json;

namespace Covid19.Models
{
    public class Record
    {
        public int _id { get; set; }
        public string תאריך { get; set; }
        public string מאושפזים { get; set; }
        public string אחוזנשיםמאושפזות { get; set; }

        [JsonProperty(PropertyName = "גיל ממוצע מאושפזים")]
        public string גילממוצעמאושפזים { get; set; }
        public string סטייתתקןגילמאושפזים { get; set; }
        public string מונשמים { get; set; }
        public string אחוזנשיםמונשמות { get; set; }
        public string גילממוצעמונשמים { get; set; }
        public string סטייתתקןגילמונשמים { get; set; }
        public string חוליםקל { get; set; }
        public string אחוזנשיםחולותקל { get; set; }
        public string גילממוצעחוליםקל { get; set; }
        public string סטייתתקןגילחוליםקל { get; set; }
        public string חוליםבינוני { get; set; }
        public string אחוזנשיםחולותבינוני { get; set; }
        public string גילממוצעחוליםבינוני { get; set; }
        public string סטייתתקןגילחוליםבינוני { get; set; }
        [JsonProperty(PropertyName = "קשה חולים")]
        public string חוליםקשה { get; set; }
        public string אחוזנשיםחולותקשה { get; set; }
        public string גילממוצעחוליםקשה { get; set; }
        public string סטייתתקןגילחוליםקשה { get; set; }
   
        //public string Date { get; set; }
        //public string Admitted { get; set; }
        //public string AdmittedWomen { get; set; }
        //public string AgeAvg { get; set; }
        //public string AgeSdv { get; set; }
        //public string Respiratory { get; set; }
        //public string RespiratoryWomen { get; set; }
        //public string RespiratoryAgeAvg { get; set; }
        //public string RespiratoryAgeSdv { get; set; }
        //public string EasyPatients { get; set; }
        //public string EasyPatientsWomen { get; set; }
        //public string EasyPatientsAge { get; set; }
        //public string EasyPatientsAgeSdv { get; set; }
        //public string MediumPatients { get; set; }
        //public string MediumPatientsWomen { get; set; }
        //public string MediumPatientsAgeAvg { get; set; }
        //public string MediumPatientsAgeSdv { get; set; }
        //public string HardPatients { get; set; }
        //public string HardPatientsWomen { get; set; }
        //public string HardPatientsAgeAvg { get; set; }
        //public string HardPatientsAgeSdv { get; set; }
    }

}
