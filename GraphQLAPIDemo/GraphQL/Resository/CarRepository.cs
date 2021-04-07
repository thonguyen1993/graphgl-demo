using GrapGLDemo.Repository;
using GraphQLAPIDemo.GraphQL.Resository;
using GraphQLAPIExample.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLAPIDemo.Services
{
    public class CarRepository : MongoRepository<Car>, ICarRepository

    {
        public CarRepository(IMongoContext context) : base(context)
        {
        }
    }
}
