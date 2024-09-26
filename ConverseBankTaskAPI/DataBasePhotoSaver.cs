using ConverseBankTaskAPI.Controllers;
using ConverseBankTaskAPI.DBContext;
using ConverseBankTaskAPI.Interfaces;
using ConverseBankTaskAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ConverseBankTaskAPI
{
    public class DataBasePhotoSaver: IPhotoSaver
    {
        public string SaveData(byte[] PhotoInfo, string Destination) 
        {
            try
            {
                var DbContext = GeneralController.dbContext;
                DbContext.Photos.Add(new Photo { PhotoBinary = PhotoInfo });
                DbContext.SaveChanges();
                return "Success";
            }
            catch(Exception ex)
            {
                return $"Exception: {ex.Message}";
            }
            
        }
    }
}
