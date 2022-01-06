﻿using Mapster;
using StoreManager.Infrastructure.Identity.Models;
using StoreManager.Shared.DTOs.Identity;

namespace StoreManager.Infrastructure.Mappings
{
    public class MapsterSettings
    {
        public static void Configure()
        {
            // here we will define the type conversion / Custom-mapping
            // More details at https://github.com/MapsterMapper/Mapster/wiki/Custom-mapping
            TypeAdapterConfig<ApplicationRoleClaim, PermissionDto>.NewConfig().Map(dest => dest.Permission, src => src.ClaimValue);
        }
    }
}