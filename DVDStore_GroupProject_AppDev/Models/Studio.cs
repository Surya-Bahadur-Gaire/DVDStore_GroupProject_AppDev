using System.ComponentModel.DataAnnotations;

namespace DVDStore_GroupProject_AppDev.Models
{
    public class Studio
    {
        [Key]
        public int StudioNumber { get; set; }
        public string StudioName { get; set; }
        public ICollection<DVDTitle> DVDTitles { get; set; }
    }
}
