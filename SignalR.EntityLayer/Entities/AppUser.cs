﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace SignalR.EntityLayer.Entities
{
    public class AppUser: IdentityUser<int>
    {
        public string Name { get; set; }

        public string Surname { get; set; }
    }
}
