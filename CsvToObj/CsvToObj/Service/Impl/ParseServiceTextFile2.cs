using CsvToObj.Models;
using CsvToObj.Service.BASE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsvToObj.Service.Impl
{
    public class ParseServiceTextFile2 : AParseServiceBase<DataForTextFile2>
    {
        protected override int DataCount => 4;

        protected override DataForTextFile2 parseData(string line)
        {
            var arr = line.Split(',');
            var result = new DataForTextFile2
            {
                Index = Convert.ToInt32(arr[0]),
                Person= arr[1],
                WeekDay = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), arr[2]),
                Activity = arr[3],
        };
            return result;
        }
    }
}
