using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization.Infrastructure;
using static API.Helpers.Authorization;

namespace API.Helpers
{
    public class Authorization
    {
        public enum Roles
        {
            Admistrator,
            Manager,
            Employee
        }
        public const Roles rol_default = Roles.Employee; 
    }
    
}