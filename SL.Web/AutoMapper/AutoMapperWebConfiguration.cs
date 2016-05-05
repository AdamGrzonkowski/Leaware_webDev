using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using SL.Core.Domain.Orders;
using SL.Core.Domain.Users;
using SL.Model.Models.Orders;
using SL.Model.Models.Users;

namespace Sklep_Leaware.AutoMapper
{
    public static class AutoMapperWebConfiguration
    {
        public static void Configure()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Register, Users>();
                cfg.CreateMap<Login, Users>();
                cfg.CreateMap<Cart, ShoppingCart>();
            });
        }
    }
}
