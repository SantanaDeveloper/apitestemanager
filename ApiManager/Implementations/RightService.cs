using Apimanager.Dao;
using Apimanager.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Apimanager.Implementations
{
    public class RightService : IRightService
    {
        private readonly IBaseDao _connection;

        public RightService(IBaseDao connection)
        {
            _connection = connection;
        }
        public async Task<object> InsertAsync(RightModel rightModel)
        {
            if (rightModel == null)
                throw new ArgumentException("O valor de 'RightModel' não pode ser nulo");

            var insertedId = await _connection.Insert(rightModel);
            return insertedId;
        }
    }
}
