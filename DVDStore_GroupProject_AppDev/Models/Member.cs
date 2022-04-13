using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DVDStore_GroupProject_AppDev.Models
{
    public class Member
    {
        [Key]
        public int MemberNumber { get; set; }


        public int MembershipCategoryNumber { get; set; }
        [ForeignKey("MembershipCategoryNumber")]
        public MembershipCategory MembershipCategory { get; set; }

        public string MemberFirstName { get; set; }
        public string MemberLastName { get; set; }
        public string MemberAddress { get; set; }
        public DateTime MemberDOB { get; set; }
        public ICollection<Loan> Loans { get; set; }
    }
}
