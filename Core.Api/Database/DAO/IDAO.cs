using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Api.Database.DAO
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
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
        Task<T> Delete(Guid id);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="objet"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<bool> Update(T objet, Guid id);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<T> Read(Guid id);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<bool> Contains(Guid id);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nbPerPage"></param>
        /// <returns></returns>
        IList<T> ReadAll(int nbPerPage = 10);
    }
}
