using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//this is for returning a user when created, instead of returning a plain confirmation string.
namespace api.DTOs.Account
{
    public class NewUserDto
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Token { get; set; }
    }
}