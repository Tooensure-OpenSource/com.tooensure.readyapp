using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ReadyApp.Services.IService
{
    public interface IGenericService<T> where T : class
    {
        Task<T?> Get(string id);
        Task<IEnumerable<T>?> GetAll();
        Task<T?> Delete(string id);
        Task<T?> Update(T model);
    }
}
