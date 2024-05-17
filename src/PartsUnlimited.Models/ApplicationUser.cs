// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using Microsoft.AspNetCore.Identity;

namespace PartsUnlimited.Models
{
    public class ApplicationUser : IdentityUser
    {
        //17/05 9:09 remote function change
        public string Name { get; set; }
        //17/05 9:10 local function change
    }
}
