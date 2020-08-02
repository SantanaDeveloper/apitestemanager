using Microsoft.Extensions.Configuration;
using Npgsql;

namespace Apimanager.Dao.DbConnections
{
    /// <summary>
    /// Classe usada para fazer conexões no banco de dados
    /// </summary>
    public class PostgreeBaseDao : BaseDao
    {
        private readonly IConfiguration _configuration;
        private readonly string _connectionString;

        public PostgreeBaseDao(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionString = _configuration.GetConnectionString("DataAccessPostgreSqlProvider");
        }

        /// <summary>
        /// Valide se a conexão foi criada
        /// </summary>
        /// <returns>Retorna um valor booleano se a conexão for válida</returns>
        public override bool IsValidConnection()
        {
            return Connection != null && (Connection is NpgsqlConnection);
        }

        /// <summary>
        /// Seta uma conexão
        /// </summary>
        public override void SetConnection()
        {
            Connection = new NpgsqlConnection(_connectionString);
        }
    }
}