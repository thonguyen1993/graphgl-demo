
using GraphQL.Types;
using GraphQLAPIDemo.Services;
using GraphQLAPIExample.Entities;
using GraphQLAPIExample.Queries.Types;
using GraphQLAPIExample.Services;

namespace GraphQL.Sample.Api.GraphQL
{
    public class Mutation : ObjectGraphType
    {
        public Mutation(CarService2 service)
        {
            Field<CarType>(
              "createCar",
              arguments: new QueryArguments(new QueryArgument<NonNullGraphType<CarInputType>> { Name = "input" }),
              resolve: context =>
              {
                  var itemInput = context.GetArgument<Car>("input");
                  return service.AddLessonAsync(itemInput);
              }
          );

            Field<CarType>(
              "updateCar",
              arguments: new QueryArguments(new QueryArgument<NonNullGraphType<CarInputType>> { Name = "input" }),
              resolve: context =>
              {
                  var itemInput = context.GetArgument<Car>("input");
                  return service.UpdateLessonAsync(itemInput.Id, itemInput);
              }
          );
        }


    }
}