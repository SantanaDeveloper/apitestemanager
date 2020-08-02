using Apimanager.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Apimanager.Implementations
{
    public interface ILeftService
    {
        /// <summary>   
        /// Insere o json da esquerda no banco de dados.
        /// </summary>
        Task<object> InsertAsync(LeftModel leftModel);
       
    }
}
