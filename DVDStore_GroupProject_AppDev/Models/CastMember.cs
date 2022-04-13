using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DVDStore_GroupProject_AppDev.Models
{
    public class CastMember
    {
        [Key]
        public int CastMemberId { get; set; }

        public int DVDNumber { get; set; }
        [ForeignKey("DVDNumber")]
        public DVDTitle DVDTitle { get; set; }

        public int ActorNumber { get; set; }
        [ForeignKey("ActorNumber")]
        public  Actor Actor { get; set; }
    }
}
