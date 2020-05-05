// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


using IdentityModel;
using IdentityServer4.Test;
using System;
using System.Collections.Generic;
using System.Security.Claims;

namespace IdentityServer.IDP
{
    public class TestUsers
    {
        public static List<TestUser> Users = new List<TestUser>
        {
            new TestUser{
                SubjectId = Guid.NewGuid().ToString(),
                Username = "Alice", 
                Password = "password", 
                Claims = 
                {
                   new Claim("gien_name","Alice"),
                   new Claim("family_name","Smith")
                }
            },
            new TestUser{
                SubjectId = Guid.NewGuid().ToString(), 
                Username = "Bob", 
                Password = "password", 
                Claims = 
                {
                    new Claim("gien_name","Bob"),
                   new Claim("family_name","Smith")
                }
            }
        };
    }
}