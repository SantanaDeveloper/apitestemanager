using Apimanager.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Apimanager.Implementations
{
    public interface IJsonService
    {
        /// <summary>   
        /// Busca todos os conjuntos de Json no banco de dados
        /// </summary>
        Task<IEnumerable<object>> GetAllAsync();

        /// <summary>   
        /// Compara o conjunto de json do id informado.
        /// </summary>
        Task<IEnumerable<JsonModel>> GetDiffsById(int id);


    }
}
