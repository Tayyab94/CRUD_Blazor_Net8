using IMS.CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.UseCases.PlusinIterfaces
{
    public interface IInventoryRepository
    {
        Task<IEnumerable<Inventory>> GetInventoriesByName(string name);

        Task AddInventoryAsycn(Inventory inventory);

        Task EditInventoryAsync(Inventory inventory);
        Task<Inventory> GetInventoryById(int inventoryId);
    }
}
