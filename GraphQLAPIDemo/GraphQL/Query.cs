using GraphQL.Types;
using GraphQLAPIDemo.Services;
using GraphQLAPIExample.Queries.Types;
using GraphQLAPIExample.Services;

namespace GraphQL.Sample.Api.GraphQL
{
    public class Query : ObjectGraphType
    {
        public Query( CarService2 service  )
        {

            Field<ListGraphType<CarType>>(
                 name: "cars",
                 resolve: context =>
                 {
                     return service.GetAll();
                 }
             );
            Field<CarType>(
                  name: "car",
                  arguments: new QueryArguments(new QueryArgument<StringGraphType> { Name = "id" }),
                  resolve: context =>
                  {
                      var id = context.GetArgument<string>("id");
                      return service.GetByIdAsync(id);
                  }
              );
        }
    }
}
