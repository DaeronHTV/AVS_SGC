using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Api.DAO
{
    public interface IDAO<T> where T: IBaseObject
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="objet"></param>
        /// <returns></returns>
        Task<bool> Create(T objet);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<T> Delete(string id);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="objet"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<bool> Update(T objet, string id);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<T> Read(string id);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool Contains(string id);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nbPerPage"></param>
        /// <returns></returns>
        IList<T> ReadAll(int nbPerPage = 10);
    }
}
