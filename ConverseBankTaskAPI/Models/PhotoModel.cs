using System.ComponentModel.DataAnnotations;

namespace ConverseBankTaskAPI.Models
{
    public class PhotoModel
    {
        public string OperationMethod { get; set; }
        public byte[] PhotoByteArray { get; set; }
    }
}
