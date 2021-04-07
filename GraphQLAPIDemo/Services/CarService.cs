
using GraphQLAPIExample.Entities;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLAPIExample.Services
{
    public class CarService
    {
        String dbName = "CarGalleryDb";
        private readonly IMongoCollection<Car> cars;

        public CarService(IConfiguration config)
        {
            MongoClient client = new MongoClient(config.GetConnectionString(dbName));
            IMongoDatabase database = client.GetDatabase(dbName);
            cars = database.GetCollection<Car>("Cars");
        }

        public List<Car> GetAll()
        {
            return cars.Find(car => true).ToList();
        }

        public Car Get(String id) {
            return cars.Find(car => car.Id == id).FirstOrDefault();
        }

        public Car Create(Car car) {
            cars.InsertOne(car);
            return car;
        }

        public Car Update(string id, Car carIn) {
            cars.ReplaceOne(car => car.Id == id, carIn);
            return carIn;
        }

        public Car remove(Car carIn)
        {
            cars.DeleteOne(car => car.Id == carIn.Id);
            return carIn;
        }
        public void remove(string id)
        {
            cars.DeleteOne(car => car.Id == id);
        }
    }
}
