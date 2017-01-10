using Newtonsoft.Json;
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
    public class TestParseServiceTextFile1 : ATestParseServiceBase<DataForTextFile1>
    {
        protected override IParseService<DataForTextFile1> getNewParseService()
            => new ParseServiceTextFile1();

    }
}
