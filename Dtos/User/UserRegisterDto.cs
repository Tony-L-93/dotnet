using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet.Dtos.Character.User
{
    public class UserRegisterDto
    {
        public string UserName { get; set; }     = string.Empty;
        public string Password { get; set; }     = string.Empty;
    }
}