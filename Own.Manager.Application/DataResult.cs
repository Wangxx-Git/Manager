using Own.Manager.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Own.Manager
{
    public class DataResult<T> where T : class
    {
        public DataResult()
        {

        }

        public DataResult(EnumResultCode code, string msg, T data)
        {
            Code = code;
            Msg = msg ?? code.ToString();
            Data = data;
        }

        public EnumResultCode Code { get; set; }

        public string Msg { get; set; }

        public T Data { get; set; }


    }
    public class PageInputDto
    {
        /// <summary>
        /// 页码
        /// </summary>
        public int Page { get; set; }

        /// <summary>
        /// 页大小
        /// </summary>
        public int Rows { get; set; }

        /// <summary>
        /// 排序字段
        /// </summary>
        public string Sort { get; set; }
        /// <summary>
        /// 排序方式
        /// </summary>
        public string Order { get; set; }

        public int SkipCount => (Page - 1) * Rows;

    }

    public class PageOutputDto<T> where T : class
    {
        public int Total { get; set; }

        public List<T> Rows { get; set; }
    }
}
