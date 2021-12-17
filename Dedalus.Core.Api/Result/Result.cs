using Microsoft.AspNetCore.Mvc;
using System;
using System.Net;

namespace Core.Api.Result
{
    public class Result<T> : ActionResult, IResult<T> where T : BaseObject
    {
        public Result()
        {

        }

        public HttpStatusCode HttpCode => throw new NotImplementedException();

        public T GetObjectResult => throw new NotImplementedException();
    }
}
