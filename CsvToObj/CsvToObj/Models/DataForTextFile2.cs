using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsvToObj.Models
{
    public class DataForTextFile2
    {
        public int Index { get; set; }

        public string Person { get; set; }

        public DayOfWeek WeekDay { get; set; }

        public string Activity { get; set; }
    }
}
