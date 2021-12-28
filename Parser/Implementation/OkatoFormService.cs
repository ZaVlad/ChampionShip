using System.Data;
using System.Linq;
using Dapper;
using Entities.Models;
using MySqlConnector;
using Parser.Infrastructure;
using Parser.Interfaces;

namespace Parser.Implementation
{
    public class OkatoFormService:IOkatoFormService
    {
        public Okato GetByAbbreviatedName(string name)
        {
            using IDbConnection db = new MySqlConnection(AppConnection.ConnectionStringSettings);
            if (db.State == ConnectionState.Closed)
            {
                db.Open();
            }
            var okato = db.QueryFirstOrDefault<Okato>("spGetOkatoByAbbreviatedName",new{name = name}, commandType: CommandType.StoredProcedure);
            return okato;
        }

        public Okato GetByName(string name)
        {
            using IDbConnection db = new MySqlConnection(AppConnection.ConnectionStringSettings);
            if (db.State == ConnectionState.Closed)
            {
                db.Open();
            }
            var okato = db.QueryFirstOrDefault<Okato>("spGetOkatoByName", new { name = name }, commandType: CommandType.StoredProcedure);
            return okato;
        }
    }
}