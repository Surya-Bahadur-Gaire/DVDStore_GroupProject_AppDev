using System.ComponentModel.DataAnnotations;

namespace DVDStore_GroupProject_AppDev.Models
{
    public class Producer
    {
        [Key]
        public int ProducerNumber { get; set; }
        public string ProducerName { get; set; }
        public ICollection<DVDTitle> DVDTitles { get; set; }
    }
}
