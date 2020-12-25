using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginPortal.Models
{
    public class AppUserType1 : IdentityUser
    {
        public string CustomValue { get; set; }
    }
}
