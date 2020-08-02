using Apimanager.Dao;
using Apimanager.Model.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Apimanager.Implementations
{
    public class JsonService : IJsonService
    {
        private readonly IBaseDao _connection;

        public JsonService(IBaseDao connection)
        {
            _connection = connection;
        }

        /// <summary>   
        /// Query de busca de todos os conjuntos de json no banco de dados.
        /// </summary>
        public async Task<IEnumerable<object>> GetAllAsync()
        {
            var res = await _connection.QueryAsync<IEnumerable<JsonModel>>(@"SELECT r.json as ""RigthJson"", l.json as ""LeftJson"", l.id as ""IdLeft"", r.id as ""IdRight"" 
                                                                            FROM public.rightdiff as r INNER JOIN
                                                                            public.leftdiff as l ON r.idleft = l.id ");
            return res.ToList();
        }

        /// <summary>   
        /// Query de busca do conjuntos de json de um especifico id no banco de dados.
        /// </summary>
        public async Task<IEnumerable<JsonModel>> GetDiffsById(int id)
        {
            var res = await _connection.QueryAsync<IEnumerable<JsonModel>>(@$"SELECT r.json as ""RigthJson"", l.json as ""LeftJson"", l.id as ""IdLeft"", r.id as ""IdRight"" 
                                                                            FROM public.rightdiff as r INNER JOIN
                                                                            public.leftdiff as l ON r.idleft = l.id WHERE idleft = {id}");
            return CastJsonModel(res);
        }

        public static IEnumerable<JsonModel> CastJsonModel(IEnumerable<dynamic> query)
        {
            return query.Select(x => new JsonModel()
            {
                LeftJson = x.LeftJson,
                RightJson = x.RigthJson
            }).ToList();
        }
    }
}
