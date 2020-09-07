namespace Covid19.Models
{
    public class Result
    {
        public bool include_total { get; set; }
        public string resource_id { get; set; }
        public Field[] fields { get; set; }
        public string records_format { get; set; }
        public Record[] records { get; set; }
        public int limit { get; set; }
        public _Links _links { get; set; }
    }

}
