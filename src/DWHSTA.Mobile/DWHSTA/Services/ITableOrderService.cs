using System.Collections.Generic;
using System.Threading.Tasks;
using DWHSTA.Model;

namespace DWHSTA.Services
{
    public interface ITableOrderService
    {
        Task AddTableOrderAsync(TableOrder order);

        Task<IEnumerable<TableOrder>> GetTableOrdersAsync();
    }
}