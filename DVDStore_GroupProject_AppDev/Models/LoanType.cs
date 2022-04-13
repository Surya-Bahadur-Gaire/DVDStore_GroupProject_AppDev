using System.ComponentModel.DataAnnotations;

namespace DVDStore_GroupProject_AppDev.Models
{
    public class LoanType
    {
        [Key]
        public int LoanTypeNumber { get; set; }
        public string LoanTypeName { get; set; }
        public string LoanDuration { get; set; }
        public ICollection<Loan> Loans { get; set; }
    }
}
