﻿using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assigment2.Models
{
    public class Role : IdentityRole
    {
        public string Description { get; set; }
    }
}