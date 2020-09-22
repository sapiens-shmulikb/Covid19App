using Newtonsoft.Json;
using System;

namespace Covid19.Models
{
    public class Record
    {
        public int _id { get; set; }
        public DateTime תאריך { get; set; }
        public int מאושפזים { get; set; }
        public float אחוזנשיםמאושפזות { get; set; }
        
        public int גילממוצעמאושפזים { get; set; }
        public float סטייתתקןגילמאושפזים { get; set; }
        public string מונשמים { get; set; }
        public int אחוזנשיםמונשמות { get; set; }
        public int גילממוצעמונשמים { get; set; }
        public float סטייתתקןגילמונשמים { get; set; }
        public int חוליםקל { get; set; }
        public float אחוזנשיםחולותקל { get; set; }
        public int גילממוצעחוליםקל { get; set; }
        public float סטייתתקןגילחוליםקל { get; set; }
        public string חוליםבינוני { get; set; }
        public string אחוזנשיםחולותבינוני { get; set; }
        public string גילממוצעחוליםבינוני { get; set; }
        public string סטייתתקןגילחוליםבינוני { get; set; }
        public string חוליםקשה { get; set; }
        public float אחוזנשיםחולותקשה { get; set; }
        public int גילממוצעחוליםקשה { get; set; }
        public float סטייתתקןגילחוליםקשה { get; set; }
        public string חוליםקשהמצטבר { get; set; }
    }
}

