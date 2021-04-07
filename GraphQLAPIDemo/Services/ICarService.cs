using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQLAPIExample.Entities;

namespace GraphQLAPIDemo.Services
{
    public interface ICarService
    {
        Task<GraphQLAPIExample.Entities.Car> AddLessonAsync(Car obj);
        Task<Car> UpdateLessonAsync(string id, Car obj);
        Task<bool> RemoveLessonAsync(string id);
        Task<Car> GetByIdAsync(string id);
        Task<IEnumerable<Car>> GetAll();
    }
}
