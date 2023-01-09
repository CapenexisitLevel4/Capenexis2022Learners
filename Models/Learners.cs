using System.ComponentModel.DataAnnotations;

namespace Capenexis2022Learners.Models
{
    public class Learners
    {
        public int Id { get; set; }
        public string SurName { get; set; }
        public string FirstName { get; set; }
        public string NationalIdentityNumber { get; set; }
        public string Course { get; set; }
        public decimal Price { get; set; }
    }
}
