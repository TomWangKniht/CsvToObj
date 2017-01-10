using CsvToObj.Models;
using CsvToObj.Service.Api;
using CsvToObj.Service.BASE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsvToObj.Service.Impl
{
    public class TestParseServiceTextFile2 : ATestParseServiceBase<DataForTextFile2>
    {
        protected override IParseService<DataForTextFile2> getNewParseService()
            => new ParseServiceTextFile2();

    }
}
