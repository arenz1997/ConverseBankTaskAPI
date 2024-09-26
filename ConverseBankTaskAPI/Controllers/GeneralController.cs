using ConverseBankTaskAPI.DBContext;
using ConverseBankTaskAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace ConverseBankTaskAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GeneralController : ControllerBase
    {
        string Path { get; set; }
        ApplicationDbContext dbContext { get; set; }


        public GeneralController(ApplicationDbContext context)
        {
            dbContext = context;            
            dbContext.Database.EnsureCreated();

            Path = AppDomain.CurrentDomain.BaseDirectory+"Image.jpg";
            
        }

        [HttpPost(Name = "SaveImage")]
        public string SaveImage(PhotoModel model)
        {
            if (ModelState.IsValid)
            {
                switch (model.OperationMethod)
                {
                    case "DB": dbContext.Photos.Add(new Photo { PhotoBinary = model.PhotoBinary }); dbContext.SaveChanges(); return "Success";
                    case "FS": System.IO.File.WriteAllBytes(Path, model.PhotoBinary); return "Success";
                    default: return "Unknown operation!!!";
                };
            }
            else
                return "Uncorrect input parameters!!!";
        }
    }
}