using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Entities.Models;
using MySqlConnector;
using Parser.Infrastructure;
using Parser.Interfaces;

namespace Parser.Implementation
{
    public class DisciplineFormService:IDisciplineFormService
    {
        public  List<Discipline> GetList()
        {
            using IDbConnection db = new MySqlConnection(AppConnection.ConnectionStringSettings);
            if (db.State == ConnectionState.Closed)
            {
                db.Open();
            }
            var disciplines =  db.Query<Discipline>("CALL spGetAllDiscipline", commandType: CommandType.Text);
            return disciplines.ToList();

        }

        public Discipline Get(int id)
        {
            using IDbConnection db = new MySqlConnection(AppConnection.ConnectionStringSettings);
            if (db.State == ConnectionState.Closed)
            {
                db.Open();
            }
            var discipline =  db.QueryFirstOrDefault<Discipline>(" spGetDisciplineById", new {id = id}, commandType: CommandType.StoredProcedure);
            return discipline;
        }

        public Discipline Get(string name)
        {
            using IDbConnection db = new MySqlConnection(AppConnection.ConnectionStringSettings);
            if (db.State == ConnectionState.Closed)
            {
                db.Open();
            }
            var discipline = db.QueryFirstOrDefault<Discipline>($"spGetDisciplineByName",
                new{name = name}, commandType: CommandType.StoredProcedure);
            return discipline;
        }
    }
}
