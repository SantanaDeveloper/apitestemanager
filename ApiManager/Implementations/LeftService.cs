using Apimanager.Dao;
using Apimanager.Model.Entities;
using System;
using System.Threading.Tasks;

namespace Apimanager.Implementations
{
    public class LeftService : ILeftService
    {
        private readonly IBaseDao _connection;

        public LeftService(IBaseDao connection)
        {
            _connection = connection;
        }

        public async Task<object> InsertAsync(LeftModel leftModel)
        {
            if (leftModel == null)
                throw new ArgumentException("O valor de 'LeftModel' não pode ser nulo");

            var insertedId = await _connection.Insert(leftModel);
            return insertedId;
        }
    }
}
