using System.Collections.Generic;

namespace CsvToObj.Service.Api
{
    public interface IParseService<T>
    {
        IEnumerable<T> process(IEnumerable<string> lines, out string msg);
    }
}