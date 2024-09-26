using ConverseBankTaskAPI.DBContext;
using ConverseBankTaskAPI.Interfaces;
using ConverseBankTaskAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace ConverseBankTaskAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GeneralController : ControllerBase
    {
        string Path { get; set; }
        public static ApplicationDbContext dbContext { get; set; }


        public GeneralController(ApplicationDbContext context)
        {
            dbContext = context;            
            dbContext.Database.EnsureCreated();

            Path = AppDomain.CurrentDomain.BaseDirectory+"Image.jpg";
        }

        [HttpPost(Name = "SaveImage")]
        public string SaveImage(PhotoModel model)
        {
            IPhotoSaverFactory PhotoSaverFactory;

            if (ModelState.IsValid)
            {
                switch (model.OperationMethod)
                {
                    case "DB": PhotoSaverFactory = new DataBasePhotoSaverFactory(); break;

                    case "FS": PhotoSaverFactory = new FileStreamPhotoSaverFactory(); break;
                    default: return "Unknown operation!!!";
                };
            }
            else
                return "Uncorrect input parameters!!!";

            IPhotoSaver PhotoSaver = PhotoSaverFactory.CreatePhotoSaver();
            return PhotoSaver.SaveData(model.PhotoByteArray, Path);

        }
    }
}