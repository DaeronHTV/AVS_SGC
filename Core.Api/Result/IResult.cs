using System.Net;

namespace Core.Api.Result
{
    public interface IResult<T> where T: IBaseObject
    {
        HttpStatusCode HttpCode { get; }

        T GetObjectResult { get; }
    }
}
