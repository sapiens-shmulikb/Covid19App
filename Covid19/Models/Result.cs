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





//public class Rootobject
//{
//    public string help { get; set; }
//    public bool success { get; set; }
//    public Result result { get; set; }
//}

//public class Result
//{
//    public bool include_total { get; set; }
//    public string resource_id { get; set; }
//    public Field[] fields { get; set; }
//    public string records_format { get; set; }
//    public Record[] records { get; set; }
//    public int limit { get; set; }
//    public _Links _links { get; set; }
//}

//public class _Links
//{
//    public string start { get; set; }
//    public string next { get; set; }
//}

//public class Field
//{
//    public string type { get; set; }
//    public string id { get; set; }
//}

//public class Record
//{
//    public int _id { get; set; }
//    public string תאריך { get; set; }
//    public string מאושפזים { get; set; }
//    public string אחוזנשיםמאושפזות { get; set; }
//    public string גילממוצעמאושפזים { get; set; }
//    public string סטייתתקןגילמאושפזים { get; set; }
//    public string מונשמים { get; set; }
//    public string אחוזנשיםמונשמות { get; set; }
//    public string גילממוצעמונשמים { get; set; }
//    public string סטייתתקןגילמונשמים { get; set; }
//    public string חוליםקל { get; set; }
//    public string אחוזנשיםחולותקל { get; set; }
//    public string גילממוצעחוליםקל { get; set; }
//    public string סטייתתקןגילחוליםקל { get; set; }
//    public string חוליםבינוני { get; set; }
//    public string אחוזנשיםחולותבינוני { get; set; }
//    public string גילממוצעחוליםבינוני { get; set; }
//    public string סטייתתקןגילחוליםבינוני { get; set; }
//    public string חוליםקשה { get; set; }
//    public string אחוזנשיםחולותקשה { get; set; }
//    public string גילממוצעחוליםקשה { get; set; }
//    public string סטייתתקןגילחוליםקשה { get; set; }
//}
