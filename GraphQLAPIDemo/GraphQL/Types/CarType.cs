using GraphQL.Types;
using GraphQLAPIExample.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLAPIExample.Queries.Types
{
    public class CarType : ObjectGraphType<Car>
    {
        public CarType()
        {
            Field(x => x.Id).Description("Id của xe");
            Field(x => x.Brand).Description("Thương hiệu xe");
            Field(x => x.Model).Description("Loại xe");
            Field(x => x.Year).Description("Năm sản xuất");
            Field(x => x.Price).Description("Giá bán");
            Field(x => x.ImageUrl).Description("Ảnh xe");
        }
    }

    public class CarInputType : InputObjectGraphType<Car>
    {
        public CarInputType()
        {
            Field(x => x.Id,true).Description("Id của xe");
            Field(x => x.Brand).Description("Thương hiệu xe");
            Field(x => x.Model).Description("Loại xe");
            Field(x => x.Year).Description("Năm sản xuất");
            Field(x => x.Price).Description("Giá bán");
            Field(x => x.ImageUrl).Description("Ảnh xe");
        }
    }
}
