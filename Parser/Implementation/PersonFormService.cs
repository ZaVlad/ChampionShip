using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;
using Entities.Models;
using MySqlConnector;
using Parser.Infrastructure;
using Parser.Interfaces;

namespace Parser.Implementation
{
    public class PersonFormService:IPersonFormService
    {
        public string Create(Person teamToCreate)
        {
            using IDbConnection db = new MySqlConnection(AppConnection.ConnectionStringSettings);
            if (db.State == ConnectionState.Closed)
            {
                db.Open();
            }

            var teamNumber = teamToCreate.Team;
            teamToCreate.Team = 0;
              db.Query("sp_CreateTeam", new{_org = teamToCreate._org,LastName = teamToCreate.LastName,
                IssuedPlace = teamToCreate.IssuedPlace,IssuedBy = teamToCreate.IssuedBy,Trainer = teamToCreate.Trainer}, commandType: CommandType.StoredProcedure);

              var id = db.QueryFirstOrDefault<int>("CALL spGetLastPersonInTable", CommandType.Text);
            return id+" "+ teamNumber;
        }

        public void CreateMember(Person memberToCreate)
        {
            using IDbConnection db = new MySqlConnection(AppConnection.ConnectionStringSettings);
            if (db.State == ConnectionState.Closed)
            {
                db.Open();
            }

            db.Query("sp_CreateMember", new
            {
                Name = memberToCreate.Name, LastName = memberToCreate.LastName, MiddleName = memberToCreate.MiddleName,
                BirthDate = memberToCreate.BirthDate, Team = memberToCreate.Team
            }, commandType: CommandType.StoredProcedure);
        }
    }
}