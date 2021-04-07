using GrapGLDemo.Repository;
using GraphQLAPIExample.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLAPIDemo.GraphQL.Resository
{
    public interface ICarRepository: IRepository<Car>
    {
    }
}
