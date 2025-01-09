﻿// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


using System.Collections.Generic;
using IdentityServer4;
using IdentityServer4.Models;

namespace CoffeeStation.IdentityServer
{
    public static class Config
    {
        public static IEnumerable<ApiResource> ApiResources =>
            new ApiResource[]
            {
                new ApiResource("ResourceCatalog")
                {
                    Scopes = { "CatalogFullPermission", "CatalogReadPermission" },
                },
                new ApiResource("ResourceDiscount") { Scopes = { "DiscountFullPermission" } },
                new ApiResource("ResourceOrder") { Scopes = { "OrderFullPermission" } },
                new ApiResource(IdentityServerConstants.LocalApi.ScopeName),
            };

        public static IEnumerable<IdentityResource> IdentityResources =>
            new IdentityResource[]
            {
                new IdentityResources.OpenId(),
                new IdentityResources.Email(),
                new IdentityResources.Profile(),
            };

        public static IEnumerable<ApiScope> ApiScopes =>
            new ApiScope[]
            {
                new ApiScope("CatalogFullPermission", "Full authority for catalog operations"),
                new ApiScope("CatalogReadPermission", "Reading authority for catalog operations"),
                new ApiScope("DiscountFullPermission", "Full authority for discount operations"),
                new ApiScope("OrderFullPermission", "Full authority for order operations"),
                new ApiScope(IdentityServerConstants.LocalApi.ScopeName),
            };

        public static IEnumerable<Client> Clients =>
            new Client[]
            {
                //Visitor
                new Client
                {
                    ClientId = "CoffeeStationVisitorId",
                    ClientName = "Coffee Station Visitor User",
                    AllowedGrantTypes = GrantTypes.ClientCredentials,
                    ClientSecrets = { new Secret("coffeestationsecret".Sha256()) },
                    AllowedScopes = { "CatalogReadPermission" },
                },
                //Manager
                new Client
                {
                    ClientId = "CoffeeStationManagerId",
                    ClientName = "Coffee Station Manager User",
                    AllowedGrantTypes = GrantTypes.ClientCredentials,
                    ClientSecrets = { new Secret("coffeestationsecret".Sha256()) },
                    AllowedScopes = { "CatalogReadPermission", "CatalogFullPermission" },
                },
                //Admin
                new Client
                {
                    ClientId = "CoffeeStationAdminId",
                    ClientName = "Coffee Station Admin User",
                    AllowedGrantTypes = GrantTypes.ClientCredentials,
                    ClientSecrets = { new Secret("coffeestationsecret".Sha256()) },
                    AllowedScopes =
                    {
                        "CatalogReadPermission",
                        "CatalogFullPermission",
                        "DiscountFullPermission",
                        "OrderFullPermission",
                        IdentityServerConstants.LocalApi.ScopeName,
                        IdentityServerConstants.StandardScopes.Email,
                        IdentityServerConstants.StandardScopes.OpenId,
                        IdentityServerConstants.StandardScopes.Profile,
                    },
                    AccessTokenLifetime =
                        600 //10 dakika
                    ,
                },
            };
    }
}
