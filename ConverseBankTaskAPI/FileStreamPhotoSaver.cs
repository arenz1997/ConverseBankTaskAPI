using ConverseBankTaskAPI.DBContext;
using ConverseBankTaskAPI.Interfaces;
using ConverseBankTaskAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ConverseBankTaskAPI
{
    public class FileStreamPhotoSaver : IPhotoSaver
    {
        public string SaveData(byte[] PhotoInfo, string Destination) 
        {
            try
            {
                System.IO.File.WriteAllBytes(Destination, PhotoInfo);
                return "Success";
            }
            catch (Exception ex)
            {
                return $"Exception: {ex.Message}";
            }
        }
    }
}
