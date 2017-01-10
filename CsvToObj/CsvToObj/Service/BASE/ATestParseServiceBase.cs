using CsvToObj.Service.Api;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsvToObj.Service.BASE
{
    public abstract class ATestParseServiceBase<T> : ITestParseServiceBase
    {
        protected abstract IParseService<T> getNewParseService();
        public void process(String fileName)
        {
            var service = getNewParseService();
            var lines = File.ReadAllLines(Properties.Settings.Default.Path + fileName);
            String msg;
            var result = service.process(lines, out msg);
            Console.WriteLine("執行結果:" + msg);
            if (result != null&&result.Count()>0)
            {
                Console.WriteLine("轉換結果如下:");
                foreach (var item in result)
                {
                    Console.WriteLine(showResultStr(item));
                    Console.WriteLine();
                }
            }

        }

        protected virtual string showResultStr(T data)
        {
            return JsonConvert.SerializeObject(data);
        }
    }
}
