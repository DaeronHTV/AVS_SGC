using System.Threading.Tasks;

namespace Core.Api.DAO
{
    public interface IDAO<T> where T: IBaseObject
    {
        Task<bool> Create(T objet);

        T Delete(string id);

        bool Update(T objet, string id);

        T Read(string id);
    }
}
