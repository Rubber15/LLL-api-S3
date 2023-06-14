using LLL_api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace LLL_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InformationController : ControllerBase
    {
        private readonly DbContext _context;
        private readonly InformationRepository dataBase;
        public InformationController(DBcontext context)
        {
            _context = context;
            dataBase = new InformationRepository(context);
        }

        // GET: DataController/Details/5
        [HttpGet]
        public List<InformationModel> Details()
        {
            return dataBase.GetAllInformation();
        }

        [HttpGet("{id}")]
        public InformationModel Details(int id)
        {
            return dataBase.GetInformationById(id);
        }

        [HttpPost]
        public void Post(InformationModel model)
        {
            dataBase.AddInformation(model);
        }

    }
}
