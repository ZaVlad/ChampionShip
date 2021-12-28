using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Intefaces.Implementation.Models;

namespace ChampionShip.Models.ViewModels
{
    public class PersonListItemViewModel
    {
        public int Code { get; set; }
        public string LastName { get; set; }
        public string Name { get; set; }
        public string MiddleName { get; set; }
        public byte Sex { get; set; }
        public DateTime? BirthDate { get; set; }
        public byte IsCommand { get; set; }
        public int? Team { get; set; }
        public int? Country { get; set; }
        public string Parent { get; set; }
    }
    public static partial class ViewModelMapperExtension
    {
        public static PersonListItemViewModel AsViewModel(this PersonListItemDto person)
        {
            return new PersonListItemViewModel()
            {
                Code = person.Code,
                BirthDate = person.BirthDate,
                Country = person.Country,
                IsCommand = person.IsCommand,
                LastName = person.LastName,
                MiddleName = person.MiddleName,
                Name = person.Name,
                Parent = person.Parent,
                Sex = person.Sex,
                Team = person.Team
            };
        }
    }
}
