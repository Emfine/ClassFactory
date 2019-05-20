using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Iguana.Data
{
    public class ResponseResult<T>
    {
        public T Data { get; set; }
        public int Status { get; set; }
        public string Message { get; set; }
        public ResponseResult()
        {
            Status = (int)EnumResponseStatusType.Failue;
        }
        public ResponseResult(T data)
        {
            Data = data;
            Status = (int)EnumResponseStatusType.Failue;
        }
    }
}