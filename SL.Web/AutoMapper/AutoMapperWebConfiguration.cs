using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using SL.Core.Domain;
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
            });
        }
    }
}
