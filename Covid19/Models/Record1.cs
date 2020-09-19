namespace Covid19.Models
{
    public class Record1
    {
        public int _id { get; set; }
        public string Date { get; set; }
        public string confirmed_cases_physicians { get; set; }
        public string confirmed_cases_nurses { get; set; }
        public string confirmed_cases_other_healthcare_workers { get; set; }
        public string isolated_nurses { get; set; }
        public string isolated_physicians { get; set; }
        public string isolated_other_healthcare_workers { get; set; }
    }

}
