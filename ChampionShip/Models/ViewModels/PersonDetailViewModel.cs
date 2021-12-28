using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Intefaces.Implementation.Models;

namespace ChampionShip.Models.ViewModels
{
    public class PersonDetailViewModel
    {
        public int Code { get; set; }
        //Фамилия
        public string LastName { get; set; }
        // Имя
        public string Name { get; set; }
        // Отчество
        public string MiddleName { get; set; }
        // Пол
        public byte Sex { get; set; }
        // Дата рождения
        public DateTime? BirthDate { get; set; }
        // Номер паспорта
        public string PassportNumber { get; set; }
        // Кем Выдан
        public string PassportIssuedBy { get; set; }
        // Когда
        public DateTime? PassportIssuedDate { get; set; }
        // Место
        public string PassportIssuedPlace { get; set; }
        public byte IsCommand { get; set; }
        // Команда
        public int? Team { get; set; }
        public int? _tex { get; set; }
        public int? _texpr { get; set; }
        public int? _sport { get; set; }
        public int? _train { get; set; }
        public int? _judge { get; set; }
        public int? _zvan { get; set; }
        public int? _org { get; set; }
        // Тип карты
        public int? CardType { get; set; }
        // Номер карты
        public int? CardNumber { get; set; }
        // ЦБД Код
        public int? CBDCode { get; set; }
        // Взнос
        public int? Payment { get; set; }
        // Тренер
        public string Trainer { get; set; }
        // Ведомство
        public int? Department { get; set; }
        // Страна
        public int? Country { get; set; }
        // Родитель
        public string Parent { get; set; }
        // Код ЕРС
        public string CodeEPC { get; set; }
        public DateTime? Updated { get; set; }
    }
    public static partial class ViewModelMapperExtension
    {
        public static PersonDetailViewModel AsViewModel(this PersonDetailDto person)
        {
            return new PersonDetailViewModel()
            {
                BirthDate = person.BirthDate,
                CardNumber = person.CardNumber,
                CardType = person.CardType,
                CBDCode = person.CBDCode,
                Code = person.Code,
                CodeEPC = person.CodeEPC,
                Country = person.Country,
                Department = person.Department,
                IsCommand = person.IsCommand,
                LastName = person.LastName,
                MiddleName = person.MiddleName,
                Name = person.Name,
                Parent = person.Parent,
                PassportIssuedBy = person.PassportIssuedBy,
                PassportIssuedDate = person.PassportIssuedDate,
                PassportIssuedPlace = person.PassportIssuedPlace,
                PassportNumber = person.PassportNumber,
                Payment = person.Payment,
                Sex = person.Sex,
                Team = person.Team,
                Trainer = person.Trainer,
                Updated = person.Updated,
                _judge = person._judge,
                _org = person._org,
                _sport = person._sport,
                _tex = person._tex,
                _texpr = person._texpr,
                _train = person._train,
                _zvan = person._zvan
            };
        }
    }
}
