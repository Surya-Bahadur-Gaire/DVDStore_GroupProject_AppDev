using System.ComponentModel.DataAnnotations;

namespace DVDStore_GroupProject_AppDev.Models
{
    public class DVDCategory
    {
        [Key]
        public int CategoryNumber { get; set; }
        public string CategoryDescription { get; set; }
        public int AgeRestricted { get; set; }
        public ICollection<DVDTitle> DVDTitle { get; set; }
    }
}
