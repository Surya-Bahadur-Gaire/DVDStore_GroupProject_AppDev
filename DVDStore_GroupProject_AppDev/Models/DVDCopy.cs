using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DVDStore_GroupProject_AppDev.Models
{
    public class DVDCopy
    {
        [Key]
        public int CopyNumber { get; set; }

        public int DVDNumber { get; set; }
        [ForeignKey("DVDNumber")]
        public DVDTitle DVDTitle { get; set; }

        public DateTime DatePurchased { get; set; }
        public ICollection<Loan> Loans { get; set; }
    }
}
