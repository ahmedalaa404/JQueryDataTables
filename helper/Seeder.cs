using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System;
using JQueryDataTables.Models;
using System.Linq.Dynamic.Core;
using Microsoft.AspNetCore.Builder;
using System.IO;
using Microsoft.CodeAnalysis;
using System.IdentityModel.Tokens.Jwt;

namespace JQueryDataTables.helper
{
    public static class Seeder
    {
        public static void SeedFromJson(IApplicationBuilder x)
        {
           
          var Context =  x.ApplicationServices.CreateScope().ServiceProvider.GetService<ApplicationsDBContext>();

            var serializer = new JsonSerializer();

            if (! (Context.Customers.Any()))
            {
                using StreamReader reader = new(@"DatSeeder.json");
                using var textReader = new JsonTextReader(reader) ;
                var Customers = serializer.Deserialize<List<Customer>>(textReader);
                Context.Customers.AddRange(Customers);
                Context.SaveChanges();
            }
            



        }


    }
}
