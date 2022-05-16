using ChargeProceesing.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChargeProceesing.API.Repository.IRepository
{
    public interface IPackRepository
    {
        ICollection<PackModel> GetPackProcessings();

        PackModel GetPackProcessing(int packProcessingID);
  
        bool PackProcessingExists(int id);

        bool CreatePackProcessing(PackModel packProcessing);
        bool UpdatePackProcessing(PackModel packProcessing);
   

        bool Save();
    }
}
