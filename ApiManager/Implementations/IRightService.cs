using Apimanager.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Apimanager.Implementations
{
    public interface IRightService
    {
        /// <summary>   
        /// Insere o json da direita no banco de dados.
        /// </summary>
        Task<object> InsertAsync(RightModel rightModel);
    }
}
