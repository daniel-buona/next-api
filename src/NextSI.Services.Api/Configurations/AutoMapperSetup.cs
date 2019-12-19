﻿using System;
using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using NextSI.Application.Dto.AutoMapper;

namespace NextSI.Services.Api.Configurations
{
    public static class AutoMapperSetup
  {
      public static void AddAutoMapperSetup(this IServiceCollection services)
      {
          if (services == null) throw new ArgumentNullException(nameof(services));

          services.AddAutoMapper();
          AutoMapperConfig.RegisterMappings();
      }
  }
}