using System.Collections.Generic;
using System.Threading.Tasks; 

namespace Application.Interfaces
{
    public interface IDictionaryService<T>
    {
         Task<List<T>> Get();
         Task<string[]> GetNames();
         Task<T> Get(string shortName);
         Task ToJson();
         Task<List<T>> GetFromJson();
         Task<string[]> GetDiagsFromJson();
         Task<string[]>  GetDDiagsFromJson();
    }
}