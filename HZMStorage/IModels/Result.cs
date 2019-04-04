using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HZMStorage.Models
{
    public class Result<T> where T : class,new()
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public T Data { get; set; }

        public Result(bool IsSuccess,string Message,T Data = null)
        {
            this.IsSuccess = IsSuccess;
            this.Message = Message;
            this.Data = Data;
        }
    }
}
