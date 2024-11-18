using System.Threading.Tasks;
using Automarket.Core.Entity;

namespace Automarket.Infrastructure.Interfaces
{
    public interface ICarRepository : IBaseRepository<Car>
    {
        Task<Car> GetByName(string name);
    }
}