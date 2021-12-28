using System.Collections.Generic;
using DocumentFormat.OpenXml.Office2010.ExcelAc;
using Entities.Models;

namespace Parser.Interfaces
{
    public interface IPersonFormService
    {
        public string Create(Person teamToCreate);
        public void CreateMember(Person memberToCreate);
    }
}