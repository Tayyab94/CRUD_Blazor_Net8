using IMS.CoreBusiness;
using IMS.UseCases.PlusinIterfaces;

namespace IMS.Plugins.InMemory
{
    public class InventoryRepository : IInventoryRepository
    {
        private List<Inventory> _inventory;
        public InventoryRepository()
        {
            _inventory = new List<Inventory>()
            {
                new Inventory()
                {
                    InventoryId = 1,
                     InventoryName="Bike",
                      Price=10,
                      Quantity=1,
                },
                  new Inventory()
                {
                    InventoryId = 2,
                     InventoryName="Moter Cycle",
                      Price=42,
                      Quantity=3,
                },
                    new Inventory()
                {
                    InventoryId = 3,
                     InventoryName="Baloone",
                      Price=4,
                      Quantity=12,
                },
                      new Inventory()
                {
                    InventoryId = 4,
                     InventoryName="Helocoptor",
                      Price=100,
                      Quantity=5,
                }
            };
        }

        public  Task AddInventoryAsycn(Inventory inventory)
        {
            if (_inventory.Any(s => s.InventoryName.Equals(inventory.InventoryName, StringComparison.OrdinalIgnoreCase)))
                return Task.CompletedTask;

            inventory.InventoryId=(_inventory.Max(s=>s.InventoryId) +1);
            _inventory.Add(inventory);
            return Task.CompletedTask;
        }

        public Task EditInventoryAsync(Inventory inventory)
        {
            // checking, Either this editable INVENTORY's name already exist into the db or not. if yes, then don't edit 
            if(_inventory.Any(s=>s.InventoryName.Equals(inventory.InventoryName,StringComparison.OrdinalIgnoreCase)))
                   return Task.CompletedTask;  

            var data=_inventory.FirstOrDefault(s=>s.InventoryId==inventory.InventoryId);
            if(data is not null)
            {
                data.InventoryName= inventory.InventoryName;
                data.Price= inventory.Price;
                data.Quantity= inventory.Quantity;  
            }

            return Task.CompletedTask;

        }

        public async Task<IEnumerable<Inventory>> GetInventoriesByName(string name)
        {
            if (string.IsNullOrEmpty(name)) return await Task.FromResult(_inventory);

            return _inventory.Where(s => s.InventoryName.Contains(name, StringComparison.OrdinalIgnoreCase));
        }

        public async Task<Inventory> GetInventoryById(int inventoryId)
        {
            var data = _inventory.First(s => s.InventoryId.Equals(inventoryId));

            var newInv = new Inventory
            {
                InventoryId = inventoryId,
                InventoryName = data.InventoryName,
                Price = data.Price,
                Quantity = data.Quantity,
            };
            return await Task.FromResult(newInv);

            //return await Task.FromResult(_inventory.First(s => s.InventoryId == inventoryId));
        }
    }
}
