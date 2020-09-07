namespace Covid19.Models
{
    public class Record
    {
        public int _id { get; set; }
        public string Date { get; set; }
        public string Admitted { get; set; }
        public string AdmittedWomen { get; set; }
        public string AgeAvg { get; set; }
        public string AgeSdv { get; set; }
        public string Respiratory { get; set; }
        public string RespiratoryWomen { get; set; }
        public string RespiratoryAgeAvg { get; set; }
        public string RespiratoryAgeSdv { get; set; }
        public string EasyPatients { get; set; }
        public string EasyPatientsWomen { get; set; }
        public string EasyPatientsAge { get; set; }
        public string EasyPatientsAgeSdv { get; set; }
        public string MediumPatients { get; set; }
        public string MediumPatientsWomen { get; set; }
        public string MediumPatientsAgeAvg { get; set; }
        public string MediumPatientsAgeSdv { get; set; }
        public string HardPatients { get; set; }
        public string HardPatientsWomen { get; set; }
        public string HardPatientsAgeAvg { get; set; }
        public string HardPatientsAgeSdv { get; set; }
    }

}
