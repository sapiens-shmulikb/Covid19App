namespace Covid19.Models
{
    public class Result1
    {
        public bool include_total { get; set; }
        public string resource_id { get; set; }
        public Field1[] fields { get; set; }
        public string records_format { get; set; }
        public Record1[] records { get; set; }
        public int limit { get; set; }
        public _Links1 _links { get; set; }
    }

}
