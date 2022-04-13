using System.ComponentModel.DataAnnotations;

namespace DVDStore_GroupProject_AppDev.Models
{
    public class MembershipCategory
    {
        [Key]
        public int MembershipCategoryNumber { get; set; }
        public string MembershipCategoryDescription { get; set; }
        public string MembershipCategoryTotalLoans { get; set; }
        public ICollection<Member> Members { get; set; }

    }
}
