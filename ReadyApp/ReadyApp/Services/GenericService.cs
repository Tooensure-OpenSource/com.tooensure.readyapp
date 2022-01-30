using ReadyApp.Services.IService;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ReadyApp.Services
{
    public abstract class GenericService<T> : IGenericService<T> where T : class
    {

        public abstract Task<T?> Delete(string id);

        public abstract Task<T?> Get(string id);

        public abstract Task<IEnumerable<T>?> GetAll();

        public abstract Task<T?> Update(T model);
    }
}
