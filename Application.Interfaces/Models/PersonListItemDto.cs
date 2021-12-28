using System;

namespace Intefaces.Implementation.Models
{
    public class PersonListItemDto
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
}
