using ChargeProceesing.API.Data;
using ChargeProceesing.API.Models;
using ChargeProceesing.API.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChargeProceesing.API.Repository
{
    public class PackRepository : IPackRepository
    {
        private readonly ApplicationDbContext _db;

        public PackRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public bool CreatePackProcessing(PackModel packProcessing)
        {
            _db.PackModels.Add(packProcessing);
            return Save();
        }

    

        public PackModel GetPackProcessing(int packProcessingID)
        {
            return _db.PackModels.FirstOrDefault(e => e.requestId == packProcessingID);
        }

        public ICollection<PackModel> GetPackProcessings()
        {
            return _db.PackModels.OrderBy(a => a.requestId).ToList();
        }

        public bool PackProcessingExists(int id)
        {
            return _db.PackModels.Any(a => a.requestId == id);
        }

        public bool Save()
        {
            return _db.SaveChanges() >= 0 ? true : false;
        }

        public bool UpdatePackProcessing(PackModel packProcessing)
        {
            _db.PackModels.Update(packProcessing);
            return Save();
        }
    }
}
