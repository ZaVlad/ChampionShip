using Entities.Models;

namespace Parser.Interfaces
{
    public interface IOkatoFormService
    {
        public Okato GetByAbbreviatedName(string name);
        public Okato GetByName(string name);
    }
}