using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IStorageService<T>
    {
        Task<List<T>> Get();
        Task<T> Get(string id);
        Task<T> Add(T T);
        Task<T> Update(T T);
        Task<T> Delete(string id);
        Task<List<T>> GetAll(string id); 
        
    }
}