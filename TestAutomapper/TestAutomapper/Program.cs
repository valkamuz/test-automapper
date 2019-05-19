using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAutomapper.Classes;

namespace TestAutomapper
{
    class Program
    {
        static void Main(string[] args)
        {
            var config = new MapperConfiguration(cfg => { cfg.CreateMap<AuthorModel, AuthorDTO>(); });

            IMapper iMapper = config.CreateMapper();
            AuthorModel source = new AuthorModel
            { 
                Id          = 1,
                FirstName   = "Иван",
                LastName    = "Иванович",
                Address     = "Тюмень"
            };
            AuthorDTO destination = iMapper.Map<AuthorModel, AuthorDTO>(source);
            Console.WriteLine(destination.FirstName);
        }
    }
}
