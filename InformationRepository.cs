using LLL_api.Models;
using Microsoft.EntityFrameworkCore;

namespace LLL_api
{
    public class InformationRepository
    {
        private readonly DBcontext _context;

        public InformationRepository(DBcontext context)
        {
            _context = context;
        }

        public List<InformationModel> GetAllInformation()
        {
            return _context.Information.ToList();
        }

        public InformationModel GetInformationById(int id)
        {
            return _context.Information.FirstOrDefault(info => info.InfromationID == id);
        }


        public void AddInformation(InformationModel information)
        {
            _context.Information.Add(information);
            _context.SaveChanges();
        }
    }
}
