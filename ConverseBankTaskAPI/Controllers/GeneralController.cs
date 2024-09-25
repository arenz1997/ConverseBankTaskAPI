using ConverseBankTaskAPI.DataBaseContext;
using ConverseBankTaskAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace ConverseBankTaskAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GeneralController : ControllerBase
    {
        string Path { get; set; }
        Context dbContext { get; set; }


        public GeneralController(Context context)
        {
            dbContext = new Context();
            dbContext.Database.EnsureCreated();

            Path = AppDomain.CurrentDomain.BaseDirectory;
            
        }

        [HttpPost(Name = "GetImage")]
        public string Post(OperationModel model)
        {
            return "Success";
        }
    }
}
