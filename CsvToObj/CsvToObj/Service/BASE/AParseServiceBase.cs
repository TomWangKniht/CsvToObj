using CsvToObj.Service.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsvToObj.Service.BASE
{

    public abstract class AParseServiceBase<T> : IParseService<T>
    {
        public IEnumerable<T> process(IEnumerable<string> lines, out String msg)
        {
            msg = String.Empty;
            lines = lines.Where(o => o.Length != 0);
            if (lines.Count() == 0)
            {
                msg = "資料數量為0";
                return null;
            }
            if (!check(lines))
            {
                msg = "格式檢查失敗";
                return null;
            }
            var result = parseDatas(lines, out msg);
            if (String.IsNullOrEmpty(msg))
            {
                msg = "處理成功";
            }
            return result;
        }

        protected Boolean check(IEnumerable<string> lines) => lines.All(checkCount);

        protected abstract int DataCount { get; }
        protected Boolean checkCount(string line) => line.Split(',') != null && line.Split(',').Count() == DataCount;

        protected IEnumerable<T> parseDatas(IEnumerable<string> lines, out string msg)
        {
            msg = String.Empty;
            var resultList = new List<T>();
            try
            {
                foreach (var item in lines)
                {
                    resultList.Add(parseData(item));
                }
            }
            catch (Exception ex)
            {
                resultList = null;
                msg = ex.Message;
            }
            return resultList;
        }
        protected abstract T parseData(string line);
    }

}
