using GraphQLAPIDemo.GraphQL.Resository;
using GraphQLAPIExample.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLAPIDemo.Services
{
    public class CarService2 : ICarService
    {
        private ICarRepository _lessonRepository;
        public CarService2(ICarRepository lessonRepository)
        {
            _lessonRepository = lessonRepository;
        }
        public async Task<Car> AddLessonAsync(Car obj)
        {
            return await _lessonRepository.Add(obj);
        }

        public async Task<IEnumerable<Car>> GetAll()
        {
            return await _lessonRepository.GetAll();
        }

        public async Task<Car> GetByIdAsync(string id)
        {
            return await _lessonRepository.GetById(id);
        }

        public async Task<bool> RemoveLessonAsync(string id)
        {
            return await _lessonRepository.Remove(id);
        }

        public async Task<Car> UpdateLessonAsync(string id, Car obj)
        {
            return await _lessonRepository.Update(id, obj);
        }
    }
}
