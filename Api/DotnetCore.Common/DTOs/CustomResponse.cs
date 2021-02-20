using DotnetCore.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetCore.Common.DTOs
{
    public class CustomResponse<T> where T : class
    {
        public bool Result { get; set; }
        public string Message { get; set; }
        public T Data { get; set; }
        public TokenDTO AccessToken { get; set; }
        public ResponseResult ResultCode { get; set; }

        public CustomResponse(bool result, string message, T data, ResponseResult resultCode = 0)
        {
            Data = data;
            Result = result;
            Message = message;
            ResultCode = resultCode;
        }

        public CustomResponse(bool result, T data, ResponseResult resultCode = 0)
        {
            Data = data;
            Result = result;
            ResultCode = resultCode;
        }

        public CustomResponse(bool result, string message, T data, TokenDTO accessToken, ResponseResult resultCode = 0)
        {
            Data = data;
            Result = result;
            Message = message;
            AccessToken = accessToken;
            ResultCode = resultCode;
        }

        public CustomResponse(bool result, T data, TokenDTO accessToken, ResponseResult resultCode = 0)
        {
            Data = data;
            Result = result;
            AccessToken = accessToken;
            ResultCode = resultCode;
        }
    }
}
