using AutoMapper;
using CurrencyExchange.Entities;
using CurrencyExchange.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CurrencyExchange
{
    public class AutoMapperConfig
    {
        public static void Configure()
        {
            Mapper.Initialize(x =>
            {
                Mapper.CreateMap<Post, PostModel>();
                Mapper.CreateMap<PostModel, Post>();
            });
        }
    }
}