using CsvToObj.Models;
using CsvToObj.Service.BASE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CsvToObj.Service.Impl
{
    public class ParseServiceTextFile1 : AParseServiceBase<DataForTextFile1>
    {
        protected override int DataCount => 3;

        protected override DataForTextFile1 parseData(string line)
        {
            var strs = line.Split(',');
            var result = new DataForTextFile1
            {
                Index = Convert.ToInt32(strs[0]),
                English = strs[1],
                Chinese = strs[2],
            };
            return result;
        }
    }
}
