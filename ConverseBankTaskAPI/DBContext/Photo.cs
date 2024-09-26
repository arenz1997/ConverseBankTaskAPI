using System.ComponentModel.DataAnnotations;

namespace ConverseBankTaskAPI.DBContext
{
    public class Photo
    {
        [Key]
        public int Id { get; set; }
        public byte[] PhotoBinary { get; set; }
    }
}
