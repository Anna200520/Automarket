using System.Collections.Generic;
using System.Threading.Tasks;
using Automarket.Core.Entity;
using Automarket.Core.Response;
using Automarket.Core.ViewModels.Car;

namespace Automarket.Application.Interfaces
{
    public interface ICarService
    {
        Task<IBaseResponse<IEnumerable<Car>>> GetCars();
        
        Task<IBaseResponse<CarViewModel>> GetCar(int id);

        Task<IBaseResponse<CarViewModel>> CreateCar(CarViewModel carViewModel);

        Task<IBaseResponse<bool>> DeleteCar(int id);

        Task<IBaseResponse<Car>> GetCarByName(string name);

        Task<IBaseResponse<Car>> Edit(int id, CarViewModel model);
    }   
}